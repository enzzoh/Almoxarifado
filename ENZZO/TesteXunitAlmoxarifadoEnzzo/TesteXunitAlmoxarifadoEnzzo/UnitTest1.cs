using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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
        var resultadoEsperado = "background-color: rgb(197, 227, 205);";

        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 832);
        driver.FindElement(By.CssSelector("#btnGravar > span")).Click();
        driver.FindElement(By.Id("idFuncionario")).Click();



        
    }
    [Fact]
    public void TesteRN02()
    {
        var ResultadoEsperado = "background-color: rgb(197, 227, 205);";
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
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
    public void TesteRn03()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("idFuncionario")).SendKeys("a");
        driver.FindElement(By.Id("idFuncionario")).SendKeys("1");

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("idFuncionario")).GetAttribute("value")));

        string ValorID = driver.FindElement(By.Id("idFuncionario")).GetAttribute("value");


        Assert.Equal("1", ValorID);


    }
    [Fact]
    public void TesteRN04()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);


        driver.FindElement(By.Id("idFuncionario")).Click();


        driver.FindElement(By.Id("idFuncionario")).SendKeys("1");

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value")));

        var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait2.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("cargo")).GetAttribute("value")));


        string novoValorNomeFuncionario = driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value");
        string novoValorNomecargo = driver.FindElement(By.Id("cargo")).GetAttribute("value");

        Assert.Equal("Maria Julia", novoValorNomeFuncionario);
        Assert.Equal("Coordenadora", novoValorNomecargo);
    }
    [Fact]
    public void TesteRN05()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);


        var dropdownCategoriaMotivo = driver.FindElement(By.Id("categoriaMotivo"));
        dropdownCategoriaMotivo.FindElement(By.XPath("//option[. = 'Gestão']")).Click();


        var waitPlanejamento = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        waitPlanejamento.Until(driver => driver.FindElement(By.Id("Motivo")).FindElements(By.XPath("//option[. = 'Planejamento']")).Count > 0);


        var waitFinanceiro = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        waitFinanceiro.Until(driver => driver.FindElement(By.Id("Motivo")).FindElements(By.XPath("//option[. = 'Financeiro']")).Count > 0);




        var motivoDropdown = driver.FindElement(By.Id("Motivo"));
        Assert.Contains("Planejamento", motivoDropdown.Text);


        Assert.Contains("Financeiro", motivoDropdown.Text);


        driver.Close();
    }

    [Fact]


    public void TesteRn06()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);


        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).SendKeys("2");
        driver.FindElement(By.Id("departamento")).Click();


        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("departamento")).GetAttribute("value")));


        string Departanome = driver.FindElement(By.Id("departamento")).GetAttribute("value");


        Assert.False(string.IsNullOrEmpty(Departanome));


    }
    [Fact]
    public void TesteRN07()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("idFuncionario")).SendKeys("1");
        driver.FindElement(By.Id("NomeFuncionario")).Click();
        driver.FindElement(By.Id("cargo")).Click();

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value")));
        var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait2.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("cargo")).GetAttribute("value")));


        string Nomefuncionarioteste = driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value");
        string cargpfuncionarioteste = driver.FindElement(By.Id("cargo")).GetAttribute("value");


        Assert.Equal("Maria Julia", Nomefuncionarioteste);
        Assert.Equal("Coordenadora", cargpfuncionarioteste);

    }
    [Fact]
    public void Testern08()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);
        driver.FindElement(By.Id("CodigoProduto")).Click();
        driver.FindElement(By.Id("CodigoProduto")).SendKeys("1");
        driver.FindElement(By.Id("DescricaoProduto")).Click();
        driver.FindElement(By.Id("Estoque")).Click();


        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("DescricaoProduto")).GetAttribute("value")));
        var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait2.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("Estoque")).GetAttribute("value")));


        string DescricaoProdutoteste = driver.FindElement(By.Id("DescricaoProduto")).GetAttribute("value");
        string Estoqueteste = driver.FindElement(By.Id("Estoque")).GetAttribute("value");


        Assert.Equal("Caderneta", DescricaoProdutoteste);
        Assert.Equal("35", Estoqueteste);


    }
    [Fact]
    public void TesteRN09()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);
        driver.FindElement(By.Id("Estoque")).Click();
        driver.FindElement(By.Id("Estoque")).SendKeys("asdsd");

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("Estoque")).GetAttribute("value")));

        string descricaoProduto = driver.FindElement(By.Id("Estoque")).GetAttribute("value");

        Assert.Empty(descricaoProduto);






    }
    [Fact]
    public void TesteRN12()
    {
        // ... (código anterior)

        // Capture os atributos CSS antes de clicar nos elementos
        string urgenteBeforeClick = driver.FindElement(By.Id("urgente")).GetCssValue("Style");
        string medioBeforeClick = driver.FindElement(By.Id("medio")).GetCssValue("Style");
        string baixoBeforeClick = driver.FindElement(By.Id("baixo")).GetCssValue("Style");

        // Clique nos elementos
        driver.FindElement(By.Id("urgente")).Click();
        driver.FindElement(By.Id("medio")).Click();
        driver.FindElement(By.Id("baixo")).Click();

        // Capture os atributos CSS após clicar nos elementos
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
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
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
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/index.html");
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
            dropdown.FindElement(By.XPath("//option[. = 'Gestão']")).Click();
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

