using System;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            //var num = 10; //вар это плохо, лучше не юзать. Нужно инициализировать сразу же, иначе ошибка.
            //int num = 10;
            // uint num_1 = 10; //тип, не принимающий отрицательные значения
            // float f = 2.6f; //нужно указывать, что число является флоатом(букву f написал).
            // bool boolean = true; //логика
            // string name = "Airat"; //массив символов(строка).
            //  char n = 'g'; //час это одна буква
            int num, num1;
            Console.WriteLine("Enter first number"); //Считывает следующую строку символов из стандартного входного потока.
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result is: " + (num + num1).ToString());//ту стринг правильнее, можно без неё.
            Console.ReadKey(); //Получает следующий нажатый пользователем символ или функциональную клавишу.
        }
    }
}
