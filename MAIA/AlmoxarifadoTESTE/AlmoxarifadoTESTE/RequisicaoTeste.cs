using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
namespace AlmoxarifadoTESTE
{
    public class RequisicaoTeste : IDisposable
    {
       
        
            public IWebDriver driver { get; private set; }
            public IDictionary<String, Object> vars { get; private set; }
            public IJavaScriptExecutor js { get; private set; }
            public RequisicaoTeste()
            {
                driver = new ChromeDriver();
                js = (IJavaScriptExecutor)driver;
                vars = new Dictionary<String, Object>();
            }
            public void Dispose()
            {
                driver.Quit();
            }

            [Fact]
            public void Test1()
            {
                driver.Navigate().GoToUrl("https://splendorous-starlight-c2b50a.netlify.app/");
                driver.Manage().Window.Size = new System.Drawing.Size(814, 859);
                driver.FindElement(By.Id("idDepartamento")).Click();
                driver.FindElement(By.Id("idDepartamento")).SendKeys("10");
            }
        }
    }

    