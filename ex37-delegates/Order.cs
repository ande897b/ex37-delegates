using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex37_delegates
{
    public delegate double BonusProvider(double ammount);
  public  class Order
    {

        public BonusProvider Bonus { get; set; }

        private List<Product> products = new List<Product>();

        public void AddProduct (Product p)
        {
            products.Add(p);
        }
        public  double GetValueOfProducts()

        {
            double result = 0;
            foreach (Product product in products)
            {
                result += product.Value;
            }
            return result;
        }
        public double GetBonus()
        {
            double result = 0;

            result = Bonus(GetValueOfProducts());

            return result;
        }
        public double GetTotalPrice()
        {
            double result = 0;

            result = Bonus(GetValueOfProducts());
            result = GetValueOfProducts() - result;

            return result;
        }
    }
}
