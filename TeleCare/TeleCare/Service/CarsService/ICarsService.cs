using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleCare.Models;

namespace TeleCare.Service.FactoryService
{
    public interface ICarsService
    {
        Cars Add(string price, string color, List<ExtraCarFeatures> extraCarFeatures);
        bool CheckIfCarHasExtraFeatures(Cars car);
    }
}