using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_testing;
using System;
using System.Collections.Generic;

namespace MSTest_tesingpjt
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void BeforeClass(TestContext tx)
        {
            Console.WriteLine("This is before test class");
        }

        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("This is after test class");
        }

        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("This is before test method");
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("This is after test method");
        }

        [TestMethod]
        public void Test()
        {
            Console.WriteLine("This is test method"); //string  test
        }

        [TestMethod]
        public void TestMethod()
        {
            int x = 0;
            x = 5;
            Assert.IsTrue(x <= 5, "TestMethod1 has right:");
        }

        [TestMethod]
        public void TestMath1()
        {
            double num1 = 32;
            double num2 = 0;
            double result = MSTest_testing.Convert.Mth1(num1);
            Assert.AreEqual(num2, result);
            Assert.AreEqual(100, MSTest_testing.Convert.Mth1(212));
        }

        [TestMethod]
        public void TestMath2()
        {
            Assert.AreEqual(212, MSTest_testing.Convert.Mth2(100));
            Assert.AreEqual(32, MSTest_testing.Convert.Mth2(0));
        }

        [TestMethod]
        public void TestgetNewID()
        {
            var numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);
            int result = MSTest_testing.Convert.getNewID(numbers);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void TestGetPhoneNumberFormat()
        {
            string phno = "250006158";
            string phno1 = "09250006158";
            string phno2 = "+959250006158";
            string phno3 = "9250006158";
            string result = MSTest_testing.Convert.GetPhoneNumberFormat(phno); //wrong format
            string result1 = MSTest_testing.Convert.GetPhoneNumberFormat(phno1);
            string result2 = MSTest_testing.Convert.GetPhoneNumberFormat(phno2);
            string result3 = MSTest_testing.Convert.GetPhoneNumberFormat(phno3);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }

    }
}
