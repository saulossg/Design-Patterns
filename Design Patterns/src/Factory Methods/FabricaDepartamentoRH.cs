using System;

namespace Factory_Methods
{
    public class FabricaDepartamentoRH : FabricaDeDepartamento
    {
        public Departamento CriarDepartamento()
        {
            return new DepartamentoRH();
        }
    }
}