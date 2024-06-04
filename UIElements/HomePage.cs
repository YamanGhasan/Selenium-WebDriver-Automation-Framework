using OpenQA.Selenium;
 using SeleniumExtras.PageObjects;
using System.Runtime.CompilerServices;

namespace setupEnviroment.UIElements
{
    public class HomePage
    {
        public HomePage() {

            // create constructor to every class 
            PageFactory.InitElements(Driver.driver, this);

        }
        [FindsBy(How =How.CssSelector,Using = "#page-17 > header > h1")]
        public IWebElement  Headline { get; set; }

    }
    } 

