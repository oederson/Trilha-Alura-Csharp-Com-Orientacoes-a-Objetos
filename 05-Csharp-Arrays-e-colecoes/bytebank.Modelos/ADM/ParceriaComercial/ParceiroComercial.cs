using _05_Csharp_Arrays_e_colecoes.bytebank.Modelos.ADM.SistemaInterno;

namespace _05_Csharp_Arrays_e_colecoes.bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
