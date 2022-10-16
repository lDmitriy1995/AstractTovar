using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractTovar
{
    internal class Set : Commodity
    {
        private readonly string _list;

        /// <summary>
        /// Новый комплект.
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="price">Цена</param>
        /// <param name="list">Перечень продуктов</param>
        public Set(string name, int price, string list)
        {
            _list = list;
            Name = name;
            Price = price;
        }

        public override string Info()
        {
            return base.Info() +
                   string.Format("\nПеречень продуктов - {0}",
                                 _list);
        }

        // Переопределяем, так как у комплекта бесконечный срок годности.
        public override bool IsCorrespondsToWorkingLife(DateTime currentDate)
        {
            return true;
        }
    }
}
