namespace Date
{
    partial class SaveEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.save_event = new System.Windows.Forms.Button();
            this.descript = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_event
            // 
            this.save_event.Location = new System.Drawing.Point(63, 184);
            this.save_event.Name = "save_event";
            this.save_event.Size = new System.Drawing.Size(75, 23);
            this.save_event.TabIndex = 0;
            this.save_event.Text = "Add Event";
            this.save_event.UseVisualStyleBackColor = true;
            this.save_event.Click += new System.EventHandler(this.button1_Click);
            // 
            // descript
            // 
            this.descript.Location = new System.Drawing.Point(19, 50);
            this.descript.Multiline = true;
            this.descript.Name = "descript";
            this.descript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descript.Size = new System.Drawing.Size(173, 90);
            this.descript.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descript);
            this.groupBox1.Controls.Add(this.save_event);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Description";
            // 
            // SaveEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaveEvent";
            this.Text = "Event Description";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaveEvent_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_event;
        public System.Windows.Forms.TextBox descript;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}