using System;
using System.Transactions;

namespace Day1
{

    interface IGovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaVeDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    }

    class TCS : IGovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basicSalary;

        public double EmployeePF(double basicSalary)
        {
            double pf = 0.00;
            pf = (basicSalary * 0.12) + (basicSalary * 0.0833);
            return(pf);
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuity = 0.00;
            if ( serviceCompleted < 5)
            {
                gratuity = 0.00;
            }
            else if ( serviceCompleted > 5)
            {
                gratuity = basicSalary / 12;
            }
            else if (serviceCompleted > 10)
            {
                gratuity = basicSalary * 2;
            }
            else if (serviceCompleted > 20)
            {
                gratuity = basicSalary * 3;
            }

            return (gratuity);

        }

        public string LeaVeDetails()
        {
            return("1 day of Casual Leave per Month \n12 days of Sick per Year \n10 days of Previlage Leave per Year");
           
        }
        public TCS(int Empid, string Name,string Dept,string Desg, double Basicsalary)
        {
            empid = Empid;
            name = Name;
            dept = Dept;
            desg = Desg;
            basicSalary = Basicsalary;
            
        }



    }

    class WellsFargo : IGovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basicSalary;

        public double EmployeePF(double basicSalary)
        {
            double pf = 0.00;
            pf = (basicSalary * 0.12) + (basicSalary * 0.12);
            return (pf);
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuity = 0.00;
            if (serviceCompleted < 5)
            {
                gratuity = 0.00;
            }
            else if (serviceCompleted > 5)
            {
                gratuity = basicSalary / 12;
            }
            else if (serviceCompleted > 10)
            {
                gratuity = basicSalary * 2;
            }
            else if (serviceCompleted > 20)
            {
                gratuity = basicSalary * 3;
            }

            return (gratuity);

        }

        public string LeaVeDetails()
        {
            return ("1 day of Casual Leave per Month \n12 days of Sick per Year \n10 days of Previlage Leave per Year");

        }
        public WellsFargo(int Empid, string Name, string Dept, string Desg, double Basicsalary)
        {
            empid = Empid;
            name = Name;
            dept = Dept;
            desg = Desg;
            basicSalary = Basicsalary;

        }
    }

    class Accenture : IGovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basicSalary;

        public double EmployeePF(double basicSalary)
        {
            double pf = 0.00;
            pf = (basicSalary * 0.12) + (basicSalary * 0.12);
            return (pf);
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuity = 0.00;
            return (gratuity);

        }

        public string LeaVeDetails()
        {
            return ("2 day of Casual Leave per Month \n5 days of Sick per Year \n5 days of Previlage Leave per Year");

        }
        public Accenture(int Empid, string Name, string Dept, string Desg, double Basicsalary)
        {
            empid = Empid;
            name = Name;
            dept = Dept;
            desg = Desg;
            basicSalary = Basicsalary;

        }
    }

    class Program
    {
        static void Main()
        {
            TCS objtcs = new TCS(125,"Raj","Tech","Software Engineer",110000);
            WellsFargo objwf = new WellsFargo(1587, "Ram", "Tech", "Software Engineer", 11000);
            Accenture objacc = new Accenture(96, "Abhi", "Tech", "Software Engineer", 420875);
            Console.WriteLine(objtcs.gratuityAmount(8,1256985));
            Console.WriteLine(objwf.EmployeePF(1256985));
            Console.WriteLine(objtcs.EmployeePF(1256985));
            Console.WriteLine(objacc.LeaVeDetails());


        }
    }

}

