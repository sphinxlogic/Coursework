namespace MasterDetail
{
   partial class MasterDetailForm
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
         this.authorLabel = new System.Windows.Forms.Label();
         this.titleLabel = new System.Windows.Forms.Label();
         this.authorComboBox = new System.Windows.Forms.ComboBox();
         this.titleComboBox = new System.Windows.Forms.ComboBox();
         this.booksDataGridView = new System.Windows.Forms.DataGridView();
         this.booksBindingSource = new System.Windows.Forms.BindingSource( this.components );
         ( ( System.ComponentModel.ISupportInitialize ) ( this.booksDataGridView ) ).BeginInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.booksBindingSource ) ).BeginInit();
         this.SuspendLayout();
         // 
         // authorLabel
         // 
         this.authorLabel.AutoSize = true;
         this.authorLabel.Location = new System.Drawing.Point( 12, 15 );
         this.authorLabel.Name = "authorLabel";
         this.authorLabel.Size = new System.Drawing.Size( 47, 15 );
         this.authorLabel.TabIndex = 0;
         this.authorLabel.Text = "Author:";
         // 
         // titleLabel
         // 
         this.titleLabel.AutoSize = true;
         this.titleLabel.Location = new System.Drawing.Point( 203, 15 );
         this.titleLabel.Name = "titleLabel";
         this.titleLabel.Size = new System.Drawing.Size( 33, 15 );
         this.titleLabel.TabIndex = 1;
         this.titleLabel.Text = "Title:";
         // 
         // authorComboBox
         // 
         this.authorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.authorComboBox.FormattingEnabled = true;
         this.authorComboBox.Location = new System.Drawing.Point( 65, 12 );
         this.authorComboBox.Name = "authorComboBox";
         this.authorComboBox.Size = new System.Drawing.Size( 132, 23 );
         this.authorComboBox.TabIndex = 2;
         this.authorComboBox.SelectedIndexChanged += new System.EventHandler( this.authorComboBox_SelectedIndexChanged );
         // 
         // titleComboBox
         // 
         this.titleComboBox.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.titleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.titleComboBox.FormattingEnabled = true;
         this.titleComboBox.Location = new System.Drawing.Point( 242, 12 );
         this.titleComboBox.Name = "titleComboBox";
         this.titleComboBox.Size = new System.Drawing.Size( 234, 23 );
         this.titleComboBox.TabIndex = 3;
         this.titleComboBox.SelectedIndexChanged += new System.EventHandler( this.titleComboBox_SelectedIndexChanged );
         // 
         // booksDataGridView
         // 
         this.booksDataGridView.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                     | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.booksDataGridView.Location = new System.Drawing.Point( 12, 41 );
         this.booksDataGridView.Name = "booksDataGridView";
         this.booksDataGridView.ReadOnly = true;
         this.booksDataGridView.Size = new System.Drawing.Size( 464, 222 );
         this.booksDataGridView.TabIndex = 4;
         // 
         // MasterDetailForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 488, 275 );
         this.Controls.Add( this.booksDataGridView );
         this.Controls.Add( this.titleComboBox );
         this.Controls.Add( this.authorComboBox );
         this.Controls.Add( this.titleLabel );
         this.Controls.Add( this.authorLabel );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "MasterDetailForm";
         this.Text = "Master/Detail";
         this.Load += new System.EventHandler( this.MasterDetailForm_Load );
         ( ( System.ComponentModel.ISupportInitialize ) ( this.booksDataGridView ) ).EndInit();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.booksBindingSource ) ).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label authorLabel;
      private System.Windows.Forms.Label titleLabel;
      private System.Windows.Forms.ComboBox authorComboBox;
      private System.Windows.Forms.ComboBox titleComboBox;
      private System.Windows.Forms.DataGridView booksDataGridView;
      private System.Windows.Forms.BindingSource booksBindingSource;
   }
}

