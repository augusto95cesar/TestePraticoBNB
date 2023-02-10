using CaixaPrevidenciaBNB.Models.Aplicacao;
using CaixaPrevidenciaBNB.Models.Aplicacao.Interface;
using CaixaPrevidenciaBNB.Models.ViewModel;
using System.Web.Mvc;

namespace CaixaPrevidenciaBNB.Controllers
{
    public class EmpregadoController : Controller
    {
        private IEmpregadoAplication _iEmpregadoApp;
        
        public EmpregadoController()
        {
            _iEmpregadoApp = new EmpregadoAplication();           
        }
        // GET: Empregado
        public ActionResult Index()
        {
            var list = _iEmpregadoApp.GetEmpregados();            
            return View(list);
        }

        // GET: Empregado/Details/5
        public ActionResult Details(int id)
        {
            var empregado = _iEmpregadoApp.GetEmpregadoById(id);
            return View(empregado);
        }

        // GET: Empregado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empregado/Create
        [HttpPost]
        public ActionResult Create(ViewEmpregado viewEmpregado)
        {
            try
            {
                _iEmpregadoApp.CreateEmpregado(viewEmpregado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empregado/Edit/5
        public ActionResult Edit(int id)
        {           
            return View(_iEmpregadoApp.GetEmpregadoById(id));
        }

        // POST: Empregado/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ViewEmpregado viewEmpregado)
        {
            try
            {
                _iEmpregadoApp.UpdateEmpregado(id, viewEmpregado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empregado/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_iEmpregadoApp.GetEmpregadoById(id));
        }

        // POST: Empregado/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ViewEmpregado viewEmpregado)
        {
            try
            {
                _iEmpregadoApp.RemoveEmpregado(id, viewEmpregado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
