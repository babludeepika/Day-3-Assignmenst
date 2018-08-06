using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderinLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PizzaOrder> po = new List<PizzaOrder>
                {
                        new PizzaOrder {orderid=1,orderdate=DateTime.Now,pizzatype="veg",pizzasize='s',toppings="sweetcorn",qty=1,price=300 },
                        new PizzaOrder {orderid=2,orderdate=DateTime.Now,pizzatype="veg",pizzasize='m',toppings="onion",qty=2,price=350 },
                        new PizzaOrder {orderid=3,orderdate=DateTime.Now,pizzatype="veg",pizzasize='l',toppings="capsicum",qty=10,price=400 },
                        new PizzaOrder {orderid=4,orderdate=DateTime.Now,pizzatype="veg",pizzasize='s',toppings="tomato",qty=5,price=200 },
                        new PizzaOrder {orderid=5,orderdate=DateTime.Now,pizzatype="non veg",pizzasize='m',toppings="chicken",qty=6,price=600 },
                        new PizzaOrder {orderid=6,orderdate=DateTime.Now,pizzatype="non veg",pizzasize='s',toppings="egg",qty=7,price=369 },
                        new PizzaOrder {orderid=7,orderdate=DateTime.Now,pizzatype="non veg",pizzasize='m',toppings="chicken",qty=5,price=400 },
                        new PizzaOrder {orderid=8,orderdate=DateTime.Now,pizzatype="non veg",pizzasize='s',toppings="egg",qty=3,price=500 },


            };

            //for selecting all pizza orders
            var data = from t in po
                       select t;

            foreach (var d in data)
                Console.WriteLine(d.orderid + "," + d.orderdate + "," + d.pizzatype + "," + d.pizzasize + "," + d.toppings + "," + d.qty + "," + d.price);
        
            Console.WriteLine("*************************");

            //displaying pizza based on pizzatype and size

            var data1 = from t in po
                        where t.pizzasize == 'l' && t.pizzatype == "non veg"
                        select t;
            foreach (var e in data1)
                Console.WriteLine(e.orderid + "," + e.orderdate + "," + e.pizzatype + "," + e.pizzasize + "," + e.toppings + "," + e.qty + "," + e.price);

            Console.WriteLine("*************************");

            var data2 = from t in po
                        group t by t.pizzatype into grp
                        select new { PizzaSold = grp.Count(), AmountCollected = grp.Sum(x => x.price) };
            foreach (var d in data2)
                Console.WriteLine(d.PizzaSold + "," + d.AmountCollected);
            Console.WriteLine("*************************");

            var data3 = from t in po
                        group t by t.pizzasize into grp
                        select new { PizzaSold = grp.Count(), AmountCollected = grp.Sum(x => x.price) };
            foreach (var d in data3)
                Console.WriteLine(d.PizzaSold + "," + d.AmountCollected);
            Console.WriteLine("*************************");

            var data4= from t in po
                       where t.pizzasize=='m'
                       select t;
            foreach (var d in data4)
                Console.WriteLine(d.pizzatype + "," + d.toppings);
            Console.WriteLine("*************************");

            var data5 = from t in po
                        where t.price == po.Max(x => x.price)
                        select t;
            foreach(var d in data5)
                Console.WriteLine(d.orderid + "," + d.orderdate + "," + d.pizzatype + "," + d.pizzasize + "," + d.toppings + "," + d.qty + "," + d.price);
            Console.WriteLine("*************************");

            var data6 = from t in po
                        where t.price == po.Min(x => x.price)
                        select t;
            foreach (var d in data6)
                Console.WriteLine(d.orderid + "," + d.orderdate + "," + d.pizzatype + "," + d.pizzasize + "," + d.toppings + "," + d.qty + "," + d.price);


        }
    }
}
