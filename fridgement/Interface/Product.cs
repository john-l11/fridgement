using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace fridgement.Interface
{
    public class Product
    {
        public string ID {  get; }
        public string Name { get; }
        public Location location { get; }
        public int Quantity { get; }
        public DateTime ExpiryDate { get; }
    }
}
