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
                tbAfter.AppendText(c.ToString());
                Thread.Sleep(150);
                tbAfter.Text = tbAfter.Text.Remove(tbAfter.Text.Length - 1);
                Thread.Sleep(150);
                tbAfter.AppendText(znakASCI.ToString());
                Thread.Sleep(150);
                //tbAfter.AppendText(" ");

            }
            



        }

        private void btDeszyfruj_Click(object sender, EventArgs e)
        {
            tbAfter.Clear();
            int i = 1;
            //zaszyfrowana.Reverse();
            foreach (int c in zaszyfrowana)
            {
                
                string tekst = "";
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

                

                //tbAfter.Text = tbAfter.Text.Remove(tbAfter.Text.Length - i);
                //Thread.Sleep(150);
                //tbAfter.AppendText(tekst);
                //Thread.Sleep(150);
                //i++;
                tbAfter.AppendText(tekst);
            }
            zaszyfrowana.Clear();
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
    }
}
