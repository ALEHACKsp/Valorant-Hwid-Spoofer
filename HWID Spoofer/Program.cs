using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWID_Spoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Nigger Mode";
            Misc.DrawASCII();
            Misc.HashText("Bem vindo a essa bosta kjkksks");
            Misc.HashText("Aperta qualquer tecla ai poha");
            Console.ReadKey();
            Console.Clear();
            Misc.DrawASCII();
            Misc.OptionText("spoof");
            Misc.OptionText("clean");
            Misc.HashText("Option :");
            var option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Misc.DrawASCII();
                Misc.HashText("Mudando o hwid");
                Spoof.SpoofHDD();
                Misc.HashText("Pronto mudei :)");
                Console.ReadKey();

            }
            else if (option == "2")
            {
                Console.Clear();
                Misc.DrawASCII();
                Misc.HashText("Cleaning Traces!");
                Spoof.CleanTraces(@"C:\Users\Raymond Shell\Pictures\mapper.exe");
                Misc.HashText("Cleaned Traces!");
                Console.ReadKey();

            }
            else
            {
                Misc.HashText("Tem apenas 2 opcao seu animal :sunglasses:");
            }
        }
    }
}
