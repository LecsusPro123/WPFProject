using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProjectFinal.Tests
{
    [TestClass()]
    public class VigenereDecipherTest
    {
        [TestMethod()]
        public void DecipherTest()
        {
            //arrange
            var path = "Texts\\МойИсходный.txt";
            string expectedText = File.ReadAllText(path, Encoding.GetEncoding(1251));

            //act
            path = "Texts\\МойЗашифрованный.txt";
            string actualText = VigenereCipher.Decipher(File.ReadAllText(path, Encoding.Default), "скорпион");

            //assert
            Assert.AreEqual(expectedText, actualText);
        }
    }
}
