using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace CalcoloCombinatori.tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(5,120)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(10, 3628800)]
        [DataRow(20, 2432902008176640000)]
        public void TestFattoriale(int num,long fattaspett)
        {
            long  fattoriale = CalcoliCombinatori.IsFattoriale(num);
            Assert.AreEqual(fattaspett, fattoriale);
                
          
        }
    }
}
