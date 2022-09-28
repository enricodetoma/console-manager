
namespace console_manager
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfigrationPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseConfigurationPath = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration path:";
            // 
            // textBoxConfigrationPath
            // 
            this.textBoxConfigrationPath.Location = new System.Drawing.Point(114, 12);
            this.textBoxConfigrationPath.Name = "textBoxConfigrationPath";
            this.textBoxConfigrationPath.Size = new System.Drawing.Size(489, 20);
            this.textBoxConfigrationPath.TabIndex = 1;
            // 
            // buttonBrowseConfigurationPath
            // 
            this.buttonBrowseConfigurationPath.Location = new System.Drawing.Point(609, 10);
            this.buttonBrowseConfigurationPath.Name = "buttonBrowseConfigurationPath";
            this.buttonBrowseConfigurationPath.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseConfigurationPath.TabIndex = 2;
            this.buttonBrowseConfigurationPath.Text = "Browse";
            this.buttonBrowseConfigurationPath.UseVisualStyleBackColor = true;
            this.buttonBrowseConfigurationPath.Click += new System.EventHandler(this.buttonBrowseConfigurationPath_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(610, 110);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(528, 110);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 145);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonBrowseConfigurationPath);
            this.Controls.Add(this.textBoxConfigrationPath);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfigrationPath;
        private System.Windows.Forms.Button buttonBrowseConfigurationPath;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}