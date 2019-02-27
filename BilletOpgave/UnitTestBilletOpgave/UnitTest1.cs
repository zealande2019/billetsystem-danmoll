using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;

namespace UnitTestBilletOpgave
{
    [TestClass]
    public class UnitTest1
    {
        //Universal Arrange
        BilClass Bil = new BilClass();
        MCClass MC = new MCClass();

        [TestMethod]
        public void TestMethodBilPris()
        {
            //Arrange
            var result = Bil.Pris();

            //Act

            //Assert
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TestMethodBilK�ret�j()
        {
            //Arrange
            var result = Bil.K�ret�j();

            //Act

            //Assert
            Assert.AreEqual("Bil", result);
        }
        [TestMethod]
        public void TestMethodMCPris()
        {
            //Arrange
            var result = MC.Pris();
            //Act
            //Assert
            Assert.AreEqual(125, result);
        }
        [TestMethod]
        public void TestMethodMCK�ret�j()
        {
            //Arrange
            var result = MC.K�ret�j();
            //Act
            //Assert
            Assert.AreEqual("MC", result);
        }
        //[TestMethod]
        //public void TestMethodBroBizz()
        //{
        //    //Arrange
        //    List<BilletDLL> BilList = new List<BilletDLL>();
        //    BilList.Add(Bil);
        //    //Act
        //    //Assert
        //}
    }
}
