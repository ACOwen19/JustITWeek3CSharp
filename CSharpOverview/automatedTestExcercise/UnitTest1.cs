using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace automatedTestExcercise
{
    // To add test to a project go to references, r-click and select from the dropdown

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = errorHandlingExercises.AutomatedTest.CalculatorOne(4, 1);
            Assert.IsTrue(result == 5);
            //Should Succeed
           
        }
        [TestMethod]
        public void TestMethod2()
        {
            var result2 = errorHandlingExercises.AutomatedTest.CalculatorTwo(4, 1);
            Assert.IsTrue(result2 == 5);
            //Should Fail
        }
    }
}
