namespace State
{
    public class RelatorioFechamentoFolha(IStateImpressao initialState)
    {
        public IStateImpressao State { get; set; } = initialState;

        public void Imprimir()
        {
            State.Imprimir();
        }

        public void ChangeState(IStateImpressao state)
        {
            State = state;
        }
    }
}
