using Core.Utilities;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetBrandId(int id);
      
        IResult Add(Brand brandd);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
