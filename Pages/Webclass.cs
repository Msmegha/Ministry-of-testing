using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ministrytesting.Drivers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Ministrytesting.Pages
{
    internal class Webclass : BaseDriver
    {
        public Webclass(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);  
        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"contextual-navigation\"]/li[2]/div/a")]
        public IWebElement Joinnow;
       
        [FindsBy(How = How.XPath, Using = "//*[@id=\"user_first_name\"]")]
        public IWebElement Name;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"user_email\"]")]
        public IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"user_username\"]")]
        public IWebElement Username;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"user_password\"]")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"user_password_confirmation\"]")]
        public IWebElement ConfrimPassword;

        [FindsBy(How = How.XPath, Using = " //*[@id=\"user_terms_accepted\"]")]
        public IWebElement Checkbox;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"submit\"]")]
        public IWebElement Signup;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"contextual-navigation\"]/li[1]/div/a")]
        public IWebElement SignIn;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"learnNav\"]")]
        public IWebElement Learn;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"eventNav\"]")]
        public IWebElement Events;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"eventNav\"]")]
        public IWebElement discussions;
    }
}
