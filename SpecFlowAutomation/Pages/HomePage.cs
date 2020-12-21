using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Pages
{
    public class HomePage : BasePage
    {
        private string URL => "https://www.sportchek.ca/";
        private string MainMenuItemXpath => "//span[@class='main-menu__text']";
        private string SubMenuItemXpath => "//li[@class='page-nav__item']";

        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());
        public void OpenSportchekHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }

        public void HoverMainMenuItem(string item)
        {
            var actions = new Actions(DriverManager.Instance());
            var menuItem = FindElements(By.XPath(MainMenuItemXpath)).First(x => x.Text.Equals(item));
            actions.MoveToElement(menuItem).Perform();
        }

        public void ClickSubMenuItem(string item)
        {
            var subMenuItem = FindElements(By.XPath(SubMenuItemXpath)).First(x => x.Text.Equals(item));
            subMenuItem.Click();
        }
    }
}
////span[@class='main-menu__text'][text()='Women'] xPath women