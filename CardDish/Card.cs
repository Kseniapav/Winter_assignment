using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using classDish;
using static classDish.Class1;

namespace CardDish
{
    public partial class Card : UserControl
    {

        public Card()
        {
            InitializeComponent(); this.BorderStyle = BorderStyle.FixedSingle;

        }


  

        private void CardDish_Load(object sender, EventArgs e)
        {

        }
        public void SetDishInfo(infoDish dataRepository)
        {
            // Устанавливаем название
            lblDishName.Text = dataRepository.Name;

            // Устанавливаем цену
            lblPrice.Text = $"Цена: {dataRepository.Price} ₽";

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

       
    }
}

       
    

    

