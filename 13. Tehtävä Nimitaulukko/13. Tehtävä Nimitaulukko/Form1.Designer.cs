namespace _13.Tehtävä_Nimitaulukko
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
            this.VastausLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(12, 54);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(81, 24);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus:";
            // 
            // NimiTB
            // 
            this.NimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NimiTB.Location = new System.Drawing.Point(569, 6);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(167, 29);
            this.NimiTB.TabIndex = 2;
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarkastaBT.Location = new System.Drawing.Point(592, 50);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(144, 33);
            this.TarkastaBT.TabIndex = 3;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = true;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 122);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.Button TarkastaBT;
    }
}

