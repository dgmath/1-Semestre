using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa_agenda
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf { get; set; }

        public bool ValidarCpf(string _cpf)
        {
            Cpf = _cpf;

            if(Cpf.Length ==  11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}