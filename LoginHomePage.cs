using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitterSelenium
{
    class LoginHomePage
    {

        public LoginHomePage()
        {
            PageFactory.InitElements(Collections.driver, this);
        }      

        [FindsBy(How = How.CssSelector, Using = ".js-username-field.email-input.js-initial-focus")]
        public IWebElement UserNameTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".js-password-field")]
        public IWebElement PasswordTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.submit.btn.primary-btn")]
        public IWebElement LoginBtn { get; set; }


        //Login method for page object
        public ProfilePage Login(string username, string password)
        {           
            UserNameTxt.SendKeys(username);            
            PasswordTxt.SendKeys(password);
            LoginBtn.Click();

            return new ProfilePage(); 
        }
    }

  
}
