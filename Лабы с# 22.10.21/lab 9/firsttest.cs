using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab9;
namespace BankTest
{
    [TestClass]
    public class firsttest
    {
        [TestMethod]
        public void pl_sec___59_59_59___1()
        {
            Time a = new Time(59, 59, 59);
            Time b = a.pl_sec(1);
            int c = b.Hours;
            Assert.AreEqual(60, c);
        }
        [TestMethod]
        public void implicit__zero()
        {
            Time a = new Time();
            bool b = (bool)a;
            Assert.AreEqual(true, b);
        }
        [TestMethod]

        public void post_plus()
        {
            Time a = new Time(59,59,0);
            a++;
            Assert.AreEqual(60, a.Hours);
        }
        [TestMethod]

        public void post_minus_60_0_0()
        {
            Time a = new Time(60, 0, 0);
            a--;
            a--;
            Assert.AreEqual(58, a.Minutes);
        }
        [TestMethod]

        public void post_minus_0_0_0()
        {
            Time a = new Time(0, 0, 0);
            a--;
            a--;
            Assert.AreEqual(0, a.Minutes);
        }
        [TestMethod]

        public void op_plus_59_59_59__0_0_1()
        {
            Time a = new Time(59, 59, 59);
            Time b = new Time(0, 0, 1);
            b = b + a;
            Assert.AreEqual(60, b.Hours);
        }
        [TestMethod]

        public void op_plus_59_59_59__1()
        {
            Time a = new Time(59, 59, 59);
            int b = 1;
            a = b + a;
            Assert.AreEqual(60, a.Hours);
        }
        [TestMethod]

        public void op_plus_59_59_59__1_revers()
        {
            Time a = new Time(59, 59, 59);
            int b = 1;
            a = a+b;
            Assert.AreEqual(60, a.Hours);
        }
        [TestMethod]

        public void op_minus_60_0_0__1()
        {
            Time a = new Time(60, 0, 0);
            int b = 1;
            a =  a-b;
            Assert.AreEqual(59, a.Hours);
        }
        [TestMethod]

        public void midl_Fract()
        {
            
           // Assert.AreEqual(59, a.Hours);
        }

    }
   

    
}
