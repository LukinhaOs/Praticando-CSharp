namespace Herança.Entidades
{
    class ContaEmpresa : Conta
    {
        public double  LoanLimtit{ get; set; }

        public ContaEmpresa()
        {

        }

        public ContaEmpresa(int numero, string titular, double saldo, double loanlimit)
        : base(numero, titular, saldo)
        {
            LoanLimtit = loanlimit;
        }

        public void Emprestimo(double quantia)
        {
            if(quantia <= LoanLimtit)
            {
                Saldo += quantia;
            }
        }
    }
}
