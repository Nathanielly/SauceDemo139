using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver; //objeto do selenium

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp()
        {
            //instanciando o chrome driver atraves do web driver manager
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(); //instanciou o selenium como chrome
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit(); //encerrar o selenium        
        }

        [Given(@"que acesso a pagina inicial do site")]
        public void DadoQueAcessoAPaginaInicialDoSite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"preencho o usuario como ""(.*)""")]
        public void QuandoPreenchoOUsuarioComo(string username)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
        }

        [When(@"a senha ""(.*)"" e clico no botao login")]
        public void QuandoASenha(string password)
        {
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();
        }

        [Then(@"exibe ""(.*)"" no titulo da Selecao")]
        public void EntaoExibeNoTituloDaSelecao(string title)
        {
            //espera explicita pelo elemento span.title ser carregado na página
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(3000));
            wait.Until(d => driver.FindElement(By.CssSelector("span.title")).Displayed);
            //Assert.That(driver.FindElement(By.CssSelector("span.title")).Text, Is.EqualTo(title));
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void QuandoAdicionoOProdutoAoCarrinho(string product)
        {
            //o nome do produto vem do arquivo .feature = Sauce Labs Backpack
            //o texto vem em maiusculo e o id em minusculo com hifens
            //ToLower transforma tudo para minusculo

           string productSelector = "add-to-cart-" + product.ToLower().Replace(" ","-");
           driver.FindElement(By.Id(productSelector)).Click();

           Console.WriteLine($"Seletor de produto = {productSelector}");

        }

        [When(@"clico no ícone do carrinho de compras")]
        public void QuandoClicoNoIconeDoCarrinhoDeCompras()
        {
           driver.FindElement(By.CssSelector("a.shopping_cart_link")).Click();
        }

        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)""")]
        public void EntaoExibeAPaginaDoCarrinhoComQuantidadeComo(string quantity)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.cart_quantity")).Text, Is.EqualTo(quantity));
        }

        [Then(@"nome do produto ""(.*)""")]
        public void EntaoNomeDoProduto(string product)
        {
            Assert.That(driver.FindElement(By.ClassName("inventory_item_name")).Text, Is.EqualTo(product));
        }

        [Then(@"o preco como ""(.*)""")]
        public void EntaoOPrecoComo(string price)
        {
            Assert.That(driver.FindElement(By.ClassName("inventory_item_price")).Text, Is.EqualTo(price));
        }
    }
}