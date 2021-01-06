using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64.View
{
    class HomeMenu
    {
        public static void Menu() {

            Console.Clear();

            //Sets the title of the application
            Console.Title = "Base 64 Encode / Decode Utility";

            Console.WriteLine(@"
   ___  __   _  _           _   _ _ 
  / __\/ /_ | || |    /\ /\| |_(_) |
 /__\// '_ \| || |_  / / \ \ __| | |
/ \/  \ (_) |__   _| \ \_/ / |_| | |
\_____/\___/   |_|    \___/ \__|_|_|");


            //Writes Out Console Menu \n = New Line to leave some spacing inbetween
            Console.WriteLine("\n\n(Made By Andrew)");
            Console.WriteLine("\n\n1: Encode Text To Base64");
            Console.WriteLine("2: Decode Base64 To Text");
            Console.Write("\nPlease Select A Option: ");
            //Gets User Input
            int option = Convert.ToInt32(Console.ReadLine());

            //Validates User Input And If It Out Of Bounds Clears The Console And Rewrites Menu
            if (option == 1)
            {
                Encode.EncodeToBase64();
            }
            else if (option == 2)
            {
                Decode.decodeToString();
            }
            else
            {
                HomeMenu.Menu();
            }







        }
    }
}
