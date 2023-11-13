//Bibliotecas
using OpenQA.Selenium;

//namespace
namespace Pages
{
    public class ComumPage
    {
        //Atributos
        protected IWebDriver driver;

        //mapeamento dos elementos comuns a duas ou mais telas
        private IWebElement lblTituloSecao => driver.FindElement(By.CssSelector("span.title"));
        private IWebElement icoCarrinho => driver.FindElement(By.CssSelector("a.shopping_cart_link"));


        //Métodos e funçoes
        //construtor
        public ComumPage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}