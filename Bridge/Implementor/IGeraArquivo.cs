using Bridge.Domain;

namespace Bridge.Implementor
{
    //Representa o meu bridge
    public interface IGeraArquivo
    {
        void GravaArquivo(Funcionario funcionario);
    }
}
