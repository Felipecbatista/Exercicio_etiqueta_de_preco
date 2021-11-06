using System;
using System.Globalization;
using System.Text;

namespace Exercicio_etiqueta_de_preco.Entities
{
    class UsedProduct:Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate): base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacure date: " + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
