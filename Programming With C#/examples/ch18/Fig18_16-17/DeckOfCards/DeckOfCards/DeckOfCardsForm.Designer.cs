namespace DeckOfCards
{
   partial class DeckOfCardsForm
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
         this.statusLabel = new System.Windows.Forms.Label();
         this.displayLabel = new System.Windows.Forms.Label();
         this.shuffleButton = new System.Windows.Forms.Button();
         this.dealButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // statusLabel
         // 
         this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.statusLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.statusLabel.Location = new System.Drawing.Point( 129, 142 );
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size( 161, 29 );
         this.statusLabel.TabIndex = 7;
         // 
         // displayLabel
         // 
         this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.displayLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.displayLabel.Location = new System.Drawing.Point( 94, 102 );
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size( 224, 30 );
         this.displayLabel.TabIndex = 6;
         // 
         // shuffleButton
         // 
         this.shuffleButton.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.shuffleButton.Location = new System.Drawing.Point( 237, 23 );
         this.shuffleButton.Name = "shuffleButton";
         this.shuffleButton.Size = new System.Drawing.Size( 133, 65 );
         this.shuffleButton.TabIndex = 5;
         this.shuffleButton.Text = "Shuffle Cards";
         this.shuffleButton.Click += new System.EventHandler( this.shuffleButton_Click );
         // 
         // dealButton
         // 
         this.dealButton.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.dealButton.Location = new System.Drawing.Point( 57, 23 );
         this.dealButton.Name = "dealButton";
         this.dealButton.Size = new System.Drawing.Size( 133, 65 );
         this.dealButton.TabIndex = 4;
         this.dealButton.Text = "Deal Card";
         this.dealButton.Click += new System.EventHandler( this.dealButton_Click );
         // 
         // DeckOfCardsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 427, 194 );
         this.Controls.Add( this.statusLabel );
         this.Controls.Add( this.displayLabel );
         this.Controls.Add( this.shuffleButton );
         this.Controls.Add( this.dealButton );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "DeckOfCardsForm";
         this.Text = "Card Dealing Program";
         this.Load += new System.EventHandler( this.DeckForm_Load );
         this.ResumeLayout( false );

      }

      #endregion

      private System.Windows.Forms.Label statusLabel;
      private System.Windows.Forms.Label displayLabel;
      private System.Windows.Forms.Button shuffleButton;
      private System.Windows.Forms.Button dealButton;
   }
}