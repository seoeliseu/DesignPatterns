using ChainOfResponsibility.Concrete;

string jsonPedido = @"{
    'cliente': 'João',
    'produto': 'Notebook',
    'quantidade': 1
}";

string jsonCurso = @"{
    'nome': 'C#',
    'descricao': 'Curso de C#',
    'cargaHoraria': 40
}";

string jsonFuncionario = @"{
    'nome': 'João',
    'idade': 25,
    'sexo': 'M'
}";

Handler.Handle(jsonPedido);

Handler.Handle(jsonCurso);

Handler.Handle(jsonFuncionario);


