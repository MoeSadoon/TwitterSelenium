using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterSelenium
{
    class ProfilePage
    {
        public ProfilePage()
        {
            PageFactory.InitElements(Collections.driver, this);
        }

        [FindsBy(How = How.Name, Using = "tweet")]
        public IWebElement TweetBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.primary-btn.tweet-action.tweet-btn.js-tweet-btn")]
        public IWebElement TweetBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a.Icon.Icon--close.Icon--medium.dismiss")]
        public IWebElement CloseAlert { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.ProfileTweet-actionButton.u-textUserColorHover.dropdown-toggle.js-dropdown-toggle")]
        public IWebElement TweetOptions { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.js-actionDelete")]
        public IWebElement DeleteBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.primary-btn.delete-action")]
        public IWebElement FinalDeleteBtn { get; set; }




        public void PostTweet(string tweet)
        {
            TweetBox.SendKeys(tweet);
            TweetBtn.Click();
        }

        public void DeleteTweet()
        {
            //Wait for TweetOptions button to be available
            WebDriverWait wait = new WebDriverWait(Collections.driver, TimeSpan.FromSeconds(2));
            wait.Until(driver => TweetOptions.Displayed);
            
            TweetOptions.Click();
            DeleteBtn.Click();
            FinalDeleteBtn.Click(); 
        }
    }
}
