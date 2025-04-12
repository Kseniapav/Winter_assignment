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
            });
            breakfast.Dishes.Add(new Dish
            {
                Name = "Тост с авокадо, яйцом пашот и лососем, 160 грамм",
                Price = 630,
            });
            breakfast.Dishes.Add(new Dish
            {
                Name = "Хашбраун с боконом, сырным соусом и яйцом пашот, 250 грамм",
                Price = 570,
            });
            breakfast.Dishes.Add(new Dish
            {
                Name = "Омлет с пармезаном, 250 грамм",
                Price = 350,
            });

            var salads = new Category { Name = "Салаты" };
            salads.Dishes.Add(new Dish
            {
                Name = "Средиземноморский салат с тигровыми креветками, 205 грамм",
                Price = 850,     
            });
            salads.Dishes.Add(new Dish
            {
                Name = "Стейк салат с копчеными томатами и орехами кешью, 160 грамм",
                Price = 830,
            });
            salads.Dishes.Add(new Dish
            {
                Name = "Цезарь с креветками, 200 грамм",
                Price = 690,
            });
            salads.Dishes.Add(new Dish
            {
                Name = "Салат с баклажанами гриль, томатами и кубиками моцареллы, 270 грамм",
                Price = 560,
            });

            var soups = new Category { Name = "Супы" };
            soups.Dishes.Add(new Dish
            {
                Name = "Суп - пюре из копченых томатов с сыром моцарелла, 310",
                Price = 490,
            });
            soups.Dishes.Add(new Dish
            {
                Name = "Крем - суп из белых грибов, 300 грамм",
                Price = 490,
            });
            soups.Dishes.Add(new Dish
            {
                Name = "Сицилийский рыбный суп, 350 грамм",
                Price = 590,
            });
            soups.Dishes.Add(new Dish
            {
                Name = "Сливочная уха с лососем, судаком и окунем, 330 грамм",
                Price = 590,
            });

            var hot_dishes = new Category { Name = "Горячие блюда" };
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Фермерский цыпленок с соусом аррабиата, 370 грамм",
                Price = 990,
            });
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Стейк мачете, 150 грамм",
                Price = 1350,
            });
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Лосось на гриле/на пару, 120 грамм",
                Price = 990,
            });
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Куринная грудка с киноа и зеленым салатом, 275 грамм",
                Price = 560,
            });
            hot_dishes.Dishes.Add(new Dish
            {
                Name = "Соте из морепродуктов в трюфельнос соусе, 360 грамм",
                Price = 990,
            });

            var desserts = new Category { Name = "Десерты" };
            desserts.Dishes.Add(new Dish
            {
                Name = "Тарт татен яблочный, 180",
                Price = 490,   
            });
            desserts.Dishes.Add(new Dish
            {
                Name = "Фисташковая панна котта с вишневым вареньем, 140",
                Price = 490,
            });
            desserts.Dishes.Add(new Dish
            {
                Name = "Шоколадный бисквит, 160",
                Price = 550,
            });
        }
    }
}
