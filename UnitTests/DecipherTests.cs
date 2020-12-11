using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProjectWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalProjectWPF.Tests
{
    [TestClass()]
    public class VigenereDecipherTest
    {
        [TestMethod()]
        public void DecipherTest()
        {
            var exePath = AppDomain.CurrentDomain.BaseDirectory;

            //arrange
            var path = Path.Combine(exePath, "Texts\\МойИсходный.txt");
            string expectedText = File.ReadAllText(path, Encoding.GetEncoding(1251));

            //act
            path = Path.Combine(exePath, "Texts\\МойЗашифрованный.txt");
            string actualText = VigenereCipher.Decipher(File.ReadAllText(path, Encoding.Default), "скорпион");

            //assert
            Assert.AreEqual(expectedText, actualText);
        }
    }
}