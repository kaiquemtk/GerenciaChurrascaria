using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Cnpj
    {              
            public static  bool VALIDAO(string cnpj)
            {
                int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                int somador;
                int resto;
                string digito;
                string cnpjAux;

                cnpj = cnpj.Trim(); //retira espaços do começo e fim, caso existam.
                cnpj = cnpj.Replace(",", "").Replace("/", "").Replace("-", ""); //retira os caracteres não necessários

                if (cnpj.Length != 14)
                {
                    return false;
                }
                else
                {
                    cnpjAux = cnpj.Substring(0, 12);
                    somador = 0;

                    int result = 0;

                    for (int i = 0; i < 12; i++)
                    {
                        int val = (int)Char.GetNumericValue(cnpjAux[i]);
                        result = (val * multiplicador1[i]);
                        somador = somador + result;

                    }

                    resto = (somador % 11);

                    if (resto < 2)
                    {
                        resto = 0;
                    }
                    else
                    {
                        resto = 11 - resto;
                    }

                    digito = resto.ToString(); //1º digito armazenado.

                    cnpjAux = cnpjAux + digito; //agora com 13 números.

                    result = 0; //zera result
                    somador = 0; //zera somador

                    for (int i = 0; i < 13; i++)
                    {
                        int val = (int)Char.GetNumericValue(cnpjAux[i]);
                        result = (val * multiplicador2[i]);
                        somador = somador + result;
                    }

                    resto = (somador % 11);

                    if (resto < 2)
                    {
                        resto = 0;
                    }
                    else
                    {
                        resto = 11 - resto;
                    }

                    digito = digito + resto.ToString(); //Concatenação do 1º dígito com o 2º dígito. ex: "00"

                    return cnpj.EndsWith(digito); //se for igual retorna true, senão retorna false.
                }
            }
        }
    }



