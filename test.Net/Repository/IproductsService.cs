using System;
using test.Net.Models;

namespace test.Net.Repository
{
    public interface IproductsService
    {
        void Addcostumer(customer customertoadd);
        
        void GetIndex();
    }
}
