namespace TarczaJuliuszaCezara
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.tbFileToEncode = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btPlikDoZaszyfrowania = new System.Windows.Forms.Button();
            this.lbPlikDoZaszyfrowania = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btPlikZaszyfrowany = new System.Windows.Forms.Button();
            this.tbŚcieżkaZaszyfrowanegoPliku = new System.Windows.Forms.TextBox();
            this.btSzyfruj = new System.Windows.Forms.Button();
            this.btDeszyfruj = new System.Windows.Forms.Button();
            this.btZapsiszDoPliku = new System.Windows.Forms.Button();
            this.btWczytaj = new System.Windows.Forms.Button();
            this.numKey = new System.Windows.Forms.NumericUpDown();
            this.btReset = new System.Windows.Forms.Button();
            this.btZapiszOdszyfrowany = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btSciezkaOdszyfrowany = new System.Windows.Forms.Button();
            this.tbOdszyfrowanyPlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numKey)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBefore
            // 
            this.tbBefore.Location = new System.Drawing.Point(449, 28);
            this.tbBefore.Multiline = true;
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.ReadOnly = true;
            this.tbBefore.Size = new System.Drawing.Size(529, 232);
            this.tbBefore.TabIndex = 0;
            this.tbBefore.Text = "Zawartość pliku przed operacjami...";
            // 
            // tbAfter
            // 
            this.tbAfter.Location = new System.Drawing.Point(449, 282);
            this.tbAfter.Multiline = true;
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.Size = new System.Drawing.Size(529, 200);
            this.tbAfter.TabIndex = 1;
            this.tbAfter.Text = "Zaszyfrowana/Odszyfrowana zawartość pliku...";
            // 
            // tbFileToEncode
            // 
            this.tbFileToEncode.Location = new System.Drawing.Point(24, 80);
            this.tbFileToEncode.Name = "tbFileToEncode";
            this.tbFileToEncode.Size = new System.Drawing.Size(282, 22);
            this.tbFileToEncode.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btPlikDoZaszyfrowania
            // 
            this.btPlikDoZaszyfrowania.Location = new System.Drawing.Point(330, 76);
            this.btPlikDoZaszyfrowania.Name = "btPlikDoZaszyfrowania";
            this.btPlikDoZaszyfrowania.Size = new System.Drawing.Size(91, 30);
            this.btPlikDoZaszyfrowania.TabIndex = 3;
            this.btPlikDoZaszyfrowania.Text = "Przeglądaj...";
            this.btPlikDoZaszyfrowania.UseVisualStyleBackColor = true;
            this.btPlikDoZaszyfrowania.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPlikDoZaszyfrowania
            // 
            this.lbPlikDoZaszyfrowania.AutoSize = true;
            this.lbPlikDoZaszyfrowania.Location = new System.Drawing.Point(21, 50);
            this.lbPlikDoZaszyfrowania.Name = "lbPlikDoZaszyfrowania";
            this.lbPlikDoZaszyfrowania.Size = new System.Drawing.Size(247, 16);
            this.lbPlikDoZaszyfrowania.TabIndex = 4;
            this.lbPlikDoZaszyfrowania.Text = "Ścieżka do pliku z zawartością tekstową:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plik docelowy z zaszyfrowanym tekstem:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btPlikZaszyfrowany
            // 
            this.btPlikZaszyfrowany.Location = new System.Drawing.Point(330, 171);
            this.btPlikZaszyfrowany.Name = "btPlikZaszyfrowany";
            this.btPlikZaszyfrowany.Size = new System.Drawing.Size(91, 30);
            this.btPlikZaszyfrowany.TabIndex = 6;
            this.btPlikZaszyfrowany.Text = "Przeglądaj...";
            this.btPlikZaszyfrowany.UseVisualStyleBackColor = true;
            this.btPlikZaszyfrowany.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbŚcieżkaZaszyfrowanegoPliku
            // 
            this.tbŚcieżkaZaszyfrowanegoPliku.Location = new System.Drawing.Point(24, 175);
            this.tbŚcieżkaZaszyfrowanegoPliku.Name = "tbŚcieżkaZaszyfrowanegoPliku";
            this.tbŚcieżkaZaszyfrowanegoPliku.Size = new System.Drawing.Size(282, 22);
            this.tbŚcieżkaZaszyfrowanegoPliku.TabIndex = 5;
            this.tbŚcieżkaZaszyfrowanegoPliku.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btSzyfruj
            // 
            this.btSzyfruj.Location = new System.Drawing.Point(24, 439);
            this.btSzyfruj.Name = "btSzyfruj";
            this.btSzyfruj.Size = new System.Drawing.Size(109, 43);
            this.btSzyfruj.TabIndex = 8;
            this.btSzyfruj.Text = "Szyfruj";
            this.btSzyfruj.UseVisualStyleBackColor = true;
            this.btSzyfruj.Click += new System.EventHandler(this.btSzyfruj_Click);
            // 
            // btDeszyfruj
            // 
            this.btDeszyfruj.Location = new System.Drawing.Point(139, 439);
            this.btDeszyfruj.Name = "btDeszyfruj";
            this.btDeszyfruj.Size = new System.Drawing.Size(109, 43);
            this.btDeszyfruj.TabIndex = 10;
            this.btDeszyfruj.Text = "Deszyfruj";
            this.btDeszyfruj.UseVisualStyleBackColor = true;
            this.btDeszyfruj.Click += new System.EventHandler(this.btDeszyfruj_Click);
            // 
            // btZapsiszDoPliku
            // 
            this.btZapsiszDoPliku.Location = new System.Drawing.Point(330, 210);
            this.btZapsiszDoPliku.Name = "btZapsiszDoPliku";
            this.btZapsiszDoPliku.Size = new System.Drawing.Size(91, 30);
            this.btZapsiszDoPliku.TabIndex = 11;
            this.btZapsiszDoPliku.Text = "Zapisz";
            this.btZapsiszDoPliku.UseVisualStyleBackColor = true;
            this.btZapsiszDoPliku.Click += new System.EventHandler(this.btZapsiszDoPliku_Click);
            // 
            // btWczytaj
            // 
            this.btWczytaj.Location = new System.Drawing.Point(330, 112);
            this.btWczytaj.Name = "btWczytaj";
            this.btWczytaj.Size = new System.Drawing.Size(91, 30);
            this.btWczytaj.TabIndex = 12;
            this.btWczytaj.Text = "Wczytaj";
            this.btWczytaj.UseVisualStyleBackColor = true;
            this.btWczytaj.Click += new System.EventHandler(this.btWczytaj_Click);
            // 
            // numKey
            // 
            this.numKey.Location = new System.Drawing.Point(24, 351);
            this.numKey.Name = "numKey";
            this.numKey.Size = new System.Drawing.Size(109, 22);
            this.numKey.TabIndex = 13;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(321, 439);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(109, 43);
            this.btReset.TabIndex = 14;
            this.btReset.Text = "Resetuj";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btZapiszOdszyfrowany
            // 
            this.btZapiszOdszyfrowany.Location = new System.Drawing.Point(330, 309);
            this.btZapiszOdszyfrowany.Name = "btZapiszOdszyfrowany";
            this.btZapiszOdszyfrowany.Size = new System.Drawing.Size(91, 30);
            this.btZapiszOdszyfrowany.TabIndex = 18;
            this.btZapiszOdszyfrowany.Text = "Zapisz";
            this.btZapiszOdszyfrowany.UseVisualStyleBackColor = true;
            this.btZapiszOdszyfrowany.Click += new System.EventHandler(this.btZapiszOdszyfrowany_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Docelowy plik z odszyfrowanym tekstem:";
            // 
            // btSciezkaOdszyfrowany
            // 
            this.btSciezkaOdszyfrowany.Location = new System.Drawing.Point(330, 270);
            this.btSciezkaOdszyfrowany.Name = "btSciezkaOdszyfrowany";
            this.btSciezkaOdszyfrowany.Size = new System.Drawing.Size(91, 30);
            this.btSciezkaOdszyfrowany.TabIndex = 16;
            this.btSciezkaOdszyfrowany.Text = "Przeglądaj...";
            this.btSciezkaOdszyfrowany.UseVisualStyleBackColor = true;
            this.btSciezkaOdszyfrowany.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbOdszyfrowanyPlik
            // 
            this.tbOdszyfrowanyPlik.Location = new System.Drawing.Point(24, 274);
            this.tbOdszyfrowanyPlik.Name = "tbOdszyfrowanyPlik";
            this.tbOdszyfrowanyPlik.Size = new System.Drawing.Size(282, 22);
            this.tbOdszyfrowanyPlik.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Klucz szyfrowania:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btZapiszOdszyfrowany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSciezkaOdszyfrowany);
            this.Controls.Add(this.tbOdszyfrowanyPlik);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.numKey);
            this.Controls.Add(this.btWczytaj);
            this.Controls.Add(this.btZapsiszDoPliku);
            this.Controls.Add(this.btDeszyfruj);
            this.Controls.Add(this.btSzyfruj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPlikZaszyfrowany);
            this.Controls.Add(this.tbŚcieżkaZaszyfrowanegoPliku);
            this.Controls.Add(this.lbPlikDoZaszyfrowania);
            this.Controls.Add(this.btPlikDoZaszyfrowania);
            this.Controls.Add(this.tbFileToEncode);
            this.Controls.Add(this.tbAfter);
            this.Controls.Add(this.tbBefore);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBefore;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.TextBox tbFileToEncode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btPlikDoZaszyfrowania;
        private System.Windows.Forms.Label lbPlikDoZaszyfrowania;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPlikZaszyfrowany;
        private System.Windows.Forms.TextBox tbŚcieżkaZaszyfrowanegoPliku;
        private System.Windows.Forms.Button btSzyfruj;
        private System.Windows.Forms.Button btDeszyfruj;
        private System.Windows.Forms.Button btZapsiszDoPliku;
        private System.Windows.Forms.Button btWczytaj;
        private System.Windows.Forms.NumericUpDown numKey;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btZapiszOdszyfrowany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSciezkaOdszyfrowany;
        private System.Windows.Forms.TextBox tbOdszyfrowanyPlik;
        private System.Windows.Forms.Label label3;
    }
}

