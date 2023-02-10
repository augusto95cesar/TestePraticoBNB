using CaixaPrevidenciaBNB.Models.Aplicacao.Interface;
using CaixaPrevidenciaBNB.Models.Service;
using CaixaPrevidenciaBNB.Models.ViewModel;
using System.Collections.Generic;
using CaixaPrevidenciaBNB.Models.Help.Map;
using System;

namespace CaixaPrevidenciaBNB.Models.Aplicacao
{
    public class EmpregadoAplication : IEmpregadoAplication
    {
        private EmpregadoService _service;
        public EmpregadoAplication()
        {
            _service = new EmpregadoService();
        }

        public void CreateEmpregado(ViewEmpregado empregado)
        {
            var map = empregado.MapByEmpregado();
            _service.Create(map);
        }

        public ViewEmpregado GetEmpregadoById(int id)
        {
            return _service.GetById(id).MapByViewEmpregado();
        }

        public List<ViewEmpregado> GetEmpregados()
        {
            return _service.GetAll().MapByViewEmpregadoList();
        }

        public void RemoveEmpregado(int id,ViewEmpregado empregado)
        {
            var bdempresa = _service.GetById(id);
            _service.Remove(bdempresa);
        }

        public void UpdateEmpregado(int id, ViewEmpregado empregado)
        {
           var bdempresa = _service.GetById(id);

            bdempresa.Matricula = empregado.Matricula;
            bdempresa.Nome = empregado.Nome;
            bdempresa.Email = empregado.Email;
            bdempresa.Cpf = Convert.ToInt32(empregado.Cpf);

            _service.Update(bdempresa);
        }
    }
}