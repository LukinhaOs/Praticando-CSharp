using System;


namespace Exercício_exceção_Conta_Bancária.Entities.Exceptions
{
    class DominanceException : AccessViolationException
    {
        public DominanceException(string name) : base(name)
        {
                                                                                                                                                               
        }
    }
}
