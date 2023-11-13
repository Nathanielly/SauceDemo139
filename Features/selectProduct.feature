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


    Esquema do Cenario: Selecao de produto com sucesso DDT
        Dado que acesso a pagina inicial do site
        Quando preencho o usuario como <usuario>
        E a senha <senha> e clico no botao login
        Entao exibe <tituloSecao> no titulo da Selecao
        Quando adiciono o produto <Produto> ao carrinho
        E clico no ícone do carrinho de compras
        Entao exibe a pagina do carrinho com a quantidade <Quantidade>
        E nome do produto <Produto>
        E o preco como <Preco>

    Exemplos:
    | usuario         | senha          | tituloSecao | Produto                 | Quantidade | Preco    |
    | "standard_user" | "secret_sauce" | "Products"  | "Sauce Labs Backpack"   | "1"        | "$29.99" |
    | "visual_user"   | "secret_sauce" | "Products"  | "Sauce Labs Bike Light" | "1"        | "$9.99"  |
    