using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

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
            Assert.Equals(Config.AlertsMessages.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();

        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.InValid.Password.ThirteenCharacters, Config.Credentials.InValid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.Equals(Config.AlertsMessages.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}