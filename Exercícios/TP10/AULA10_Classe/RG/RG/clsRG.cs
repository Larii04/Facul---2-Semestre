using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG
{
    public class clsRG
    {
        #region Validar RG
        public static Boolean ValidaRG(string RG)
        {
            // inicio as variaveis para trabalho
            int Soma = 0;
            int Resto = 0;
            // Retiro os caracteres ponto, traço e espaços da string
            //RG = RG.Replace(".", "");
            //RG = RG.Replace("-", "");
            //RG = RG.Trim();
            // Retiro os caracteres ponto, traço e espaços da string
            RG = RG.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "").Trim();
            // Verifico se o RG é diferente de 9 digitos, se for adiciono zeros na frente até ter 9 caracteres
            if (RG.Length != 9)
                for (int i = 0; i < 10 - RG.Length; i++)
                {
                    RG = RG.Insert(i, "0");
                }
            //efetuo os calculos
            for (int i = 0; i < 8; i++)
            {
                Soma += (int.Parse(RG.Substring(i, 1)) * (i + 2));
            }
            Soma += (int.Parse(RG.Substring(8, 1)) * 100);
            Resto = Soma % 11;
            if (Resto > 1)
                return false;
            else
                return true;
        }
        #endregion
    }
}
