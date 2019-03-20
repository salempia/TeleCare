using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using System.Data.SqlClient;
using TeleCare.Repository.Base;
using TeleCare.Models;

namespace TeleCare.Repository
{
    public class CarsRepository : BaseRepository<Cars> , ICarsRepository   
    {       
       
        public IQueryable<Cars> GetAllCars()
        {
            throw new NotImplementedException();
        }

        Cars ICarsRepository.Update(Cars address)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Cars AddCars(Cars cars)
        {
            throw new NotImplementedException();
        }

        public bool CheckForFeatures(Cars Cars)
        {
            return Cars.ExtraCarFeatures != null ? true : false;
        }
    }
}