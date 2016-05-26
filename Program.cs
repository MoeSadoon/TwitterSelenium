using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitterSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            //Collections.driver = new FirefoxDriver();
            Collections.driver = new ChromeDriver(@"C:\Users\Moe Sadoon\Documents\Visual Studio 2015\Projects\Selenium\TwitterSelenium");
            Collections.driver.Navigate().GoToUrl("https://twitter.com/login");
        }

        [Test]
        public void Execute()
        {
            //Initialise login page object
            LoginHomePage loginPage = new LoginHomePage();

            //Login method initialises profile page object
            ProfilePage profilePage = loginPage.Login("[YourUsername]","[YourPassword]");

            //Post tweet from profile page
            profilePage.PostTweet("Hello this is my first automated tweet!");

            Thread.Sleep(3000);

            //Delete Tweet
            profilePage.DeleteTweet();
        }

       
    }
}
