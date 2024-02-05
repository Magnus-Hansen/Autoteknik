using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class CarRegNoValidator : IValidator
    {
        //public bool Validate(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return false;

        //    if (input.Length > 4 && input.Length < 8)
        //    {
        //        if (char.IsUpper(input[0]) && char.IsUpper(input[1]))
        //        {
        //            for (int i = 2; i < input.Length; i++)
        //            {
        //                if (!char.IsDigit(input[i]))
        //                    return false;
        //            }
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        public bool Validate(string input)
        {
            string pattern = @"^[A-Z]{2}\d{3,5}$";

            return Regex.IsMatch(input, pattern);
        }
        /*
         Hvilket regulære udtryk kan jeg anvende til at validere en dansk bils registreringsnummer som skal starte med 2 store bogstaver og have mellem 3 til 5 tal

         kan du lave det i c#
        
        kan du forklare det dannede regulære udtryk
         
        ^: Dette anker sikrer, at matchningen starter fra begyndelsen af strengen.
        [A-Z]{2}: Dette matcher præcist to store bogstaver i rækkefølge. A-Z specificerer, at bogstaverne skal være store, og {2} angiver, at der skal være præcis to af dem.
        \d{3,5}: Dette matcher mellem 3 og 5 tal. \d repræsenterer ethvert decimaltal (0-9), og {3,5} specificerer, at der skal være mellem 3 og 5 tal.
        $: Dette anker sikrer, at matchningen slutter ved slutningen af strengen.
         
         */
    }
}
