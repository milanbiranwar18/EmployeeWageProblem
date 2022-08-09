using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> CompanyEmpWageList;
        private Dictionary<string, CompanyEmpWage> CompanyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.CompanyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.CompanyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerhour, int numofWorkingdays, int maxHoursPermonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerhour, numofWorkingdays, maxHoursPermonth);
            this.CompanyEmpWageList.AddLast(companyEmpWage);
            this.CompanyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.CompanyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage);
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int emphrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs<=companyEmpWage.maxHoursPerMonth && totalWorkingDays<=companyEmpWage.maxHoursPerMonth)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        emphrs = 12;
                        break;
                    case IS_PART_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                totalEmpHrs += emphrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + emphrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
           
        

        
    }
}
