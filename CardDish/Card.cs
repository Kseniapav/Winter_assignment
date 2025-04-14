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
    public partial class Card : UserControl
    {
        private readonly string ImagePath;

        public Card()
        {
            InitializeComponent(); this.BorderStyle = BorderStyle.FixedSingle;

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
        public void SetDishInfo(Card DataRepository)
        {
            // Устанавливаем название
            lblDishName.Text = DataRepository.Name;

            // Устанавливаем цену
            lblPrice.Text = $"Цена: {DataRepository.lblPrice} ₽";

            // Загружаем изображение
            if (!string.IsNullOrEmpty(DataRepository.ImagePath))
            {
                string fullPath = Path.Combine(Application.StartupPath, "Images", "Dishes", DataRepository.ImagePath);

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

       
    }
}

       
    

    

