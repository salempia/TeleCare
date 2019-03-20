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
    public class FactoryRepository : BaseRepository<Factory> , IFactoryRepository
    {       
      
        public Factory Update(Factory factory)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Factory Addfactory(Factory factory)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Factory> GetAllfactory()
        {
            throw new NotImplementedException();
        }
    }
}