namespace LabelTextBoxButtonTest
{
   partial class LabelTextBoxButtonTestForm
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
         this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
         this.displayPasswordLabel = new System.Windows.Forms.Label();
         this.displayPasswordButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // inputPasswordTextBox
         // 
         this.inputPasswordTextBox.Location = new System.Drawing.Point( 14, 14 );
         this.inputPasswordTextBox.Name = "inputPasswordTextBox";
         this.inputPasswordTextBox.Size = new System.Drawing.Size( 297, 23 );
         this.inputPasswordTextBox.TabIndex = 0;
         this.inputPasswordTextBox.UseSystemPasswordChar = true;
         // 
         // displayPasswordLabel
         // 
         this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.displayPasswordLabel.Location = new System.Drawing.Point( 14, 58 );
         this.displayPasswordLabel.Name = "displayPasswordLabel";
         this.displayPasswordLabel.Size = new System.Drawing.Size( 297, 35 );
         this.displayPasswordLabel.TabIndex = 1;
         // 
         // displayPasswordButton
         // 
         this.displayPasswordButton.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.displayPasswordButton.Location = new System.Drawing.Point( 103, 107 );
         this.displayPasswordButton.Name = "displayPasswordButton";
         this.displayPasswordButton.Size = new System.Drawing.Size( 127, 42 );
         this.displayPasswordButton.TabIndex = 2;
         this.displayPasswordButton.Text = "Show Me";
         this.displayPasswordButton.Click += new System.EventHandler( this.displayPasswordButton_Click );
         // 
         // LabelTextBoxButtonTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 325, 166 );
         this.Controls.Add( this.displayPasswordButton );
         this.Controls.Add( this.displayPasswordLabel );
         this.Controls.Add( this.inputPasswordTextBox );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "LabelTextBoxButtonTestForm";
         this.Text = "Label, TextBox and Button Test";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox inputPasswordTextBox;
      private System.Windows.Forms.Label displayPasswordLabel;
      private System.Windows.Forms.Button displayPasswordButton;
   }
}