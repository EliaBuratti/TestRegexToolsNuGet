using RegexMultiTools;
using System.Text.RegularExpressions;

namespace TestRegexToolsNuGet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //first tool
            Console.WriteLine("Primo tool");
            Console.WriteLine("inserisci un indirizzo email:");
            string email = Console.ReadLine();

            Console.WriteLine("L'indirizzo email è {0}", RegexMultiTools.Tool.IsValidEmail(email) ? "corretto" : "errato");

            Console.WriteLine("\n\n");


            //second tool
            Console.WriteLine("Secondo tool");
            string MyDetails = "Nome: Elia Cognome: Buratti";

            Console.WriteLine("Stringa di esempio: " + MyDetails);


            string patternDetails = @"Nome: (?<nome>\w+) Cognome: (?<cognome>\w+)";

            var match = RegexMultiTools.Tool.FindDetails(MyDetails);

            Console.WriteLine($"Il nome è: {match.Groups["nome"].Value} e il cognome è: {match.Groups["cognome"]}");
            Console.WriteLine("\n\n");


            //third tool
            Console.WriteLine("Terzo tool");
            Console.WriteLine("Scrivi una frase:");
            string phraseInput = Console.ReadLine().ToLower();

            Console.WriteLine("Vuoi aggiungere delle parole da censurare? (Y/N)");
            bool choice = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

            string censorWords = "";

            if (choice)
            {
                Console.WriteLine("Scrivi delle parole che vuoi censurare.");
                censorWords = Console.ReadLine();
            }

            Console.WriteLine(RegexMultiTools.Tool.CensorBadWords(phraseInput, censorWords)); //if possible to disable default words
            Console.WriteLine("\n\n");

            //fourth tool
            Console.WriteLine("Quarto tool");
            Console.WriteLine("inserisci il codice fiscale:");
            string fiscalCode = Console.ReadLine().ToUpper();

            Console.WriteLine("Il codice fiscale è {0}", RegexMultiTools.Tool.CheckFiscalCode(fiscalCode) ? "corretto" : "errato");
            Console.WriteLine("\n\n");

            //fifth tool
            Console.WriteLine("Quinto tool");
            Console.WriteLine("inserisci una data in formato americano (MM/GG/YYYY)");
            string date = Console.ReadLine();

            Console.WriteLine(RegexMultiTools.Tool.ConvertToEUformat(date));

        }
    }
}
