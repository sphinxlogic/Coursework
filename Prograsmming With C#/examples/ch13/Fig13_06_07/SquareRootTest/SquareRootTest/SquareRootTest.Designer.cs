namespace SquareRootTest
{
   partial class SquareRootForm
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
         this.outputLabel = new System.Windows.Forms.Label();
         this.squareRootButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.inputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // outputLabel
         // 
         this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.outputLabel.Location = new System.Drawing.Point( 13, 104 );
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size( 274, 25 );
         this.outputLabel.TabIndex = 7;
         // 
         // squareRootButton
         // 
         this.squareRootButton.Location = new System.Drawing.Point( 62, 54 );
         this.squareRootButton.Name = "squareRootButton";
         this.squareRootButton.Size = new System.Drawing.Size( 174, 31 );
         this.squareRootButton.TabIndex = 6;
         this.squareRootButton.Text = "Square Root";
         this.squareRootButton.Click += new System.EventHandler( this.squareRootButton_Click );
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point( 187, 15 );
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size( 100, 26 );
         this.inputTextBox.TabIndex = 5;
         // 
         // inputLabel
         // 
         this.inputLabel.AutoSize = true;
         this.inputLabel.Location = new System.Drawing.Point( 13, 18 );
         this.inputLabel.Name = "inputLabel";
         this.inputLabel.Size = new System.Drawing.Size( 173, 20 );
         this.inputLabel.TabIndex = 4;
         this.inputLabel.Text = "Please enter a number:";
         // 
         // SquareRootForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 9F, 20F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 300, 144 );
         this.Controls.Add( this.outputLabel );
         this.Controls.Add( this.squareRootButton );
         this.Controls.Add( this.inputTextBox );
         this.Controls.Add( this.inputLabel );
         this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
         this.Name = "SquareRootForm";
         this.Text = "Computing the Square Root";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label outputLabel;
      private System.Windows.Forms.Button squareRootButton;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.Label inputLabel;
   }
}

