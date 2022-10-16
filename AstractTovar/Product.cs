using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractTovar
{
    internal class Product : Commodity
    {
        /// <summary>
        /// Новый продукт.
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="price">Цена</param>
        /// <param name="manufactureDate">Дата производства</param>
        /// <param name="workingLife">Срок годности</param>
        public Product(string name, int price, DateTime manufactureDate, int workingLife)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
            WorkingLife = workingLife;
        }

        public override string Info()
        {
            return base.Info() +
                   string.Format("\nДата производства - {0}\nСрок годности - {1} дней",
                                 ManufactureDate, WorkingLife);
        }
    }

    /// <summary>
    /// Партия.
    /// </summary>
}
