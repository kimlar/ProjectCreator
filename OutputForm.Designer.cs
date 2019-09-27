namespace ProjectCreator
{
    partial class OutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputForm));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.chkShowProject = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 13);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(718, 422);
            this.txtOutput.TabIndex = 0;
            // 
            // btnComplete
            // 
            this.btnComplete.Enabled = false;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.Gray;
            this.btnComplete.Location = new System.Drawing.Point(234, 441);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(280, 30);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "COMPLETE";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // chkShowProject
            // 
            this.chkShowProject.AutoSize = true;
            this.chkShowProject.Checked = true;
            this.chkShowProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowProject.Location = new System.Drawing.Point(13, 449);
            this.chkShowProject.Name = "chkShowProject";
            this.chkShowProject.Size = new System.Drawing.Size(162, 17);
            this.chkShowProject.TabIndex = 3;
            this.chkShowProject.Text = "Show project location on exit";
            this.chkShowProject.UseVisualStyleBackColor = true;
            this.chkShowProject.CheckedChanged += new System.EventHandler(this.chkShowProject_CheckedChanged);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 483);
            this.Controls.Add(this.chkShowProject);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutputForm";
            this.ShowIcon = false;
            this.Text = "Output";
            this.Load += new System.EventHandler(this.OutputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComplete;
        public System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.CheckBox chkShowProject;
    }
}