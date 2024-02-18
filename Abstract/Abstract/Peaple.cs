using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Peaple
    {
        private string name;
        private string surname;
        private string patronymic;

        protected string Name { get => name; set => name = value; }
        protected string Surname { get => surname; set => surname = value; }
        protected string Patronymic { get => patronymic; set => patronymic = value; }

        public abstract void Greetings();
    }
}
