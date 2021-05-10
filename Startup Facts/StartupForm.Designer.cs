
namespace Startup_Facts
{
    partial class StartupForm
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
            this.text = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.AnotherFactButton = new System.Windows.Forms.Button();
            this.Sauce = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(12, 9);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(310, 97);
            this.text.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(93, 109);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AnotherFactButton
            // 
            this.AnotherFactButton.Location = new System.Drawing.Point(174, 109);
            this.AnotherFactButton.Name = "AnotherFactButton";
            this.AnotherFactButton.Size = new System.Drawing.Size(75, 23);
            this.AnotherFactButton.TabIndex = 2;
            this.AnotherFactButton.Text = "More Facts";
            this.AnotherFactButton.UseVisualStyleBackColor = true;
            this.AnotherFactButton.Click += new System.EventHandler(this.AnotherFactButton_Click);
            // 
            // Sauce
            // 
            this.Sauce.AutoSize = true;
            this.Sauce.Location = new System.Drawing.Point(12, 113);
            this.Sauce.Name = "Sauce";
            this.Sauce.Size = new System.Drawing.Size(38, 15);
            this.Sauce.TabIndex = 3;
            this.Sauce.TabStop = true;
            this.Sauce.Text = "Sauce";
            this.Sauce.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sauce_LinkClicked);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 136);
            this.Controls.Add(this.Sauce);
            this.Controls.Add(this.AnotherFactButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.text);
            this.MinimumSize = new System.Drawing.Size(350, 175);
            this.Name = "StartupForm";
            this.Text = "Didn\'t You Want To Know...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button AnotherFactButton;
        private System.Windows.Forms.LinkLabel Sauce;
    }
}

