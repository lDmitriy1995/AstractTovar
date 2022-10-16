#region using

using AstractTovar;
using System;
using System.Collections.Generic;

#endregion

namespace ConsoleApplicationTest
{

    public static class Program
    {
        private static void Main()
        {
            List<Commodity> commodities = new List<Commodity>
                                  {
                                      new Product("молоко", 20, Convert.ToDateTime("01.12.2022"), 14),
                                      new Product("кефир ", 30, Convert.ToDateTime("02.12.2022"), 6),
                                      new Batch("йогурт", 30, 4, Convert.ToDateTime("04.12.2022"), 1),
                                      new Batch("актимэль", 15, 4, Convert.ToDateTime("05.12.2022"), 21),
                                      new Set("карандаши", 40, "цветные"),
                                      new Set("ручки", 50, "синие")
                                  };

            // Выводим данные и соответствие сроку годности.
            DateTime now = DateTime.Now;
            foreach (Commodity commodity in commodities)
            {
                Console.WriteLine(commodity.Info());
                Console.WriteLine(commodity.IsCorrespondsToWorkingLife(now) ? "Годен" : "Не годен");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    
    
   
   
}
