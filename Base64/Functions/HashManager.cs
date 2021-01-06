using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64.Functions
{
    class HashManager
    {
        //Takes In A Value Of String and names the string base64EncodedData
        //It Converts the from Base64 to Plain Text And Returns The String 
        //In Base64
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }


        //Takes In A Value Of String and names the string plaintext
        //It Converts the string into Bytes And Returns The String 
        //In Base64
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

    }
}
