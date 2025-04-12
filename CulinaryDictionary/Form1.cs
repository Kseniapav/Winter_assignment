using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulinaryDictionary
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Для SplitContainer
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.SplitterDistance = 200; // Ширина левой панели

            // Для TreeView
            treeViewCategories.Dock = DockStyle.Fill;
            treeViewCategories.HideSelection = false;

            // Для FlowLayoutPanel
            flowLayoutDishes.Dock = DockStyle.Fill;
            flowLayoutDishes.AutoScroll = true;
            flowLayoutDishes.WrapContents = false;
            flowLayoutDishes.FlowDirection = FlowDirection.TopDown;

            // Для Label
            lblCategoryName.Dock = DockStyle.Top;
            lblCategoryName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblCategoryName.TextAlign = ContentAlignment.MiddleCenter;
            lblCategoryName.Height = 40;
        }
    }
}
