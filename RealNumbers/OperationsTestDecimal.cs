using NUnit.Framework;

namespace RealNumbers
{
   [TestFixture]
   public class OperationsTestDecimal
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
      public void TestAdd_Signs()
      {
         var numbers = new[] {"-1.01", "1.02"};
         var operations = new Operations();
         var retVal = operations.AddNumbersDecimal(numbers);
         
         Assert.AreEqual(retVal, "0.01");
      }
      
      [Test]
      public void TestAdd_Condingame()
      {
         var numbers = new[] {"-1.001", "1.01"};
         var operations = new Operations();
         var retVal = operations.AddNumbersDecimal(numbers);
         
         Assert.AreEqual(retVal, "0.009");
      }

      [Test]
      public void TestAdd_Five()
      {
         var numbers = new[] {"-1.00001", "1.0001"};
         var operations = new Operations();
         var retVal = operations.AddNumbersDecimal(numbers);
         
         Assert.AreEqual(retVal, "0.00009");
      }

      [Test]
      public void TestAdd_28th()
      {
         var numbers = new[] {"-1.0000000000000000000000000001", "1.0001"};
         var operations = new Operations();
         var retVal = operations.AddNumbersDecimal(numbers);
         
         Assert.AreEqual(retVal, "0.0000999999999999999999999999");
      }

      [Test]
      public void TestAdd_29th_Fail()
      {
         var numbers = new[] {"-1.00000000000000000000000000001", "1.0001"};
         var operations = new Operations();
         var retVal = operations.AddNumbersDecimal(numbers);
         
         Assert.AreEqual(retVal, "0.00009999999999999999999999999");
      }
   }
}