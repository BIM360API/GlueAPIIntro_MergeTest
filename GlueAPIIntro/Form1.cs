#region Copyright
//
// Copyright (C) 2013-2015 by Autodesk, Inc.
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
//
// Written by M.Harada 
#endregion // Copyright

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; // for Debug.
// Added for RestSharp. 
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers; 


namespace GlueAPIIntro
{
  public partial class Form1 : Form
  {
    // Glue defines the actual Glue specic call 
    Glue glueCall = new Glue();

     // Save auth token. 
    private static string m_authToken = "";
    private static string m_project_id = ""; 
    private static int m_proj_index = 0;    
    private static string m_model_id = ""; 
    private static int m_model_index = 0;
    // Two model ids to merge test. 
    private static string m_model_version_id1 = "";
    private static string m_model_version_id2 = "";

    public Form1()
    {
      InitializeComponent();

      // A tentative name for a merged model to be created. 
      DateTime today = DateTime.Now;
      string time = today.ToString("yyyyMMdd_HHmm");
      textBoxMergedModelName.Text = "API_Merge_" + time; 
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
       // Get the user name and password from the user. 
       string userName = textBoxUserName.Text;
       string password = textBoxPassword.Text;

      textBoxRequest.Text = "Request comes here"; 
      textBoxResponse.Text = "Response comes here. This may take secones. Please wait...";
      this.Update();
      
      // Here is the main part that we call Glue login 
      m_authToken = glueCall.Login(userName, password);

      // Show the request and response in the form. 
      // This is for learning purpose. 
      ShowRequestResponse(); 
    }

    // Displays request and response in the text boxes.
    // This is for learning purpose. 
    private void ShowRequestResponse()
    {
        // show the request and response in the form. 
        IRestResponse response = glueCall.m_lastResponse;
        textBoxRequest.Text = response.ResponseUri.AbsoluteUri;
        textBoxResponse.Text =
            "Status Code: " + response.StatusCode.ToString() + Environment.NewLine
            + response.Content;
    }

    private void buttonLogout_Click(object sender, EventArgs e)
    {
       textBoxRequest.Text = "Request comes here";
       textBoxResponse.Text = "Response comes here. This may take secones. Please wait...";
       this.Update();

       // Here is the main part that we call Glue login 
       string logoutResponse = glueCall.Logout(m_authToken);
 
       // Show the request and response in the form. 
       // This is for learning purpose. 
       ShowRequestResponse(); 
    }

    private void buttonProjects_Click(object sender, EventArgs e)
    {
      textBoxRequest.Text = "Request comes here";
      textBoxResponse.Text = "Response comes here";

      List<Project> proj_list = glueCall.ProjectList(m_authToken);

      // Show the request and response in the form. 
      // This is for learning purpose. 
      ShowRequestResponse(); 

      // We want to get hold of one project. 
      // For simplicity, just pick up arbitrary one.
      m_proj_index %= proj_list.Count; 
      Project proj = proj_list[m_proj_index++];
      m_project_id = proj.project_id;
      string project_name = proj.project_name;
      
      // Display the name of the project and (index/# of projects) 
      textBoxProject.Text = project_name;
      labelCurProj.Text = "Project" + " (" + m_proj_index.ToString() + "/" + proj_list.Count.ToString() + ")";

    }

    private void buttonModels_Click(object sender, EventArgs e)
    {
      textBoxRequest.Text = "Request comes here";
      textBoxResponse.Text = "Response comes here";

      List<ModelInfo> model_list = glueCall.ModelList(m_authToken, m_project_id);

      // Show the request and response in the form. 
      // This is for learning purpose. 
      ShowRequestResponse(); 

      // We want to get hold of one model. 
      // For simplicity, just pick up arbitrary one.
      m_model_index %= model_list.Count;
      ModelInfo model = model_list[m_model_index++];
      m_model_id = model.model_id;
      string model_name = model.model_name;
      // Display the name of the model and (index/# of models)  
      textBoxModel.Text = model_name; 
      labelCurModel.Text = "Model" + " (" + m_model_index.ToString() + "/" + model_list.Count.ToString() + ")"; 

    }

    // Get the model version id of the first model 
    private void buttonModelInfo1_Click(object sender, EventArgs e)
    {
        textBoxRequest.Text = "Request comes here";
        textBoxResponse.Text = "Response comes here";

        m_model_version_id1 = glueCall.ModelInfoV2(m_authToken, m_model_id);

        // Show the request and response in the form. 
        // This is for learning purpose. 
        ShowRequestResponse(); 

        // Display the model version id of the first model 
        textBoxModelVersionId1.Text = m_model_version_id1; 
    }

    // Get the model version id of the second model 
    private void buttonModelInfo2_Click(object sender, EventArgs e)
    {
        textBoxRequest.Text = "Request comes here";
        textBoxResponse.Text = "Response comes here";

        m_model_version_id2 = glueCall.ModelInfoV2(m_authToken, m_model_id);

        // Show the request and response in the form. 
        ShowRequestResponse();

        // Display the model version id of the second model 
        textBoxModelVersionId2.Text = m_model_version_id2; 
    }

    // Merge two models 
    private void buttonMerge_Click(object sender, EventArgs e)
    {
        textBoxRequest.Text = "Request comes here";
        textBoxResponse.Text = "Response comes here";

        string modelName = textBoxMergedModelName.Text;
        // merge two models
        string modelTransformations = setupMergeParam(m_model_version_id1, m_model_version_id2);

        textBoxRequest.Text = modelTransformations; 

        string test = glueCall.Merge(m_authToken, m_project_id, modelName, modelTransformations);

        // Show the request and response in the form. 
        ShowRequestResponse(); 
    }

    // Composing model transformation here 
    private string setupMergeParam(string model1, string model2)
    {
        List<model_units_and_transformation> modelTransformationRequests = 
            new List<model_units_and_transformation>();

        // Set trans info for model1 
        model_units_and_transformation item1 = new model_units_and_transformation();
        item1 = initTransformation(item1); 
        item1.Media = model1;
        modelTransformationRequests.Add(item1);

        // Set trans info for model2 
        model_units_and_transformation item2 = new model_units_and_transformation();
        item2 = initTransformation(item2);
        item2.Media = model2;
        modelTransformationRequests.Add(item2);

        // Conver to JSON 
        JsonSerializer serial = new JsonSerializer(); 
        string transString = serial.Serialize(modelTransformationRequests); 

        return transString; 
    }

    // Set the initial value of model transformation 
    private model_units_and_transformation initTransformation(model_units_and_transformation item)
    {
        item.Media = "";
        item.Transform = new model_transformation_info();
        item.Transform.Rotation = new double[3]; 
        item.Transform.Rotation[0] = 90.0;
        item.Transform.Rotation[1] = 0.0;
        item.Transform.Rotation[2] = 0.0;
        item.Transform.Scale = new double[3]; 
        item.Transform.Scale[0] = 1.0;
        item.Transform.Scale[1] = 1.0;
        item.Transform.Scale[2] = 1.0;
        item.Transform.Translation = new double[3]; 
        item.Transform.Translation[0] = 0.0;
        item.Transform.Translation[1] = 0.0;
        item.Transform.Translation[2] = 0.0;
        item.Transform.Type = "ModelInstance";
        item.Transform.Version = 0;
        item.Type = "ModelInstance";
        item.Units = "Millimeter";
        item.Version = 1; 

        return item; 
    }

  }
}
