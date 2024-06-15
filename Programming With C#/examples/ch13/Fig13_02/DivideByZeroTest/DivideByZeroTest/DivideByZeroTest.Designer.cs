namespace DivideByZeroTest
{
   partial class DivideByZeroTestForm
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
         this.divideButton = new System.Windows.Forms.Button();
         this.denominatorTextBox = new System.Windows.Forms.TextBox();
         this.numeratorTextBox = new System.Windows.Forms.TextBox();
         this.denominatorLabel = new System.Windows.Forms.Label();
         this.numeratorLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // outputLabel
         // 
         this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.outputLabel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.outputLabel.Location = new System.Drawing.Point( 165, 98 );
         this.outputLabel.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size( 100, 30 );
         this.outputLabel.TabIndex = 11;
         // 
         // divideButton
         // 
         this.divideButton.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.divideButton.Location = new System.Drawing.Point( 14, 98 );
         this.divideButton.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
         this.divideButton.Name = "divideButton";
         this.divideButton.Size = new System.Drawing.Size( 138, 31 );
         this.divideButton.TabIndex = 10;
         this.divideButton.Text = "Click to Divide";
         this.divideButton.Click += new System.EventHandler( this.divideButton_Click );
         // 
         // denominatorTextBox
         // 
         this.denominatorTextBox.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.denominatorTextBox.Location = new System.Drawing.Point( 165, 52 );
         this.denominatorTextBox.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
         this.denominatorTextBox.Name = "denominatorTextBox";
         this.denominatorTextBox.Size = new System.Drawing.Size( 100, 26 );
         this.denominatorTextBox.TabIndex = 9;
         // 
         // numeratorTextBox
         // 
         this.numeratorTextBox.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.numeratorTextBox.Location = new System.Drawing.Point( 165, 15 );
         this.numeratorTextBox.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
         this.numeratorTextBox.Name = "numeratorTextBox";
         this.numeratorTextBox.Size = new System.Drawing.Size( 100, 26 );
         this.numeratorTextBox.TabIndex = 8;
         // 
         // denominatorLabel
         // 
         this.denominatorLabel.AutoSize = true;
         this.denominatorLabel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.denominatorLabel.Location = new System.Drawing.Point( 14, 54 );
         this.denominatorLabel.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
         this.denominatorLabel.Name = "denominatorLabel";
         this.denominatorLabel.Size = new System.Drawing.Size( 145, 20 );
         this.denominatorLabel.TabIndex = 7;
         this.denominatorLabel.Text = "Enter denominator:";
         // 
         // numeratorLabel
         // 
         this.numeratorLabel.AutoSize = true;
         this.numeratorLabel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.numeratorLabel.Location = new System.Drawing.Point( 12, 18 );
         this.numeratorLabel.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
         this.numeratorLabel.Name = "numeratorLabel";
         this.numeratorLabel.Size = new System.Drawing.Size( 129, 20 );
         this.numeratorLabel.TabIndex = 6;
         this.numeratorLabel.Text = "Enter numerator:";
         // 
         // DivideByZeroTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 281, 142 );
         this.Controls.Add( this.outputLabel );
         this.Controls.Add( this.divideButton );
         this.Controls.Add( this.denominatorTextBox );
         this.Controls.Add( this.numeratorTextBox );
         this.Controls.Add( this.denominatorLabel );
         this.Controls.Add( this.numeratorLabel );
         this.Name = "DivideByZeroTestForm";
         this.Text = "DivideByZero";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label outputLabel;
      private System.Windows.Forms.Button divideButton;
      private System.Windows.Forms.TextBox denominatorTextBox;
      private System.Windows.Forms.TextBox numeratorTextBox;
      private System.Windows.Forms.Label denominatorLabel;
      private System.Windows.Forms.Label numeratorLabel;
   }
}

