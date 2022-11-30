using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Day3
{
    internal class Program
    {
        static void Main()
        {
            
            //Please Uncomment whichever questions answer you would like to view.
            //For Example Uncomment the lines under commented  Question1 to view the output for the question
            //I have uncommented the answer of 3rd question, so for now it will give output of third question, kindly uncomment whichever answer you want to view, Thanks!!
            
            Program cube = new Program();
            //cube.Cubes();     //question 1
            Program matches = new Program();
            //matches.Matches();            //question 2
            List<Orders> order = new List<Orders>()
            {

            new Orders() {id = 209, name = "Soap",date = "12/03/2017", quantity = 8},

            new Orders() {id = 211, name = "Comb", date = "03/05/2016", quantity = 6},

            new Orders() {id = 212, name = "Mouse", date = "04/08/2017", quantity = 8},

            new Orders() {id = 213, name = "Chair", date = "12/01/2016", quantity = 5},

            new Orders() {id = 214, name = "Table", date = "17/06/2015", quantity = 1},
            };
            List<Items> item = new List<Items>()
            {

            new Items() {name = "Soap",price =10},

            new Items() {name = "Comb",price =2},

            new Items() {name = "Mouse",price = 65},

            new Items() {name = "Chair",price = 250},

            new Items() {name = "Table", price = 365},
            };
            //start of question 3
           // /*
            var res = order.OrderByDescending(o => o.date).OrderByDescending(a => a.quantity);
            foreach (var val in res)
            {
                Console.Write("Name: {0}", val.name);
                Console.Write(" Date: {0}", val.date);
                Console.WriteLine(" Quantity: {0}", val.quantity);
            }
          //  */
            //end of question 3

            //start of quesion 4
            /*
            var monthorder = from o in order
                             orderby o.date.Substring(3,2) descending
                             select o;
            foreach (var val in monthorder)
            {
                Console.Write("Name: {0}", val.name);
                Console.Write(" Date: {0}", val.date);
                Console.WriteLine(" Quantity: {0}", val.quantity);
            }
            */
            //end of question 4

            //start of question 5
            /*
            var itemtotalprice = from o in order
                                 join i in item
                                  on o.name equals i.name
                                 orderby o.date.Substring(3, 2) descending
                                 select new
                                 {
                                     name = i.name,
                                     totalprice = i.price * o.quantity,
                                     date = o.date,
                                     id = o.id
                                 };
            foreach (var val in itemtotalprice)
            {
                Console.Write("Id: {0}", val.id);
                Console.Write(" Name: {0}", val.name);
                Console.Write(" Date: {0}", val.date);
                Console.WriteLine(" Total Price: {0}", val.totalprice);
            }
            */
            //end of question 5
            
            //start of question 9
            /*
            int[] no = { 2, 6, 5, 1, 3, 4, 8, 45 };
            int count = 0;
            foreach( int i in no)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i.ToString());
                    count++;
                }                
            }
            Console.Write("Count is :");
            Console.WriteLine(count);
            
            */
            //end of question 9




        }

        public void Cubes()
        {
            int[] nos = { 12, 568, 264, 10254, 21, 658, 235, 14, 52, 45, 24, 81, 85118, 15551, 125, 96 };
            var cubes = nos.Where(x => x > 100).Where(x => x < 1000).ToList();
            foreach (int a in cubes)
            {
                Console.WriteLine(a * a * a);
            }
        }

        public void Matches()
        {
            List<string> names = new List<string> { "ram", "sam", "alex", "jonh", "abhi", "vish" };
            int halflen = (names.Count() / 2);
            int coun = (names.Count()) - 1;
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            for (int i = 0; i < halflen; i++)
            {
                list1.Add(names[i]);
            }
            for (int j = halflen; j <= coun; j++)
            {
                list2.Add(names[j]);
            }
            var combo = from a in list1
                        from b in list2
                        select new { a, b };
            foreach (var i in combo)
            {
                Console.WriteLine(i);
            }

        }
   
    }

    public class Orders
    {

        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string date
        {
            get;
            set;
        }

        public int quantity
        {
            get;
            set;
        }
    }

    public class Items
    {
        public string name
        {
            get;
            set;
        }

        public int price
        {
            get;
            set;
        }        
    }


}
