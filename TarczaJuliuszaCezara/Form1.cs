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

        private void btSzyfruj_Click(object sender, EventArgs e)
        {
            tbAfter.Clear();
           
            foreach(char c in tbBefore.Text)
            {
                int znakASCI;
                if (c ==  ' ')
                    znakASCI = 95; 
                else
                    znakASCI = (int)c + 5;

                tbAfter.AppendText(znakASCI.ToString());
                tbAfter.AppendText(" ");
            }
            


        }
    }
}
