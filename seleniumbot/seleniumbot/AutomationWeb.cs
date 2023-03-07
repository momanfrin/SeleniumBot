using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumbot
{
    public class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb()
        {
            driver = new ChormeDriver();
        }

        public void TestWeb()
        {
            driver.Navigate().GoToUrl("https://login.identity.nielseniq.com/oauth2/default/v1/authorize?client_id=0oa44adypuQ9Zv7Zf4x7&code_challenge=4-tDRB4szqTn_kAVc-Gu9pfaY3Un6iLG8Mqvm6f0R9M&code_challenge_method=S256&nonce=5yXogapo40xUXdQcdRpJLtltKBRsyTFxZtzadTJuGoI5xbb9Q8thU17jjDcoehyk&redirect_uri=https%3A%2F%2Fgateway.nielseniq.com%2Fhome%2Flogin%2Fcallback&response_type=code&state=CZca3dU1HV0Z7jPoqjVxKtOGH2c8aSRAb2DDVvKFbfewDX73G0cgsRj0BCJjKS4a&scope=openid%20profile%20email")
            driver.FindElement(By.Id("input27")).SendKeys("rnunes6");
            driver.FindElement(By.ClassName("button button-primary")).Click();
            driver.FindElement(By.Id("input60")).SendKeys("23!Odlanor23");
            driver.FindElement(By.ClassName("button button-primary")).Click();
        }
    }
}
