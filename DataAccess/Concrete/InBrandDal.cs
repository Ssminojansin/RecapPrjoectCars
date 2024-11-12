using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InBrandDal()
        {

            _brands = new List<Brand>()

            {
                new Brand{BrandId =1,BrandName="Kia Sportage",ColorId=1 ,ModelYear=2024 },
                new Brand{BrandId =2,BrandName="Fiat Egea",ColorId=1 ,ModelYear=2024 },
                new Brand{BrandId =3,BrandName="Togg T10X",ColorId=1 ,ModelYear=2024 },
                new Brand{BrandId =4,BrandName="Seat Leon",ColorId=1 ,ModelYear=2024 },
            };
        }
        public List<Brand> GetBrands()
        {
            return _brands;
        }

        public List<Brand> GetById(int brandId)
        {
            return _brands.Where(b => b.BrandId == brandId).ToList();
        }
    }
}
