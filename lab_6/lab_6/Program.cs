using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_6
{
    public class Pechantor_izdanie//Печатное издание
    {
        public string Name;
        public int col_str;
        public int year;
        public Pechantor_izdanie(string name, int col_str, int year)
        {
            this.Name = name;//обеспечиваем доступ в текущему классу
            this.col_str = col_str;
            this.year = year;
        }
        public void PrintName()
        {
            Console.WriteLine("" + this.Name);
        }
        public void PrintCol_str()
        {
            Console.WriteLine("" + this.col_str);
        }
        public void PrintYear()
        {
            Console.WriteLine("" + this.year);
        }
        public class Jurnal : Pechantor_izdanie//Журнал, производный класс
        {
            public string Number;
            public Jurnal(string name, int col_str, int year, string number)
                : base(name, col_str, year)
            {
                this.Number = number;//обеспечиваем доступ в текущему классу
            }
            public void PrintNamber()
            {
                Console.WriteLine("" + this.Number);
            }
            public class Book : Pechantor_izdanie//Книга, производный класс
            {
                public string Janr;
                public Book(string name, int col_str, int year, string janr)
                    : base(name, col_str, year)
                {
                    this.Janr = janr;//обеспечиваем доступ в текущему классу
                }
                public void PrintJanr()
                {
                    Console.WriteLine("" + this.Janr);
                }
                public class Uchebnic : Pechantor_izdanie//Учебник, производный класс
                {
                    public string Autor;
                    public Uchebnic(string name, int col_str, int year, string autor)
                        : base(name, col_str, year)//bazovi klas
                    {
                        this.Autor = autor;//обеспечиваем доступ в текущему классу
                    }
                    public void PrintAutor()
                    {
                        Console.WriteLine("" + this.Autor);
                    }
                }
                public static void Main(string[] args)
                {
                    //sozdanie obekta classa
                    Uchebnic ns = new Uchebnic("Buckvar", 20, 1995, "Pushkin");
                    Pechantor_izdanie ps = new Pechantor_izdanie("Buckvar", 20, 1995);
                    ps.PrintName();
                    ps.PrintCol_str();
                    ps.PrintYear();
                    ns.PrintAutor();
                    Console.ReadKey();
                }
            }
        }
    }
}
