

using setupEnviroment.UIElements;

namespace setupEnviroment
{
    public static class Actions
    {

        public static void  InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);

        }
        public static void FillLoginForm(string username , string password,string repeatPassword)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordField.Clear();
            loginScenario.RepeatPasswordField.SendKeys(repeatPassword);
            loginScenario.LoginButton.Click();
        
    }
    }
}
