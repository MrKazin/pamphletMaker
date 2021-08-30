using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form // додумать  оболочку и печать
    {
        public Form1() { InitializeComponent(); }
        private String fileName;
        private bool f1 = false;
        private bool f2 = false;
        private bool f3 = false;
        private bool f4 = false;//
        private bool f5 = false;
        private bool f6 = false;//
        protected Image im;
        public String documentContents;
        Regex regex = new Regex("[0-9]{2}.[0-9]{2}.[0-9]{4}");
        private void TextBox1_Leave(object sender, EventArgs e) { enablePanel();  if (textBox1.Text.Length > 0) { errorProvider1.SetError(textBox1, ""); f1 = true; } else { errorProvider1.SetError(textBox1, "error!"); f1 = false; } }
        private void TextBox2_Leave(object sender, EventArgs e) { enablePanel(); if (textBox2.Text.Length > 0) { errorProvider1.SetError(textBox2, ""); f2 = true; } else { errorProvider1.SetError(textBox2, "error!"); f2 = false; } }
        private void TextBox3_Leave(object sender, EventArgs e) { enablePanel(); if (textBox3.Text.Length > 0) { errorProvider1.SetError(textBox3, ""); f3 = true; } else { errorProvider1.SetError(textBox3, "error!"); f3 = false; } }
        private void TextBox5_Leave(object sender, EventArgs e) { enablePanel(); if (textBox5.Text.Length > 0) { errorProvider1.SetError(textBox5, ""); f5 = true; } else { errorProvider1.SetError(textBox5, "error!"); f5 = false; } }
        private void TextBox4_Leave(object sender, EventArgs e) { enablePanel(); int Num; if (int.TryParse(textBox4.Text, out Num)) { errorProvider1.SetError(textBox4, ""); f4 = true; } else errorProvider1.SetError(textBox4, "error!"); f4 = false; }
        private void TextBox6_Leave(object sender, EventArgs e) { enablePanel(); if (textBox6.Text.Length == 10) { if (regex.IsMatch(textBox6.Text)) { errorProvider1.SetError(textBox6, ""); f6 = true; } else errorProvider1.SetError(textBox6, "error!"); f6 = false; } }
        private void button4_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.richTextBox1.SelectionColor = colorDialog1.Color;
                }// меняем цвет // готовo                                                                                                                                                          /**/
        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                fileName = openFileDialog1.FileName; /*im = new Image; im.ImageLocation = fileName;*/
            }
        }// готовo 
        private void button3_Click(object sender, EventArgs e) {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                this.richTextBox1.SelectionFont = fontDialog1.Font;
                }// шрифт меняем // готово
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
            } //закрыть окно // готово                                                                    
        protected void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(im, new Point(0, 0));
        }                                                                    /**/
        private void button5_Click(object sender, EventArgs e) {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
                printDialog.Close();
            }
        }//     

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14), Brushes.Black, new Point(0, 0));
            //e.Graphics.DrawImage(im, new Point(10, 10));
        }

        private bool checkFielder(){ if (f1==true && f2==true && f3==true && f5==true ) { return true; }/*подумать над f4 и f6*/else { return false; }}
        private void textBox6_TextChanged(object sender, EventArgs e) { if (textBox6.Text.Length < 10) { textBox6.Text = DateTime.Now.ToShortDateString(); } enablePanel(); }//готово
        private void enablePanel() { if (checkFielder() == true) { panel1.Enabled = true; } else { panel1.Enabled = false; } }//готово

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial",14), Brushes.Black,new Point(0,0));
        }

        private void textBox4_TextChanged(object sender, EventArgs e){}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

        }
    }
}
