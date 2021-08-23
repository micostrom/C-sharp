namespace _7.Tehtävä
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
            this.FahrenheitLb = new System.Windows.Forms.Label();
            this.FahrenheitTB = new System.Windows.Forms.TextBox();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.CelsiusLB = new System.Windows.Forms.Label();
            this.CelsiuksetTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FahrenheitLb
            // 
            this.FahrenheitLb.AutoSize = true;
            this.FahrenheitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitLb.Location = new System.Drawing.Point(12, 18);
            this.FahrenheitLb.Name = "FahrenheitLb";
            this.FahrenheitLb.Size = new System.Drawing.Size(121, 25);
            this.FahrenheitLb.TabIndex = 0;
            this.FahrenheitLb.Text = "Fahrenheit:";
            // 
            // FahrenheitTB
            // 
            this.FahrenheitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitTB.Location = new System.Drawing.Point(156, 18);
            this.FahrenheitTB.Name = "FahrenheitTB";
            this.FahrenheitTB.Size = new System.Drawing.Size(293, 31);
            this.FahrenheitTB.TabIndex = 1;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuunnaBT.Location = new System.Drawing.Point(17, 63);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(119, 63);
            this.MuunnaBT.TabIndex = 2;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // CelsiusLB
            // 
            this.CelsiusLB.AutoSize = true;
            this.CelsiusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusLB.Location = new System.Drawing.Point(12, 141);
            this.CelsiusLB.Name = "CelsiusLB";
            this.CelsiusLB.Size = new System.Drawing.Size(118, 25);
            this.CelsiusLB.TabIndex = 3;
            this.CelsiusLB.Text = "Celsiukset:";
            // 
            // CelsiuksetTB
            // 
            this.CelsiuksetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiuksetTB.Location = new System.Drawing.Point(156, 135);
            this.CelsiuksetTB.Name = "CelsiuksetTB";
            this.CelsiuksetTB.Size = new System.Drawing.Size(293, 31);
            this.CelsiuksetTB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 180);
            this.Controls.Add(this.CelsiuksetTB);
            this.Controls.Add(this.CelsiusLB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.FahrenheitTB);
            this.Controls.Add(this.FahrenheitLb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FahrenheitLb;
        private System.Windows.Forms.TextBox FahrenheitTB;
        private System.Windows.Forms.Button MuunnaBT;
        private System.Windows.Forms.Label CelsiusLB;
        private System.Windows.Forms.TextBox CelsiuksetTB;
    }
}

