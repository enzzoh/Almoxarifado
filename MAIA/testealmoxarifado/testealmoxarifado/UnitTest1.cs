using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    public void TesteRn03()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/Almoxarifado-main/index.html");
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
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/Almoxarifado-main/index.html");
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
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/Almoxarifado-main/index.html");
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
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/Almoxarifado-main/index.html");
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
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/Almoxarifado-main/index.html");
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
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/Almoxarifado-main/index.html");
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
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);
        driver.FindElement(By.Id("Estoque")).Click();
        driver.FindElement(By.Id("Estoque")).SendKeys("asdsd");

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("Estoque")).GetAttribute("value")));

        string descricaoProduto = driver.FindElement(By.Id("Estoque")).GetAttribute("value");

        Assert.Empty(descricaoProduto);






    }
    [Fact]
    public void TesteRN10()
    {
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/Almoxarifado-main/Almoxarifado-main/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);
        driver.FindElement(By.Id("CodigoProduto")).Click();
        driver.FindElement(By.Id("CodigoProduto")).SendKeys("1");
        driver.FindElement(By.Id("Estoque")).Click();
        driver.FindElement(By.Id("Estoque")).SendKeys("-12");
        driver.FindElement(By.Id("btnInserirItens")).Click();



        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => !string.IsNullOrEmpty(driver.FindElement(By.Id("Estoque")).GetAttribute("value")));

        string estoque = driver.FindElement(By.Id("Estoque")).GetAttribute("value");

        Assert.Empty(estoque);






    }



}
