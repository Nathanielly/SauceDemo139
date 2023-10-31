using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [Given(@"que acesso a página inicial do site")]
        public void DadoQueAcessoAPaginaInicialDoSite()
        {
            _scenarioContext.Pending();
        }

        [When(@"preencho o usuario como ""(.*)""")]
        public void QuandoPreenchoOUsuarioComo(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"a senha ""(.*)""")]
        public void QuandoASenha(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"clico no botão ""(.*)""")]
        public void QuandoClicoNoBotao(string login0)
        {
            _scenarioContext.Pending();
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void QuandoAdicionoOProdutoAoCarrinho(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"clico no ícone do carrinho de compras")]
        public void QuandoClicoNoIconeDoCarrinhoDeCompras()
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe ""(.*)"" no titulo da Selecao")]
        public void EntaoExibeNoTituloDaSelecao(string products0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe a pagina do carrinho com quantidade como ""(.*)""")]
        public void EntaoExibeAPaginaDoCarrinhoComQuantidadeComo(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"nome do produto ""(.*)""")]
        public void EntaoNomeDoProduto(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o preco como ""(.*)""")]
        public void EntaoOPrecoComo(string p0)
        {
            _scenarioContext.Pending();
        }
    }
}