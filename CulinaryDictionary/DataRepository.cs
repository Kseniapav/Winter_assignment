using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulinaryDictionary
{
    internal static class DataRepository
    {
        public static List<Category> Categories { get; set; } = new List<Category>();

        public static void InitializeSampleData()
        {
            var breakfast = new Category { Name = "Завтраки"};
            breakfast.Dishes.Add(new Dish
            {
                Name = "Скрэмбл с тигровыми креветками и авокадо, 230 грамм",
                Price = 690,
                ImagePath = "1.JPG"
            });
            breakfast.Dishes.Add(new Dish
            {
                Name = "Тост с авокадо, яйцом пашот и лососем, 160 грамм",
                Price = 630,
                ImagePath = "2.JPG"
            });
            breakfast.Dishes.Add(new Dish
            {
                Name = "Хашбраун с беконом, сырным соусом и яйцом пашот, 250 грамм",
                Price = 570,
                ImagePath = "3.JPG"
            });
            breakfast.Dishes.Add(new Dish
            {
                Name = "Омлет с пармезаном, 250 грамм",
                Price = 350,
                ImagePath = "4.JPG"
            });

            var salads = new Category { Name = "Салаты" };
            salads.Dishes.Add(new Dish
            {
                Name = "Средиземноморский салат с тигровыми креветками, 205 грамм",
                Price = 850,
                ImagePath = "5.JPG"
            });
            salads.Dishes.Add(new Dish
            {
                Name = "Стейк салат с копчеными томатами и орехами кешью, 160 грамм",
                Price = 830,
                ImagePath = "6.JPG"
            });
            salads.Dishes.Add(new Dish
            {
                Name = "Цезарь с креветками, 200 грамм",
                Price = 690,
                ImagePath = "7.JPG"
            });
            salads.Dishes.Add(new Dish
            {
                Name = "Салат с баклажанами гриль, томатами и кубиками моцареллы, 270 грамм",
                Price = 560,
                ImagePath = "8.JPG"
            });

            var soups = new Category { Name = "Супы" };
            soups.Dishes.Add(new Dish
            {
                Name = "Суп - пюре из копченых томатов с сыром моцарелла, 310",
                Price = 490,
                ImagePath = "9.JPG"
            });
            soups.Dishes.Add(new Dish
            {
                Name = "Крем - суп из белых грибов, 300 грамм",
                Price = 490,
                ImagePath = "10.JPG"
            });
            soups.Dishes.Add(new Dish
            {
                Name = "Сицилийский рыбный суп, 350 грамм",
                Price = 590,
                ImagePath = "11.JPG"
            });
            soups.Dishes.Add(new Dish
            {
                Name = "Сливочная уха с лососем, судаком и окунем, 330 грамм",
                Price = 590,
                ImagePath = "12.JPG"
            });

            var hot_dishes = new Category { Name = "Горячие блюда" };
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Фермерский цыпленок с соусом аррабиата, 370 грамм",
                Price = 990,
                ImagePath = "13.JPG"
            });
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Стейк мачете, 150 грамм",
                Price = 1350,
                ImagePath = "14.JPG"
            });
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Лосось на гриле/на пару, 120 грамм",
                Price = 990,
                ImagePath = "15.JPG"
            });
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Куринная грудка с киноа и зеленым салатом, 275 грамм",
                Price = 560,
                ImagePath = "16.JPG"
            });
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Соте из морепродуктов в трюфельнос соусе, 360 грамм",
                Price = 990,
                ImagePath = "17.JPG"
            });

            var desserts = new Category { Name = "Десерты" };
            desserts.Dishes.Add(new Dish
            {
                Name = "Тарт татен яблочный, 180",
                Price = 490,
                ImagePath = "18.JPG"
            });
            desserts.Dishes.Add(new Dish
            {
                Name = "Фисташковая панна котта с вишневым вареньем, 140",
                Price = 490,
                ImagePath = "19.JPG"
            });
            desserts.Dishes.Add(new Dish
            {
                Name = "Шоколадный бисквит, 160",
                Price = 550,
                ImagePath = "20.JPG"
            });
        }
    }
}
