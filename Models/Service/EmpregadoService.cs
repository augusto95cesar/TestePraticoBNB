
using CaixaPrevidenciaBNB.Models.Entity;
using CaixaPrevidenciaBNB.Models.Help.Map;
using CaixaPrevidenciaBNB.Models.Repository;
using System;
using System.Collections.Generic;

namespace CaixaPrevidenciaBNB.Models.Service
{
    public class EmpregadoService
    {
        private RepositoryApp _repApp;
        public EmpregadoService()
        {
            _repApp = new RepositoryApp();
        }

        internal void Create(Empregado empregado)
        {
            _repApp.EmpregadoRepository.Add(empregado);
            _repApp.Commit();
        }

        internal Empregado GetById(int id)
        {
            return _repApp.EmpregadoRepository.FindById(id);
        }

        internal List<Empregado> GetAll()
        {            
            return _repApp.EmpregadoRepository.FindAll().ConvertForList();           
        }

        internal void Update(Empregado bdempresa)
        {
            _repApp.EmpregadoRepository.Edit(bdempresa);
            _repApp.Commit();
        }

        internal void Remove(Empregado bdempresa)
        {
            _repApp.EmpregadoRepository.Remove(bdempresa);
            _repApp.Commit();
        }
    }
}