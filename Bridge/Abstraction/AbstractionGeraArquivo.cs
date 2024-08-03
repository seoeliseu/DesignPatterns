using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public abstract class AbstractionGeraArquivo
    {
        protected IGeraArquivo geraArquivo;
        protected AbstractionGeraArquivo(IGeraArquivo geraArquivo)
        {
            this.geraArquivo = geraArquivo;
        }
        public virtual void GravaArquivo(Funcionario funcionario)
        {
            geraArquivo.GravaArquivo(funcionario);
        }
    }
}
