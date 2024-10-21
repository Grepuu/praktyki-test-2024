
#pragma warning disable CS0219 // Zmienna jest przypisana, ale jej wartość nie jest nigdy używana
namespace Praktyki2024.Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("==========================================================");

            // 1. rodzaje zmiennych
            int liczbaInt = 10, liczba2, liczba3, liczba4, liczba5 = 19;

            //int liczbaInt = 10;
            //int liczba2;
            //int liczba3;
            //int liczba4;
            //int liczba5 = 19;

            float liczbaZmiennoPrzecinkowa2 = 12.12f;
            double liczbaZmiennoPrzecinkowa1 = 11.11;
            bool prawdaFalsz = true;
            Boolean prawdaFalsz2 = false;
            byte bajt = 0;

            //var liczbaZmiennoPrzecinkowa2 = 12.12f;
            //var liczbaZmiennoPrzecinkowa1 = 11.11;
            //var prawdaFalsz = true;
            //var prawdaFalsz2 = false;
            //var bajt = 0;

            string ciagZnakow = "Hello, World!";
            String ciagZnakow3 = "Hello, World!";
            char pojedynczyZnak = 'H';
            char[] ciagZnakow2 = ['H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', '!'];

            liczbaInt = liczbaInt + 2;

            // 2. wyświetlanie w konsoli
            Console.WriteLine("Kompletna linijka do konsoli");
            Console.WriteLine("Druga kompletna linijka do konsoli");
            Console.Write("Wpisuje slowo1\n");
            Console.Write("Wpisuje slowo2\n");
            Console.Write("Wpisuje slowo3\n");

            liczba3 = 14;
            Console.WriteLine($"Liczba int: {liczbaInt}, druga liczba: {liczba5}, trzecia liczba: {liczba3}");
            Console.WriteLine($"Liczba float: {liczbaZmiennoPrzecinkowa2}");
            Console.WriteLine($"bool: {prawdaFalsz}");
            Console.WriteLine($"byte: {bajt}");
            Console.WriteLine($"string: {ciagZnakow}");
            Console.WriteLine($"char: {pojedynczyZnak}");
            Console.WriteLine($"char[]: {ciagZnakow2}");
            Console.WriteLine("==========================================================");

            // 3. pobieranie inputu od użytkownika
            string? imie = null;

            Console.Write("Wpisz swoje imie:\n");
            imie = Console.ReadLine();
            Console.WriteLine($"Masz na imie: {imie}");


            // 4. walidowanie inputu od użytkownika
            string? wiek;
            int wiekSparsowany = 0;
            bool czyUdaloSieSparsowacWiek = false;

            Console.Write("Wpisz swoj wiek:\n");
            wiek = Console.ReadLine();

            if (wiek != null)
            {
                try
                {
                    wiekSparsowany = Convert.ToInt32(wiek);
                }
                catch (Exception e)
                {
                    wiekSparsowany = 0;
                }

                czyUdaloSieSparsowacWiek = wiekSparsowany > 0;
            }

            // musimy sprawdzić czy wiek jest liczbą
            if(czyUdaloSieSparsowacWiek)
            {
                // jesli jest liczbą wyświetlić że wpisał dobrze i wysiwetlić wiek i imie
                Console.WriteLine($"Twoje dane: {imie}, {wiekSparsowany} lat");
            }
            else
            {
                // jeśli nie jest wyświetlić tekst że błędne dane
                Console.WriteLine($"Wprowadziles/as niepoprawne dane");
            }

            // 5. pętle
            WyswietlPetle(40);

            // 6. funkcje

            //zadania domowe:
            // 1.Zdefiniować po trzy zmienne typu int, float, string, char i char[]
            // 2a(*).zrobić tak by char[] wyświetlił się w konsoli poprawnie
            // 2b.Wyświetlić w każdą zdefiniowaną zmienną w pojedynczej linii(każdą osobno)
            // 3 i 4.Pobrać od użytkownika imie, wiek, rok urodzenia, plec
            // wyświetlić komunikaty o błędzie:
            // jeśli wiek błędny
            // jesli rok urodzenia wiekszy niż 2010
            // jeśli plec bledna(płec to może być M lub K małe)
            // jesli nie ma błędów wyświetlić dane użytkownika
            // 5.Zrobić po jednej pętli z każdego rodzaju
            // 5b(*).Zrobić pętlę do/while tak by nie wyszedł z niej użytkownik dopóki nie wpisze pasującego 4 cyfrowego kodu 1234
            // na wyjście z pętli wyświetlić komunikat
            // 5c.Przykład różnicy gdzie można użyć while a gdzie do while
            // 5d.podwójna choinke forem(zdjecie na chacie)
            // 6.każde zadanie w osobnej funkcji

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }

        /// <summary>
        /// public - zakres dostępu do funkcji
        /// static - czy jest statyczna
        /// void - typ zwracany
        /// Funkcja - nazwa funkcji
        /// </summary>
        public static void Funkcja(int numer1, string tekst1)
        {
            // ciało funkcji
        }

        public static void WyswietlPetle(int maxLiczenia)
        {
            for (int i = 0; i < maxLiczenia; i++)
            {
                Console.WriteLine($"FOR: {i}");
            }

            // var = variable
            var l = new[] { 'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', '!' };
            foreach (int znak in l)
            {
                Console.WriteLine($"Foreach: {znak}");
            }

            var j = 0;
            do
            {
                Console.WriteLine($"Do while: {j}");
                j++;
            } while (j < maxLiczenia);

            var k = 0;
            while (k < maxLiczenia)
            {
                Console.WriteLine($"While: {k}");
                k++;
            }
        }
    }
}
