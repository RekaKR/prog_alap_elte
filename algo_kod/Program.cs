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
        // feltételes maximum keresés
        int n = 3;
        int[] tomb = { 10, 8, 11 };

        bool van = false;
        int maxIndex = 0;
        int maxErtek = tomb[0];

        for (int i = 0; i < n; i++) {
            if (van && tomb[i] > 8) {
                if (tomb[i] > maxErtek) {
                    maxIndex = i;
                    maxErtek = tomb[i];
                }
            } else if (!van && tomb[i] > 8) {
                maxIndex = i;
                maxErtek = tomb[i];
                van = true;
            }
        }

        if (van) {
            Console.WriteLine($"{maxIndex}, {maxErtek}");
        }
        */

        /*
        // feltételes minimum keresés
        int n = 3;
        int[] tomb = { 10, 8, 11 };

        bool van = false;
        int minIndex = 0;
        int minErtek = tomb[0];

        for (int i = 0; i < n; i++) {
            if (van && tomb[i] > 8) {
                if (tomb[i] < minErtek) {
                    minIndex = i;
                    minErtek = tomb[i];
                }
            } else if (!van && tomb[i] > 8) {
                minIndex = i;
                minErtek = tomb[i];
                van = true;
            }
        }

        if (van)
        {
            Console.WriteLine($"{minIndex}, {minErtek}");
        }
        */

        /*
        // keresés
        int n = 4;
        int[] tomb = { 3, 8, 2, 10 };

        int index = 0;

        while (index < n && !(tomb[index] > 4)) {
            index++;
        }

        bool van = (index < n);

        Console.WriteLine($"{van}, {index}");
        */
    
        /*
        // eldöntés
        int n = 3;
        int[] tomb = { 10, 8, 11 };
        
        int i = 0;

        while (i < n && !(tomb[i] > 80)) {
            i++;
        }
        
        bool van = (i < n);

        Console.WriteLine(van);
        */

        /*
        // mind eldöntés
        int n = 3;
        int[] tomb = { 10, 2, 11 };

        int i = 0;

        while (i < n && tomb[i] > 2) {
            i++;
        }

        bool mind = (i == n);

        Console.WriteLine(mind);
        */

        /*
        // kiválasztás
        string szo = "blablabla";

        int ind = 0;

        while (szo[ind] != 'a') {
            ind++;
        }

        Console.WriteLine(ind);
        */

        /*
        // kiválasztás
        string szo = "blablabla";

        int ind = 0;

        while (szo[ind] != 'a') {
            ind++;
        }

        Console.WriteLine(ind);

        // egy példa tömbre
        // feltételezzük, hogy van legalább egy ilyen elem a tömbben
        int[] tomb = { 1, 2, 3 };

        int ind2 = 0;

        while (tomb[ind2] != 2)
        {
            ind2++;
        }

        Console.WriteLine(ind2);
        */
        
        //--------- FELTÖLTÉS ALATT ---------
    }
}
