﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class EncipherNullStringExceptionTests
    {
        [TestMethod()]
        public void EncipherNullStringExceptionTest()
        {
            try
            {
                VigenereCipher.Encipher(null, "скорпион");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Введите исходный текст");
            }
        }
    }

    [TestClass()]
    public class EncipherEmptyStringExceptionTests
    {
        [TestMethod()]
        public void EncipherEmptyStringExceptionTest()
        {
            try
            {
                VigenereCipher.Encipher(string.Empty, "скорпион");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Введите исходный текст");
            }
        }
    }

    [TestClass()]
    public class EncipherKeyExceptionTests
    {
        [TestMethod()]
        public void EncipherKeyExceptionTest()
        {
            var exePath = AppDomain.CurrentDomain.BaseDirectory;
            var path = Path.Combine(exePath, "Texts\\МойИсходный.txt");
            try
            {
                VigenereCipher.Encipher(File.ReadAllText(path, Encoding.Default), "cкорпион");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Неправильно ввели ключ");
            }
        }
    }
}