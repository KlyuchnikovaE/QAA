﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.ru");
            IWebElement findEdit = driver.FindElement(By.Id("lst-ib"));
            findEdit.Click();
            findEdit.SendKeys("Симбирсофт");
          
        }
    }
}
