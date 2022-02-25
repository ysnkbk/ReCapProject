using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetBrandId(int id);
      
        void Add(Brand brandd);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
