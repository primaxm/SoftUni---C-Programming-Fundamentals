using System;
using System.Collections.Generic;
using System.Linq;

namespace Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //product name. product price
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            while (n-- != 0)
            {
                string[] pro = Console.ReadLine().Split('-').ToArray();
                if (products.ContainsKey(pro[0]))
                {
                    products[pro[0]] = decimal.Parse(pro[1]);
                }
                else
                {
                    products.Add(pro[0], decimal.Parse(pro[1]));
                }
            }

            //client name, product name, quantity
            string[] cust = Console.ReadLine().Split(new char[] { '-', ','}).ToArray();
            List<Customer> cList = new List<Customer>();

            while (cust[0] != "end of clients")
            {
               
                if (products.ContainsKey(cust[1]))
                {
                    if (cList.Any(x => x.Name == cust[0]))
                    {
                        //update
                        foreach (var item in cList.Where(x => x.Name == cust[0]))
                        {
                            if (item.ShopList.ContainsKey(cust[1]))
                            {
                                item.ShopList[cust[1]] += int.Parse(cust[2]);
                            }
                            else
                            {
                                item.ShopList.Add(cust[1], int.Parse(cust[2]));
                            }
                            item.Bill += products[cust[1]] * int.Parse(cust[2]);
                        }
                        
                    }
                    else
                    {
                        Customer customers = new Customer();
                        customers.Name = cust[0];
                        Dictionary<string, int> tmp = new Dictionary<string, int>();
                        tmp.Add(cust[1], int.Parse(cust[2]));
                        customers.ShopList = tmp;
                        customers.Bill = products[cust[1]] * int.Parse(cust[2]);
                        cList.Add(customers);
                    }

                }
                cust = Console.ReadLine().Split(new char[] { '-', ',' }).ToArray();
            }
            
            foreach (var item in cList.OrderBy(x => x.Name))
            {
                Console.WriteLine(item.Name);
                foreach (var pro in item.ShopList)
                {
                    Console.WriteLine($"-- {pro.Key} - {pro.Value}");
                }

                Console.WriteLine($"Bill: {item.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {cList.Sum(x => x.Bill):f2}");


        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
