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
    public class DecipherNullStringExceptionTests
    {
        [TestMethod()]
        public void DecipherNullStringExceptionTest()
        {
            try
            {
                VigenereCipher.Decipher(null, "скорпион");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Введите исходный текст");
            }
        }
    }

    [TestClass()]
    public class DecipherEmptyStringExceptionTests
    {
        [TestMethod()]
        public void DecipherEmptyStringExceptionTest()
        {
            try
            {
                VigenereCipher.Decipher(string.Empty, "скорпион");
                //Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Введите исходный текст");
            }
        }
    }

    [TestClass()]
    public class DecipherKeyExceptionTests
    {
        [TestMethod()]
        public void DecipherKeyExceptionTest()
        {
            var exePath = AppDomain.CurrentDomain.BaseDirectory;
            var path = Path.Combine(exePath, "Texts\\МойЗашифрованный.txt");
            try
            {
                VigenereCipher.Decipher(File.ReadAllText(path, Encoding.Default), "cкорпион");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Неправильно ввели ключ");
            }
        }
    }
}