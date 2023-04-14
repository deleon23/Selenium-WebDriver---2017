using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://RDVSuperaQA.azurewebsites.net");

                var instancia = driver.FindElementByName("tenancyName");
                var login = driver.FindElementByName("usernameOrEmailAddress");
                var senha = driver.FindElementByName("password");
                var btnLogin = driver.FindElementByClassName("btn btn-success uppercase");

                instancia.SendKeys("SUPERA");
                login.SendKeys("deleon.henrique");
                senha.SendKeys("123321");

                btnLogin.Click();

                driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);
            }
        }
    }
}
