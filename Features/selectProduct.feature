#language: pt
Funcionalidade: Selecionar produto na loja
@Loja
    Cenario: Selecao com sucesso
        Dado que acesso a página inicial do site
        Quando preencho o usuario como "standard_user"
        E a senha "sauce_secret"
        E clico no botão "login"
        Entao exibe "Products" no titulo da Selecao
        Quando adiciono o produto "Sauce Labs Backpack" ao carrinho
        E clico no ícone do carrinho de compras
        Entao exibe a pagina do carrinho com quantidade como "1"
        E nome do produto "Sauce Labs Backpack"
        E o preco como "$29.99"