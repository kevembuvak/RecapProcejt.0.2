using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkDal
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from car in context.Set<Car>()
                             join brand in context.Set<Brand>()
                             on car.BrandId equals brand.BrandId
                             join color in context.Set<Color>()
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarName = car.Name,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName
                             };

                return result.ToList();

            }
        }
    }
}
