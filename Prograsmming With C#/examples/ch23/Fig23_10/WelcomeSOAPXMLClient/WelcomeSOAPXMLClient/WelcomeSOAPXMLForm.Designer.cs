namespace WelcomeSOAPXMLClient
{
    partial class WelcomeSOAPXMLForm
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
           this.textLabel = new System.Windows.Forms.Label();
           this.textBox = new System.Windows.Forms.TextBox();
           this.submitButton = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // textLabel
           // 
           this.textLabel.AutoSize = true;
           this.textLabel.Location = new System.Drawing.Point(12, 11);
           this.textLabel.Name = "textLabel";
           this.textLabel.Size = new System.Drawing.Size(87, 13);
           this.textLabel.TabIndex = 5;
           this.textLabel.Text = "Enter your name:";
           // 
           // textBox
           // 
           this.textBox.Location = new System.Drawing.Point(103, 8);
           this.textBox.Name = "textBox";
           this.textBox.Size = new System.Drawing.Size(100, 20);
           this.textBox.TabIndex = 4;
           // 
           // submitButton
           // 
           this.submitButton.Location = new System.Drawing.Point(65, 34);
           this.submitButton.Name = "submitButton";
           this.submitButton.Size = new System.Drawing.Size(75, 23);
           this.submitButton.TabIndex = 3;
           this.submitButton.Text = "Submit";
           this.submitButton.UseVisualStyleBackColor = true;
           this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
           // 
           // WelcomeSOAPXMLForm
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(214, 64);
           this.Controls.Add(this.textLabel);
           this.Controls.Add(this.textBox);
           this.Controls.Add(this.submitButton);
           this.Name = "WelcomeSOAPXMLForm";
           this.Text = "WelcomeSOAPXMLClient";
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label textLabel;
        internal System.Windows.Forms.TextBox textBox;
        internal System.Windows.Forms.Button submitButton;
    }
}

