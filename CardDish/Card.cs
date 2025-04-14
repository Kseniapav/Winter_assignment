using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CardDish
{
    public partial class Card: UserControl
    {      

        public Card()
        {
            InitializeComponent();this.BorderStyle = BorderStyle.FixedSingle;
        this.BackColor = Color.White;
        this.Padding = new Padding(10);
        this.Margin = new Padding(10);
        this.Width = 300;

            picDishImage.SizeMode = PictureBoxSizeMode.Zoom;
            picDishImage.Height = 150;
            picDishImage.Dock = DockStyle.Top;
            picDishImage.BackColor = Color.WhiteSmoke;

            lblDishName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblDishName.Dock = DockStyle.Top;
            lblDishName.Margin = new Padding(0, 10, 0, 5);

            lblPrice.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblPrice.Dock = DockStyle.Top;
            lblPrice.Margin = new Padding(0, 10, 0, 0);

            this.MouseEnter += CardDish_MouseEnter; ;
            this.MouseLeave += CardDish_MouseLeave; ;
        }

        private void CardDish_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CardDish_MouseEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CardDish_Load(object sender, EventArgs e)
        {

        }
        public void SetDishInfo(Card dish)
        {
            // Устанавливаем название блюда
            lblDishName.Text = dish.Name ?? "Без названия";

            // Устанавливаем цену (исправлено с dish.Price)
            lblPrice.Text = $"Цена: {dish.lblPrice} ₽";

            // Загружаем изображение
            if (!string.IsNullOrEmpty(dish.ImagePath))
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", "Dishes", dish.ImagePath);

                try
                {
                    if (File.Exists(imagePath))
                    {
                        // Освобождаем предыдущее изображение
                        if (picDishImage.Image != null)
                        {
                            var oldImage = picDishImage.Image;
                            picDishImage.Image = null;
                            oldImage.Dispose();
                        }

                        picDishImage.Image = Image.FromFile(imagePath);
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

       
    }

    
}
