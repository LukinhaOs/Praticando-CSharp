namespace Herança.Entidades
{
    class ContaEmpresa : Conta
    {
        public double  EmprestimoLimit{ get; set; }

        public ContaEmpresa()
        {
            
        }

        public ContaEmpresa(int numero, string titular, double saldo, double loanlimit)
        : base(numero, titular, saldo)
        {
            EmprestimoLimit = loanlimit;
        }

        public void Emprestimo(double quantia)
        {
            if(quantia <= EmprestimoLimit)
            {
                Saldo += quantia;
            }
        }
    }
}
