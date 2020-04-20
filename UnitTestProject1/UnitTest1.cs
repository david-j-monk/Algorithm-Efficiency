using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoithmEfficiencyClassLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private decimal n = 1000000;
        [TestMethod]
        public void AlgoTestA()
        {
            AlgoTesting testA = new AlgoTesting();

            AlgoTesting.methodtotestA(n);
            
        }
        [TestMethod]
        public void AlgoTestB()
        {
            AlgoTesting testB = new AlgoTesting();

            AlgoTesting.methodtotestB(n);
        }
    }
}
