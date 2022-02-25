using Business.Abstract;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

     
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            
           
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }


        public List<Color> GetColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            throw new NotImplementedException();
        }

     

        List<Color> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }


        List<Color> IColorService.GetColorId(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}
