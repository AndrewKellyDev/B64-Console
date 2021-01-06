using Base64.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64.View
{
    class Decode
    {
        public static void decodeToString()
        {
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
            Console.Write("\n\nPlease Enter The Text You Wish To Decode:");
            string dataToDecode = Console.ReadLine();

            //Creates A New Variable Named normalText and send it to the Decode Base64 Funtion
            //Where it gets decoded and sent back
            string normalText = HashManager.Base64Decode(dataToDecode);

            //Using $ before a string allows you to use the {} and put a variable
            //This saves u having to do something like "Your Decoded Hash Is:" + normalText
            Console.WriteLine($"Your Decoded Hash Is: {normalText}");
            Console.ReadLine();

            //Once User Clicks Enter it will return them to the menu
            HomeMenu.Menu();

        }
    }
}
