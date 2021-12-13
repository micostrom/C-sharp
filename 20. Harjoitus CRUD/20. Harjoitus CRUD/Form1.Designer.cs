
namespace _20.Harjoitus_CRUD
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
            this.IDLB = new System.Windows.Forms.Label();
            this.SukunimiLB = new System.Windows.Forms.Label();
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.OpiskelijanroLB = new System.Windows.Forms.Label();
            this.SahkopostiLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.SahkopostiTB = new System.Windows.Forms.TextBox();
            this.OpiskelijanroTB = new System.Windows.Forms.TextBox();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLB
            // 
            this.IDLB.AutoSize = true;
            this.IDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLB.Location = new System.Drawing.Point(12, 9);
            this.IDLB.Name = "IDLB";
            this.IDLB.Size = new System.Drawing.Size(41, 25);
            this.IDLB.TabIndex = 0;
            this.IDLB.Text = "ID:";
            // 
            // SukunimiLB
            // 
            this.SukunimiLB.AutoSize = true;
            this.SukunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SukunimiLB.Location = new System.Drawing.Point(12, 85);
            this.SukunimiLB.Name = "SukunimiLB";
            this.SukunimiLB.Size = new System.Drawing.Size(115, 25);
            this.SukunimiLB.TabIndex = 1;
            this.SukunimiLB.Text = "Sukunimi:";
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtunimiLB.Location = new System.Drawing.Point(12, 47);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.Size = new System.Drawing.Size(97, 25);
            this.EtunimiLB.TabIndex = 2;
            this.EtunimiLB.Text = "Etunimi:";
            // 
            // OpiskelijanroLB
            // 
            this.OpiskelijanroLB.AutoSize = true;
            this.OpiskelijanroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpiskelijanroLB.Location = new System.Drawing.Point(359, 85);
            this.OpiskelijanroLB.Name = "OpiskelijanroLB";
            this.OpiskelijanroLB.Size = new System.Drawing.Size(157, 25);
            this.OpiskelijanroLB.TabIndex = 3;
            this.OpiskelijanroLB.Text = "Opiskelijanro:";
            // 
            // SahkopostiLB
            // 
            this.SahkopostiLB.AutoSize = true;
            this.SahkopostiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SahkopostiLB.Location = new System.Drawing.Point(359, 47);
            this.SahkopostiLB.Name = "SahkopostiLB";
            this.SahkopostiLB.Size = new System.Drawing.Size(136, 25);
            this.SahkopostiLB.TabIndex = 4;
            this.SahkopostiLB.Text = "Sähköposti:";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhelinLB.Location = new System.Drawing.Point(359, 9);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(98, 25);
            this.PuhelinLB.TabIndex = 5;
            this.PuhelinLB.Text = "Puhelin:";
            // 
            // IDTB
            // 
            this.IDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTB.Location = new System.Drawing.Point(132, 9);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(199, 31);
            this.IDTB.TabIndex = 6;
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SukunimiTB.Location = new System.Drawing.Point(132, 79);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(199, 31);
            this.SukunimiTB.TabIndex = 7;
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtunimiTB.Location = new System.Drawing.Point(132, 44);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(199, 31);
            this.EtunimiTB.TabIndex = 8;
            // 
            // SahkopostiTB
            // 
            this.SahkopostiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SahkopostiTB.Location = new System.Drawing.Point(513, 45);
            this.SahkopostiTB.Name = "SahkopostiTB";
            this.SahkopostiTB.Size = new System.Drawing.Size(264, 31);
            this.SahkopostiTB.TabIndex = 11;
            // 
            // OpiskelijanroTB
            // 
            this.OpiskelijanroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpiskelijanroTB.Location = new System.Drawing.Point(513, 80);
            this.OpiskelijanroTB.Name = "OpiskelijanroTB";
            this.OpiskelijanroTB.Size = new System.Drawing.Size(264, 31);
            this.OpiskelijanroTB.TabIndex = 10;
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhelinTB.Location = new System.Drawing.Point(513, 10);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(264, 31);
            this.PuhelinTB.TabIndex = 9;
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(12, 171);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(1003, 267);
            this.TietotauluDG.TabIndex = 12;
            this.TietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellClick);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaBT.Location = new System.Drawing.Point(17, 117);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(185, 49);
            this.TyhjennaBT.TabIndex = 13;
            this.TyhjennaBT.Text = "TYHJENNÄ";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // TallennaBT
            // 
            this.TallennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallennaBT.Location = new System.Drawing.Point(208, 117);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(185, 49);
            this.TallennaBT.TabIndex = 14;
            this.TallennaBT.Text = "TALLENNA";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivitaBT.Location = new System.Drawing.Point(399, 117);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(185, 49);
            this.PaivitaBT.TabIndex = 15;
            this.PaivitaBT.Text = "PÄIVITÄ";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.Location = new System.Drawing.Point(590, 117);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(185, 49);
            this.PoistaBT.TabIndex = 16;
            this.PoistaBT.Text = "POISTA";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.SahkopostiTB);
            this.Controls.Add(this.OpiskelijanroTB);
            this.Controls.Add(this.PuhelinTB);
            this.Controls.Add(this.EtunimiTB);
            this.Controls.Add(this.SukunimiTB);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.SahkopostiLB);
            this.Controls.Add(this.OpiskelijanroLB);
            this.Controls.Add(this.EtunimiLB);
            this.Controls.Add(this.SukunimiLB);
            this.Controls.Add(this.IDLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLB;
        private System.Windows.Forms.Label SukunimiLB;
        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.Label OpiskelijanroLB;
        private System.Windows.Forms.Label SahkopostiLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.TextBox SahkopostiTB;
        private System.Windows.Forms.TextBox OpiskelijanroTB;
        private System.Windows.Forms.TextBox PuhelinTB;
        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button PoistaBT;
    }
}

