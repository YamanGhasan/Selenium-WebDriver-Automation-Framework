using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
 

namespace setupEnviroment.UIElements
{
    public class TestCasesPage
    {

        public TestCasesPage()
    {
        PageFactory.InitElements(Driver.driver, this);
    }

    [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div.mh-loop-content.clearfix > header > h3 > a")]
    public IWebElement UsernameCase { get; set; }
}
}
