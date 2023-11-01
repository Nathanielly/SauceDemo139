#language: pt
Funcionalidade: Selecionar produto na loja
    @Loja
    Cenario: Selecao de produto com sucesso
        Dado que acesso a pagina inicial do site
        Quando preencho o usuario como "standard_user"
        E a senha "secret_sauce" e clico no botao login
        Entao exibe "Products" no titulo da Selecao
        Quando adiciono o produto "Sauce Labs Backpack" ao carrinho
        E clico no ícone do carrinho de compras
        Entao exibe a pagina do carrinho com a quantidade "1"
        E nome do produto "Sauce Labs Backpack"
        E o preco como "$29.99"