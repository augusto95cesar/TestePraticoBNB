using CaixaPrevidenciaBNB.Models.ViewModel;
using System.Collections.Generic;

namespace CaixaPrevidenciaBNB.Models.Aplicacao.Interface
{
    interface IEmpregadoAplication
    {
        List<ViewEmpregado> GetEmpregados();
        ViewEmpregado GetEmpregadoById(int id);
        void CreateEmpregado(ViewEmpregado empregado);
        void UpdateEmpregado(int id, ViewEmpregado empregado);
        void RemoveEmpregado(int id, ViewEmpregado empregado);
    }
}
