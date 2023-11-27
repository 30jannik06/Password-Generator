namespace Passwort_Generator
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.passwordGenerateButton = new System.Windows.Forms.Button();
            this.guideLabelCount = new System.Windows.Forms.Label();
            this.guideGenerateLabel = new System.Windows.Forms.Label();
            this.lenghtCount = new System.Windows.Forms.TextBox();
            this.passwordOutput = new System.Windows.Forms.TextBox();
            this.copyPasswordButton = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordGenerateButton
            // 
            this.passwordGenerateButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordGenerateButton.Location = new System.Drawing.Point(12, 101);
            this.passwordGenerateButton.Name = "passwordGenerateButton";
            this.passwordGenerateButton.Size = new System.Drawing.Size(140, 40);
            this.passwordGenerateButton.TabIndex = 0;
            this.passwordGenerateButton.Text = "Generate Password";
            this.passwordGenerateButton.UseVisualStyleBackColor = true;
            this.passwordGenerateButton.Click += new System.EventHandler(this.passwordGenerateButton_Click);
            // 
            // guideLabelCount
            // 
            this.guideLabelCount.AutoSize = true;
            this.guideLabelCount.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guideLabelCount.Location = new System.Drawing.Point(12, 55);
            this.guideLabelCount.Name = "guideLabelCount";
            this.guideLabelCount.Size = new System.Drawing.Size(107, 14);
            this.guideLabelCount.TabIndex = 1;
            this.guideLabelCount.Text = "How many Chars?";
            // 
            // guideGenerateLabel
            // 
            this.guideGenerateLabel.AutoSize = true;
            this.guideGenerateLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guideGenerateLabel.Location = new System.Drawing.Point(171, 55);
            this.guideGenerateLabel.Name = "guideGenerateLabel";
            this.guideGenerateLabel.Size = new System.Drawing.Size(125, 14);
            this.guideGenerateLabel.TabIndex = 2;
            this.guideGenerateLabel.Text = "Generated Password";
            // 
            // lenghtCount
            // 
            this.lenghtCount.Location = new System.Drawing.Point(12, 72);
            this.lenghtCount.Name = "lenghtCount";
            this.lenghtCount.Size = new System.Drawing.Size(61, 23);
            this.lenghtCount.TabIndex = 3;
            // 
            // passwordOutput
            // 
            this.passwordOutput.Location = new System.Drawing.Point(171, 72);
            this.passwordOutput.Name = "passwordOutput";
            this.passwordOutput.Size = new System.Drawing.Size(140, 23);
            this.passwordOutput.TabIndex = 4;
            // 
            // copyPasswordButton
            // 
            this.copyPasswordButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyPasswordButton.Location = new System.Drawing.Point(171, 101);
            this.copyPasswordButton.Name = "copyPasswordButton";
            this.copyPasswordButton.Size = new System.Drawing.Size(140, 40);
            this.copyPasswordButton.TabIndex = 5;
            this.copyPasswordButton.Text = "Copy Password";
            this.copyPasswordButton.UseVisualStyleBackColor = true;
            this.copyPasswordButton.Click += new System.EventHandler(this.copyPasswordButton_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(12, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(237, 22);
            this.labelHeader.TabIndex = 6;
            this.labelHeader.Text = "Easy Passwort Generator";
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 167);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.copyPasswordButton);
            this.Controls.Add(this.passwordOutput);
            this.Controls.Add(this.lenghtCount);
            this.Controls.Add(this.guideGenerateLabel);
            this.Controls.Add(this.guideLabelCount);
            this.Controls.Add(this.passwordGenerateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button passwordGenerateButton;
        private Label guideLabelCount;
        private Label guideGenerateLabel;
        private TextBox lenghtCount;
        private TextBox passwordOutput;
        private Button copyPasswordButton;
        private Label labelHeader;
    }
}