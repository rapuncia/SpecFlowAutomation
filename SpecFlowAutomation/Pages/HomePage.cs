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
        private string MainMenuItemXpath = "//div/header/div[5]/div//nav/div[1]//div[1]/ul/li[1]/a";
    }
}
