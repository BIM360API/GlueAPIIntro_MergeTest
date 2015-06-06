#region Copyright
//
// Copyright (C) 2013 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
#endregion // Copyright

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Added 
using System.Net; // for HttpWebRequest
using System.IO; // StreamWriter
using System.Diagnostics; // for Debug writing 
// For HttpUtility. 
// Tip: If your application is set as .NET Framework 4 Client Profile, 
// it won't show System.Web. Use .NET Framework 4 instead.  
using System.Web;

namespace GlueAPIIntro
{
  class GlueWebRequest
  {
    // Base Url for the Glue web services 
    private const string baseApiUrl = Glue.baseApiUrl;

    // Member variables 
    public string requestUrl { get; set; }   
    public HttpStatusCode statusCode { get; set; }
    public string responseHeader { get; set; }
    public string responseBody { get; set; }

    //===============================================================
    // Http Web Request call. 
    // 
    // Actual Web requests Glue API call happens here 
    // 
    //===============================================================
    #region WebRequestCall

    public string MakeAPICall(string urlEndpoint, string urlArgs, string reqMethod, string postBody = "")
    {
      string responseAsString = ""; // return value 

      // (1) Construct web request 
      // 
      // Set up URL = baseApiUrl + urlEndpoint + .json 
      // e.g., https://b4.autodesk.com/api/security/v1/login.json 
      // 
      // Using json here for simplicity. xml is another option.  

      string url = baseApiUrl + urlEndpoint + ".json";

      // If arguments, add "?" at the end 

      if (urlArgs != "")
      {
        url += "?" + urlArgs;
      }

      Debug.WriteLine("MakeAPICall() url=" + url);
      Debug.WriteLine("MakeAPICall() postBody=" + postBody);
 
      try
      {

        // (2) Create a http web request from the given url. 
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = reqMethod; // Get/Post
        request.UserAgent = "User-Agent: MyTestApp/1.0 (platform=Windows, page=web, info=MyInfo)";


        // if POST, write body or Post data.
        if ((reqMethod != "GET") && (reqMethod != "HEAD"))
        {
          SetBody(request, postBody);
        }

        // the time length in milliseconds. 
        // make it longer for debugging purposes (5 min)
        request.Timeout = 300000;

        this.requestUrl = request.RequestUri.ToString(); 

        Debug.WriteLine("MakeAPICall() request.RequestUri=" + request.RequestUri.ToString());

        //
        // (3) Finally, get the response 
        // 
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        this.statusCode = response.StatusCode;
        this.responseHeader = GetHeaderFromResponse(response);
        this.responseBody = GetBodyFromResponse(response);

        response.Close();

        Debug.WriteLine("MakeAPICall() resHeader=" + this.responseHeader);
        Debug.WriteLine("MakeAPICall() resBody=" + this.responseBody);

      }
      catch (WebException ex)
      {
        responseAsString += "** Exception in MakeAPICall()" + ex.Message + "\n"; 
      }

      responseAsString += this.responseHeader + this.responseBody;

      return responseAsString;
    }

    // If POST, write body
    // 
    void SetBody(HttpWebRequest request, string requestBody)
    {
      if (requestBody.Length > 0)
      {
        request.ContentType = "application/x-www-form-urlencoded";
        using (Stream requestStream = request.GetRequestStream())
        using (StreamWriter writer = new StreamWriter(requestStream))
        {
          writer.Write(requestBody);
        }
      }
    }

    // 
    // Get a header from the response we recieved. 
    // Listing for each key
    // 

    string GetHeaderFromResponse(HttpWebResponse response)
    {
      string result = "Status code: " + (int)response.StatusCode + " " + response.StatusCode + "\r\n";
      foreach (string key in response.Headers.Keys)
      {
        result += string.Format("{0}: {1} \r\n", key, response.Headers[key]);
      }

      result += "\r\n";
      return result;
    }

    // 
    // Get a body from the response we recieved. 
    //

    string GetBodyFromResponse(HttpWebResponse response)
    {
      string result = "";
      string tBody = new StreamReader(response.GetResponseStream()).ReadToEnd();
      result += tBody;
      return result;
    }
    #endregion WebRequestCall
  }
}
