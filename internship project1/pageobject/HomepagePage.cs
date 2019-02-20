using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship_project1.pageobject
{
    class HomepagePage
    {

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }
    }
}