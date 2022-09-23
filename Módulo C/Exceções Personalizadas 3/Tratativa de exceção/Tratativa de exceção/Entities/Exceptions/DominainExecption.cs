using System;


namespace Tratativa_de_exceção.Entities.Exceptions
{
    class DominainExecption : AccessViolationException
    {
        public DominainExecption(String message) : base(message)
        {

        }
    }
}
