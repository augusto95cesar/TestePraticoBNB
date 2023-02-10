using System;

namespace CaixaPrevidenciaBNB.Models.Entity
{
    public class Empregado
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Estado_Civil { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }

    }
}