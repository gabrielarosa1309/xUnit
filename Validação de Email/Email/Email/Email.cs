using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    public static class Validacao
    {
        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            int arroba = email.IndexOf('@');
            int ponto = email.LastIndexOf('.');

            return arroba > 0 && ponto > arroba + 1 && ponto < email.Length - 1;
        }
    }
}
