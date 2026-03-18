using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace initiere
{
    internal class Exercitii
    {

        public static void Ex1()
        {

            //afisare

            Console.WriteLine("test");

        }
        //todo================tipruri de date in csharp
        //int ->numere intregi
        //char-->caracter
        //double-->numere in virgula mobila
        // string-->text
        // bool -->Adevarat sau fals
        //Obs!!! "3"+"2"=>"32" concatenare   3+2=>5   "3"+2=> "32"

        //todo: ATRIBUIREA
        // X=4 X DEVINE 4    x+=7; x devine 11 x+=7 este prescurtarea de la x=x+7

        //todo=====================operatori aritmetici
        /// <summary>
        ///   + adunare 
        ///   - scadere
        ///   * produs
        ///   /  cat  -> (int)5/2=>2
        ///           -> (double) 5/2=2.5
        ///       rest -> 5%2=1 => restul impartirii lui 5 la 2   123%10=>3 ultima cifra
        /// </summary>
        /// todo:=====================operatori de comparare si logici
        /// < mai mic <= mai mic sau egal
        /// > mai mare
        /// == egalitate
        /// != diferit
        /// && si 
        /// || sau  
        /// ! negatie
        /// todo:=======================instructiuni conditionale
        ///  ======if simplu
        ///  if(conditie){   
        ///      executa
        ///  }
        ///  ======if else
        ///  if(conditie){
        ///     instructiune ce este executata doar daca conditia este adevarata 
        ///   }else{ 
        ///    alta instructiune  doar daca conditia este falase
        ///   }
        ///   ======if else if inalantuire de if
        ///   if(conditie){]
        ///    executa1
        ///   }else if(conditia2){
        ///     executa2
        ///   }else if(conditia3{
        ///     execututa3
        ///   }else{
        ///   executa4
        ///     daca nu este nicio conditie adevarata 
        ///   }
        ///   todo:=================conversii
        ///   int x=7;
        ///   int y=2;
        ///   x/y=>3
        ///   (double)(x/y)=>3.5
        ///    char t='a'
        ///    af t=>a
        ///    af (int)t=>97
        public static void Ex2()
        {
            //declarare si afisare

            int x = 12; //  lui x i-am atribuit valoarea 12

            x = 9;// o variabila retine ultima valoare atribuita

            Console.WriteLine(x);
            Console.WriteLine("x="+x);
        }
        public static void Ex3()
        {
            int numarGaini = 15;
            int numarPisici = 3;

            int totalPicioare = (numarGaini * 2) + (numarPisici * 4) + 2;

            string solutie = "In curte avem " + numarGaini + " gaini " + numarPisici + " pisici si un om ,numarul total de picioare este " + totalPicioare;
            //Console.WriteLine("In curte avem 5 gaini,3 pisici si un om, totalul este : " + totalPicioare);
            Console.WriteLine(solutie);

            string solutie2 = "In curte avem \n";
            solutie2 += "pisici " + numarPisici + "\n";
            solutie2 += "gaini " + numarGaini + "\n";
            solutie2 += "1 om" + "\n";
            solutie2 += "total picioare in curte " + totalPicioare;

            Console.WriteLine(solutie2);
        }
        public static void Ex4()
        {
            int x = 123;
            int y = 349;

            int suma = x + y;
            int ultimaCifra = suma % 10;

            string solutie = "Suma este" + suma + "\n" + "ultima cifra" + ultimaCifra;
            Console.WriteLine(solutie);
        }
        public static void Ex6()
        {
            int a = 5;
            int b = 2;
            int c = 2;
            string valoare = "a = " + a + "\n" + "b = " + b + "\n" + "c= " + c;
            Console.WriteLine("Inainte ");
            Console.WriteLine(valoare);
            c = a; // c devine val din a 
            a = b; // a devine val din b
            b = c; // b devine val din c

            valoare = "a = " + a + "\n" + "b = " + b + "\n" + "c= " + c;

            Console.WriteLine("Dupa ");
            Console.WriteLine(valoare);
        }
        public static void Ex8()
        {
            int a =16;
            int b = 32;
            int k = 4;

            if (a % k == 0 && b % k == 0)
            {
                Console.WriteLine($"{a/k}/{b/k}");
            }
            else
            {
                Console.WriteLine("nu se poate simplifica");
            }
        }
        public static void Ex9()
        {
            int zi = 4;

            if (zi > 0 && zi <= 10)
            {
                Console.WriteLine("prima decada");
            }
            else if (zi > 10 && zi <= 20)
            {
                Console.WriteLine("a doua decada");
            } else {            
                Console.WriteLine("a treia decada");
            }
        }
        public static void Ex16()
        {

            char x = 'A';
            string text = "assadas ";

            //VERIFICARE DACA ESTE LISTERA MARE ?

            if (x >= 'A' && x <= 'Z')
            {
                x =(char)( x + 32);
            }


             if (x == 'a' || x == 'e'|| x == 'i' || x == 'o' || x== 'u')
             {
                Console.WriteLine(x+" este vocala");
             }       
             else if(x>='a'&&x<='z')
             {
                Console.WriteLine(x+"este consoana");
            }
            else
            {
                Console.WriteLine("nu este caracter valid");
            }

        }
    }
}
