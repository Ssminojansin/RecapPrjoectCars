using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InColorDal : IColorDal
    {
        List<Color> _colors;
        public InColorDal()
        {
            _colors = new List<Color>()
            {
                new Color{ColorId=1 ,ColorName="Siyah" },
                new Color{ColorId=2 ,ColorName="Mavi" },
            };
        }
        public List<Color> GetById(int colorId)
        {
            return _colors.Where(d => d.ColorId == colorId).ToList();
        }

        public List<Color> GetColors()
        {
            return _colors;
        }
    }
}
