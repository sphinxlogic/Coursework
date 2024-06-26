namespace ToolTipDemonstration
{
   partial class ToolTipDemonstrationForm
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
         this.components = new System.ComponentModel.Container();
         this.labelsToolTip = new System.Windows.Forms.ToolTip( this.components );
         this.secondLabel = new System.Windows.Forms.Label();
         this.firstLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // secondLabel
         // 
         this.secondLabel.AutoSize = true;
         this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.secondLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.secondLabel.Location = new System.Drawing.Point( 87, 91 );
         this.secondLabel.Name = "secondLabel";
         this.secondLabel.Size = new System.Drawing.Size( 120, 17 );
         this.secondLabel.TabIndex = 7;
         this.secondLabel.Tag = "";
         this.secondLabel.Text = "This is another Label.";
         this.labelsToolTip.SetToolTip( this.secondLabel, "Second Label" );
         // 
         // firstLabel
         // 
         this.firstLabel.AutoSize = true;
         this.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.firstLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.firstLabel.Location = new System.Drawing.Point( 87, 38 );
         this.firstLabel.Name = "firstLabel";
         this.firstLabel.Size = new System.Drawing.Size( 82, 17 );
         this.firstLabel.TabIndex = 6;
         this.firstLabel.Text = "This is a label.";
         this.labelsToolTip.SetToolTip( this.firstLabel, "First Label" );
         // 
         // ToolTipDemonstrationForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 294, 143 );
         this.Controls.Add( this.secondLabel );
         this.Controls.Add( this.firstLabel );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "ToolTipDemonstrationForm";
         this.Text = "ToolTip Demonstration";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ToolTip labelsToolTip;
      internal System.Windows.Forms.Label secondLabel;
      internal System.Windows.Forms.Label firstLabel;
   }
}
