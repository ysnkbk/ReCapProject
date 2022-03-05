using Business.Abstract;
using Business.Constants;
using Core.Utilities;
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

        public IResult Add(Color color)
        {
            if(color.ColorId==1)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ProductAdded);

           
        }

        public IResult Delete(Color color)
        {
            if (color.ColorId == 1)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ProductDeleted);
        }


        public IDataResult<List<Color>> GetColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Color color)
        {
            if (color.ColorId == 1)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ProductUpdated);
        }

     

        IDataResult<List<Color>> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }


        IDataResult<List<Color>> IColorService.GetColorId(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}
