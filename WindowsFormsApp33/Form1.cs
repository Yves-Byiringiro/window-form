using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form f;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch(node.Text)
            {
                case "Calc":
                    f.Dispose();
                    f = new formcalculater();
                    f.TopLevel = false;
                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();

                    break;


                case "Room 1":
                    f.Dispose();
                    f = new formRoom();
                    f.TopLevel = false;
                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();

                    break;


                case "Room 2":
                    f.Dispose();
                    f = new formRoom2();
                    f.TopLevel = false;
                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();

                    break;


                case "Student name":
                    f.Dispose();
                    f = new formstudentname();
                    f.TopLevel = false;
                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();

                    break;


                case "Student REG NUMBER":
                    f.Dispose();
                    f = new formstudentregnumber();
                    f.TopLevel = false;
                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();

                    break;
            }//for switch
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].ExpandAll();
            f = new formcalculater();
            
            f.TopLevel=false;
            this.MainPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;// fill the form in the main panel
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
