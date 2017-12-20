using System;

namespace Factory_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            ///TESTE
            FabricaDeDepartamento fabricaRH = new FabricaDepartamentoRH();
            fabricaRH.CriarDepartamento().exibirInformacao();
            
            FabricaDeDepartamento fabricaFinanceiro = new FabricaDeDepartamentoFinanceiro();
            fabricaFinanceiro.CriarDepartamento().exibirInformacao();

        }
    }
}
