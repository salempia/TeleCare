using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleCare.Models;

namespace TeleCare.Repository
{
    public interface IFactoryRepository
    {
        IQueryable<Factory> GetAllfactory();
        Factory Update(Factory factory);
        void Delete(int id);
        Factory Addfactory(Factory factory);        
    }
}
