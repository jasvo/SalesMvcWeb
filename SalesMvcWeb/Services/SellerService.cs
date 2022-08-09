using SalesMvcWeb.Data;
using SalesMvcWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesMvcWeb.Services
{
    public class SellerService
    {
        private readonly SalesMvcWebContext _context;

        public SellerService( SalesMvcWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
