using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        private int counter = 0;
        Form3 f3;
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form f1;
            counter++;
            f1 = new Form3("Name of the product");
            f1.MdiParent = this;
            f1.Show();
            ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the product");
            окноToolStripMenuItem.DropDownItems.Add(newItem);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void буклетПродуктаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter++;
            f3 = new Form3("Name of the product");
            f3.MdiParent = this;
            f3.Show();
            ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the product");
            окноToolStripMenuItem.DropDownItems.Add(newItem);
        }

        private void буклетГостиницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter++;
            f3 = new Form3("Name of the hostel");
            f3.MdiParent = this;
            f3.Show();
            ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the hostel");
            окноToolStripMenuItem.DropDownItems.Add(newItem);
        }

        private void буклетОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter++;
            f3 =new Form3("Name of the organisation");
            f3.MdiParent = this;
            f3.Show();
            ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the organistion");
            окноToolStripMenuItem.DropDownItems.Add(newItem);
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)//каскадом
        {
            foreach (var f in MdiChildren)
            {

                if (f.WindowState == FormWindowState.Minimized)
                {
                    f.WindowState = FormWindowState.Normal;
                    f.Show();
                }


            }
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)//мозаикой
        {
            foreach (var f in MdiChildren)
            {

                if (f.WindowState == FormWindowState.Minimized)
                {
                    f.WindowState = FormWindowState.Normal;
                    f.Show();
                }


            }
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            counter++;
            Form f2;
            f2 = new Form3("Name of the hostel");
            f2.MdiParent = this;
            f2.Show();
            ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the hostel");
            окноToolStripMenuItem.DropDownItems.Add(newItem);

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            counter++;
            Form f4;
            f4 = new Form3("Name of the organisation");
            f4.MdiParent = this;
            f4.Show();
            ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the organisation");
            окноToolStripMenuItem.DropDownItems.Add(newItem);
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren)
            {

                if (f.WindowState == FormWindowState.Minimized)
                {
                    f.WindowState = FormWindowState.Normal;
                    f.Show();
                }


            }
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void мозаикойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren)
            {

                if (f.WindowState == FormWindowState.Minimized)
                {
                    f.WindowState = FormWindowState.Normal;
                    f.Show();
                }


            }
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        theBox.SelectionAlignment = HorizontalAlignment.Right;
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        theBox.SelectionAlignment = HorizontalAlignment.Left;
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }

        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        theBox.SelectionAlignment = HorizontalAlignment.Center;
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }

        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        theBox.SelectionAlignment = HorizontalAlignment.Left;
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        theBox.SelectionAlignment = HorizontalAlignment.Center;
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        theBox.SelectionAlignment = HorizontalAlignment.Right;
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
