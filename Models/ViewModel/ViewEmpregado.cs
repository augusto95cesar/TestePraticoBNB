using CaixaPrevidenciaBNB.Models.Enums;
using System;

namespace CaixaPrevidenciaBNB.Models.ViewModel
{
    public class ViewEmpregado
    {
        public int Identificador { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Sexo { get; set; }
        public int EstadoCivil { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}