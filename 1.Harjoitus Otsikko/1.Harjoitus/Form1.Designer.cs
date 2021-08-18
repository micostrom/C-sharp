
namespace _1.Harjoitus
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.AlkuperäinenBT = new System.Windows.Forms.Button();
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.BackColor = System.Drawing.Color.White;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.ForeColor = System.Drawing.Color.Black;
            this.OtsikkoLB.Location = new System.Drawing.Point(12, 9);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(82, 30);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Otsikko";
            // 
            // AlkuperäinenBT
            // 
            this.AlkuperäinenBT.BackColor = System.Drawing.Color.Lime;
            this.AlkuperäinenBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlkuperäinenBT.Location = new System.Drawing.Point(303, 51);
            this.AlkuperäinenBT.Name = "AlkuperäinenBT";
            this.AlkuperäinenBT.Size = new System.Drawing.Size(292, 59);
            this.AlkuperäinenBT.TabIndex = 1;
            this.AlkuperäinenBT.Text = "Vaihda alkuperäiseksi";
            this.AlkuperäinenBT.UseVisualStyleBackColor = false;
            this.AlkuperäinenBT.Click += new System.EventHandler(this.AlkuperäinenBT_Click);
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.BackColor = System.Drawing.Color.Red;
            this.VaihdaBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VaihdaBT.ForeColor = System.Drawing.Color.Black;
            this.VaihdaBT.Location = new System.Drawing.Point(5, 51);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(292, 59);
            this.VaihdaBT.TabIndex = 2;
            this.VaihdaBT.Text = "Vaihda otsikko";
            this.VaihdaBT.UseVisualStyleBackColor = false;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 127);
            this.Controls.Add(this.VaihdaBT);
            this.Controls.Add(this.AlkuperäinenBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button AlkuperäinenBT;
        private System.Windows.Forms.Button VaihdaBT;
    }
}

