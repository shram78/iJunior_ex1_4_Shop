using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Легенда:
Вы приходите в магазин и хотите купить за своё золото кристаллы. В вашем кошельке есть какое-то количество золота,
продавец спрашивает у вас, сколько кристаллов вы хотите купить? После сделки у вас остаётся какое-то количество золота
и появляется какое-то количество кристаллов.
При старте программы пользователь вводит начальное количество золота. Потом ему предлагается купить
какое-то количество кристаллов по цене N(задать в программе самому). Пользователь вводит число
и его золото конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран.*/

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Магазин кристалов 'у Шрама'\n");
            int myMoney = 0; // мой баланс
            int cristalCost = 0; // стоимость одного кристала
            int myCristal = 0; // количество моих кристалов
            bool isOutOfMoney; // когда ситуация с нехваткой баланса
            Console.Write("Продавец: сегодня один кристал стоит (введите стоимость в рублях):");
            cristalCost = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nИгрок: отлично, а у меня есть (введите сколько денег в кошельке):");
            myMoney = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Продавец: сколько кристалов купишь?");
            myCristal = Convert.ToInt32(Console.ReadLine());

            isOutOfMoney = myMoney >= cristalCost * myCristal;// тру когда денег больше, чем стоимость покупки
            myCristal *= Convert.ToInt32(isOutOfMoney); // ноль кристалов, если не хватило денег

            myMoney -= myCristal * cristalCost;
            Console.WriteLine($"У тебя в мешке {myCristal} кристалов, а в кошельке осталось {myMoney} монет ");
            Console.ReadLine();
        }
    }
}
