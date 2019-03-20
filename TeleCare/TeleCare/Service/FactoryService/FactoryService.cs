using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleCare.Models;
using TeleCare.Repository;

namespace TeleCare.Service.FactoryService
{
    public class FactoryService : IFactoryService
    {
        private readonly IFactoryRepository factoryRepository;
        public FactoryService()
        {
            factoryRepository = new FactoryRepository();
        }
        public IQueryable<Factory> GetAll()
        {
            return factoryRepository.GetAllfactory();
        }
      
    }
}