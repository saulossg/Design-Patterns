using System;

namespace Factory_Methods
{
    public class DepartamentoRH : Departamento
    {
        void Departamento.exibirInformacao()
        {
            Console.WriteLine("Departamento RH criado!!!!");
        }
    }
}