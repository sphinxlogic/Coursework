namespace NumericUpDownTest
{
   partial class interestCalculatorForm
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
         this.principalLabel = new System.Windows.Forms.Label();
         this.principalTextBox = new System.Windows.Forms.TextBox();
         this.interestLabel = new System.Windows.Forms.Label();
         this.interestTextBox = new System.Windows.Forms.TextBox();
         this.yearsLabel = new System.Windows.Forms.Label();
         this.yearUpDown = new System.Windows.Forms.NumericUpDown();
         this.balanceLabel = new System.Windows.Forms.Label();
         this.displayTextBox = new System.Windows.Forms.TextBox();
         this.calculateButton = new System.Windows.Forms.Button();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.yearUpDown ) ).BeginInit();
         this.SuspendLayout();
         // 
         // principalLabel
         // 
         this.principalLabel.AutoSize = true;
         this.principalLabel.Location = new System.Drawing.Point( 19, 25 );
         this.principalLabel.Name = "principalLabel";
         this.principalLabel.Size = new System.Drawing.Size( 56, 15 );
         this.principalLabel.TabIndex = 0;
         this.principalLabel.Text = "Principal:";
         // 
         // principalTextBox
         // 
         this.principalTextBox.Location = new System.Drawing.Point( 98, 22 );
         this.principalTextBox.Name = "principalTextBox";
         this.principalTextBox.Size = new System.Drawing.Size( 116, 23 );
         this.principalTextBox.TabIndex = 1;
         this.principalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // interestLabel
         // 
         this.interestLabel.AutoSize = true;
         this.interestLabel.Location = new System.Drawing.Point( 19, 73 );
         this.interestLabel.Name = "interestLabel";
         this.interestLabel.Size = new System.Drawing.Size( 75, 15 );
         this.interestLabel.TabIndex = 2;
         this.interestLabel.Text = "Interest Rate:";
         // 
         // interestTextBox
         // 
         this.interestTextBox.Location = new System.Drawing.Point( 98, 69 );
         this.interestTextBox.Name = "interestTextBox";
         this.interestTextBox.Size = new System.Drawing.Size( 116, 23 );
         this.interestTextBox.TabIndex = 3;
         this.interestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // yearsLabel
         // 
         this.yearsLabel.AutoSize = true;
         this.yearsLabel.Location = new System.Drawing.Point( 19, 120 );
         this.yearsLabel.Name = "yearsLabel";
         this.yearsLabel.Size = new System.Drawing.Size( 38, 15 );
         this.yearsLabel.TabIndex = 4;
         this.yearsLabel.Text = "Years:";
         // 
         // yearUpDown
         // 
         this.yearUpDown.Location = new System.Drawing.Point( 98, 112 );
         this.yearUpDown.Maximum = new decimal( new int[] {
            10,
            0,
            0,
            0} );
         this.yearUpDown.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            0} );
         this.yearUpDown.Name = "yearUpDown";
         this.yearUpDown.ReadOnly = true;
         this.yearUpDown.Size = new System.Drawing.Size( 117, 23 );
         this.yearUpDown.TabIndex = 5;
         this.yearUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.yearUpDown.Value = new decimal( new int[] {
            1,
            0,
            0,
            0} );
         // 
         // balanceLabel
         // 
         this.balanceLabel.AutoSize = true;
         this.balanceLabel.Location = new System.Drawing.Point( 19, 167 );
         this.balanceLabel.Name = "balanceLabel";
         this.balanceLabel.Size = new System.Drawing.Size( 132, 15 );
         this.balanceLabel.TabIndex = 6;
         this.balanceLabel.Text = "Yearly account balance:";
         // 
         // displayTextBox
         // 
         this.displayTextBox.BackColor = System.Drawing.SystemColors.Control;
         this.displayTextBox.Location = new System.Drawing.Point( 20, 198 );
         this.displayTextBox.Multiline = true;
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.ReadOnly = true;
         this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.displayTextBox.Size = new System.Drawing.Size( 296, 119 );
         this.displayTextBox.TabIndex = 7;
         // 
         // calculateButton
         // 
         this.calculateButton.Location = new System.Drawing.Point( 229, 18 );
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.Size = new System.Drawing.Size( 87, 27 );
         this.calculateButton.TabIndex = 8;
         this.calculateButton.Text = "Calculate";
         this.calculateButton.Click += new System.EventHandler( this.calculateButton_Click );
         // 
         // interestCalculatorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 337, 332 );
         this.Controls.Add( this.calculateButton );
         this.Controls.Add( this.displayTextBox );
         this.Controls.Add( this.balanceLabel );
         this.Controls.Add( this.yearUpDown );
         this.Controls.Add( this.yearsLabel );
         this.Controls.Add( this.interestTextBox );
         this.Controls.Add( this.interestLabel );
         this.Controls.Add( this.principalTextBox );
         this.Controls.Add( this.principalLabel );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "interestCalculatorForm";
         this.Text = "Interest Calculator";
         ( ( System.ComponentModel.ISupportInitialize ) ( this.yearUpDown ) ).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label principalLabel;
      private System.Windows.Forms.TextBox principalTextBox;
      private System.Windows.Forms.Label interestLabel;
      private System.Windows.Forms.TextBox interestTextBox;
      private System.Windows.Forms.Label yearsLabel;
      private System.Windows.Forms.NumericUpDown yearUpDown;
      private System.Windows.Forms.Label balanceLabel;
      private System.Windows.Forms.TextBox displayTextBox;
      private System.Windows.Forms.Button calculateButton;
   }
}