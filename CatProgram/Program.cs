using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace CatProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat(BuyCat());
            
            ImagineMenu(Kitty.Name, "");

            char menu;
            char[] menuLimit = new char[]{'1', '2', '3', '4', '0'};
            bool end = false;

            while(!end)
            {

                menu = Convert.ToChar(Console.ReadLine()[0]);

                if (menuLimit.Contains(menu))
                {
                    switch(menu)
                    {
                        //Именуем кошку
                        case '1':
                            if(String.IsNullOrEmpty(Kitty.Name))
                            {
                                Console.WriteLine("Введите имя кошки (Имя кошки нельзя будет изменить!):");
                                Kitty.Name = Console.ReadLine();
                                ImagineMenu(Kitty.Name, "У кошки появилось имя!");
                            }
                            else
                            {
                                ImagineMenu(Kitty.Name, "Имя кошки нельзя изменить!");
                            }
                            break;

                        //Кормим кошку
                        case '2':
                            Kitty.Feed();
                            ImagineMenu(Kitty.Name, "Кошка была покормлена.");
                            break;

                        //Наказываем кошку
                        case '3':
                            Kitty.Punish();
                            ImagineMenu(Kitty.Name, "Кошка была жестоко наказана.");
                            break;

                        //Узнаём цвет
                        case '4':
                            Console.WriteLine("Если цвет кошки Зелёный - она в восторге, продолжайте в том же духе" +
                                              "\nЕсли Желтый - ваша кошка чувствует себя умеренно" +
                                              "\nЕсли Красный - она присмерти, бегите её кормить!!!" +
                                              "\n\nЦвет вашей кошки: {0}" +
                                              "\n\n(Нажмите Enter чтобы вернуться в меню)", Kitty.Color);
                            Console.ReadLine();
                            ImagineMenu(Kitty.Name, "");
                            break;

                        //Выход
                        case '0':
                            end = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Выберите пункт меню!");

                }
                //switch ()
            }
            
        }

        static int BuyCat()
        {
            Console.WriteLine("Вы покупаете Кибер Кошачу. Введите её возраст:");
            int age = -1;
            while (age < 0 || age > 15)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0 || age > 15) Console.WriteLine("Возраст не может быть отрицательным или больше чем 15!");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + " Введите целое число!");
                }
             }

            return age;
            }

        static void ImagineMenu(string catName, string s)
        {
            Console.Clear();
            Console.WriteLine("-------{0}-------" +
                              "\n1. Задать имя кошке" +
                              "\n2. Кормить кошку" +
                              "\n3. Наказать кошку" +
                              "\n4. Узнать состояние здоровья кошки по её окрасу" +
                              "\n0. Завершить работу приложения" +
                              "\n\n {1}" +
                              "\n Выберите пункт меню",
                              catName, s);
        }
    }
}
