using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterSelenium
{
    public static class IWebDriverExtensions
    {
        public static void WaitForElement(this IWebDriver driver, IWebElement element, int timeInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(Collections.driver, TimeSpan.FromSeconds(timeInSeconds));
            wait.Until(drv => element.Displayed);
        } 
    }
}
