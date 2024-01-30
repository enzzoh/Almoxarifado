const categorias = [
    {
        "idCategoria": 1,
        "Descricao": "Gestão",
    },
    {
        "idCategoria": 2,
        "Descricao": "Cliente",
    },
    {
        "idCategoria": 3,
        "Descricao": "RP",
    },
]

const motivos = [
    {
        "idMotivo": 1,
        "Descricao": "Planejamento",
        "idCategoria": 1,
    },
    {
        "idMotivo": 2,
        "Descricao": "Financeiro",
        "idCategoria": 1,
    },
    {
        "idMotivo": 3,
        "Descricao": "Financeiro",
        "idCategoria": 2,
    },
]

const produtos = [
    {
        "idproduto": 1,
        "Descricao": "Caderneta",
        "estoque": 35,
        "estoqueMinimo": 10,
        "unidade": "Un",
        "preco": 350,
    },
    {
        "idproduto": 2,
        "Descricao": "Papel A4",
        "estoque": 75,
        "estoqueMinimo": 10,
        "unidade": "Un",
        "preco": 7,
    },
    {
        "idproduto": 3,
        "Descricao": "Cadeira",
        "estoque": 90,
        "estoqueMinimo": 10,
        "unidade": "Un",
        "preco": 15,
    },
    {
        "idproduto": 4,
        "Descricao": "Mesa de escritório",
        "estoque": 40,
        "estoqueMinimo": 10,
        "unidade": "Un",
        "preco": 480,
    },
]

const departamentos = [
    {
        "idDep": 1,
        "Descricao": "Secretaria da Educação",
        "responsavel": "José Abreu",
    },
    {
        "idDep": 2,
        "Descricao": "Relações Públicas",
        "resposavel": "Ana Luíza",
    },
    {
        "idDep": 3,
        "Descricao": "Secretaria da Fazenda",
        "responsavel": "Maria da Graça",
    },
]

const funcionarios = [
    {
        "idFunc": 1,
        "nomeFunc": "Maria Julia",
        "cargoFunc": "Coordenadora",
    },
    {
        "idFunc": 2,
        "nomeFunc": "Caetano Veloso",
        "cargoFunc": "Repositor",
    },
    {
        "idFunc": 3,
        "nomeFunc": "Glauber Rocha",
        "cargoFunc": "Supervisor",
    },
]