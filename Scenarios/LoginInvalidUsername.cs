using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
 

namespace setupEnviroment.Scenarios
{
    public class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases();
        }

        [TestCase]
        public void LessThan5Chars()
        {
            NavigateTo.LoginFormScenarioThroughMenu();
            Actions.FillLoginForm(Config.Credentials.InValid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            ClassicAssert.AreEqual(Config.AlertsMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.InValid.Username.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            ClassicAssert.AreEqual(Config.AlertsMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
