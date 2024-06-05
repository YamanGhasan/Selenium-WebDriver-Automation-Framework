using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

 

namespace setupEnviroment.Scenarios
{
    public class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases();
        }

        [Test]
        public void LessThan5Chars()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.InValid.Password.FourCharacters,
                Config.Credentials.InValid.Password.FourCharacters);
            Thread.Sleep(1000);

            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            ClassicAssert.AreEqual(Config.AlertsMessages.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();

        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.InValid.Password.ThirteenCharacters, Config.Credentials.InValid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            ClassicAssert.AreEqual(Config.AlertsMessages.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
