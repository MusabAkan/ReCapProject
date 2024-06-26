﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarRepository : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (var context = new RecapContext())
            {
                var result = from cr in context.Cars
                             join b in context.Brands on cr.BrandId equals b.Id
                             join c in context.Colors on cr.ColorId equals c.Id
                             select new CarDetailsDto { BrandName = b.Name, CarName = cr.Description, ColorName = c.Name, DailyPrice = cr.DailyPrice };
                return result.ToList();
            }
        }
    }
}
