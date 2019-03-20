using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleCare.Models;

namespace TeleCare.Repository
{
    public interface ICarsRepository
    {
        IQueryable<Cars> GetAllCars();
        Cars Update(Cars address);
        void Delete(int id);
        Cars AddCars(Cars cars);
        bool CheckForFeatures(Cars Cars);
    }
}
