using NUnit.Framework;

namespace RealNumbers
{
   [TestFixture]
   public class OperationsTestBigInteger
   {
      [Test]
      public void TestAdd_Simple()
      {
         var numbers = new[] {"1.01", "1.02"};
         var operations = new Operations();
         var retVal = operations.AddNumbersDecimal(numbers);
         
         Assert.AreEqual(retVal, "2.03");
      }

      [Test]
      public void TestAdd_20digit()
      {
         var numbers = new[] {"-10000000000000000001", "1"};
         var operations = new Operations();
         var retVal = operations.AddNumbersBigInteger(numbers);
         
         Assert.AreEqual(retVal, "-10000000000000000000");
      }

      [Test]
      public void TestAdd_30digit()
      {
         var numbers = new[] {"-100000000000000000000000000001", "1"};
         var operations = new Operations();
         var retVal = operations.AddNumbersBigInteger(numbers);
         
         Assert.AreEqual(retVal, "-100000000000000000000000000000");
      }

      [Test]
      public void TestAdd_60digit()
      {
         var numbers = new[] {"-100000000000000000000000000000000000000000000000000000000001", "1"};
         var operations = new Operations();
         var retVal = operations.AddNumbersBigInteger(numbers);
         
         Assert.AreEqual(retVal, "-100000000000000000000000000000000000000000000000000000000000");
      }
   }
}