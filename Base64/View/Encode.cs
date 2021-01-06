using Base64.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64.View
{
    class Encode
    {
        public static void EncodeToBase64() 
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
            Console.Write("\n\nPlease Enter The Text You Wish To Encode:");
            string dataToEncode = Console.ReadLine();

            //Creates A New Variable Named hashedText and send it to the Base64 Funtion
            //Where it gets encoded and sent back
            string hashedText = HashManager.Base64Encode(dataToEncode);

            //Using $ before a string allows you to use the {} and put a variable
            //This saves u having to do something like "Your Base64 Hash Is:" + hashedText
            Console.WriteLine($"Your Base64 Hash Is: {hashedText}");
            Console.ReadLine();

            //Once User Clicks Enter it will return them to the menu
            HomeMenu.Menu();

        }
    }
}
