namespace initiere;
//
//  while(conditie){
//   //executa instructiuni
//  }
//

internal class BuclaRepetitivaWhile
{
    public static void While01()
    {
        // ============================================================
        // WHILE 01 - NUMERELE DE LA 1 LA 10
        // ============================================================
        // Folosind o bucla while, afiseaza fiecare numar de la 1 la 10
        // pe cate o linie separata.
        //
        // Exemplu output:
        //   1
        //   2
        //   3
        //   ...
        //   10
        // ============================================================

        // TODO

        int nr = 1;
        while (nr != 11)
        {
            Console.WriteLine(nr);
            nr++;
        }
        // 1!=11 da=> af(1) nr devine 2
        // 2!=11 da=> af(2) nr devine 3
        //..
        //11!=11 false


    }

    public static void While02()
    {
        // ============================================================
        // WHILE 02 - NUMERE DESCRESCATOR
        // ============================================================
        // Folosind while, afiseaza numerele de la 10 la 1 pe cate o
        // linie. La final mai printezi linia "start".
        //
        // Exemplu output:
        //   10
        //   9
        //   8
        //   ...
        //   1
        //   start
        // ============================================================

        // TODO
        int numar = 10;
        while (numar != 0)
        {
            Console.WriteLine(numar);
            numar--;

        }
        Console.WriteLine("Start");
    }

    public static void While03()
    {
        // ============================================================
        // WHILE 03 - NUMERELE PARE PANA LA 20
        // ============================================================
        // Folosind while, afiseaza toate numerele pare de la 0 la 20
        // (inclusiv 20), fiecare pe o linie noua.
        //
        // Exemplu output:
        //   0
        //   2
        //   4
        //   ...
        //   20
        // ============================================================

        // TODO
        int n = 0;
        while (n !=22)
        {
            Console.WriteLine(n);
            n = n + 2; // sau n+=2;
        }
    }

    public static void While04()
    {
        // ============================================================
        // WHILE 04 - MULTIPLII LUI 3
        // ============================================================
        // Declara o variabila int `n`. Afiseaza toti multiplii lui 3
        // de la 1 la n (inclusiv), fiecare pe o linie noua.
        //
        // Exemplu output (n = 15):
        //   3
        //   6
        //   9
        //   12
        //   15
        // ============================================================

        // TODO
        int n = 3;
        while(n !=18)
        {
            Console.WriteLine(n);
            n = n + 3;

        }
        //1!=15 da  af(1)  n devine 4

    
    }

    public static void While05()
    {
        // ============================================================
        // WHILE 05 - SUMA DE LA 1 LA N
        // ============================================================
        // Declara o variabila int `n`. Calculeaza si afiseaza suma
        // numerelor de la 1 la n.
        //
        // Exemplu output (n = 5):
        //   Suma de la 1 la 5 = 15
        // ============================================================

        // TODO
        int n = 10;
        int s = 0;
        int ct = 1;
        while (ct != n)
        {
            s = s + ct;
            ct = ct + 1;

        }
        // 1!=5 DA  s=1   ct=2 
        // 2!=5     s=2   ct=3
        // 3!=5     s=5   ct=4
        // 4!=5     s=9   ct=5
        // 5!=5 false

        Console.WriteLine(s);
    }

    public static void While06()
    {
        // ============================================================
        // WHILE 06 - FACTORIAL
        // ============================================================
        // Declara o variabila int `n`. Calculeaza si afiseaza n!
        // (produsul tuturor numerelor de la 1 la n).
        //
        // Exemplu output (n = 5):
        //   5! = 120
        // ============================================================

        // TODO
        int n = 5;
        int produs = 1;
        int ct = 1;
        while (ct !=1)
        {
            produs = produs + ct;
            ct = ct + 1;
        }
        Console.WriteLine(produs);
        //1!=5 p=2 ct2
        //2!=5 p=4 ct=3
        //3!=5 p=7 ct=4
        //4!=5 p=11 ct 5
    }

    public static void While07()
    {
        // ============================================================
        // WHILE 07 - TABLA INMULTIRII CU N
        // ============================================================
        // Declara o variabila int `n`. Afiseaza tabla inmultirii cu
        // n (de la n*1 pana la n*10), cate o linie pentru fiecare
        // produs.
        //
        // Exemplu output (n = 4):
        //   4 x 1 = 4
        //   4 x 2 = 8
        //   ...
        //   4 x 10 = 40
        // ============================================================

        // TODO
    }

    public static void While08()
    {
        // ============================================================
        // WHILE 08 - NUMARUL DE CIFRE
        // ============================================================
        // Declara o variabila int `numar` (pozitiv). Afiseaza cate
        // cifre are numarul respectiv.
        //
        // Exemplu output (numar = 1234):
        //   1234 are 4 cifre
        // ============================================================

        // TODO
    }

    public static void While09()
    {
        // ============================================================
        // WHILE 09 - SUMA CIFRELOR UNUI NUMAR
        // ============================================================
        // Declara o variabila int `numar` (pozitiv). Calculeaza si
        // afiseaza suma cifrelor lui.
        //
        // Exemplu output (numar = 1234):
        //   Suma cifrelor = 10
        // ============================================================

        // TODO
    }

    public static void While10()
    {
        // ============================================================
        // WHILE 10 - INVERSUL UNUI NUMAR
        // ============================================================
        // Declara o variabila int `numar` (pozitiv). Afiseaza
        // numarul inversat (cifrele in ordine inversa).
        //
        // Exemplu output (numar = 1234):
        //   Inversul lui 1234 este 4321
        // ============================================================

        // TODO
    }
}
