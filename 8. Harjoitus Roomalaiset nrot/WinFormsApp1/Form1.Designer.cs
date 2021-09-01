
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LukuTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 54F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // LukuTB
            // 
            this.LukuTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuTB.Location = new System.Drawing.Point(575, 121);
            this.LukuTB.Name = "LukuTB";
            this.LukuTB.Size = new System.Drawing.Size(129, 35);
            this.LukuTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(74, 211);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(422, 50);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "XXXXXXXX";
            this.VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            this.MuutaBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MuutaBT.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuutaBT.ForeColor = System.Drawing.Color.Black;
            this.MuutaBT.Location = new System.Drawing.Point(575, 211);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(129, 50);
            this.MuutaBT.TabIndex = 4;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = false;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(716, 316);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.LukuTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LukuTB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button MuutaBT;
    }
}

