using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public class MainPageObject
    {
        private IWebDriver _webDriver;
        private By EntranceBtn = By.XPath("//a[@class = 'button-main ln-auto stroke-white']");
        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public AuthorizationPageObject Entrance()
        {
            _webDriver.FindElement(EntranceBtn).Click();
            return new AuthorizationPageObject(_webDriver);
        }
    }
}
