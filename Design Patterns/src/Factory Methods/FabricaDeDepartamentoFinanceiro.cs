namespace Factory_Methods
{
    public class FabricaDeDepartamentoFinanceiro : FabricaDeDepartamento
    {
        public Departamento CriarDepartamento()
        {
            return new DepartamentoFinanceiro();
        }
    }
}