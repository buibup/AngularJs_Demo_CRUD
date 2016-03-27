using AngularJs_Demo_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJs_Demo_CRUD.Interface
{
    interface IProductRepository
    {
        IEnumerable<TblProductList> GetAll();
        TblProductList Get(int id);
        TblProductList Add(TblProductList item);
        bool Update(TblProductList item);
        bool Delete(int id);
    }
}
