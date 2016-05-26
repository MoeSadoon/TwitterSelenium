using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwitterSelenium
{
    public enum Drivers
    {
        Chrome,
        FireFox,
        IE,
        Opera,
        Safari
    }

    public static class Driver
    {
        public static void StartUp(Drivers driver)
        {
            //The path where my project solution and hence webdrivers are found, replace accordingly
            string path = @"C:\Users\Moe Sadoon\Documents\Visual Studio 2015\Projects\Selenium\TwitterSelenium";

            switch (driver)
            {
                case Drivers.Chrome:
                    Collections.driver = new ChromeDriver(path);
                    break;

                case Drivers.FireFox:
                    Collections.driver = new FirefoxDriver();
                    break;

                case Drivers.IE:
                    Collections.driver = new InternetExplorerDriver(path);
                    break;

                case Drivers.Opera:
                    Collections.driver = new OperaDriver(path);
                    break;

                case Drivers.Safari:
                    Collections.driver = new SafariDriver();
                    break;
            }

        }
    }
}
