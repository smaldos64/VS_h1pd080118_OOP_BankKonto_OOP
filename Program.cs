using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKonto_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount.BankName = "Roskilde Bank";
            BankAccount.BankName = "h1pd080118 Bank";
            // Da BankName i klassen BnkAccount er defineret som en statisk variabel
            // (en statisk variabel er en der virker på klassen og ikke på de enkelte 
            // objekter af klassen !!!), skal jeg følgelig arbejde direkte på klassen 
            // og ikke på et objekt af klassen.

            BankAccount bankAccount_obj = new BankAccount();
            // Her opretter jeg et objekt af klassen BankAccount, der anvender default
            // constructor for BankAccount klassen.

            //bankAccount_obj.setKontoNummer(12345);
            bankAccount_obj.KontoNummer = 12345;
            bankAccount_obj.setName("Joakim Von And");
            bankAccount_obj.deposit(12345678.5);
            PrintAccountInfo(bankAccount_obj);

            BankAccount bankAccount_obj_Mathias = new BankAccount();
            // Her opretter jeg et objekt af klassen BankAccount, der anvender default
            // constructor for BankAccount klassen.

            //bankAccount_obj_Mathias.setKontoNummer(54321);
            bankAccount_obj_Mathias.KontoNummer = 54321;
            bankAccount_obj_Mathias.setName("Mathias Von Græsholt");
            bankAccount_obj_Mathias.deposit(1000);
            bankAccount_obj_Mathias.withdraw(1200);
            bankAccount_obj_Mathias.withdraw(200);
            PrintAccountInfo(bankAccount_obj_Mathias);

            bankAccount_obj_Mathias.deposit(5000);
            PrintAccountInfo(bankAccount_obj_Mathias);

            BankAccount bankAccount_obj_Martin = new BankAccount("Martin", 300, 43345);
            // Her opretter jeg et objekt af klassen BankAccount, der anvender den
            // constructor for BankAccount klassen, som overloader default constructoren
            // for BankAcount klassen.

            bankAccount_obj_Martin.KontoNummer = 800;
            bankAccount_obj_Martin.KontoNummer = 1200;

            BankAccount bankAccount_obj_Malthe;
            bankAccount_obj_Malthe = bankAccount_obj_Martin;

            PrintAccountInfo(bankAccount_obj_Martin);
            PrintAccountInfo(bankAccount_obj_Malthe);

            bankAccount_obj_Malthe.setName("Malthe");
            PrintAccountInfo(bankAccount_obj_Martin);
            PrintAccountInfo(bankAccount_obj_Malthe);

            bankAccount_obj_Malthe = bankAccount_obj_Mathias;
            PrintAccountInfo(bankAccount_obj_Martin);
            PrintAccountInfo(bankAccount_obj_Malthe);

            Console.ReadLine();
        }

        private static void PrintAccountInfo(BankAccount bankAccount_obj)
        {
            Console.WriteLine("Konto oplysninger for : {0}. Der er kunde i {1}", bankAccount_obj.getName(), BankAccount.BankName);
            //Console.WriteLine("Konto Nummer : {0}", bankAccount_obj.getKontoNummer());
            Console.WriteLine("Konto Nummer : {0}", bankAccount_obj.KontoNummer);
            Console.WriteLine("Indestående på Konto : {0}", bankAccount_obj.getIndesaaende());
            Console.WriteLine("");
        }

    }
}
