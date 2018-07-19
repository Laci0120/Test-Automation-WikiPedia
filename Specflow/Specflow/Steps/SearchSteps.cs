using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Specflow.Steps
{
    
    [Binding]
    public class SearchSteps
    {

        IWebDriver Driver = new FirefoxDriver();

        [Given(@"Navigate to the Wikipedia site")]
        public void GivenNavigateToTheWikipediaSite()
        {
            Driver.Navigate().GoToUrl("http://www.wikipedia.org");
        }

        [Given(@"Choose the English language")]
        public void GivenChooseTheEnglishLanguage()
        {
            Driver.FindElement(By.Id("js-link-box-en")).Click();
        }

        [Given(@"Search for Test Automation")]
        public void GivenSearchForTestAutomation()
        {
            Driver.FindElement(By.Id("searchInput")).SendKeys("Test Automation");
            Driver.FindElement(By.Id("searchButton")).Click();
        }

        [Given(@"Validate Unit testing text")]
        public void GivenValidateUnitTestingText()
        {
            Assert.That(Driver.PageSource.Contains("Unit testing"), Is.EqualTo(true), "The text Unit testing does not exist");
        }

        [Given(@"Search for Test Automation Interface Model picture")]
        public void GivenSearchForTestAutomationInterfaceModelPicture()
        {
            Assert.That(Driver.PageSource.Contains("Test_Automation_Interface.png"), Is.EqualTo(true), "Test Automation Interface Model picture does not exist");
        }

        [Given(@"Search for the link of Behavior driven development and navigate to there")]
        public void GivenSearchForTheLinkOfBehaviorDrivenDevelopmentAndNavigateToThere()
        {
            Driver.FindElement(By.XPath("//a[text()='Behavior driven development']")).Click();
        }

        [Then(@"I should see Behavior driven development Wikipedia page")]
        public void ThenIShouldSeeBehaviorDrivenDevelopmentWikipediaPage()
        {
            Console.WriteLine("The Test is completed");
        }

    }
}
