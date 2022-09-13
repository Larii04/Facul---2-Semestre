using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacoes
{
    public class clsValidacoes
    {
        public static Boolean ValidaCartao(string NumCC)
        {

            #region Corrige e Verifica a String
            NumCC = NumCC.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "").Replace(" ", "").Trim();
            if (NumCC.Length != 16)
                return false;
            #endregion

            #region Variáveis
            int Soma, mult, Resto;
            int[] soma1 = new int[16];
            #endregion

            #region Cálculo

            Soma = 0;
            Resto = 0;
            mult = 0;
         

            for (int i = 0; i < 16; i++)
                {
                    if (i % 2 == 0)
                    {
                    mult = 2;
                     }
                if (i % 2 == 1)
                {
                    mult = 1;
                }

                soma1[i] = int.Parse(NumCC.Substring(i, 1)) * (mult);
                if (soma1[i] > 9)
                    {
                        soma1[i] = soma1[i] - 9;
                        
                    }
                Soma += soma1[i];    
                   
                    
                }
            
            Resto = Soma % 10;
            if (Resto == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            #endregion
        }
    }
}
