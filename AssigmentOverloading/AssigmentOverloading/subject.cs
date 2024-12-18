using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOverloading
{
    public class subject : student
    {
        public subject (string name, string contact,int age,string address) : base (name , contact, age , address)
        {

        }
        public void sub(string course)
        {
            Console.WriteLine("Course " + course);
        }
        public void sub()
        {
            Console.WriteLine("Student Details");
            information();
        }
    }
}
