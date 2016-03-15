using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ciphers.Test
{
    [TestClass]
    public class Caesar
    {
        [TestMethod]
        public void CipherTest()
        {
            string ciphertext = Ciphers.Caesar.Cipher("Hello World");
            Assert.AreEqual(ciphertext, "UryybJbeyq");
        }
    }
}
