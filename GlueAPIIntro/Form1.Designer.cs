namespace GlueAPIIntro
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelResponse = new System.Windows.Forms.Label();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.labelRequest = new System.Windows.Forms.Label();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.buttonModels = new System.Windows.Forms.Button();
            this.labelCurProj = new System.Windows.Forms.Label();
            this.labelCurModel = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonModelInfo1 = new System.Windows.Forms.Button();
            this.buttonModelInfo2 = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxModelVersionId1 = new System.Windows.Forms.TextBox();
            this.textBoxModelVersionId2 = new System.Windows.Forms.TextBox();
            this.textBoxMergedModelName = new System.Windows.Forms.TextBox();
            this.labelMergedModelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(464, 24);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 30);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(24, 404);
            this.labelResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(72, 17);
            this.labelResponse.TabIndex = 2;
            this.labelResponse.Text = "Response";
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(27, 425);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(512, 92);
            this.textBoxResponse.TabIndex = 3;
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Location = new System.Drawing.Point(24, 318);
            this.labelRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(61, 17);
            this.labelRequest.TabIndex = 4;
            this.labelRequest.Text = "Request";
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(27, 339);
            this.textBoxRequest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequest.Size = new System.Drawing.Size(512, 61);
            this.textBoxRequest.TabIndex = 5;
            // 
            // buttonProjects
            // 
            this.buttonProjects.Location = new System.Drawing.Point(464, 108);
            this.buttonProjects.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(75, 30);
            this.buttonProjects.TabIndex = 6;
            this.buttonProjects.Text = "Projects";
            this.buttonProjects.UseVisualStyleBackColor = true;
            this.buttonProjects.Click += new System.EventHandler(this.buttonProjects_Click);
            // 
            // buttonModels
            // 
            this.buttonModels.Location = new System.Drawing.Point(464, 152);
            this.buttonModels.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModels.Name = "buttonModels";
            this.buttonModels.Size = new System.Drawing.Size(75, 30);
            this.buttonModels.TabIndex = 7;
            this.buttonModels.Text = "Models";
            this.buttonModels.UseVisualStyleBackColor = true;
            this.buttonModels.Click += new System.EventHandler(this.buttonModels_Click);
            // 
            // labelCurProj
            // 
            this.labelCurProj.AutoSize = true;
            this.labelCurProj.Location = new System.Drawing.Point(24, 115);
            this.labelCurProj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurProj.Name = "labelCurProj";
            this.labelCurProj.Size = new System.Drawing.Size(52, 17);
            this.labelCurProj.TabIndex = 10;
            this.labelCurProj.Text = "Project";
            // 
            // labelCurModel
            // 
            this.labelCurModel.AutoSize = true;
            this.labelCurModel.Location = new System.Drawing.Point(24, 161);
            this.labelCurModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurModel.Name = "labelCurModel";
            this.labelCurModel.Size = new System.Drawing.Size(46, 17);
            this.labelCurModel.TabIndex = 11;
            this.labelCurModel.Text = "Model";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(24, 28);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 17);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 62);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(114, 25);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(342, 22);
            this.textBoxUserName.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(114, 62);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(342, 22);
            this.textBoxPassword.TabIndex = 15;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(464, 58);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 30);
            this.buttonLogout.TabIndex = 16;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonModelInfo1
            // 
            this.buttonModelInfo1.Location = new System.Drawing.Point(444, 197);
            this.buttonModelInfo1.Name = "buttonModelInfo1";
            this.buttonModelInfo1.Size = new System.Drawing.Size(95, 30);
            this.buttonModelInfo1.TabIndex = 17;
            this.buttonModelInfo1.Text = "Model Info 1";
            this.buttonModelInfo1.UseVisualStyleBackColor = true;
            this.buttonModelInfo1.Click += new System.EventHandler(this.buttonModelInfo1_Click);
            // 
            // buttonModelInfo2
            // 
            this.buttonModelInfo2.Location = new System.Drawing.Point(444, 233);
            this.buttonModelInfo2.Name = "buttonModelInfo2";
            this.buttonModelInfo2.Size = new System.Drawing.Size(95, 30);
            this.buttonModelInfo2.TabIndex = 18;
            this.buttonModelInfo2.Text = "Model Info 2";
            this.buttonModelInfo2.UseVisualStyleBackColor = true;
            this.buttonModelInfo2.Click += new System.EventHandler(this.buttonModelInfo2_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(464, 272);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(75, 30);
            this.buttonMerge.TabIndex = 19;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // textBoxProject
            // 
            this.textBoxProject.Location = new System.Drawing.Point(113, 112);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(343, 22);
            this.textBoxProject.TabIndex = 21;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(114, 156);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(342, 22);
            this.textBoxModel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Model version id1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Model version id2";
            // 
            // textBoxModelVersionId1
            // 
            this.textBoxModelVersionId1.Location = new System.Drawing.Point(169, 204);
            this.textBoxModelVersionId1.Name = "textBoxModelVersionId1";
            this.textBoxModelVersionId1.Size = new System.Drawing.Size(269, 22);
            this.textBoxModelVersionId1.TabIndex = 25;
            // 
            // textBoxModelVersionId2
            // 
            this.textBoxModelVersionId2.Location = new System.Drawing.Point(169, 240);
            this.textBoxModelVersionId2.Name = "textBoxModelVersionId2";
            this.textBoxModelVersionId2.Size = new System.Drawing.Size(269, 22);
            this.textBoxModelVersionId2.TabIndex = 26;
            // 
            // textBoxMergedModelName
            // 
            this.textBoxMergedModelName.Location = new System.Drawing.Point(169, 279);
            this.textBoxMergedModelName.Name = "textBoxMergedModelName";
            this.textBoxMergedModelName.Size = new System.Drawing.Size(269, 22);
            this.textBoxMergedModelName.TabIndex = 27;
            // 
            // labelMergedModelName
            // 
            this.labelMergedModelName.AutoSize = true;
            this.labelMergedModelName.Location = new System.Drawing.Point(24, 279);
            this.labelMergedModelName.Name = "labelMergedModelName";
            this.labelMergedModelName.Size = new System.Drawing.Size(139, 17);
            this.labelMergedModelName.TabIndex = 28;
            this.labelMergedModelName.Text = "Merged Model Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 574);
            this.Controls.Add(this.labelMergedModelName);
            this.Controls.Add(this.textBoxMergedModelName);
            this.Controls.Add(this.textBoxModelVersionId2);
            this.Controls.Add(this.textBoxModelVersionId1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.buttonModelInfo2);
            this.Controls.Add(this.buttonModelInfo1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelCurModel);
            this.Controls.Add(this.labelCurProj);
            this.Controls.Add(this.buttonModels);
            this.Controls.Add(this.buttonProjects);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Glue API Intro";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonLogin;
    private System.Windows.Forms.Label labelResponse;
    private System.Windows.Forms.TextBox textBoxResponse;
    private System.Windows.Forms.Label labelRequest;
    private System.Windows.Forms.TextBox textBoxRequest;
    private System.Windows.Forms.Button buttonProjects;
    private System.Windows.Forms.Button buttonModels;
    private System.Windows.Forms.Label labelCurProj;
    private System.Windows.Forms.Label labelCurModel;
    private System.Windows.Forms.Label labelUserName;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox textBoxUserName;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Button buttonLogout;
    private System.Windows.Forms.Button buttonModelInfo1;
    private System.Windows.Forms.Button buttonModelInfo2;
    private System.Windows.Forms.Button buttonMerge;
    private System.Windows.Forms.TextBox textBoxProject;
    private System.Windows.Forms.TextBox textBoxModel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxModelVersionId1;
    private System.Windows.Forms.TextBox textBoxModelVersionId2;
    private System.Windows.Forms.TextBox textBoxMergedModelName;
    private System.Windows.Forms.Label labelMergedModelName;

  }
}

