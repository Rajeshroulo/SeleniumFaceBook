﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Seleniumfacebook.TestDataAccess;

namespace facebook.PageObjects
{

    public class FbloginPage
    {

       public IWebDriver driver;

        public FbloginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);                      
        }

        [FindsBy(How = How.Id, Using = "email")]

        public IWebElement mail { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]

        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit'][@value ='Log In']")]

        public IWebElement loginButton { get; set; }

        public void Login()
        {
            mail.SendKeys(ExcelDataAccess.GetTestData("TestLoginAndLogout").email);
            password.SendKeys(ExcelDataAccess.GetTestData("TestLoginAndLogout").password);
            loginButton.Click();
        }

    }
}
