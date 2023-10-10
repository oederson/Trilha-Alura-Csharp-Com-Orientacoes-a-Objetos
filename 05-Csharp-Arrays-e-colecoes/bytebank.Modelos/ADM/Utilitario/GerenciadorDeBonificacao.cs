
using _05_Csharp_Arrays_e_colecoes.bytebank.Modelos.ADM.Funcionarios;

namespace _05_Csharp_Arrays_e_colecoes.bytebank.Modelos.ADMs.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.getBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
