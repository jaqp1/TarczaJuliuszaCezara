using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarczaJuliuszaCezara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wybierz plik";
                openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbFileToEncode.Text = openFileDialog.FileName;
                    
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wybierz plik";
                openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbŚcieżkaZaszyfrowanegoPliku.Text = openFileDialog.FileName;

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        List<int> zaszyfrowana = new List<int>();

        private void btSzyfruj_Click(object sender, EventArgs e)
        {
            tbAfter.Clear();
            int i = 0;
            foreach(char c in tbBefore.Text)
            {
                int znakASCI;
                if((int)c >33 && (int)c < 48 || (int)c > 57 && (int)c < 65 || (int)c > 90 && (int)c < 97 || (int)c > 122)
                {
                    znakASCI = (int)c;
                }
                else if (char.IsUpper(c))
                {
                    znakASCI = c + (int)numKey.Value;
                    if (znakASCI > 90)
                        znakASCI = 65 + (znakASCI - 90 - 1);
                }
                else if (char.IsLower(c))
                {
                    znakASCI = c + (int)numKey.Value;
                    if (znakASCI > 122)
                        znakASCI = 97 + (znakASCI - 122 - 1);
                } 
                else if (c == ' ')
                    znakASCI = 95;
                else 
                    znakASCI = (int)c + (int)numKey.Value;

                zaszyfrowana.Add(znakASCI);
                //tbAfter.AppendText(c.ToString());
                //Thread.Sleep(100);
                //tbAfter.Text = tbAfter.Text.Remove(tbAfter.Text.Length - 1);
                //Thread.Sleep(100);
                tbBefore.SelectAll();
                tbBefore.SelectionColor = Color.Black;
                tbBefore.SelectionBackColor = Color.White;
                tbAfter.AppendText(znakASCI.ToString());
                tbBefore.Select(i, 1);
                tbBefore.SelectionColor = Color.White;
                tbBefore.SelectionBackColor = Color.Black;

                tbPozycja.Text = i.ToString();
                i++;
                Application.DoEvents();
                Thread.Sleep(250);
                //tbAfter.AppendText(" ");

            }
            tbBefore.SelectionBackColor = Color.White;
            tbPozycja.Clear() ;



            MessageBox.Show("Szyfrowanie zakończone");
        }

        private void btDeszyfruj_Click(object sender, EventArgs e)
        {
            //tbAfter.Clear();
            //zaszyfrowana.Reverse();
            string tekst = "";
            foreach (int c in zaszyfrowana)
            {
                
                
                int znakASCI;
                if ((int)c > 33 && (int)c < 48 || (int)c > 57 && (int)c < 65 || (int)c > 90 && (int)c < 95 || (int)c > 122)
                {
                    tekst += (char)c;
                }
                else if (char.IsUpper((char)c))
                {
                    znakASCI = c - (int)numKey.Value;
                    if (znakASCI < 65)
                        znakASCI = 90 - (65 - znakASCI - 1);
                    tekst += (char)znakASCI;
                }
                else if (char.IsLower((char)c))
                {
                    znakASCI = c - (int)numKey.Value;
                    if (znakASCI < 97)
                        znakASCI = 122 - (97 - znakASCI - 1);
                    tekst += (char)znakASCI;
                }
                else if (c == '_')
                {
                    tekst += (char)32;
                }     
            }
            //for (int i = 0; i < zaszyfrowana.Count; i++)
            //{
            //    tbAfter.AppendText(zaszyfrowana[i].ToString());
            //}
            //tbAfter.Text = zaszyfrowana + "" ;
            int j = zaszyfrowana.Count - 1;
            for (int i = 0; i < zaszyfrowana.Count; i++)
            {
                tbAfter.Text = tbAfter.Text.Remove(i, zaszyfrowana[i].ToString().Length).Insert(i, tekst[i].ToString());
                j--;
                tbBefore.SelectAll();
                tbBefore.SelectionColor = Color.Black;
                tbBefore.SelectionBackColor = Color.White;
                tbBefore.Select(i, 1);
                tbBefore.SelectionColor = Color.White;
                tbBefore.SelectionBackColor = Color.Black;
                tbPozycja.Text = i.ToString();
                Application.DoEvents();
                Thread.Sleep(250);
            }
            tbBefore.SelectionBackColor = Color.White;
            tbPozycja.Clear();

            zaszyfrowana.Clear();
            MessageBox.Show("Deszyfrowanie zakończone");
        }

        private void btWczytaj_Click(object sender, EventArgs e)
        {
            String line;
            try
            {
                tbBefore.Clear();
                StreamReader sr = new StreamReader(tbFileToEncode.Text);
                line = sr.ReadLine();
                while (line != null)
                {
                    tbBefore.AppendText(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                tbBefore.Text = "Exception: " + ex.Message;
            }
        }

        private void btZapsiszDoPliku_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(tbŚcieżkaZaszyfrowanegoPliku.Text);
                sw.WriteLine(tbAfter.Text);
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił wyjątek: " + ex.Message);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbBefore.Text = "Zawartość pliku przed operacjami...";
            tbAfter.Text = "Zaszyfrowana/Odszyfrowana zawartość pliku...";
            tbFileToEncode.Clear();
            tbŚcieżkaZaszyfrowanegoPliku.Clear();
            tbOdszyfrowanyPlik.Clear();
            numKey.Value = 0;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wybierz plik";
                openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbOdszyfrowanyPlik.Text = openFileDialog.FileName;

                }

            }
        }

        private void btZapiszOdszyfrowany_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(tbOdszyfrowanyPlik.Text);
                sw.WriteLine(tbAfter.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił wyjątek: " + ex.Message);
            }
        }

        private void btCompare_Click(object sender, EventArgs e)
        {
            int zgodne = 0, nzgodne = 0;
            for(int i = 0; i < tbBefore.Text.Length; i++)
            {
                tbPozycja.Text = i.ToString();
                //tbBefore.SelectAll();
                //tbBefore.SelectionColor = Color.Black;
                //tbAfter.SelectAll();
                //tbAfter.SelectionColor = Color.Black;
                if (tbAfter.Text[i] == tbBefore.Text[i])
                {
                    tbBefore.Select(i, 1);
                    tbBefore.SelectionColor = Color.Green;

                    tbAfter.Select(i, 1);
                    tbAfter.SelectionColor = Color.Green;
                    zgodne++;
                }
                else
                {

                    tbBefore.Select(i, 1);
                    tbBefore.SelectionColor = Color.Red;

                    tbAfter.Select(i, 1);
                    tbAfter.SelectionColor = Color.Red;
                    nzgodne++;
                }
                Application.DoEvents();
                Thread.Sleep(100);
            }
            tbBefore.SelectAll();
            tbBefore.SelectionColor = Color.Black;
            tbAfter.SelectAll();
            tbAfter.SelectionColor = Color.Black;
            if (nzgodne == 0) {
                MessageBox.Show("Wszystkie litery są zgodne z tekstem źródłowym.");
            }
            else
            {
                MessageBox.Show("Znaleziono niezgodność liter!");
            }
            tbPozycja.Clear();
        }

    }
}
