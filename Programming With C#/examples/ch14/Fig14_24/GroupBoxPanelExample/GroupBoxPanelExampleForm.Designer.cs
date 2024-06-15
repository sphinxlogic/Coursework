namespace GroupBoxPanelExample
{
   partial class GroupBoxPanelExampleForm
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
         this.hiButton = new System.Windows.Forms.Button();
         this.byeButton = new System.Windows.Forms.Button();
         this.mainGroupBox = new System.Windows.Forms.GroupBox();
         this.mainPanel = new System.Windows.Forms.Panel();
         this.rightButton = new System.Windows.Forms.Button();
         this.leftButton = new System.Windows.Forms.Button();
         this.messageLabel = new System.Windows.Forms.Label();
         this.mainGroupBox.SuspendLayout();
         this.mainPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // hiButton
         // 
         this.hiButton.Location = new System.Drawing.Point( 19, 48 );
         this.hiButton.Name = "hiButton";
         this.hiButton.Size = new System.Drawing.Size( 87, 43 );
         this.hiButton.TabIndex = 0;
         this.hiButton.Text = "Hi";
         this.hiButton.Click += new System.EventHandler( this.hiButton_Click );
         // 
         // byeButton
         // 
         this.byeButton.Location = new System.Drawing.Point( 127, 48 );
         this.byeButton.Name = "byeButton";
         this.byeButton.Size = new System.Drawing.Size( 87, 43 );
         this.byeButton.TabIndex = 1;
         this.byeButton.Text = "Bye";
         this.byeButton.Click += new System.EventHandler( this.byeButton_Click );
         // 
         // mainGroupBox
         // 
         this.mainGroupBox.Controls.Add( this.byeButton );
         this.mainGroupBox.Controls.Add( this.hiButton );
         this.mainGroupBox.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.mainGroupBox.Location = new System.Drawing.Point( 34, 14 );
         this.mainGroupBox.Name = "mainGroupBox";
         this.mainGroupBox.Size = new System.Drawing.Size( 233, 115 );
         this.mainGroupBox.TabIndex = 2;
         this.mainGroupBox.TabStop = false;
         this.mainGroupBox.Text = "Main GroupBox";
         // 
         // mainPanel
         // 
         this.mainPanel.AutoScroll = true;
         this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.mainPanel.Controls.Add( this.rightButton );
         this.mainPanel.Controls.Add( this.leftButton );
         this.mainPanel.Location = new System.Drawing.Point( 34, 179 );
         this.mainPanel.Name = "mainPanel";
         this.mainPanel.Size = new System.Drawing.Size( 233, 104 );
         this.mainPanel.TabIndex = 3;
         // 
         // rightButton
         // 
         this.rightButton.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.rightButton.Location = new System.Drawing.Point( 184, 27 );
         this.rightButton.Name = "rightButton";
         this.rightButton.Size = new System.Drawing.Size( 87, 44 );
         this.rightButton.TabIndex = 1;
         this.rightButton.Text = "Far right";
         this.rightButton.Click += new System.EventHandler( this.rightButton_Click );
         // 
         // leftButton
         // 
         this.leftButton.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.leftButton.Location = new System.Drawing.Point( 17, 27 );
         this.leftButton.Name = "leftButton";
         this.leftButton.Size = new System.Drawing.Size( 87, 44 );
         this.leftButton.TabIndex = 0;
         this.leftButton.Text = "Far left";
         this.leftButton.Click += new System.EventHandler( this.leftButton_Click );
         // 
         // messageLabel
         // 
         this.messageLabel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.messageLabel.Location = new System.Drawing.Point( 34, 145 );
         this.messageLabel.Name = "messageLabel";
         this.messageLabel.Size = new System.Drawing.Size( 233, 28 );
         this.messageLabel.TabIndex = 4;
         // 
         // GroupBoxPanelExampleForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 301, 297 );
         this.Controls.Add( this.messageLabel );
         this.Controls.Add( this.mainPanel );
         this.Controls.Add( this.mainGroupBox );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "GroupBoxPanelExampleForm";
         this.Text = "GroupBox and Panel Example";
         this.mainGroupBox.ResumeLayout( false );
         this.mainPanel.ResumeLayout( false );
         this.ResumeLayout( false );

      }

      #endregion

      private System.Windows.Forms.Button hiButton;
      private System.Windows.Forms.Button byeButton;
      private System.Windows.Forms.GroupBox mainGroupBox;
      private System.Windows.Forms.Panel mainPanel;
      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.Button rightButton;
      private System.Windows.Forms.Button leftButton;
   }
}

