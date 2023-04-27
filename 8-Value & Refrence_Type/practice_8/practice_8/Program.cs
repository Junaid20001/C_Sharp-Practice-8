using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8
{
    /*
    internal class Program
    {
        
        public void Show(int val)
        {
            val *= val;
            Console.WriteLine("Inside the show function/method " + val);    //no return value
        }
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("before calling the function " + val);
            program.Show(val);
            Console.WriteLine("after calliing the function " + val);
        */
    /*
    //Value Type or Struct or (object create in Stack memory)...
    struct Employee
    {                                      
        public int Salary;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Salary = 5000;
            e.Age = 23;

            Employee e1 = e;
            Employee e2 = e;

            e.Age = 25;
            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);
       */
    /*
    //Value Type or Struct or (object create in Stack memory)...
    internal class Program
    {
        public void jk(int old_val)
        {
            int new_val;
            new_val = old_val + 10;
            Console.WriteLine("Value in the called function is : " + new_val);
        }
        static void Main(string[] args)
        {
            int old_val = 15;
            Program jks = new Program();
            Console.WriteLine("value before calling the function : " + old_val);
            jks.jk(old_val);
            Console.WriteLine("value after calling the function: " + old_val);
    */
    /*
    //Reference Type or Class or (object create in Heap memory)
    internal class Program
    {
        public void jk(ref int old_val)
        {
            int new_val;
            new_val = old_val + 10;
            Console.WriteLine("Value in the called function is : " + new_val);
            old_val = new_val;
        }
        
        static void Main(string[] args)
        {
            int old_val = 15;
            Program jks = new Program();
            Console.WriteLine("value before calling the function : " + old_val);
            jks.jk(ref old_val);
            Console.WriteLine("value after calling the function: " + old_val);
    */
    /*
    //Reference Type or Class or (object create in Heap memory)
    class Employee
    {
        public int Salary;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Salary = 5000;
            e.Age = 23;

            Employee e1 = e;
            Employee e2 = e;

            e.Age = 25;
            Console.WriteLine(e.Age);
            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);
    */
            Console.ReadLine();
        }
    }

}
   
