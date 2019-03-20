using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleCare.Models;

namespace TeleCare.Service.FactoryService
{
    public interface IFactoryService
    {
        IQueryable<Factory> GetAll();
    }
}