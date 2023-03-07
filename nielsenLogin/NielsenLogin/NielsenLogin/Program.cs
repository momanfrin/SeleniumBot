using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NielsenLogin
{
    class Program
    {
        public IWebDriver Page;
        public void Main(string[] args)
        {
            ChromeDriverService service;
            service = ChromeDriverService.CreateDefaultService();
            service.SuppressInitialDiagnosticInformation = true;
            service.HideCommandPromptWindow = true;
            ChromeOptions options;
            options = new ChromeOptions();
            options.AddArgument("--lang=pt-BR");
            Page = new ChromeDriver(service, options);
        }
        public void NielsenLogin()
        {
            string url = "https://login.identity.nielseniq.com/oauth2/default/v1/authorize?client_id=0oa44adypuQ9Zv7Zf4x7&code_challenge=4-tDRB4szqTn_kAVc-Gu9pfaY3Un6iLG8Mqvm6f0R9M&code_challenge_method=S256&nonce=5yXogapo40xUXdQcdRpJLtltKBRsyTFxZtzadTJuGoI5xbb9Q8thU17jjDcoehyk&redirect_uri=https%3A%2F%2Fgateway.nielseniq.com%2Fhome%2Flogin%2Fcallback&response_type=code&state=CZca3dU1HV0Z7jPoqjVxKtOGH2c8aSRAb2DDVvKFbfewDX73G0cgsRj0BCJjKS4a&scope=openid%20profile%20email";
            Page.Url = url;
            Page.Navigate();
        }
    }
}
