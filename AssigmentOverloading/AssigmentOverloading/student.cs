using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOverloading
{
    public class student
    {
        string name;
        string contact;
        int age;
        string address;

        public student(string name, string contact, int age,string address)
        {
            this.name = name;
            this.contact = contact;
            this.age = age;
            this.address= address;
        }

        public void information()
        {
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Age is " + age);
            Console.WriteLine("Contact is " + contact);
            Console.WriteLine("Address is " + address);
        }
    }
}
