
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.PolttoaineTB = new System.Windows.Forms.TextBox();
            this.MuutTB = new System.Windows.Forms.TextBox();
            this.VakuutusTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.KilmoteriCB = new System.Windows.Forms.ComboBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auton kustannuslaskuri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lainan lyhennys korkoineen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vakuutusmaksut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Polttoneste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Muut kulut:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(413, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pesut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(413, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kilometrit/vuosi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(413, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Renkaat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(413, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 30);
            this.label10.TabIndex = 9;
            this.label10.Text = "Huollot:";
            // 
            // LainaTB
            // 
            this.LainaTB.AccessibleName = "";
            this.LainaTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LainaTB.Location = new System.Drawing.Point(287, 70);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(100, 35);
            this.LainaTB.TabIndex = 10;
            // 
            // PesutTB
            // 
            this.PesutTB.AccessibleName = "";
            this.PesutTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesutTB.Location = new System.Drawing.Point(569, 67);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(100, 35);
            this.PesutTB.TabIndex = 11;
            // 
            // HuollotTB
            // 
            this.HuollotTB.AccessibleName = "";
            this.HuollotTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HuollotTB.Location = new System.Drawing.Point(569, 108);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(100, 35);
            this.HuollotTB.TabIndex = 12;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.AccessibleName = "";
            this.RenkaatTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RenkaatTB.Location = new System.Drawing.Point(569, 150);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(100, 35);
            this.RenkaatTB.TabIndex = 13;
            // 
            // PolttoaineTB
            // 
            this.PolttoaineTB.AccessibleName = "";
            this.PolttoaineTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PolttoaineTB.Location = new System.Drawing.Point(287, 235);
            this.PolttoaineTB.Name = "PolttoaineTB";
            this.PolttoaineTB.Size = new System.Drawing.Size(100, 35);
            this.PolttoaineTB.TabIndex = 15;
            // 
            // MuutTB
            // 
            this.MuutTB.AccessibleName = "";
            this.MuutTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuutTB.Location = new System.Drawing.Point(287, 194);
            this.MuutTB.Name = "MuutTB";
            this.MuutTB.Size = new System.Drawing.Size(100, 35);
            this.MuutTB.TabIndex = 16;
            // 
            // VakuutusTB
            // 
            this.VakuutusTB.AccessibleName = "";
            this.VakuutusTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VakuutusTB.Location = new System.Drawing.Point(287, 153);
            this.VakuutusTB.Name = "VakuutusTB";
            this.VakuutusTB.Size = new System.Drawing.Size(100, 35);
            this.VakuutusTB.TabIndex = 17;
            // 
            // NesteetTB
            // 
            this.NesteetTB.AccessibleName = "";
            this.NesteetTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NesteetTB.Location = new System.Drawing.Point(287, 113);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(100, 35);
            this.NesteetTB.TabIndex = 18;
            // 
            // KilmoteriCB
            // 
            this.KilmoteriCB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KilmoteriCB.FormattingEnabled = true;
            this.KilmoteriCB.Items.AddRange(new object[] {
            "10 000",
            "20 000",
            "30 000",
            "40 000",
            "50 000",
            "75 000",
            "100 000",
            "200 000",
            "300 000"});
            this.KilmoteriCB.Location = new System.Drawing.Point(569, 190);
            this.KilmoteriCB.Name = "KilmoteriCB";
            this.KilmoteriCB.Size = new System.Drawing.Size(100, 38);
            this.KilmoteriCB.TabIndex = 19;
            this.KilmoteriCB.SelectedIndexChanged += new System.EventHandler(this.KilmoteriCB_SelectedIndexChanged);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(26, 307);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(88, 30);
            this.VastausLB.TabIndex = 20;
            this.VastausLB.Text = "Vastaus:";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KilmoteriCB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.VakuutusTB);
            this.Controls.Add(this.MuutTB);
            this.Controls.Add(this.PolttoaineTB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LainaTB;
        private System.Windows.Forms.TextBox PesutTB;
        private System.Windows.Forms.TextBox HuollotTB;
        private System.Windows.Forms.TextBox RenkaatTB;
        private System.Windows.Forms.TextBox PolttoaineTB;
        private System.Windows.Forms.TextBox MuutTB;
        private System.Windows.Forms.TextBox VakuutusTB;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.ComboBox KilmoteriCB;
        private System.Windows.Forms.Label VastausLB;
    }
}

