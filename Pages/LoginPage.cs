//Bibliotecas

//Namespace
using OpenQA.Selenium;

namespace Pages
{

//Classe
    public class LoginPage : ComumPage //herda tudo que está na comum page
    {
    
        //Atributos
            //Mapeamento dos elementos
            private IWebElement txtUsuario => driver.FindElement(By.Id("user-name"));
            private IWebElement txtSenha => driver.FindElement(By.Id("password-name"));
            private IWebElement btnLogin => driver.FindElement(By.Id("login-button"));

        //Metodos e funções
            //Construtor
        public LoginPage(IWebDriver driver) : base(driver)
        {
            
        }
            //Ações a serem usadas na automação
        public void PreencherUsuarioESenha(string usuario, string senha)
        {
            txtUsuario.SendKeys(usuario);
            txtSenha.SendKeys(senha);

        }
        public void ClicarNoBotaoLogin()
        {
            btnLogin.Click();
        }
        public void DarEnter()
        {
            txtSenha.SendKeys(Keys.Enter);
        }

    }
}