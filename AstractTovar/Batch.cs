using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractTovar
{
    internal class Batch : Commodity
    {
        private readonly int _count;

        /// <summary>
        /// Новая партия.
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="price">Цена</param>
        /// <param name="count">Количество.</param>
        /// <param name="manufactureDate">Дата производства</param>
        /// <param name="workingLife">Срок годности</param>
        public Batch(string name, int price, int count, DateTime manufactureDate, int workingLife)
        {
            _count = count;
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
            WorkingLife = workingLife;
        }

        public override string Info()
        {
            return base.Info() +
                   string.Format("\nКоличество - {0}\nДата производства - {1}\nСрок годности - {2} дней",
                                 _count, ManufactureDate, WorkingLife);
        }
    }

    /// <summary>
    /// Комплект.
    /// </summary>
}
