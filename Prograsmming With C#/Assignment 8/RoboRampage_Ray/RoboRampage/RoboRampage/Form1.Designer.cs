namespace RoboRampage
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_uturn = new System.Windows.Forms.Button();
            this.nmr_numMoves = new System.Windows.Forms.NumericUpDown();
            this.btn_move = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_numMoves)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rotate Robot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Move Robot";
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(748, 101);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(906, 101);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_uturn
            // 
            this.btn_uturn.Location = new System.Drawing.Point(832, 154);
            this.btn_uturn.Name = "btn_uturn";
            this.btn_uturn.Size = new System.Drawing.Size(75, 23);
            this.btn_uturn.TabIndex = 4;
            this.btn_uturn.Text = "U-turn";
            this.btn_uturn.UseVisualStyleBackColor = true;
            this.btn_uturn.Click += new System.EventHandler(this.btn_uturn_Click);
            // 
            // nmr_numMoves
            // 
            this.nmr_numMoves.Location = new System.Drawing.Point(906, 338);
            this.nmr_numMoves.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmr_numMoves.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nmr_numMoves.Name = "nmr_numMoves";
            this.nmr_numMoves.Size = new System.Drawing.Size(31, 20);
            this.nmr_numMoves.TabIndex = 5;
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(802, 338);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(75, 23);
            this.btn_move.TabIndex = 6;
            this.btn_move.Text = "Move";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 706);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.nmr_numMoves);
            this.Controls.Add(this.btn_uturn);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RoboRampage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_numMoves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_uturn;
        private System.Windows.Forms.NumericUpDown nmr_numMoves;
        private System.Windows.Forms.Button btn_move;
    }
}

