using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Ministrytesting.Drivers;
using Ministrytesting.Pages;
using OpenQA.Selenium.DevTools.V106.Browser;
using TechTalk.SpecFlow;

namespace Ministrytesting.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions : BaseDriver
    {
        Webclass w;

        [Given(@"Navigate to url")]
        public void GivenNavigateToUrl()
        {
            launch();
        }

        [When(@"Click on join now")]
        public void WhenClickOnJoinNow()
        {
            w = new Webclass(driver);
            w.Joinnow.Click();
        }

        [When(@"Fill the SignUp text fields")]
        public void WhenFillTheSignUpTextFields()
        {
            w = new Webclass(driver);
            w.Name.SendKeys("Megha M"); 
            w.Email.SendKeys("Meghana11@gmail.com");
            w.Username.SendKeys("Megha11");
            w.Password.SendKeys("Megha@23");
            w.ConfrimPassword.SendKeys("Megha@23");
            w.Checkbox.Click();
            w.Signup.Click();
        }

        [Then(@"Signup page should display")]
        public void ThenSignupPageShouldDisplay()
        {
            close();
        }

        [When(@"Click on SignIn")]
        public void WhenClickOnSignIn()
        {
            w = new Webclass(driver);
            w.SignIn.Click();
        }

        [Then(@"SignIn page should display")]
        public void ThenSignInPageShouldDisplay()
        {
            close();
        }

        [When(@"Click on Learn")]
        public void WhenClickOnLearn()
        {
            w = new Webclass(driver);
            w.Learn.Click();
        }

        [Then(@"Learn page should display")]
        public void ThenLearnPageShouldDisplay()
        {
            close();
        }

        [When(@"Click on Events")]
        public void WhenClickOnEvents()
        {
            w = new Webclass(driver);
            w.Events.Click();
        }

        [Then(@"Events page should dispplay")]
        public void ThenEventsPageShouldDispplay()
        {
            close();
        }

        [When(@"Click on discussions")]
        public void WhenClickOnDiscussions()
        {
            w = new Webclass(driver);
            w.discussions.Click();
        }

        [Then(@"Discussions page should display")]
        public void ThenDiscussionsPageShouldDisplay()
        {
            close();
        }



    }
}
