using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Autolot())
            {
                //var mark = new Mark
                //{
                //    Name = "Mercedes"
                //};
                //context.Marks.Add(mark);
                //context.Cars.Add(new Car { Mark = mark, Name = "Gelendwagen", Price = 190000, Color = "Space Grey" });
                //context.SaveChanges();

                var markWithT = from mark
                                in context.Marks
                                where mark.Name.ToLower().Contains("t")
                                orderby mark.Name
                                ascending
                                select mark;

                var cars = markWithT.Where(x => x.Cars.Count > 0)
                    .OrderBy(x => x.Name)
                    .FirstOrDefault();

                var name = "Oleg";
                int count = name.GetCount(); //Метод расширения

            }
        }
    }
}
