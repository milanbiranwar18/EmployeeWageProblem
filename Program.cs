// See https://aka.ms/new-console-template for more information
using EmployeeWage;

Console.WriteLine("Welcome to Employee Wage Computation Program");

//EmployeeAttendance.Employee_Attendance();

//EmployeeWages.DailyEmployeeWage();
//EmployeeWages.EmployeeWageWithPartTime();
//EmployeeWages.EmployeeWageUC4();
//EmployeeWages.EmployeeWageofMonthUC5();

//EmployeeWages.EmployeeWageofMonthwithMaxHrs();
//EmployeeWages.EmployeeWageUC();
//EmployeeWages.computeEmpWage("Parle", 20, 2, 10);


//********EmployeeWageUC9********
EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
dMart.computeEmpWage();
Console.WriteLine(dMart.ToString());
reliance.computeEmpWage();
Console.WriteLine(reliance.ToString());
