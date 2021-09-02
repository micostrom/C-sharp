namespace _11.Harjoitus_Noppa
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
            this.Noppa01BT = new System.Windows.Forms.PictureBox();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeitaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Noppa01BT
            // 
            this.Noppa01BT.Image = global::_11.Harjoitus_Noppa.Properties.Resources.Noppa1;
            this.Noppa01BT.Location = new System.Drawing.Point(56, 85);
            this.Noppa01BT.Name = "Noppa01BT";
            this.Noppa01BT.Size = new System.Drawing.Size(169, 152);
            this.Noppa01BT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01BT.TabIndex = 0;
            this.Noppa01BT.TabStop = false;
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::_11.Harjoitus_Noppa.Properties.Resources.Noppa3;
            this.Noppa02PB.Location = new System.Drawing.Point(231, 85);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(169, 152);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 1;
            this.Noppa02PB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nopan heitto";
            // 
            // HeitaBT
            // 
            this.HeitaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeitaBT.Location = new System.Drawing.Point(56, 262);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(344, 58);
            this.HeitaBT.TabIndex = 3;
            this.HeitaBT.Text = "Heitä";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 352);
            this.Controls.Add(this.HeitaBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.Noppa01BT);
            this.Name = "Form1";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Noppa01BT;
        private System.Windows.Forms.PictureBox Noppa02PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HeitaBT;
    }
}

