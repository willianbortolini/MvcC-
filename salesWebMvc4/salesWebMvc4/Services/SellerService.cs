using salesWebMvc4.Data;
using salesWebMvc4.Models;
using System.Collections.Generic;
using System.Linq;

namespace salesWebMvc4.Services
{
    public class SellerService
    {
        private readonly salesWebMvc4Context _context;

        public SellerService(salesWebMvc4Context context)
        {
            _context = context;
        }

        public  List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }

}
