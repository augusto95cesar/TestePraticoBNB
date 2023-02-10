using CaixaPrevidenciaBNB.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace CaixaPrevidenciaBNB.Models.Help.Map
{
    public static class ConvertBNB
    {
        public static List<Empregado> ConvertForList(this IQueryable<Empregado> empregadoList) {

            var list = new List<Empregado>();

            foreach (var empregado in empregadoList)
            {
                list.Add(empregado);
            }

            return list;
        }
    }
}