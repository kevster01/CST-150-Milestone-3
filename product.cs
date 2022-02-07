using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_Project_1
{
    public struct Product {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Brand")]
        public string Brand { get; set; }
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [DisplayName("Price")]
        public decimal Price { get; set; }
        [DisplayName("Category")]
        public int Category { get; set; }

        public override string ToString() {
            return
                $"Id = {Id}\nName = {Name.Stringify()}\nBrand = {Brand.Stringify()}\nQuantity = {Quantity}\nPrice = {Price}\nCategory = {Category}";
        }
    }
}
