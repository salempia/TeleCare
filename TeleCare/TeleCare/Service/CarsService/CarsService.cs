using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleCare.Models;
using TeleCare.Repository;

namespace TeleCare.Service.FactoryService
{
    public class CarsService : ICarsService
    {
        List<Cars> newCars = new List<Cars>();
        private readonly ICarsRepository carsRepository;
        public CarsService()
        {
            carsRepository = new CarsRepository();
        }

        public Cars Add(string price, string color, List<ExtraCarFeatures> extraCarFeatures)
        {
            List<ExtraCarFeatures> extrafeatures = new List<ExtraCarFeatures>();
            Cars cars = new Cars();
            cars.ExtraCarFeatures = extraCarFeatures;
            cars.Color = color;
            cars.Price = price;

            carsRepository.AddCars(cars);

            return cars;
        }

        public IQueryable<Cars> GetAll()
        {
            return carsRepository.GetAllCars();
        }

        public bool CheckIfCarHasExtraFeatures(Cars car)
        {
            return carsRepository.CheckForFeatures(car);
        }
    }
}