// Generated by Selenium IDE
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
public class SuiteTests : IDisposable
{
    public IWebDriver driver { get; private set; }
    public IDictionary<String, Object> vars { get; private set; }
    public IJavaScriptExecutor js { get; private set; }
    public SuiteTests()
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
    public void TesteRN01()

    {
        var resultadoesperado = "background-color: red";
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);

        driver.FindElement(By.CssSelector("btnGravar")).Click();


        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("style")));

        var NomeFuncionario = driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("style");


        Assert.Equal(resultadoesperado, NomeFuncionario);

    }
    [Fact]
    public void TesteRN02()
    {
        var ResultadoEsperado = "background-color: rgb(127, 255, 212);";
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("idFuncionario")).Click();
        {
            var element = driver.FindElement(By.Id("idFuncionario"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("idFuncionario")).GetAttribute("style")));

        var NomeFuncionario = driver.FindElement(By.Id("idFuncionario")).GetAttribute("style");


        Assert.Equal(ResultadoEsperado, NomeFuncionario);

    }



        [Fact]
    public void TesteRN03()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(1616, 868);
        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).SendKeys("a");
        driver.FindElement(By.Id("idDepartamento")).SendKeys("1");

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("idDepartamento")).GetAttribute("value")));

        string ValorID = driver.FindElement(By.Id("idDepartamento")).GetAttribute("value");


        Assert.Equal("1", ValorID);


    }
    [Fact]
    public void TesteRN04()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(596, 832);
        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).SendKeys("10");
        driver.FindElement(By.Id("departamento")).Click();

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("departamento")).GetAttribute("value")));

        string departamentoNome = driver.FindElement(By.Id("departamento")).GetAttribute("value");


        Assert.Equal("Sec. Educa��o", departamentoNome);
    }
    [Fact]
    public void TesteRN06()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(596, 832);
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("idFuncionario")).SendKeys("10");
        driver.FindElement(By.Id("departamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).SendKeys("10");

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("departamento")).GetAttribute("value")));

        string departamentoNome = driver.FindElement(By.Id("departamento")).GetAttribute("value");


        var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait2.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value")));

        string funcionarioNome = driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value");


        var wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait3.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("cargo")).GetAttribute("value")));

        string CargoNome = driver.FindElement(By.Id("cargo")).GetAttribute("value");


        Assert.Equal("Sec. Educa��o", departamentoNome);
        Assert.Equal("Reginaldo Santana", funcionarioNome);
        Assert.Equal("CIO", CargoNome);

    }
    [Fact]
    public void TesteRN07()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(596, 832);
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("idFuncionario")).SendKeys("10");
        driver.FindElement(By.Id("departamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).SendKeys("10");

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("departamento")).GetAttribute("value")));

        string departamentoNome = driver.FindElement(By.Id("departamento")).GetAttribute("value");


        var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait2.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value")));

        string funcionarioNome = driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value");


        var wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait3.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("cargo")).GetAttribute("value")));

        string CargoNome = driver.FindElement(By.Id("cargo")).GetAttribute("value");


        Assert.Equal("Sec. Educa��o", departamentoNome);
        Assert.Equal("Reginaldo Santana", funcionarioNome);
        Assert.Equal("CIO", CargoNome);

    }
    [Fact]
    public void TesteRN8()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(955, 832);
        driver.FindElement(By.Id("Estoque")).Click();
        driver.FindElement(By.Id("Estoque")).SendKeys("1111");

    

        string estoque = driver.FindElement(By.Id("Estoque")).GetAttribute("value");


        Assert.Equal("1111", estoque);
    }

   
    [Fact]
    public void TesteRN9()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(1616, 868);
     
       
        driver.FindElement(By.Id("Estoque")).Click();
        driver.FindElement(By.Id("Estoque")).SendKeys("23123");
        var wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait3.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("Estoque")).GetAttribute("value")));

        string estoque = driver.FindElement(By.Id("Estoque")).GetAttribute("value");


        Assert.NotEqual("23123", estoque);
        driver.Close();
    }
    [Fact]
    public void TesteRN10()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(1616, 868);
        driver.FindElement(By.Id("codigoProduto")).Click();
        driver.FindElement(By.Id("codigoProduto")).SendKeys("10");
        driver.FindElement(By.Id("Estoque")).Click();
        driver.FindElement(By.Id("Quantidade")).Click();
        driver.FindElement(By.Id("Quantidade")).SendKeys("-2");
       



        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(Driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("Quantidade")).GetAttribute("value")));
        string estoque = driver.FindElement(By.Id("Quantidade")).GetAttribute("value");

        Assert.NotEqual("-2", estoque);
        driver.Close();
    }
    [Fact]
    public void TesteRN112()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(1616, 868);

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(Driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("verde")).GetAttribute("value")));
        string quadradinho1 = driver.FindElement(By.Id("verde")).GetAttribute("value");

        driver.FindElement(By.Id("verde")).Click();
        driver.FindElement(By.Id("verde")).Click();
        driver.FindElement(By.Id("verde")).Click();
        driver.FindElement(By.Id("verde")).Click();

        var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait2.Until(Driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("verde")).GetAttribute("value")));
        string quadradinho2 = driver.FindElement(By.Id("verde")).GetAttribute("value");

        Assert.NotEqual(quadradinho1 , quadradinho2);   

    }
    [Fact]
    public void TesteRN12()
    {
        // ... (c�digo anterior)

        // Capture os atributos CSS antes de clicar nos elementos
        string urgenteBeforeClick = driver.FindElement(By.Id("urgente")).GetCssValue("Style");
        string medioBeforeClick = driver.FindElement(By.Id("medio")).GetCssValue("Style");
        string baixoBeforeClick = driver.FindElement(By.Id("baixo")).GetCssValue("Style");

        // Clique nos elementos
        driver.FindElement(By.Id("urgente")).Click();
        driver.FindElement(By.Id("medio")).Click();
        driver.FindElement(By.Id("baixo")).Click();

        // Capture os atributos CSS ap�s clicar nos elementos
        string urgenteAfterClick = driver.FindElement(By.Id("urgente")).GetCssValue("Style");
        string medioAfterClick = driver.FindElement(By.Id("medio")).GetCssValue("Style");
        string baixoAfterClick = driver.FindElement(By.Id("baixo")).GetCssValue("Style");

        // Verifique se os atributos mudaram
        Assert.NotEqual(urgenteBeforeClick, urgenteAfterClick);
        Assert.NotEqual(medioBeforeClick, medioAfterClick);
        Assert.NotEqual(baixoBeforeClick, baixoAfterClick);
    }
    [Fact]
    public void TesteRN13()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 832);

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(Driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("verde")).GetAttribute("value")));
        string quadradinho1 = driver.FindElement(By.Id("verde")).GetAttribute("value");

        driver.FindElement(By.Id("codigoProduto")).Click();
        driver.FindElement(By.Id("codigoProduto")).SendKeys("10");
        driver.FindElement(By.Id("verde")).Click();
        driver.FindElement(By.Id("verde")).Click();
        {
            var element = driver.FindElement(By.Id("verde"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        driver.FindElement(By.Id("verde")).Click();
        driver.FindElement(By.Id("verde")).Click();
        driver.FindElement(By.Id("verde")).Click();
        driver.FindElement(By.Id("verde")).Click();
        driver.FindElement(By.Id("verde")).Click();
        {
            var element = driver.FindElement(By.Id("verde"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        driver.FindElement(By.Id("verde")).Click();

        var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait2.Until(Driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("verde")).GetAttribute("value")));
        string quadradinho2 = driver.FindElement(By.Id("verde")).GetAttribute("value");

        Assert.NotEqual(quadradinho2, quadradinho1);
    }
    [Fact]
    public void TesteRN14()
    {
        driver.Navigate().GoToUrl("https://guilhermeveigalopes.github.io/almoxarifado/");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 832);

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(Driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("verde")).GetAttribute("value")));
        string quadradinho1 = driver.FindElement(By.Id("verde")).GetAttribute("value");

        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).SendKeys("10");
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("idFuncionario")).SendKeys("10");
        driver.FindElement(By.Id("categoriaMotivo")).Click();
        {
            var dropdown = driver.FindElement(By.Id("categoriaMotivo"));
            dropdown.FindElement(By.XPath("//option[. = 'Gest�o']")).Click();
        }
        driver.FindElement(By.Id("Motivo")).Click();
        {
            var dropdown = driver.FindElement(By.Id("Motivo"));
            dropdown.FindElement(By.XPath("//option[. = 'Financeiro']")).Click();
        }
        driver.FindElement(By.Id("medio")).Click();
        driver.FindElement(By.Id("codigoProduto")).Click();
        driver.FindElement(By.Id("codigoProduto")).SendKeys("10");
        driver.FindElement(By.Id("Quantidade")).Click();
        driver.FindElement(By.Id("Quantidade")).SendKeys("7");
        driver.FindElement(By.Id("Estoque")).Click();
        driver.FindElement(By.Id("Estoque")).SendKeys("4");
        driver.FindElement(By.CssSelector("#BtnInserirItens > span")).Click();
        driver.FindElement(By.CssSelector("#BtnInserirItens > span")).Click();



        var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait2.Until(Driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("verde")).GetAttribute("value")));
        string quadradinho2 = driver.FindElement(By.Id("verde")).GetAttribute("value");

        Assert.NotEqual(quadradinho2, quadradinho1);
    }


}