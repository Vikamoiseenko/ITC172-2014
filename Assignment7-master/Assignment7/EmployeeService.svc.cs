using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Assignment7.DataAccess;

namespace Assignment7
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        EmployeeDB db = new EmployeeDB();   

        public Employee GetEmployee(int employeeID)
        {
            Employee employee = db.GetEmployeeById(employeeID);
            return employee;
        }

        public void EditEmployee(Employee employee)
        {
            db.EditEmployee(employee);
        }
    }
}
