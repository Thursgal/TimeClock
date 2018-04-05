using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

public class Employee
{

    private string employeeID;
    private string lastName;
    private string firstName;
    private string 

    public Employee()
    {
    }
    public string EmployeeID
    {
        get{ return employeeID;}
        set { employeeID = value; }
    }

    public string LastName
    {
        get{ return lastName;}
        set{ lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value;}
    }
    

 
}// end class
