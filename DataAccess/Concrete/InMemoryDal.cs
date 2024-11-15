﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
       
        

        public InMemoryDal()
        {

            _cars = new List<Car>()
            {
             new Car { CarId = 1, BrandId = 1,ColorId =1, DailyPrice = 1500, Description = "Full Consept"},
            new Car { CarId = 2, BrandId = 3,ColorId =2, DailyPrice = 2500, Description = "Yol Yardım Desteği"},
            new Car {CarId = 3, BrandId = 3, ColorId =1, DailyPrice = 3500, Description = "Elektrikli"},
            new Car {CarId = 4, BrandId = 4,ColorId =2,  DailyPrice = 4500, Description = "Dehşet Verici"},
            new Car {CarId = 5, BrandId = 2,ColorId =1,  DailyPrice = 5500, Description = "Full Consept"},

        };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
        }

     
    }
}
