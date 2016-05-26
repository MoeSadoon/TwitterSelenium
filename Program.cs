using NUnit.Framework;
using OpenQA.Selenium;
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
            //This initializes the Collections.driver by assinging it the specified browser driver from the Drivers enum
            Driver.StartUp(Drivers.Chrome); // This equates to: Collections.driver = new ChromeDriver(@"C:\Users\Moe Sadoon\Documents\Visual Studio 2015\Projects\Selenium\TwitterSelenium");
         
            Collections.driver.Navigate().GoToUrl("https://twitter.com/login");
        }

        [Test]
        public void Execute()
        {
            //Initialise login page object
            LoginHomePage loginPage = new LoginHomePage();

            //Replace with your own Twitter credentials
            ProfilePage profilePage = loginPage.Login("Username","Password");

            //Post tweet from profile page
            profilePage.PostTweet("Hello this is my first automated tweet!");

            //Delete Tweet
            profilePage.DeleteTweet();
        }

       
    }
}
