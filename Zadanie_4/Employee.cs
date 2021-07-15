using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Employee
    {
        String imie, nazwisko;
        double stawka, wyplata, stankonta;

        public Employee(String name, String surname, double wage)
        {
            imie = name;
            nazwisko = surname;
            stawka = wage;
        }

        public void RegisterTime(double czas)
        {
            if (czas < 8)  wyplata += czas * stawka;
            else wyplata += (czas - 8) * (stawka * 2) + (8 * stawka);
        }

        public void PaySalary()
        {
            stankonta += wyplata;
            Console.WriteLine("Wyplacono pracownikowi {0}. Stan konta pracownika to: {1}", wyplata, stankonta);
            wyplata = 0;
        }

    }
}
