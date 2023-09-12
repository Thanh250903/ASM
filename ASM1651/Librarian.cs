using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1651
{
    internal class Librarian : Person
    {
        private string idCard;
        private int phoneNumber;
        private int getKPI;
        private double salary;
        public void setidCard(string idCard)
        {
            this.idCard = idCard;
        }
        public string getidCard()
        {
            return this.idCard;
        }
        public void setPhoneNumber(int phoneNumber) 
        {
            this.phoneNumber = phoneNumber;
        }
        public int getPhoneNumber()
        {
            return this.phoneNumber;
        }
        public void setgetKPI(int kPI)
        {
            this.getKPI = kPI;
        }
        public int getgetKPI()
        {
            return this.getKPI;
        }
        public void setsalary(double salary)
        {
            this.salary = salary;
        }
        public double getsalary()
        {
            return this.salary;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setage(int age)
        {
            this.age = age;
        }
        public int getage()
        {
            return this.age;
        }
        public Librarian(string name, int age,string idCard, int phoneNumber, int getKPI, double salary) : base(name, age)
        {
            this.idCard = idCard;
            this.phoneNumber = phoneNumber;
            this.getKPI = getKPI;
            this.salary = salary;
        }
        public Librarian()
        {

        }
        public override string ToString()
        {
            return "Name: '" + this.name
               + "', Age: '" + this.age
               + "', ID card: '" + this.idCard
               + "', Phone number: '" + this.phoneNumber
               + "', KPI: '" + this.getKPI
               + "', Salary: '" + this.salary;
        }

    }
    

}
