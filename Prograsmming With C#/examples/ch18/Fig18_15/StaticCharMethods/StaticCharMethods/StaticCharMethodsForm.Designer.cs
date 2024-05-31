namespace StaticCharMethods
{
   partial class StaticCharMethodsForm
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
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.analyzeButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.enterLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // outputTextBox
         // 
         this.outputTextBox.Location = new System.Drawing.Point( 24, 102 );
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.Size = new System.Drawing.Size( 195, 138 );
         this.outputTextBox.TabIndex = 7;
         // 
         // analyzeButton
         // 
         this.analyzeButton.Font = new System.Drawing.Font( "Segoe UI", 9F );
         this.analyzeButton.Location = new System.Drawing.Point( 57, 57 );
         this.analyzeButton.Name = "analyzeButton";
         this.analyzeButton.Size = new System.Drawing.Size( 130, 26 );
         this.analyzeButton.TabIndex = 6;
         this.analyzeButton.Text = "Analyze Character";
         this.analyzeButton.Click += new System.EventHandler( this.analyzeButton_Click );
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point( 145, 19 );
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size( 74, 23 );
         this.inputTextBox.TabIndex = 5;
         // 
         // enterLabel
         // 
         this.enterLabel.AutoSize = true;
         this.enterLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.enterLabel.Location = new System.Drawing.Point( 22, 23 );
         this.enterLabel.Name = "enterLabel";
         this.enterLabel.Size = new System.Drawing.Size( 98, 15 );
         this.enterLabel.TabIndex = 4;
         this.enterLabel.Text = "Enter a character:";
         // 
         // StaticCharMethodsForm
         // 
         this.ClientSize = new System.Drawing.Size( 240, 258 );
         this.Controls.Add( this.outputTextBox );
         this.Controls.Add( this.analyzeButton );
         this.Controls.Add( this.inputTextBox );
         this.Controls.Add( this.enterLabel );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "StaticCharMethodsForm";
         this.Text = "Static Char Methods";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox outputTextBox;
      private System.Windows.Forms.Button analyzeButton;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.Label enterLabel;
   }
}