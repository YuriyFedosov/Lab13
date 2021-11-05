using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задан класс Building, который описывает здание.Класс содержит следующие элементы:
            адрес здания;
            длина здания;
            ширина здания;
            высота здания.
            В классе Building нужно реализовать следующие методы:
            конструктор с 4 параметрами;
            свойства get/ set для доступа к полям класса;
            метод Print(), который выводит информацию о здании.
            Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.
            В классе MultiBuilding реализовать следующие элементы:

            конструктор с 5 параметрами – реализует вызов конструктора базового класса;
            свойство get/ set доступа к внутреннему полю класса;
            метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
            Класс MultiBuilding сделать таким, что не может быть унаследован.*/
            
            //Тестовые параметры

            /*Building b1 = new Building("Spb",15,6,4.5);
            b1.Print();
            MultiBuilding b2 = new MultiBuilding("Spb", 12, 7, 9, 2);
            b2.Print();
            Console.ReadKey();*/


        }

    }
    class Building //Класс по заданию
    {
        //Параметры
        internal string Adress { get; set; }
        internal double Length { get; set; }
        internal double Width { get; set; }
        internal double Height { get; set; }

        internal Building() //Конструктор по умолчанию
        {

        }
        internal Building(string a, double l, double w, double h) //Конструктор по заданию
        {
            Adress = a;
            Length = l;
            Width = w;
            Height = h;
        }
        internal void Print() //1й метод
        {
            Console.WriteLine("\nЗдание по адресу {0} имеет длину {1} м., ширину {2} м., Высоту {3} м.", Adress,Length,Width,Height);
        }

    }
    sealed class MultiBuilding:Building //Наследованный класс
    {
        internal int Levels { get; set; } //доп.параметр
        internal MultiBuilding(string a, double l, double w, double h,int lev) //Конструктор с этажом
            :base(a,l,w,h)
        {
            Levels = lev;
        }
        internal new void Print() //Обновление метода из родительского класса.
        {
            base.Print();
            Console.WriteLine("Количество этажей {0}", Levels);

        }
    }



}
