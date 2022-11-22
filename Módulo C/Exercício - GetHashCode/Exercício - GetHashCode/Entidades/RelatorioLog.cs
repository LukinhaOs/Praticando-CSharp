using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício___GetHashCode.Entidades
{
    class RelatorioLog
    {
        public string Username { get; set; }
        public DateTime  Instante { get; set; }

        public RelatorioLog()
        {

        }

        public RelatorioLog (string username, DateTime instante)
        {
            Username = username;
            Instante = instante;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj) // Este método utiliza o Equals para testar repetição de dados em um objeto
        {
            if (!(obj is RelatorioLog))
            {
                return false;
            }
            RelatorioLog other = obj as RelatorioLog;
            return Username.Equals(other.Username);
        }
    }
}
