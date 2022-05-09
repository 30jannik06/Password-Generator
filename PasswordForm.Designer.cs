namespace PasswortGenerator
{
    partial class PasswordForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.lenghtCount = new System.Windows.Forms.TextBox();
            this.passwordOutput = new System.Windows.Forms.TextBox();
            this.passwordGenerateButton = new System.Windows.Forms.Button();
            this.copyPasswordButton = new System.Windows.Forms.Button();
            this.guideLabelCount = new System.Windows.Forms.Label();
            this.guideGenerateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lenghtCount
            // 
            this.lenghtCount.Location = new System.Drawing.Point(80, 91);
            this.lenghtCount.Name = "lenghtCount";
            this.lenghtCount.Size = new System.Drawing.Size(53, 23);
            this.lenghtCount.TabIndex = 0;
            this.lenghtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordOutput
            // 
            this.passwordOutput.Location = new System.Drawing.Point(185, 91);
            this.passwordOutput.Name = "passwordOutput";
            this.passwordOutput.Size = new System.Drawing.Size(300, 23);
            this.passwordOutput.TabIndex = 1;
            this.passwordOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordGenerateButton
            // 
            this.passwordGenerateButton.Location = new System.Drawing.Point(80, 191);
            this.passwordGenerateButton.Name = "passwordGenerateButton";
            this.passwordGenerateButton.Size = new System.Drawing.Size(150, 60);
            this.passwordGenerateButton.TabIndex = 2;
            this.passwordGenerateButton.Text = "Generate Password";
            this.passwordGenerateButton.UseVisualStyleBackColor = true;
            this.passwordGenerateButton.Click += new System.EventHandler(this.passwordGenerateButton_Click);
            // 
            // copyPasswordButton
            // 
            this.copyPasswordButton.Location = new System.Drawing.Point(335, 191);
            this.copyPasswordButton.Name = "copyPasswordButton";
            this.copyPasswordButton.Size = new System.Drawing.Size(150, 60);
            this.copyPasswordButton.TabIndex = 3;
            this.copyPasswordButton.Text = "Copy Password";
            this.copyPasswordButton.UseVisualStyleBackColor = true;
            this.copyPasswordButton.Click += new System.EventHandler(this.copyPasswordButton_Click);
            // 
            // guideLabelCount
            // 
            this.guideLabelCount.AutoSize = true;
            this.guideLabelCount.ForeColor = System.Drawing.Color.White;
            this.guideLabelCount.Location = new System.Drawing.Point(80, 49);
            this.guideLabelCount.Name = "guideLabelCount";
            this.guideLabelCount.Size = new System.Drawing.Size(103, 15);
            this.guideLabelCount.TabIndex = 4;
            this.guideLabelCount.Text = "How many Chars?";
            this.guideLabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guideGenerateLabel
            // 
            this.guideGenerateLabel.AutoSize = true;
            this.guideGenerateLabel.ForeColor = System.Drawing.Color.White;
            this.guideGenerateLabel.Location = new System.Drawing.Point(371, 49);
            this.guideGenerateLabel.Name = "guideGenerateLabel";
            this.guideGenerateLabel.Size = new System.Drawing.Size(114, 15);
            this.guideGenerateLabel.TabIndex = 5;
            this.guideGenerateLabel.Text = "Generated Password";
            this.guideGenerateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(572, 330);
            this.Controls.Add(this.guideGenerateLabel);
            this.Controls.Add(this.guideLabelCount);
            this.Controls.Add(this.copyPasswordButton);
            this.Controls.Add(this.passwordGenerateButton);
            this.Controls.Add(this.passwordOutput);
            this.Controls.Add(this.lenghtCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox lenghtCount;
        private TextBox passwordOutput;
        private Button passwordGenerateButton;
        private Button copyPasswordButton;
        private Label guideLabelCount;
        private Label guideGenerateLabel;
    }
}