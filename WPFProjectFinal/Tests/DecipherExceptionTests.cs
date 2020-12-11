using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace WPFProjectFinal.Tests
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
            var path = "Texts\\МойЗашифрованный.txt";
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
