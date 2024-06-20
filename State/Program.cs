using State;

var listaRelatorio = new List<IStateImpressao>
{
    new ImpressaoRelatorioFuncionario(),
    new ImpressaoRelatorioCargaHoraria()
};

var relatorioFechamento = new RelatorioFechamentoFolha(new ImpressaoRelatorioFuncionario());
foreach (var item in listaRelatorio)
{
    relatorioFechamento.ChangeState(item);
    relatorioFechamento.Imprimir();
}