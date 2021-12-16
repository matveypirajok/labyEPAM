using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public class AuthorizationPageObject
    {
        private IWebDriver _webDriver;
        private By LoginInput = By.XPath("//input[@name = 'email']");
        private By PasswordInput = By.XPath("//input[@name = 'password']");
        private By LoginBtn = By.XPath("//button[@class = 'button-main l_btn']");
        public AuthorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public TradingPageObject Login(string login, string password)
        {
            System.Threading.Thread.Sleep(1000);
            _webDriver.FindElement(LoginInput).SendKeys(login);
            System.Threading.Thread.Sleep(1000);
            _webDriver.FindElement(PasswordInput).SendKeys(password);
            System.Threading.Thread.Sleep(1000);
            _webDriver.FindElement(LoginBtn).Click();
            return new TradingPageObject(_webDriver);
        }
    }
}
