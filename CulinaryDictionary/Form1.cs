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
using classDish;
using FormQuantity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static classDish.Class1;


namespace CulinaryDictionary
{
    public partial class Form1 : Form
    {
        DataRepository class1 = new DataRepository();
        private List<CartItem> cart = new List<CartItem>();
        public Form1()
        {
            InitializeComponent();
            class1.InitializeSampleData();


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

            foreach (var category in class1.Categories)
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
                    card.SetDishInfo(dish);
                    card.AddToCartClicked += Dish_AddToCartClicked;
                    flowLayoutDishes.Controls.Add(card);

                }
            }
        }

        private void Dish_AddToCartClicked(object sender, EventArgs e)
        {
            var dishControl = sender as Card;
            if (dishControl == null) return;

            // Открываем форму выбора количества
            var form = new Quantity(dishControl.lblDishName.Text, dishControl.Price);

            if (form.ShowDialog() == DialogResult.OK)
            {
                // ✅ Создаём новый элемент корзины
                var item = new CartItem
                {
                    DishName = dishControl.lblDishName.Text,
                    Price = dishControl.Price,
                    Quantity = form._Quantity,
                };

                // ✅ Добавляем в общий список корзины
                cart.Add(item);

                MessageBox.Show(
                    $"Добавлено в корзину: {item.DishName} × {item.Quantity}\nСумма: {item.Total:C}",
                    "Корзина",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutDishes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            var cartForm = new FormCart(cart);
            cartForm.ShowDialog();
        }
    }
}
