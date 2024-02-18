﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Englishman:Peaple
    {
        static string nationality = "Англичан";
        static string language = "Английский";

        public static string Nationality { get => nationality; set => nationality = value; }
        public static string Language { get => language; set => language = value; }

        public Englishman()
        {

        }

        public Englishman(string name, string surname, string patricname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patricname;
        }



        public void Inf()
        {
            Console.WriteLine($"Имя - {Name}\n" +
                $"Фамилия - {Surname}\n" +
                $"Отчество - {Patronymic}\n" +
                $"Национальность - {nationality}\n" +
                $"Язык - {language}\n");
        }

        public override void Greetings()
        {
            Console.WriteLine("HI");
        }
    }
}
