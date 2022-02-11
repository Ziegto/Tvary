
namespace TvaryWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_novy_ctverec = new System.Windows.Forms.Button();
            this.BTN_novy_obdelnik = new System.Windows.Forms.Button();
            this.BTN_novy_kruh = new System.Windows.Forms.Button();
            this.BTN_dialog_barva = new System.Windows.Forms.Button();
            this.TB_vyska = new System.Windows.Forms.TextBox();
            this.TB_sirka = new System.Windows.Forms.TextBox();
            this.TB_y = new System.Windows.Forms.TextBox();
            this.TB_x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_obsah = new System.Windows.Forms.TextBox();
            this.TB_obvod = new System.Windows.Forms.TextBox();
            this.BTN_vypocitat_obsah = new System.Windows.Forms.Button();
            this.BTN_vypocitat_obvod = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_zmensit = new System.Windows.Forms.Button();
            this.BTN_zvetsit = new System.Windows.Forms.Button();
            this.BTN_doprava = new System.Windows.Forms.Button();
            this.BTN_dolu = new System.Windows.Forms.Button();
            this.BTN_nahoru = new System.Windows.Forms.Button();
            this.BTN_doleva = new System.Windows.Forms.Button();
            this.LB_seznam_tvaru = new System.Windows.Forms.ListBox();
            this.CHB_zpusob_ovladani = new System.Windows.Forms.CheckBox();
            this.platno = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_novy_ctverec);
            this.groupBox1.Controls.Add(this.BTN_novy_obdelnik);
            this.groupBox1.Controls.Add(this.BTN_novy_kruh);
            this.groupBox1.Controls.Add(this.BTN_dialog_barva);
            this.groupBox1.Controls.Add(this.TB_vyska);
            this.groupBox1.Controls.Add(this.TB_sirka);
            this.groupBox1.Controls.Add(this.TB_y);
            this.groupBox1.Controls.Add(this.TB_x);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "novy tvar:";
            // 
            // BTN_novy_ctverec
            // 
            this.BTN_novy_ctverec.Location = new System.Drawing.Point(12, 346);
            this.BTN_novy_ctverec.Name = "BTN_novy_ctverec";
            this.BTN_novy_ctverec.Size = new System.Drawing.Size(173, 29);
            this.BTN_novy_ctverec.TabIndex = 12;
            this.BTN_novy_ctverec.Text = "novy ctverec";
            this.BTN_novy_ctverec.UseVisualStyleBackColor = true;
            this.BTN_novy_ctverec.Click += new System.EventHandler(this.NovyObjektClick);
            // 
            // BTN_novy_obdelnik
            // 
            this.BTN_novy_obdelnik.Location = new System.Drawing.Point(12, 301);
            this.BTN_novy_obdelnik.Name = "BTN_novy_obdelnik";
            this.BTN_novy_obdelnik.Size = new System.Drawing.Size(173, 29);
            this.BTN_novy_obdelnik.TabIndex = 11;
            this.BTN_novy_obdelnik.Text = "novy obdelnik";
            this.BTN_novy_obdelnik.UseVisualStyleBackColor = true;
            this.BTN_novy_obdelnik.Click += new System.EventHandler(this.NovyObjektClick);
            // 
            // BTN_novy_kruh
            // 
            this.BTN_novy_kruh.Location = new System.Drawing.Point(12, 257);
            this.BTN_novy_kruh.Name = "BTN_novy_kruh";
            this.BTN_novy_kruh.Size = new System.Drawing.Size(173, 29);
            this.BTN_novy_kruh.TabIndex = 10;
            this.BTN_novy_kruh.Text = "novy kruh";
            this.BTN_novy_kruh.UseVisualStyleBackColor = true;
            this.BTN_novy_kruh.Click += new System.EventHandler(this.NovyObjektClick);
            // 
            // BTN_dialog_barva
            // 
            this.BTN_dialog_barva.Location = new System.Drawing.Point(85, 198);
            this.BTN_dialog_barva.Name = "BTN_dialog_barva";
            this.BTN_dialog_barva.Size = new System.Drawing.Size(100, 27);
            this.BTN_dialog_barva.TabIndex = 9;
            this.BTN_dialog_barva.Text = "dialog barva";
            this.BTN_dialog_barva.UseVisualStyleBackColor = true;
            this.BTN_dialog_barva.Click += new System.EventHandler(this.BTN_dialog_barva_Click);
            // 
            // TB_vyska
            // 
            this.TB_vyska.Location = new System.Drawing.Point(85, 151);
            this.TB_vyska.Name = "TB_vyska";
            this.TB_vyska.Size = new System.Drawing.Size(100, 22);
            this.TB_vyska.TabIndex = 8;
            // 
            // TB_sirka
            // 
            this.TB_sirka.Location = new System.Drawing.Point(85, 107);
            this.TB_sirka.Name = "TB_sirka";
            this.TB_sirka.Size = new System.Drawing.Size(100, 22);
            this.TB_sirka.TabIndex = 7;
            // 
            // TB_y
            // 
            this.TB_y.Location = new System.Drawing.Point(85, 73);
            this.TB_y.Name = "TB_y";
            this.TB_y.Size = new System.Drawing.Size(100, 22);
            this.TB_y.TabIndex = 6;
            // 
            // TB_x
            // 
            this.TB_x.Location = new System.Drawing.Point(85, 35);
            this.TB_x.Name = "TB_x";
            this.TB_x.Size = new System.Drawing.Size(100, 22);
            this.TB_x.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "barva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "vyska:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "sirka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_obsah);
            this.groupBox2.Controls.Add(this.TB_obvod);
            this.groupBox2.Controls.Add(this.BTN_vypocitat_obsah);
            this.groupBox2.Controls.Add(this.BTN_vypocitat_obvod);
            this.groupBox2.Location = new System.Drawing.Point(39, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "vypocitat charakteristiky tvaru:";
            // 
            // TB_obsah
            // 
            this.TB_obsah.Location = new System.Drawing.Point(165, 88);
            this.TB_obsah.Name = "TB_obsah";
            this.TB_obsah.Size = new System.Drawing.Size(100, 22);
            this.TB_obsah.TabIndex = 6;
            // 
            // TB_obvod
            // 
            this.TB_obvod.Location = new System.Drawing.Point(165, 43);
            this.TB_obvod.Name = "TB_obvod";
            this.TB_obvod.Size = new System.Drawing.Size(100, 22);
            this.TB_obvod.TabIndex = 2;
            // 
            // BTN_vypocitat_obsah
            // 
            this.BTN_vypocitat_obsah.Location = new System.Drawing.Point(12, 88);
            this.BTN_vypocitat_obsah.Name = "BTN_vypocitat_obsah";
            this.BTN_vypocitat_obsah.Size = new System.Drawing.Size(133, 29);
            this.BTN_vypocitat_obsah.TabIndex = 1;
            this.BTN_vypocitat_obsah.Text = "vypocitat obsah";
            this.BTN_vypocitat_obsah.UseVisualStyleBackColor = true;
            this.BTN_vypocitat_obsah.Click += new System.EventHandler(this.Vypocitat);
            // 
            // BTN_vypocitat_obvod
            // 
            this.BTN_vypocitat_obvod.Location = new System.Drawing.Point(12, 42);
            this.BTN_vypocitat_obvod.Name = "BTN_vypocitat_obvod";
            this.BTN_vypocitat_obvod.Size = new System.Drawing.Size(133, 29);
            this.BTN_vypocitat_obvod.TabIndex = 0;
            this.BTN_vypocitat_obvod.Text = "vypocitat obvod";
            this.BTN_vypocitat_obvod.UseVisualStyleBackColor = true;
            this.BTN_vypocitat_obvod.Click += new System.EventHandler(this.Vypocitat);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_zmensit);
            this.groupBox3.Controls.Add(this.BTN_zvetsit);
            this.groupBox3.Controls.Add(this.BTN_doprava);
            this.groupBox3.Controls.Add(this.BTN_dolu);
            this.groupBox3.Controls.Add(this.BTN_nahoru);
            this.groupBox3.Controls.Add(this.BTN_doleva);
            this.groupBox3.Location = new System.Drawing.Point(566, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ovladaci panel tvaru:";
            // 
            // BTN_zmensit
            // 
            this.BTN_zmensit.Location = new System.Drawing.Point(365, 119);
            this.BTN_zmensit.Name = "BTN_zmensit";
            this.BTN_zmensit.Size = new System.Drawing.Size(75, 29);
            this.BTN_zmensit.TabIndex = 5;
            this.BTN_zmensit.Text = "zmensit";
            this.BTN_zmensit.UseVisualStyleBackColor = true;
            this.BTN_zmensit.Click += new System.EventHandler(this.Velikost_Click);
            // 
            // BTN_zvetsit
            // 
            this.BTN_zvetsit.Location = new System.Drawing.Point(365, 53);
            this.BTN_zvetsit.Name = "BTN_zvetsit";
            this.BTN_zvetsit.Size = new System.Drawing.Size(75, 29);
            this.BTN_zvetsit.TabIndex = 4;
            this.BTN_zvetsit.Text = "zvetsit";
            this.BTN_zvetsit.UseVisualStyleBackColor = true;
            this.BTN_zvetsit.Click += new System.EventHandler(this.Velikost_Click);
            // 
            // BTN_doprava
            // 
            this.BTN_doprava.Location = new System.Drawing.Point(114, 99);
            this.BTN_doprava.Name = "BTN_doprava";
            this.BTN_doprava.Size = new System.Drawing.Size(75, 29);
            this.BTN_doprava.TabIndex = 3;
            this.BTN_doprava.Text = "doprava";
            this.BTN_doprava.UseVisualStyleBackColor = true;
            this.BTN_doprava.Click += new System.EventHandler(this.Posunout_Click);
            // 
            // BTN_dolu
            // 
            this.BTN_dolu.Location = new System.Drawing.Point(54, 141);
            this.BTN_dolu.Name = "BTN_dolu";
            this.BTN_dolu.Size = new System.Drawing.Size(75, 29);
            this.BTN_dolu.TabIndex = 2;
            this.BTN_dolu.Text = "dolu";
            this.BTN_dolu.UseVisualStyleBackColor = true;
            this.BTN_dolu.Click += new System.EventHandler(this.Posunout_Click);
            // 
            // BTN_nahoru
            // 
            this.BTN_nahoru.Location = new System.Drawing.Point(54, 53);
            this.BTN_nahoru.Name = "BTN_nahoru";
            this.BTN_nahoru.Size = new System.Drawing.Size(75, 29);
            this.BTN_nahoru.TabIndex = 1;
            this.BTN_nahoru.Text = "nahoru";
            this.BTN_nahoru.UseVisualStyleBackColor = true;
            this.BTN_nahoru.Click += new System.EventHandler(this.Posunout_Click);
            // 
            // BTN_doleva
            // 
            this.BTN_doleva.Location = new System.Drawing.Point(6, 99);
            this.BTN_doleva.Name = "BTN_doleva";
            this.BTN_doleva.Size = new System.Drawing.Size(75, 29);
            this.BTN_doleva.TabIndex = 0;
            this.BTN_doleva.Text = "doleva";
            this.BTN_doleva.UseVisualStyleBackColor = true;
            this.BTN_doleva.Click += new System.EventHandler(this.Posunout_Click);
            // 
            // LB_seznam_tvaru
            // 
            this.LB_seznam_tvaru.ItemHeight = 16;
            this.LB_seznam_tvaru.Location = new System.Drawing.Point(318, 42);
            this.LB_seznam_tvaru.Name = "LB_seznam_tvaru";
            this.LB_seznam_tvaru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_seznam_tvaru.Size = new System.Drawing.Size(242, 388);
            this.LB_seznam_tvaru.TabIndex = 3;
            this.LB_seznam_tvaru.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Klavesnice);
            // 
            // CHB_zpusob_ovladani
            // 
            this.CHB_zpusob_ovladani.AutoSize = true;
            this.CHB_zpusob_ovladani.Location = new System.Drawing.Point(572, 659);
            this.CHB_zpusob_ovladani.Name = "CHB_zpusob_ovladani";
            this.CHB_zpusob_ovladani.Size = new System.Drawing.Size(212, 20);
            this.CHB_zpusob_ovladani.TabIndex = 4;
            this.CHB_zpusob_ovladani.Text = "ovladani tvaru: Klavesnice/GUI";
            this.CHB_zpusob_ovladani.UseVisualStyleBackColor = true;
            this.CHB_zpusob_ovladani.CheckedChanged += new System.EventHandler(this.CHB_zpusob_ovladani_CheckedChanged);
            // 
            // platno
            // 
            this.platno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.platno.Location = new System.Drawing.Point(566, 42);
            this.platno.Name = "platno";
            this.platno.Size = new System.Drawing.Size(513, 388);
            this.platno.TabIndex = 5;
            this.platno.Paint += new System.Windows.Forms.PaintEventHandler(this.platno_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 682);
            this.Controls.Add(this.platno);
            this.Controls.Add(this.CHB_zpusob_ovladani);
            this.Controls.Add(this.LB_seznam_tvaru);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Moje grafické objekty";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_novy_ctverec;
        private System.Windows.Forms.Button BTN_novy_obdelnik;
        private System.Windows.Forms.Button BTN_novy_kruh;
        private System.Windows.Forms.Button BTN_dialog_barva;
        private System.Windows.Forms.TextBox TB_vyska;
        private System.Windows.Forms.TextBox TB_sirka;
        private System.Windows.Forms.TextBox TB_y;
        private System.Windows.Forms.TextBox TB_x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_obsah;
        private System.Windows.Forms.TextBox TB_obvod;
        private System.Windows.Forms.Button BTN_vypocitat_obsah;
        private System.Windows.Forms.Button BTN_vypocitat_obvod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_zmensit;
        private System.Windows.Forms.Button BTN_zvetsit;
        private System.Windows.Forms.Button BTN_doprava;
        private System.Windows.Forms.Button BTN_dolu;
        private System.Windows.Forms.Button BTN_nahoru;
        private System.Windows.Forms.Button BTN_doleva;
        private System.Windows.Forms.ListBox LB_seznam_tvaru;
        private System.Windows.Forms.CheckBox CHB_zpusob_ovladani;
        private System.Windows.Forms.Panel platno;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

