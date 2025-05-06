using System;

public interface IEmployee
{
    string Id { get; set; }
    string Name { get; set; }
    float MonthlyPackage { get; set; }
    int Attendance { get; set; }
    int Da { get; set; }
    int Ta { get; set; }
    int Hra { get; set; }
    int Ppf { get; set; }
    float GrossSalary { get; set; }
    float NetSalary { get; set; }
    float TotalSalary { get; set; }

    float CalculateGrossSalary();
    float CalculateNetSalary();
    float CalculateTotalSalary();
    void DisplayPaySlip();
}

public abstract class EmployeeBase : IEmployee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public float MonthlyPackage { get; set; }
    public int Attendance { get; set; }
    public int Da { get; set; }
    public int Ta { get; set; }
    public int Hra { get; set; }
    public int Ppf { get; set; }
    public float GrossSalary { get; set; }
    public float NetSalary { get; set; }
    public float TotalSalary { get; set; }
    public int Incentives { get; set; }

    public float CalculateGrossSalary()
    {
        return MonthlyPackage * (Attendance / 31f);
    }

    public float CalculateNetSalary()
    {
        return GrossSalary + Da + Ta + Hra - Ppf;
    }

    public float CalculateTotalSalary()
    {
        return NetSalary + Incentives;
    }

    public abstract void DisplayPaySlip();

    protected EmployeeBase(string id, string name, float package, int attendance)
    {
        Id = id;
        Name = name;
        MonthlyPackage = (package * 100000) / 12;
        Attendance = attendance;
        GrossSalary = CalculateGrossSalary();
        NetSalary = CalculateNetSalary();
        TotalSalary = CalculateTotalSalary();
    }
}

public class Developer : EmployeeBase
{
    public Developer(string id, string name, float package, int attendance)
        : base(id, name, package, attendance)
    {
        Da = 2000;
        Ta = 2000;
        Hra = 15000;
        Ppf = 550;
        Incentives = 10000;
        GrossSalary = CalculateGrossSalary();
        NetSalary = CalculateNetSalary();
        TotalSalary = CalculateTotalSalary();
    }

    public override void DisplayPaySlip()
    {
        Console.WriteLine();
        Console.WriteLine("---------------Pay Slip--------------");
        Console.WriteLine($"Salary Slip for {Name} ({Id}):");
        Console.WriteLine("Role: Developer");
        Console.WriteLine($"Base Package: {MonthlyPackage}/mo");
        Console.WriteLine($"Attendance out of 31: {Attendance}");
        Console.WriteLine($"DA: {Da}");
        Console.WriteLine($"TA: {Ta}");
        Console.WriteLine($"HRA: {Hra}");
        Console.WriteLine($"PPF: {Ppf}");
        Console.WriteLine($"Gross Salary: {GrossSalary}");
        Console.WriteLine($"Net Salary: {NetSalary}");
        Console.WriteLine($"Incentives: {Incentives}");
        Console.WriteLine($"Total Salary: {TotalSalary}");
        Console.WriteLine();
    }
}

public class BackOffice : EmployeeBase
{
    public BackOffice(string id, string name, float package, int attendance)
        : base(id, name, package, attendance)
    {
        Da = 1000;
        Ta = 1000;
        Hra = 8000;
        Ppf = 1050;
        Incentives = 0;
        GrossSalary = CalculateGrossSalary();
        NetSalary = CalculateNetSalary();
        TotalSalary = CalculateTotalSalary();
    }

    public override void DisplayPaySlip()
    {
        Console.WriteLine();
        Console.WriteLine("---------------Pay Slip--------------");
        Console.WriteLine($"Salary Slip for {Name} ({Id}):");
        Console.WriteLine("Role: BackOffice");
        Console.WriteLine($"Base Package: {MonthlyPackage}/mo");
        Console.WriteLine($"Attendance out of 31: {Attendance}");
        Console.WriteLine($"DA: {Da}");
        Console.WriteLine($"TA: {Ta}");
        Console.WriteLine($"HRA: {Hra}");
        Console.WriteLine($"PPF: {Ppf}");
        Console.WriteLine($"Gross Salary: {GrossSalary}");
        Console.WriteLine($"Net Salary: {NetSalary}");
        Console.WriteLine($"Incentives: {Incentives}");
        Console.WriteLine($"Total Salary: {TotalSalary}");
        Console.WriteLine();
    }
}

public class Tester : EmployeeBase
{
    public int NoOfProjectsTested { get; set; }
    public int NoOfReports { get; set; }

    public Tester(string id, string name, float package, int attendance, int noProjTested, int noReports)
        : base(id, name, package, attendance)
    {
        Da = 1500;
        Ta = 3000;
        Hra = 6000;
        Ppf = 3000;
        NoOfProjectsTested = noProjTested;
        NoOfReports = noReports;
        Incentives = CalculateIncentives();
        GrossSalary = CalculateGrossSalary();
        NetSalary = CalculateNetSalary();
        TotalSalary = CalculateTotalSalary();
    }

    private int CalculateIncentives()
    {
        if (NoOfReports > 10 || NoOfProjectsTested > 10) return 10000;
        if (NoOfReports > 5 || NoOfProjectsTested > 5) return 5000;
        return 1000;
    }

    public override void DisplayPaySlip()
    {
        Console.WriteLine();
        Console.WriteLine("---------------Pay Slip--------------");
        Console.WriteLine($"Salary Slip for {Name} ({Id}):");
        Console.WriteLine("Role: Tester");
        Console.WriteLine($"Base Package: {MonthlyPackage}/mo");
        Console.WriteLine($"Attendance out of 31: {Attendance}");
        Console.WriteLine($"DA: {Da}");
        Console.WriteLine($"TA: {Ta}");
        Console.WriteLine($"HRA: {Hra}");
        Console.WriteLine($"PPF: {Ppf}");
        Console.WriteLine($"Gross Salary: {GrossSalary}");
        Console.WriteLine($"Net Salary: {NetSalary}");
        Console.WriteLine($"Incentives: {Incentives}");
        Console.WriteLine($"Total Salary: {TotalSalary}");
        Console.WriteLine();
    }
}

public class Marketing : EmployeeBase
{
    public Marketing(string id, string name, float package, int attendance)
        : base(id, name, package, attendance)
    {
        Da = 500;
        Ta = 30;
        Hra = 6;
        Ppf = 6000;
        Incentives = -150;
        GrossSalary = CalculateGrossSalary();
        NetSalary = CalculateNetSalary();
        TotalSalary = CalculateTotalSalary();
    }

    public override void DisplayPaySlip()
    {
        Console.WriteLine();
        Console.WriteLine("---------------Pay Slip--------------");
        Console.WriteLine($"Salary Slip for {Name} ({Id}):");
        Console.WriteLine("Role: Marketing");
        Console.WriteLine($"Base Package: {MonthlyPackage}/mo");
        Console.WriteLine($"Attendance out of 31: {Attendance}");
        Console.WriteLine($"DA: {Da}");
        Console.WriteLine($"TA: {Ta}");
        Console.WriteLine($"HRA: {Hra}");
        Console.WriteLine($"PPF: {Ppf}");
        Console.WriteLine($"Gross Salary: {GrossSalary}");
        Console.WriteLine($"Net Salary: {NetSalary}");
        Console.WriteLine($"Incentives: {Incentives}");
        Console.WriteLine($"Total Salary: {TotalSalary}");
        Console.WriteLine();
    }
}

public class Program
{
    public static Developer[] Developers;
    public static BackOffice[] BackOffices;
    public static Tester[] Testers;
    public static Marketing[] Marketers;
    public static int GlobalUniqueId = 1;

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the team details of the organization");

        // Developers
        Console.WriteLine("How many Developers?: ");
        int numDevs = int.Parse(Console.ReadLine());
        Developers = new Developer[numDevs];
        for (int i = 0; i < numDevs; i++)
        {
            string id = GlobalUniqueId++.ToString();
            Console.Write("Enter Developer's Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Package in LPA: ");
            float pkg = float.Parse(Console.ReadLine());
            Console.Write("Enter Attendance (0-31): ");
            int attendance = int.Parse(Console.ReadLine());

            Developers[i] = new Developer(id, name, pkg, attendance);
        }

        // BackOffice Workers
        Console.WriteLine("How many BackOffice workers?: ");
        int numBackOffices = int.Parse(Console.ReadLine());
        BackOffices = new BackOffice[numBackOffices];
        for (int i = 0; i < numBackOffices; i++)
        {
            string id = GlobalUniqueId++.ToString();
            Console.Write("Enter BackOffice Worker's Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Package in LPA: ");
            float pkg = float.Parse(Console.ReadLine());
            Console.Write("Enter Attendance (0-31): ");
            int attendance = int.Parse(Console.ReadLine());

            BackOffices[i] = new BackOffice(id, name, pkg, attendance);
        }

        // Testers
        Console.WriteLine("How many Testers?: ");
        int numTesters = int.Parse(Console.ReadLine());
        Testers = new Tester[numTesters];
        for (int i = 0; i < numTesters; i++)
        {
            string id = GlobalUniqueId++.ToString();
            Console.Write("Enter Tester's Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Package in LPA: ");
            float pkg = float.Parse(Console.ReadLine());
            Console.Write("Enter Attendance (0-31): ");
            int attendance = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Projects Tested: ");
            int noProjTested = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Reports Submitted: ");
            int noReports = int.Parse(Console.ReadLine());

            Testers[i] = new Tester(id, name, pkg, attendance, noProjTested, noReports);
        }

        // Marketing
        Console.WriteLine("How many Marketing team members?: ");
        int numMarketers = int.Parse(Console.ReadLine());
        Marketers = new Marketing[numMarketers];
        for (int i = 0; i < numMarketers; i++)
        {
            string id = GlobalUniqueId++.ToString();
            Console.Write("Enter Marketing Member's Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Package in LPA: ");
            float pkg = float.Parse(Console.ReadLine());
            Console.Write("Enter Attendance (0-31): ");
            int attendance = int.Parse(Console.ReadLine());

            Marketers[i] = new Marketing(id, name, pkg, attendance);
        }

        // Display Pay Slips
        Console.WriteLine("\n--- Pay Slips ---");

        foreach (var developer in Developers)
        {
            developer.DisplayPaySlip();
        }

        foreach (var backOffice in BackOffices)
        {
            backOffice.DisplayPaySlip();
        }

        foreach (var tester in Testers)
        {
            tester.DisplayPaySlip();
        }

        foreach (var marketer in Marketers)
        {
            marketer.DisplayPaySlip();
        }

        Console.WriteLine("\nAll pay slips generated successfully.");
    }
}


