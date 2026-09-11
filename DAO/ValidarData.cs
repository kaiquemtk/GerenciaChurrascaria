using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ValidarData
    {


        public static bool ValidarData123(string data)
        {
            DateTime dataValida;

            ///Primeiro tenta converter a data, se não conseguir converter retornará "False".
            ///Se converter para uma data checa se é maior que a data de hoje, se for retornará "False".
            if ((!DateTime.TryParse(data, out dataValida)) || dataValida > DateTime.Today)
                return false;

            ///Se for uma data válida e for menor ou igual a data de hoje, retorna "True".
            else
                return true;

        }
    }
}
    

