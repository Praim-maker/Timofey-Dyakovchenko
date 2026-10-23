using System;

namespace Timofey_Dyakovchenko
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем объект класса Box
            Box myBox = new Box();

            // 2. Задаем значения полям объекта
            myBox.width = 2;
            myBox.height = 3;
            myBox.length = 5;

            // 3. Выводим на экран данные, хранящиеся в объекте
            myBox.Show();

            // 4. Рассчитываем объем коробки и выводим его на экран
            float v = myBox.Volume();
            Console.WriteLine($"Объем коробки: {v}");

            Console.ReadKey();
        }
    }

    class Box
    {
        // Открытые поля для хранения данных о высоте, ширине, длине
        public float height;
        public float width;
        public float length;

        // Метод - показать на экране данные о ящике
        public void Show()
        {
            Console.WriteLine($"Коробка: ширина = {width}, высота = {height}, длина = {length}");
        }

        // Метод - рассчитать объем коробки
        public float Volume()
        {
            return width * height * length;
        }
    }
}
