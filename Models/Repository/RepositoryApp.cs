using CaixaPrevidenciaBNB.Models.Entity;
using System.Data.Entity;

namespace CaixaPrevidenciaBNB.Models.Repository
{
    public class RepositoryApp : DbContext
    { 
       private BNEContext _context = new BNEContext();
        private RepositoryBase<Empregado> _empregadoRepository;
        public RepositoryBase<Empregado> EmpregadoRepository
        {
            get
            {
                if (_empregadoRepository == null)
                {
                    _empregadoRepository = new RepositoryBase<Empregado>(_context);
                }
                return _empregadoRepository;
            }
        } 
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}