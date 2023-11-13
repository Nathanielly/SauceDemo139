#language: pt
Funcionalidade: Selecionar produto na loja PO
    @PO
    Esquema do Cenario: Selecao de produto com sucesso PO
        Dado que acesso a pagina inicial do site PO
        Quando preencho o usuario como <usuario> PO
        E a senha <senha> e clico no botao login PO
        Entao exibe <tituloSecao> no titulo da Selecao PO
        Quando adiciono o produto <Produto> ao carrinho PO
        E clico no ícone do carrinho de compras PO
        Entao exibe a pagina do carrinho com a quantidade <Quantidade> PO
        E nome do produto <Produto> PO
        E o preco como <Preco> PO

    Exemplos:
    | usuario         | senha          | tituloSecao | Produto                 | Quantidade | Preco    |
    | "standard_user" | "secret_sauce" | "Products"  | "Sauce Labs Backpack"   | "1"        | "$29.99" |
    | "visual_user"   | "secret_sauce" | "Products"  | "Sauce Labs Bike Light" | "1"        | "$9.99"  |