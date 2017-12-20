using System;

namespace Factory_Methods
{
    public interface FabricaDeDepartamento
    {
        Departamento CriarDepartamento();
    }
}