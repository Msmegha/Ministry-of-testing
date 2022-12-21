using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Ministrytesting.Drivers
{
    public class BaseDriver
    {
        public IWebDriver driver;

        public void launch()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ministryoftesting.com/");
        }

        public void close()
        {
            driver.Quit();
        }
    }
}
