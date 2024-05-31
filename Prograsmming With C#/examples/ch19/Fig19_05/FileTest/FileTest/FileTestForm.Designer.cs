﻿namespace FileTest
{
   partial class FileTestForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.inputLabel = new System.Windows.Forms.Label();
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // inputLabel
         // 
         this.inputLabel.AutoSize = true;
         this.inputLabel.Font = new System.Drawing.Font( "Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.inputLabel.Location = new System.Drawing.Point( 13, 15 );
         this.inputLabel.Name = "inputLabel";
         this.inputLabel.Size = new System.Drawing.Size( 152, 20 );
         this.inputLabel.TabIndex = 5;
         this.inputLabel.Text = "Enter file or directory:";
         // 
         // outputTextBox
         // 
         this.outputTextBox.Location = new System.Drawing.Point( 13, 92 );
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.outputTextBox.Size = new System.Drawing.Size( 268, 237 );
         this.outputTextBox.TabIndex = 4;
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point( 13, 51 );
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size( 270, 23 );
         this.inputTextBox.TabIndex = 3;
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler( this.inputTextBox_KeyDown );
         // 
         // FileTestForm
         // 
         this.ClientSize = new System.Drawing.Size( 296, 345 );
         this.Controls.Add( this.inputLabel );
         this.Controls.Add( this.outputTextBox );
         this.Controls.Add( this.inputTextBox );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "FileTestForm";
         this.Text = "File Test";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label inputLabel;
      private System.Windows.Forms.TextBox outputTextBox;
      private System.Windows.Forms.TextBox inputTextBox;
   }
}