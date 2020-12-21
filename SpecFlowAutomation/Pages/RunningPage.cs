using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Pages
{
    class RunningPage : BasePage
    {
        private string TitleXPath => "//*[@id='global-page-header__title']/text()";

        private static RunningPage runningPage;
        public static RunningPage Instance => runningPage ?? (runningPage = new RunningPage());

        public bool IsPageTitleDisplayed()
        {
            return IsDisplayed(By.XPath(TitleXPath));
        }
    }
}
