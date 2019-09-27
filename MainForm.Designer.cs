namespace ProjectCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRootDir_ProjectCodeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRootDir_ProjectLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRootDir_ProjectLocation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAddTtf = new System.Windows.Forms.CheckBox();
            this.chkAddNet = new System.Windows.Forms.CheckBox();
            this.optTypes_SDL2Project = new System.Windows.Forms.RadioButton();
            this.optTypes_LibraryProject = new System.Windows.Forms.RadioButton();
            this.optTypes_ConsoleProject = new System.Windows.Forms.RadioButton();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProject_SolutionName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProject_ProjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root Name";
            // 
            // txtRootDir_ProjectCodeName
            // 
            this.txtRootDir_ProjectCodeName.Location = new System.Drawing.Point(159, 26);
            this.txtRootDir_ProjectCodeName.Name = "txtRootDir_ProjectCodeName";
            this.txtRootDir_ProjectCodeName.Size = new System.Drawing.Size(166, 20);
            this.txtRootDir_ProjectCodeName.TabIndex = 0;
            this.txtRootDir_ProjectCodeName.TextChanged += new System.EventHandler(this.txtRootDir_ProjectCodeName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Root Location";
            // 
            // txtRootDir_ProjectLocation
            // 
            this.txtRootDir_ProjectLocation.Location = new System.Drawing.Point(159, 55);
            this.txtRootDir_ProjectLocation.Name = "txtRootDir_ProjectLocation";
            this.txtRootDir_ProjectLocation.Size = new System.Drawing.Size(166, 20);
            this.txtRootDir_ProjectLocation.TabIndex = 1;
            this.txtRootDir_ProjectLocation.TextChanged += new System.EventHandler(this.txtRootDir_ProjectLocation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "All projects are x64 and Unicode. Also use Precompiled Headers(PCH).";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRootDir_ProjectLocation);
            this.groupBox1.Controls.Add(this.txtRootDir_ProjectLocation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRootDir_ProjectCodeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Root";
            // 
            // btnRootDir_ProjectLocation
            // 
            this.btnRootDir_ProjectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRootDir_ProjectLocation.Location = new System.Drawing.Point(331, 55);
            this.btnRootDir_ProjectLocation.Name = "btnRootDir_ProjectLocation";
            this.btnRootDir_ProjectLocation.Size = new System.Drawing.Size(26, 20);
            this.btnRootDir_ProjectLocation.TabIndex = 2;
            this.btnRootDir_ProjectLocation.Text = "...";
            this.btnRootDir_ProjectLocation.UseVisualStyleBackColor = true;
            this.btnRootDir_ProjectLocation.Click += new System.EventHandler(this.btnRootDir_ProjectLocation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAddTtf);
            this.groupBox2.Controls.Add(this.chkAddNet);
            this.groupBox2.Controls.Add(this.optTypes_SDL2Project);
            this.groupBox2.Controls.Add(this.optTypes_LibraryProject);
            this.groupBox2.Controls.Add(this.optTypes_ConsoleProject);
            this.groupBox2.Location = new System.Drawing.Point(25, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Types";
            // 
            // chkAddTtf
            // 
            this.chkAddTtf.AutoSize = true;
            this.chkAddTtf.Enabled = false;
            this.chkAddTtf.Location = new System.Drawing.Point(52, 128);
            this.chkAddTtf.Name = "chkAddTtf";
            this.chkAddTtf.Size = new System.Drawing.Size(90, 17);
            this.chkAddTtf.TabIndex = 4;
            this.chkAddTtf.Text = "Add SDL2_ttf";
            this.chkAddTtf.UseVisualStyleBackColor = true;
            // 
            // chkAddNet
            // 
            this.chkAddNet.AutoSize = true;
            this.chkAddNet.Enabled = false;
            this.chkAddNet.Location = new System.Drawing.Point(52, 104);
            this.chkAddNet.Name = "chkAddNet";
            this.chkAddNet.Size = new System.Drawing.Size(96, 17);
            this.chkAddNet.TabIndex = 3;
            this.chkAddNet.Text = "Add SDL2_net";
            this.chkAddNet.UseVisualStyleBackColor = true;
            // 
            // optTypes_SDL2Project
            // 
            this.optTypes_SDL2Project.AutoSize = true;
            this.optTypes_SDL2Project.Location = new System.Drawing.Point(28, 81);
            this.optTypes_SDL2Project.Name = "optTypes_SDL2Project";
            this.optTypes_SDL2Project.Size = new System.Drawing.Size(139, 17);
            this.optTypes_SDL2Project.TabIndex = 2;
            this.optTypes_SDL2Project.Text = "SDL2 project ( sdl_gpu )";
            this.optTypes_SDL2Project.UseVisualStyleBackColor = true;
            this.optTypes_SDL2Project.CheckedChanged += new System.EventHandler(this.optTypes_SDL2Project_CheckedChanged);
            // 
            // optTypes_LibraryProject
            // 
            this.optTypes_LibraryProject.AutoSize = true;
            this.optTypes_LibraryProject.Location = new System.Drawing.Point(28, 57);
            this.optTypes_LibraryProject.Name = "optTypes_LibraryProject";
            this.optTypes_LibraryProject.Size = new System.Drawing.Size(91, 17);
            this.optTypes_LibraryProject.TabIndex = 1;
            this.optTypes_LibraryProject.Text = "Library project";
            this.optTypes_LibraryProject.UseVisualStyleBackColor = true;
            this.optTypes_LibraryProject.CheckedChanged += new System.EventHandler(this.optTypes_LibraryProject_CheckedChanged);
            // 
            // optTypes_ConsoleProject
            // 
            this.optTypes_ConsoleProject.AutoSize = true;
            this.optTypes_ConsoleProject.Checked = true;
            this.optTypes_ConsoleProject.Location = new System.Drawing.Point(28, 33);
            this.optTypes_ConsoleProject.Name = "optTypes_ConsoleProject";
            this.optTypes_ConsoleProject.Size = new System.Drawing.Size(98, 17);
            this.optTypes_ConsoleProject.TabIndex = 0;
            this.optTypes_ConsoleProject.TabStop = true;
            this.optTypes_ConsoleProject.Text = "Console project";
            this.optTypes_ConsoleProject.UseVisualStyleBackColor = true;
            this.optTypes_ConsoleProject.CheckedChanged += new System.EventHandler(this.optTypes_ConsoleProject_CheckedChanged);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProject.Location = new System.Drawing.Point(77, 439);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(273, 38);
            this.btnCreateProject.TabIndex = 4;
            this.btnCreateProject.Text = "Create project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtProject_SolutionName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtProject_ProjectName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(25, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 107);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project";
            // 
            // txtProject_SolutionName
            // 
            this.txtProject_SolutionName.Location = new System.Drawing.Point(159, 28);
            this.txtProject_SolutionName.Name = "txtProject_SolutionName";
            this.txtProject_SolutionName.Size = new System.Drawing.Size(166, 20);
            this.txtProject_SolutionName.TabIndex = 0;
            this.txtProject_SolutionName.TextChanged += new System.EventHandler(this.txtProject_SolutionName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Solution Name";
            // 
            // txtProject_ProjectName
            // 
            this.txtProject_ProjectName.Location = new System.Drawing.Point(159, 59);
            this.txtProject_ProjectName.Name = "txtProject_ProjectName";
            this.txtProject_ProjectName.Size = new System.Drawing.Size(166, 20);
            this.txtProject_ProjectName.TabIndex = 1;
            this.txtProject_ProjectName.TextChanged += new System.EventHandler(this.txtProject_ProjectName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Project Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Project Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRootDir_ProjectCodeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRootDir_ProjectLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRootDir_ProjectLocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optTypes_SDL2Project;
        private System.Windows.Forms.RadioButton optTypes_LibraryProject;
        private System.Windows.Forms.RadioButton optTypes_ConsoleProject;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProject_ProjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProject_SolutionName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAddTtf;
        private System.Windows.Forms.CheckBox chkAddNet;
    }
}

