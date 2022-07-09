using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205238#content
namespace FieldsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();
            // calling this method when a list is initialized inside it causes the count to reset
            // to prevent that use readonly keyword when creating a list


            Console.WriteLine(customer.Orders.Count);
        }
    }
}