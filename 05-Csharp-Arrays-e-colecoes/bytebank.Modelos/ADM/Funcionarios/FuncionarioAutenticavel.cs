using _05_Csharp_Arrays_e_colecoes.bytebank.Modelos.ADM.SistemaInterno;


namespace _05_Csharp_Arrays_e_colecoes.bytebank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
