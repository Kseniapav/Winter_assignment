using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Menu
    {
        public List<Dish> Dishes { get; set; } = new List<Dish>();

        // Загрузка меню из файла
        public void LoadMenu(string filePath)
        {
            try
            {
                // Проверяем, существует ли файл
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Файл не найден!");
                    return;
                }

                // Читаем все строки из файла
                var lines = File.ReadAllLines(filePath);

                // Обрабатываем каждую строку
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length != 4) // Проверяем, что строка содержит все необходимые части
                    {
                        Console.WriteLine($"Ошибка в формате строки: {line}");
                        continue;
                    }

                    var dish = new Dish
                    {
                        Category = parts[0],
                        Name = parts[1],
                        Ingredients = parts[2].Split(',').ToDictionary(
                            x => x.Split(':')[0],
                            x => double.Parse(x.Split(':')[1])),
                        Calories = double.Parse(parts[3])
                    };
                    Dishes.Add(dish);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        // Получить блюда по категории
        public List<Dish> GetDishesByCategory(string category)
        {
            return Dishes.Where(d => d.Category == category).ToList();
        }
    }

    class Program
    {
        static void Main()
        {
            // Указываем путь к файлу
            string filePath = @"C:\Documents\menu.txt";

            // Создаем объект меню и загружаем данные
            var menu = new Menu();
            menu.LoadMenu(filePath);

            // Пример использования: получаем блюда из категории "Салаты"
            var salads = menu.GetDishesByCategory("Салаты");

            // Выводим информацию о блюдах
            foreach (var salad in salads)
            {
                Console.WriteLine($"Название: {salad.Name}, Калорийность: {salad.Calories}");
                Console.WriteLine("Ингредиенты:");
                foreach (var ingredient in salad.Ingredients)
                {
                    Console.WriteLine($"  {ingredient.Key}: {ingredient.Value}");
                }
            }
        }
    }
}
