﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        int iloscProduktów(Koszyk kosz)
        {

            return 0;
        }
        static void Main(string[] args)
        {
            Car car1 = new Car("Audi", 2019, 9);
            Car car2 = car1;
            Console.WriteLine(car1.model);
            Console.WriteLine(car2.model);
            car2.model = "Opel";
            Console.WriteLine(car2.model);
            Console.WriteLine("Koszt przejazdu wyniesie {0} ", car1.ObliczKosztPrzejazdu(145, 5));
            Console.ReadKey();

            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Marek";
            dyrektor.nazwisko = "Kozak";
            dyrektor.rokUrodzenia = 1976;
            dyrektor.waga = 67;
            dyrektor.wzrost = 187;
            dyrektor.okulary = true;
            dyrektor.value = Osoba.plec.M;
            Console.WriteLine(dyrektor.imie + " " + dyrektor.nazwisko + " " + dyrektor.ObliczWiek());
            dyrektor.Przedrostek();
            Console.ReadKey();

            Osoba pacjent = new Osoba();
            pacjent.imie = "Mateusz";
            pacjent.nazwisko = "Dzik";
            pacjent.wzrost = 173;
            pacjent.waga = 68;
            pacjent.BMI();
            Console.ReadKey();

            Produkt banan = new Produkt("banan", 1.4);
            Produkt mikserKuchenny = new Produkt("mikser kuchenny", 56.99);
            Produkt czapka = new Produkt("czapka", 49.99);
            Produkt laysy = new Produkt("Laysy paprykowe", 4.99);

            Koszyk kosz = new Koszyk();
            kosz.DodajProdukt(banan);
            kosz.DodajProdukt(laysy);
            kosz.ZawartoscKoszyka();
            Console.ReadKey();

        }
    }
}
