#region Copyright 
//
// Copyright (C) 2013-2014 by Autodesk, Inc.
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
// Added for MD5 
using System.Security.Cryptography; // for MD5
// Added for RestSharp
using RestSharp;
using RestSharp.Deserializers;  

namespace GlueAPIIntro
{
  class GlueUtils
  {
    ///===============================================================
    ///  Rutiones to generate the signature components. 
    ///  These are generic helper functions. Not specific to Glue API.
    ///  cf. https://b4.autodesk.com/api/doc/doc_api.shtml
    ///===============================================================

    /// UNIX Epoch timestamp - 
    /// the number of seconds since January 1st, 1970 00:00:00 GMT 
    /// (the UNIX epoch). 
    /// The BIM 360 Glue Platform accepts timestamps up to a configurable 
    /// number of minutes on either side of the server timestamp, 
    /// to accommodate reasonable clock drift
    /// 
    public static int GetUNIXEpochTimestamp()
    {
      TimeSpan tSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1));
      int timestamp = (int)tSpan.TotalSeconds;
      return timestamp;
    }

    /// Calculate a hash based on MD5 message-digest algorithm.
    /// 128-bit (16-byte) hash value, typically expressed as 32 digit
    /// hexadecimal number. 
    /// Here we use System.Securrity.Cryptogaphy.MD5 
    /// cf. http://en.wikipedia.org/wiki/MD5
    ///
    public static string ComputeMD5Hash(string aString)
    {
      // step 1, calculate MD5 hash from aString
      MD5 md5 = System.Security.Cryptography.MD5.Create();
      byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(aString);
      byte[] hash = md5.ComputeHash(inputBytes);

      // step 2, convert byte array to hex string
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < hash.Length; i++)
      {
        sb.Append(hash[i].ToString("x2"));
      }
      return sb.ToString();
    }

    /// Given a simple json response, get a value of a given key. 
    /// 
    /// Deserialize json to dictionary, and get a value from a simple jason: 
    /// http://blog.atavisticsoftware.com/2014/02/using-restsharp-to-deserialize-json.html
    /// 
    public static bool GetValue(IRestResponse response, string key, out string value)
    {
       JsonDeserializer deserial = new JsonDeserializer();
       Dictionary<string, string> jsonObj = deserial.Deserialize<Dictionary<string, string>>(response);
       if (jsonObj.TryGetValue(key, out value))
       {
          return true;
       }
       value = "";
       return false;
    }


    /// <summary>
    /// Given a simple jason response where we know it's a list (e.g., a list of projects), 
    /// returns a list of values of a given key. (e.g., "project_id")
    /// We can use this to collect, for example, a list of project_id's from /api/projects. 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    public static List<string> GetValueList(IRestResponse response, string key)
    {
       // First deserialize to the list of dictionary.  A dictionary represents a record. 
       JsonDeserializer deserial = new JsonDeserializer();
       List<Dictionary<string, string>> jsonObj = deserial.Deserialize<List<Dictionary<string, string>>>(response);

       // Collect values here. 
       List<string> values = new List<string>();

       foreach (Dictionary<string, string> item in jsonObj)
       {
          string val = "";
          if (item.TryGetValue(key, out val))
          {
             values.Add(val);
             //Debug.WriteLine("RestUtils.GetValueList: key = {0} value = {1}", key, val);
          }

       }

       return values;
    }


    /// <summary>
    /// Given a list of strings, return a formatted string 
    /// </summary>
    /// <param name="ls"></param>
    /// <returns></returns>
    public static string ListToString(IList<string> ls)
    {
       string s = "";
       foreach (string p in ls)
       {
          s += p + Environment.NewLine;
       }
       return s;
    }


  }
}
