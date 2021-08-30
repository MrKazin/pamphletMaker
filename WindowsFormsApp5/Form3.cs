using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : WindowsFormsApp5.Form1
    {
        static int counter=0;
        public Form3(String str){
            Name = str;
            InitializeComponent();
            this.Name = str;
            this.label1.Text = str;
            counter++;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
