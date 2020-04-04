using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace RealNumbers
{
   public class Operations
   {
      public string AddNumbersDecimal(string[] numbers)
      {
         decimal retVal = 0;
         foreach (var num in numbers)
         {
            retVal = retVal + decimal.Parse(num);
         }
         return retVal.ToString();
      }
     
      public string AddNumbersDouble(string[] numbers)
      {
         double retVal = 0;
         
         foreach (var num in numbers)
         {
            var d = double.Parse(num);
            retVal += d;
         }
         return retVal.ToString();
      }
     
      public string AddNumbersBigInteger(string[] numbers)
      {
         BigInteger retVal = 0;
         
         foreach (var num in numbers)
         {
            var d = BigInteger.Parse(num);
            retVal += d;
         }
         return retVal.ToString();
      }
   }
}