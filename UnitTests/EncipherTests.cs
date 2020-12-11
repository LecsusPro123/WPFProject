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
    public class VigenereEncipherTest
    {
        [TestMethod()]
        public void EncipherTest()
        {
            var exePath = AppDomain.CurrentDomain.BaseDirectory;

            //arrange
            var path = Path.Combine(exePath, "Texts\\МойЗашифрованный.txt");
            string expectedText = File.ReadAllText(path, Encoding.GetEncoding(1251));

            //act
            path = Path.Combine(exePath, "Texts\\МойИсходный.txt");
            string actualText = VigenereCipher.Encipher(File.ReadAllText(path, Encoding.Default), "скорпион");

            //assert
            Assert.AreEqual(expectedText, actualText);
        }
    }
}