﻿namespace _05_Csharp_Arrays_e_colecoes.bytebank.Modelos.ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double getBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
