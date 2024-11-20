using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
                if((int)c >33 && (int)c < 48 || (int)c > 57 && (int)c < 65 )
                {
                    znakASCI = (int)c;
                }
                else if (char.IsUpper(c))
                {
                    znakASCI = c + 5;
                    if (znakASCI > 90)
                        znakASCI = 65 + (znakASCI - 90 - 1);
                }
                else if (char.IsLower(c))
                {
                    znakASCI = c + 5;
                    if (znakASCI > 122)
                        znakASCI = 97 + (znakASCI - 122 - 1);
                } 
                else if (c == ' ')
                    znakASCI = 95;
                else 
                    znakASCI = (int)c + 5;

                zaszyfrowana.Add(znakASCI);
                tbAfter.AppendText(znakASCI.ToString());
                tbAfter.AppendText(" ");
                
            }
            



        }

        private void btDeszyfruj_Click(object sender, EventArgs e)
        {
            tbAfter.Clear();

            foreach (int c in zaszyfrowana)
            {
                string tekst = "";
                int znakASCI;
                if ((int)c > 33 && (int)c < 48 || (int)c > 57 && (int)c < 65 )
                {
                    tekst += (char)c;
                }
                else if (char.IsUpper((char)c))
                {
                    znakASCI = c - 5;
                    if (znakASCI < 65)
                        znakASCI = 90 - (65 - znakASCI + 1);
                    tekst += (char)znakASCI;
                }
                else if (char.IsLower((char)c))
                {
                    znakASCI = c - 5;
                    if (znakASCI < 97)
                        znakASCI = 122 - (97 - znakASCI + 1);
                    tekst += (char)znakASCI;
                }
                else if (c == '_')
                {
                    tekst += (char)32;
                } 

                tbAfter.AppendText(tekst);
            }
            zaszyfrowana.Clear();
        }
    }
}
