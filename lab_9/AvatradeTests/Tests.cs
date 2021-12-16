using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AvatradeTests.PageObject;

namespace AvatradeTests
{
    public class Tests
    {
        private IWebDriver _driver;

        private const string TestEmail = "testikiepamuch@gmail.com";
        private const string TestPassword = "12@3123123Gg";

        [SetUp]
        public void StartPageSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://capital.com/");
            _driver.Manage().Window.Maximize();
        }
        [Test]
        public void Login()
        {
            var main = new MainPageObject(_driver);
            main.Entrance().Login(TestEmail, TestPassword).TradeTest();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}