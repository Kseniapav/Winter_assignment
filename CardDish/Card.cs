using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using classDish;
using static classDish.Class1;
using System.Diagnostics;

namespace CardDish
{
    public partial class Card : UserControl
    {
        public event EventHandler AddToCartClicked;
        private int price;
        public Card()
        {
            InitializeComponent(); this.BorderStyle = BorderStyle.FixedSingle;
            this.MouseEnter += Dish_MouseEnter;
            this.MouseLeave += Dish_MouseLeave;
            buttonAddToCart.Click += buttonAddToCart_Click;


        }
        public int Price
        {
            get => price;
            set
            {
                price = value;
                lblPrice.Text = $"{value} ₽"; // обновляем отображение
            }
        }
        public void Dish_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow; // Подсветка
        }

        public void Dish_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192,0,0); // Возврат цвета
        }

        public void buttonAddToCart_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, EventArgs.Empty);
        }


        public void CardDish_Load(object sender, EventArgs e)
        {

        }
        public void SetDishInfo(infoDish dataRepository)
        {
            // Устанавливаем название
            lblDishName.Text = dataRepository.Name;

            // Устанавливаем цену
            Price = dataRepository.Price;

            // Загружаем изображение
            if (!string.IsNullOrEmpty(dataRepository.ImagePath))
            {
                string fullPath = Path.Combine(Application.StartupPath, "Images", "Dishes", dataRepository.ImagePath);

                try
                {
                    if (File.Exists(fullPath))
                    {
                        picDishImage.Image?.Dispose(); // Освобождаем старое изображение
                        picDishImage.Image = Image.FromFile(fullPath);
                    }
                    else
                    {

                    }
                }
                catch
                {

                }
            }
        }

        public void lblPrice_Click(object sender, EventArgs e)
        {

        }

        public void lblDishName_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToCart_Click_1(object sender, EventArgs e)
        {

        }
    }
}

       
    

    

