using System;

namespace Datatypes
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Koodi tulee tänne
            // Syntax - syntaksi eli pitää olla aaltosulut
            // syntaksi virhe tai syntax error
            // Tämä on kommentti
            // Kommentit eivät suorita mitään

            // Datatypes - datatyypit
            // Numeroita
            // 35 - kokonaisluku - integer
            // 13.5 - liukuluku - floating point
            // Merkkejä - char / Merkkijono -string
            // 't'/ "word"
            // Bool
            // true/false 1/0
            // Literals
            // data on tallessa muuttujissa - variable (=muuttuja)
            // <data_type> <variable name>
            //
            // int, johon voidaan laittaa vain kokonaislukuja
            int apu = 5;
            int integerValue = 10; // puolipiste rivin loppuun (= tyhjä muuttuja on luotu, mutta sillä ei ole vielä arvoa)
            integerValue = 15;
            // double - liukuluku, johon voi siis laittaa desimaaleja
            double doubleValue; // luotu tyhjä doublevalue muuttuja, jolla ei ole arvoa
            doubleValue = 3.14; // voi joko luoda muuttujan jolle annetaan arvo tai luoda muuttuja, jolla on arvo. tämä on muuttuja, jolla ei ole arvoa. yllä olevalla on arvo
            // char, voidaan tallentaa vain yksi kirjain
            char characterValue = 'r';
            // string, johon voi tallentaa sanan
            string stringValue = "Word";
            // bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä


            // luokaa muuttuja nimeltä message
            // ja antakaa sille arvoksi "Hello"
            string message = "Hello"; // literaali arvo on hello, joka on kovakoodattu
            Console.WriteLine(message);
            string input;
            input = Console.ReadLine(); //konsoli on luokkana, readline metodi. Tällä lukee käyttäjän arvon, mutta ei tallenna sitä minnekään
            // "Vastasit x", jossa x on käyttäjän syöte (input).
            Console.WriteLine("Vastasit {0}", input);
            Console.Write($"Interpolating {input} ovi jatkaa");
            Console.Write("Vastasit" + input);

            #region 3 C# Perus: Ikä-tehtävä
            //Koodi
            Console.Write("Anna ikäsi: ");
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);
            Console.WriteLine($"Olet {age} vuotta!");

            // Ilmoita käyttäjän ikä kuukausina
            // +, -, *, /, %
            int sum = 5 + 4;
            sum = 7 - age;
            sum = sum * age;
            sum /= age;
            // sum = 9

            Console.Write($"Olet {age * 12} kuukautta vanha");


            #endregion

            #region 4 C# Perus: Palkan lasku

            Console.Write("Anna tuntipalkka: ");
            string userInput = Console.ReadLine();
            int eur = int.Parse(userInput);
            Console.WriteLine($"Tuntipalkka on {eur} euroa");
            

            

        }
    }
}
