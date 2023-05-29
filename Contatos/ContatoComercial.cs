using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa_agenda
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj { get; set; }

        public bool ValidarCnpj(string _cnpj)
        {
            Cnpj = _cnpj;

            if (Cnpj.Length == 14)
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