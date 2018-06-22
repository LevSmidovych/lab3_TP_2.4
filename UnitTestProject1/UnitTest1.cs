using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        workWithArray testClass = new workWithArray();

        [TestMethod]
        public void checkNumTrue()
        {
            bool expected = true;
            bool actual = testClass.checkNum("1765");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkNumFalse()
        {
            bool expected = false;
            bool actual = testClass.checkNum("u78i");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void СcheckNumTrue()
        {
            bool expected = true;
            bool actual = testClass.checkNum("7446");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void СcheckNumFalse()
        {
            bool expected = false;
            bool actual = testClass.checkNum("29741");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkAll0()
        {
            int expected = 0;
            int actual = testClass.checkAll("xyz","13","6153");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkAll1()
        {
            int expected = 1;
            int actual = testClass.checkAll("2871", "735", "6173");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkAll2()
        {
            int expected = 2;
            int actual = testClass.checkAll("851", "", "778");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkAll3()
        {
            int expected = 3;
            int actual = testClass.checkAll("57", "2890", "7738");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkAll4()
        {
            int expected = 4;
            int actual = testClass.checkAll("57", "63", "77y8");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkAll5()
        {
            int expected = 5;
            int actual = testClass.checkAll("57", "493", "8734");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkAll6()
        {
            int expected = 6;
            int actual = testClass.checkAll("57", "473", "225");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void checkAll7()
        {
            int expected = 7;
            int actual = testClass.checkAll("57", "225", "473");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void getArr()
        {
            int[] expectedArr = {999999, 6};
            int[] actualArr = testClass.getArr("57", "473", "225");
            for (int i = 0; i < 2; i++)
            {
                int expected = expectedArr[i];
                int actual = actualArr[i];
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void op1()
        {
            string C = "3";
            testClass.arraySize = 5;
            testClass.array = new int[] {1, 2, 3, 4 ,5 };
            string expected = "Сумма чисел больших 3 равна 3\nСумма чисел меньших 3 равна 9";
            string actual = testClass.firstOp(C);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void op2()
        {
            testClass.arraySize = 5;
            testClass.array = new int[] { 4, 3, 1, 5, 2 };
            int[] expectedArr = {5, 4, 3, 2, 1 };
            int[] actualArr = testClass.secondOp();
            for (int i = 0;i < 5;i++) {
                int expected = expectedArr[i];
                int actual = actualArr[i];
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void op3True()
        {
            testClass.arraySize = 5;
            testClass.array = new int[] { 241, 548, 3588, 4553, 540 };
            string expected = "Количество чисел у которых число составленное из двух первых цифер которых нечетна 3 Сумма этих чисел 1321";
            string actual = testClass.thirdOp("3");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void op3False()
        {
            testClass.arraySize = 5;
            testClass.array = new int[] { 1, 2, 3, 4, 5 };
            string expected = "С не соосвествует формату";
            string actual = testClass.thirdOp("q45q");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void op4()
        {
            testClass.arraySize = 5;
            testClass.array = new int[] { 841, 2, 533, 249, 35 };
            string expected = "Количество чисел у которых число составленное тз двух первых цифер которых четна 3 Сумма этих чисел 1092";
            string actual = testClass.foursOp();
            Assert.AreEqual(expected, actual);
        }
    }
}
