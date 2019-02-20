using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship_project1.pageobject
{
    class Registrationpage
    {
        private IWebDriver driver;

        public Registrationpage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstname { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "# signup-form > div.buttons-holder.text-center > button")]
        private IWebElement Signup { get; set; }

        internal void EnterFirstName()
        {
            throw new NotImplementedException();
        }

        public void ClickOnSignup()
        {
            Signup.Click();
        }

        public void ClickOnRegister()
        {
            register.Click();
        }
        public void enterfirstname()
        {
            firstname.SendKeys("Oluwaseun");
        }
        public void EnterEmailAddress(string myEmail)
        {
            emailAddress.SendKeys(myEmail);

        }

    }
}