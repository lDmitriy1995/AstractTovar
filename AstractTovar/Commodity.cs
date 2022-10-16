using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractTovar
{
    internal abstract class Commodity
    {
        /// <summary>
        /// Дата производства.
        /// </summary>
        protected DateTime ManufactureDate;

        /// <summary>
        /// Название продукта.
        /// </summary>
        protected string Name;

        /// <summary>
        /// Цена.
        /// </summary>
        protected int Price;

        /// <summary>
        /// Срок годности.
        /// </summary>
        protected int WorkingLife;

        /// <summary>
        /// Вывод информации о товаре.
        /// </summary>
        public virtual string Info()
        {
            return string.Format("Название продукта - {0}\nЦена - {1}", Name, Price);
        }

        /// <summary>
        /// Соответствие сроку годности.
        /// </summary>
        /// <param name="currentDate">Текущая дата.</param>
        /// <returns>true, если годен.</returns>
        public virtual bool IsCorrespondsToWorkingLife(DateTime currentDate)
        {
            return (currentDate < ManufactureDate + new TimeSpan(WorkingLife, 0, 0, 0));
        }
    }

    /// <summary>
    /// Продукт.
    /// </summary>
}
