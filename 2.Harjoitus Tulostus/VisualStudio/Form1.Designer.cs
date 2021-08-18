
namespace VisualStudio
{
    partial class NappulaBT
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
            this.EnsimmäinenLB = new System.Windows.Forms.Label();
            this.ToinenLB = new System.Windows.Forms.Label();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.NappiBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnsimmäinenLB
            // 
            this.EnsimmäinenLB.AutoSize = true;
            this.EnsimmäinenLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnsimmäinenLB.Location = new System.Drawing.Point(30, 50);
            this.EnsimmäinenLB.Name = "EnsimmäinenLB";
            this.EnsimmäinenLB.Size = new System.Drawing.Size(223, 33);
            this.EnsimmäinenLB.TabIndex = 0;
            this.EnsimmäinenLB.Text = "Tulostettava teksti:";
            // 
            // ToinenLB
            // 
            this.ToinenLB.AutoSize = true;
            this.ToinenLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToinenLB.Location = new System.Drawing.Point(30, 136);
            this.ToinenLB.Name = "ToinenLB";
            this.ToinenLB.Size = new System.Drawing.Size(72, 33);
            this.ToinenLB.TabIndex = 1;
            this.ToinenLB.Text = "xxxx";
            this.ToinenLB.Visible = false;
            // 
            // TekstiTB
            // 
            this.TekstiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TekstiTB.Location = new System.Drawing.Point(259, 50);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(858, 35);
            this.TekstiTB.TabIndex = 2;
            // 
            // NappiBT
            // 
            this.NappiBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NappiBT.Location = new System.Drawing.Point(1159, 50);
            this.NappiBT.Name = "NappiBT";
            this.NappiBT.Size = new System.Drawing.Size(105, 33);
            this.NappiBT.TabIndex = 3;
            this.NappiBT.Text = "Hyväksy";
            this.NappiBT.UseVisualStyleBackColor = true;
            this.NappiBT.Click += new System.EventHandler(this.NappiBT_Click);
            // 
            // NappulaBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1301, 649);
            this.Controls.Add(this.NappiBT);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.ToinenLB);
            this.Controls.Add(this.EnsimmäinenLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "NappulaBT";
            this.Text = "Hyväksy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnsimmäinenLB;
        private System.Windows.Forms.Label ToinenLB;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Button NappiBT;
    }
}

