using CaixaPrevidenciaBNB.Models.Entity;
using CaixaPrevidenciaBNB.Models.Enums;
using CaixaPrevidenciaBNB.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace CaixaPrevidenciaBNB.Models.Help.Map
{
    public static class ViewEmpregadoAndEmpregadoEntityMap
    {
        public static Empregado MapByEmpregado(this ViewEmpregado empregado)
        {
            return new Empregado
            {
                Cpf = Convert.ToInt32(empregado.Cpf),
                Data_Nascimento = Convert.ToDateTime(empregado.Data_Nascimento),
                Email = empregado.Email,
                Estado_Civil = empregado.EstadoCivil == TipoEstadoCivil.Casado.GetHashCode() ? "Casado" :
                empregado.EstadoCivil == TipoEstadoCivil.Solteiro.GetHashCode() ? "Solteiro" : "Viuvo",
                Matricula = empregado.Matricula,
                Nome = empregado.Nome,
                Sexo = empregado.Sexo == TipoSexo.Feminino.GetHashCode() ? "Feminino" : "Masculino",
                Id = empregado.Identificador
            };
        }

        public static ViewEmpregado MapByViewEmpregado(this Empregado empregado)
        {
            return new ViewEmpregado
            {
                Cpf = empregado.Cpf.ToString(),
                Data_Nascimento = Convert.ToDateTime(empregado.Data_Nascimento),
                Email = empregado.Email,
                EstadoCivil = empregado.Estado_Civil == "Casado" ? TipoEstadoCivil.Casado.GetHashCode() :
                empregado.Estado_Civil == "Solteiro" ? TipoEstadoCivil.Solteiro.GetHashCode() : TipoEstadoCivil.Viuvo.GetHashCode(),
                Matricula = empregado.Matricula,
                Nome = empregado.Nome,
                Sexo = empregado.Sexo == "Feminino" ? TipoSexo.Feminino.GetHashCode() : TipoSexo.Masculino.GetHashCode(),
                Identificador = empregado.Id

            };
        }

        public static List<ViewEmpregado> MapByViewEmpregadoList(this List<Empregado> empregadolist)
        {
            var list = new List<ViewEmpregado>();

            foreach (var empregado in empregadolist)
            {
                list.Add(empregado.MapByViewEmpregado());
            }

            return list;
        }
    }
}