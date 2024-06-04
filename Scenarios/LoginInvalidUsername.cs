using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Assert.Equals(Config.AlertsMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.InValid.Username.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.Equals(Config.AlertsMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}