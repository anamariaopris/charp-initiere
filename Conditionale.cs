using System.ComponentModel.Design;

namespace initiere;

internal class Conditionale
{
    public static void Cond01()
    {
        // ============================================================
        // CONDITIONAL 01 - POZITIV / NEGATIV / ZERO
        // ============================================================
        // Declara o variabila int `numar`. Afiseaza:
        //   - "pozitiv" daca este > 0
        //   - "negativ" daca este < 0
        //   - "zero" altfel
        //
        // Exemplu output (daca numar = -3):
        //   negativ
        // ============================================================

        // TODO
        int numar = 9;
 
        if( numar > 0)
        {

            Console.WriteLine(numar+" este pozitiv");
        }else if( numar < 0)
        {
            Console.WriteLine(numar+" este negativ");
        }
        else
        {
            Console.WriteLine("zero");
        }

        
    }

    public static void Cond02()
    {
        // ============================================================
        // CONDITIONAL 02 - PAR SAU IMPAR
        // ============================================================
        // Declara o variabila int `numar`. Afiseaza:
        //   - "X este par"   daca este par
        //   - "X este impar" daca este impar
        //
        // Exemplu output (daca numar = 7):
        //   7 este impar
        // ============================================================

        // TODO
        int numar = 20;
        
        if (numar%2 == 0)

        {
            Console.WriteLine(numar + "este par");
        }
        else
        {
            Console.WriteLine(numar +" este impar");
        }
    }

    public static void Cond03()
    {
        // ============================================================
        // CONDITIONAL 03 - MAXIMUL DINTRE 2 NUMERE
        // ============================================================
        // Declara doua variabile int `a` si `b`. Afiseaza maximul
        // dintre ele.
        //
        // Exemplu output (daca a = 5, b = 12):
        //   Maxim = 12
        // ============================================================

        // TODO
        int a = 5;
        int b = 12;

        if (a < b)
        {
            Console.WriteLine(b + "este maximul");
        }
        else
        {
            Console.WriteLine(b + "este minimul");
        } 

    }

    public static void Cond04()
    {
        // ============================================================
        // CONDITIONAL 04 - MAXIMUL DINTRE 3 NUMERE
        // ============================================================
        // Declara trei variabile int `a`, `b`, `c`. Afiseaza maximul
        // dintre cele trei.
        //
        // Exemplu output (daca a = 4, b = 9, c = 7):
        //   Maxim = 9
        // ============================================================

        // TODO
        int a = 14;
        int b = 329;
        int c = 17;

        if (a>b&&a>c)
        {
            Console.WriteLine("Maximul este "+a);

        }else if (b > c)
        {
            Console.WriteLine("Maximul este " + b);
        }
        else
        {

            Console.WriteLine("Maximul este " + c);
        }
    }

    public static void Cond05()
    {
        // ============================================================
        // CONDITIONAL 05 - CALIFICATIV PE BAZA NOTEI
        // ============================================================
        // Declara o variabila int `nota` cu o valoare intre 1 si 10.
        // Afiseaza calificativul:
        //   - nota >= 9  -> "Excelent"
        //   - nota >= 7  -> "Bine"
        //   - nota >= 5  -> "Suficient"
        //   - altfel     -> "Insuficient"
        //
        // Exemplu output (daca nota = 8):
        //   Nota 8 => Bine
        // ============================================================

        // TODO
        int nota = 5;
        if (nota >= 9)
        {
            Console.WriteLine("EXCELENT ");
        } else if (nota >= 7)
        {
            Console.WriteLine("Bine ");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Suficient ");
        }
        else
        {
            Console.WriteLine("Insuficient");
        }
    }

    public static void Cond06()
    {
        // ============================================================
        // CONDITIONAL 06 - CATEGORII DE VARSTA
        // ============================================================
        // Declara o variabila int `varsta`. Afiseaza categoria:
        //   - sub 13      -> "copil"
        //   - intre 13 si 17 -> "adolescent"
        //   - intre 18 si 64 -> "adult"
        //   - peste 64    -> "varstnic"
        //
        // Exemplu output (daca varsta = 30):
        //   adult
        // ============================================================

        // TODO
        int varsta = 20;

        if (varsta > 64)
        {
            Console.WriteLine("varstnic ");
        }
        else if (varsta > 18)
        {
            Console.WriteLine("Adult ");
        }
        else if (varsta > 13)
        {
            Console.WriteLine("adolescent ");
        }
        else
        {
            Console.WriteLine("copil ");
        }
            
        

    }

    public static void Cond07()
    {
        // ============================================================
        // CONDITIONAL 07 - LOGIN
        // ============================================================
        // Definite in cod doua variabile cu datele corecte:
        //   string utilizatorCorect = "admin";
        //   string parolaCorecta    = "1234";
        // Definite alte doua variabile cu datele "introduse" de
        // utilizator (le pui tu in cod). Verifica daca AMBELE
        // potrivesc si afiseaza:
        //   - "Login OK"     daca da
        //   - "Date invalide" altfel
        //
        // Exemplu output (daca utilizator = "admin", parola = "abcd"):
        //   Date invalide
        // ============================================================

        // TODO
        string utilizatorCorect = "admin";
        string parolaCorecta = "1234";


        string utilizatorIntrodus = "adminasdasd";
        string parolaIntrodusa = "1234asdasd";

        if (utilizatorIntrodus.Equals(utilizatorCorect)&&parolaIntrodusa.Equals(parolaCorecta))
        {

            Console.WriteLine("V-ati logat cu succes");
        }else if (!utilizatorIntrodus.Equals(utilizatorCorect))
        {
            Console.WriteLine("A-ti introdus un username gresit");
        }
        else 
        {
            Console.WriteLine("Parola introdusa este gresita");
        }

    }

    public static void Cond08()
    {
        // ============================================================
        // CONDITIONAL 08 - ANOTIMP DUPA LUNA
        // ============================================================
        // Declara o variabila int `luna` (1-12). Afiseaza anotimpul:
        //   - 12, 1, 2  -> "iarna"
        //   - 3, 4, 5   -> "primavara"
        //   - 6, 7, 8   -> "vara"
        //   - 9, 10, 11 -> "toamna"
        // Pentru o luna invalida (< 1 sau > 12) afiseaza "luna invalida".
        //
        // Exemplu output (daca luna = 4):
        //   primavara
        // ============================================================

        // TODO
    }

    public static void Cond09()
    {
        // ============================================================
        // CONDITIONAL 09 - TRIUNGHI VALID
        // ============================================================
        // Declara trei variabile int `a`, `b`, `c` (laturile unui
        // triunghi). Verifica daca cele 3 lungimi pot forma un
        // triunghi valid si afiseaza:
        //   - "triunghi valid"   daca da
        //   - "triunghi invalid" altfel
        //
        // Regula: orice latura trebuie sa fie mai mica decat suma
        // celorlalte doua.
        //
        // Exemplu output (daca a = 3, b = 4, c = 5):
        //   triunghi valid
        // Exemplu output (daca a = 1, b = 1, c = 10):
        //   triunghi invalid
        // ============================================================

        // TODO
    }

    public static void Cond10()
    {
        // ============================================================
        // CONDITIONAL 10 - AN BISECT
        // ============================================================
        // Declara o variabila int `an`. Afiseaza:
        //   - "X este bisect"    daca este an bisect
        //   - "X nu este bisect" altfel
        //
        // Regula an bisect:
        //   - se imparte la 4
        //   - SI nu se imparte la 100
        //   - SAU se imparte la 400
        // (ex: 2000 si 2024 sunt bisecti, 1900 si 2023 nu)
        //
        // Exemplu output (daca an = 2024):
        //   2024 este bisect
        // ============================================================

        // TODO
    }

    public static void Cond11()
    {
        // ============================================================
        // CONDITIONAL 11 - OPERATOR TERNAR
        // ============================================================
        // Declara o variabila int `numar` (presupune ca nu este 0).
        // Folosind operatorul ternar ( conditie ? a : b ), declara
        // o variabila string `semn` care sa fie "pozitiv" sau
        // "negativ" si afiseaza:
        //   X este Y
        //
        // Exemplu output (daca numar = -5):
        //   -5 este negativ
        // ============================================================

        // TODO
    }

    public static void Cond12()
    {
        // ============================================================
        // CONDITIONAL 12 - PRET CU REDUCERE
        // ============================================================
        // Declara doua variabile:
        //   double pretInitial
        //   bool   areCard
        // Calculeaza pretul final dupa regula:
        //   - daca are card SI pretul initial > 200 -> reducere 30%
        //   - daca are card                          -> reducere 20%
        //   - altfel                                  -> reducere 10%
        // Afiseaza pretul final cu 2 zecimale:
        //   Pret final: X.XX
        //
        // Exemplu output (daca pretInitial = 250.0, areCard = true):
        //   Pret final: 175.00
        // ============================================================

        // TODO
    }
}
