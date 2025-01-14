using System;
internal class Program
{
    static void Main(string[] args)
    {
        /*
        // összegzés
        int n = 2;
        int[] tomb = {1, 2};
        
        int osszeg = 0;
        for (int i = 0; i < n; i++) {
            osszeg += tomb[i];
        }

        Console.WriteLine(osszeg);
        */

        /*
        // feltételes összegzés
        int n = 2;
        int[] tomb = {14, 2};
        
        int osszeg = 0;
        for (int i = 0; i < n; i++) {
            if (tomb[i] > 10) {
                osszeg += tomb[i];
            }
        }

        Console.WriteLine(osszeg);
        */

        /*
        // megszámlálás
        int n = 2;
        int[] tomb = { 14, 2 };
        
        int db = 0;
        for (int i = 0; i < n; i++) {
            if (tomb[i] > 10) {
                db++;
            }
        }

        Console.WriteLine(db);
        */

        /*
        // maximum kiválasztás
        int n = 3;
        int[] tomb = { 1, 2, 10 };

        int maxIndex = 0;
        int maxErtek = tomb[0];

        for (int i = 1; i < n; i++) {
            if (tomb[i] > maxErtek) {
                maxIndex = i;
                maxErtek = tomb[i];
            }
        }

        Console.WriteLine($"{maxIndex}, {maxErtek}");
        */

        /*
        // minimum kiválasztás
        int n = 3;
        int[] tomb = { 1, 2, 10 };

        int minIndex = 0;
        int minErtek = tomb[0];

        for (int i = 1; i < n; i++) {
            if (tomb[i] < minErtek) {
                minIndex = i;
                minErtek = tomb[i];
            }
        }

        Console.WriteLine($"{minIndex}, {minErtek}");
        */

/*
        // feltételes maximum kiválasztás
        int n = 3;
        int[] tomb = { 10, 8, 11 };

        bool van = false;
        int maxIndex;
        int maxErtek;

        for (int i = 0; i < n; i++)
        {
            if (van && tomb[i] > 8)
            {
                if (tomb[i] > maxErtek)
                {
                    maxIndex = i;
                    maxErtek = tomb[i];
                }
            }
            else if (!van && tomb[i] > 8)
            {
                maxIndex = i;
                maxErtek = tomb[i];
                van = true;
            }
        }

        Console.WriteLine($"{maxIndex}, {maxErtek}");

        --------- FELTÖLTÉS ALATT ---------
        */
    }
}
