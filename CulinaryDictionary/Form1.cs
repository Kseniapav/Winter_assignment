using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardDish;
using CulinaryDictionary;

namespace CulinaryDictionary
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            DataRepository.InitializeSampleData();

            // Заполнение TreeView
            InitializeCategoriesTree();

            // Настройка внешнего вида
            this.Text = "Наше меню:";
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeCategoriesTree()
        {
            treeViewCategories.BeginUpdate();
            treeViewCategories.Nodes.Clear();

            foreach (var category in DataRepository.Categories)
            {
                var node = new TreeNode(category.Name) { Tag = category };
                treeViewCategories.Nodes.Add(node);
            }

            treeViewCategories.EndUpdate();          

        }


        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Category selectedCategory)
            {
                // Отображаем название категории
                lblCategoryName.Text = selectedCategory.Name;

                // Очищаем панель с блюдами
                flowLayoutDishes.Controls.Clear();

                // Добавляем карточки блюд
                foreach (var dish in selectedCategory.Dishes)
                {
                    var card = new Card();
                    card.SetDishInfo(card);
                    flowLayoutDishes.Controls.Add(card);
                }
            }
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
