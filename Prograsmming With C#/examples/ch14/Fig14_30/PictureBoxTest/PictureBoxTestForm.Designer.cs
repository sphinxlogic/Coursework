namespace PictureBoxTest
{
   partial class PictureBoxTestForm
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
         this.imagePictureBox = new System.Windows.Forms.PictureBox();
         this.nextButton = new System.Windows.Forms.Button();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.imagePictureBox ) ).BeginInit();
         this.SuspendLayout();
         // 
         // imagePictureBox
         // 
         this.imagePictureBox.Location = new System.Drawing.Point( 21, 70 );
         this.imagePictureBox.Name = "imagePictureBox";
         this.imagePictureBox.Size = new System.Drawing.Size( 304, 247 );
         this.imagePictureBox.TabIndex = 7;
         this.imagePictureBox.TabStop = false;
         this.imagePictureBox.BackColorChanged += new System.EventHandler( this.nextButton_Click );
         // 
         // nextButton
         // 
         this.nextButton.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.nextButton.Location = new System.Drawing.Point( 90, 20 );
         this.nextButton.Name = "nextButton";
         this.nextButton.Size = new System.Drawing.Size( 154, 32 );
         this.nextButton.TabIndex = 6;
         this.nextButton.Text = "Next Image";
         this.nextButton.BackColorChanged += new System.EventHandler( this.nextButton_Click );
         this.nextButton.Click += new System.EventHandler( this.nextButton_Click );
         // 
         // PictureBoxTestForm
         // 
         this.ClientSize = new System.Drawing.Size( 346, 336 );
         this.Controls.Add( this.imagePictureBox );
         this.Controls.Add( this.nextButton );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "PictureBoxTestForm";
         this.Text = "PictureBoxTest";
         ( ( System.ComponentModel.ISupportInitialize ) ( this.imagePictureBox ) ).EndInit();
         this.ResumeLayout( false );

      }

      #endregion

      internal System.Windows.Forms.PictureBox imagePictureBox;
      internal System.Windows.Forms.Button nextButton;

   }
}
