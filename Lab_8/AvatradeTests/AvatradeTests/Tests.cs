using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests
{
    public class Tests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private const string TestEmail = "testikiepamuch@gmail.com";
        private const string TestPassword = "12@3123123Gg";

        [SetUp]
        public void StartPageSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://capital.com/");
            _driver.Manage().Window.Maximize();

            var logInBtn = _driver.FindElement(By.XPath("//div[@class='banner__slider-btn--with-link']//div[@class='bannerBtns']//a[@class='button-main outlined-light rounded-lg ln-auto _demo showBannerBtns __cp_b __cp_bs']"));
            logInBtn.Click();

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var inputEmail = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='control-outline control-outline--input']//div[@class='control-form']//input[@class='field-form']")));
            inputEmail.SendKeys(TestEmail);

            var inputPassword = _driver.FindElement(By.XPath("//div[@class='control-outline control-outline--input']//div[@class='control-form']//input[@class='field-form']"));
            inputPassword.SendKeys(TestPassword);

            var submitBtn = _driver.FindElement(By.XPath("//button[@class='button-main s2_btn']"));
            submitBtn.Click();
        }

        [Test]
        public void CreateDealToBuyEURTest()
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            var selectCurrency = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[text()='EUR/JPY']"))); //по непонятной причине работает через раз
            selectCurrency.Click();

            var buyprikoli = _driver.FindElement(By
                .XPath("//button[@class='button-outlined button-outlined--small']"));
            buyprikoli.Click();

            var selectCurrencyy = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@class='button-main button-main--negative ng-star-inserted']")));
            selectCurrencyy.Click();

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}