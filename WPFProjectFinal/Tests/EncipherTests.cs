using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFProjectFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFProjectFinal.Tests
{
    [TestClass()]
    public class EncipherTests
    {
        [TestMethod()]
        public void EncipherTest()
        {
            //arrange
            var path = "Texts\\МойЗашифрованный.txt";
            string expectedText = File.ReadAllText(path, Encoding.GetEncoding(1251));
            
            //act
            path = "Texts\\МойИсходный.txt";
            string actualText = VigenereCipher.Encipher(File.ReadAllText(path, Encoding.Default), "скорпион");

            //assert
            Assert.AreEqual(expectedText, actualText);
        }
    }
}