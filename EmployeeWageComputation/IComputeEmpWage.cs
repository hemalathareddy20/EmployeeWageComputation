using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        public void addCopanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
    }
}
