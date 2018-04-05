using System;

public class Calls
{
	public Calls()
	{
	}

    public bool CheckEmpID(string userId, string userPassword)
    {
        // call DB check for userid and password
        // get responce
        // pass responce
        return true;
    }
    public void LogIn(string userId, string userPassword)
    { 
        // check id authentication
        bool answer = CheckEmpID(userId, userPassword);
        
    }
    public string GetRole(string empID)
    {
        string role;
        string workID;
        //call DB ask for rolls of empID
        return role;
    }
    public void newPunch(string empID, int workID, DateTime punchTime)
    {
        if(checkClockedIn = false)
        {
            // create and log new punch
        }
        else
        {
            // error
        }
    }
    public bool checkClockedIn(string empID)
    {
        //check DB for last log with empID
        //check log for null data in clock out

        // if null -- still clocked in
        return true;
        // if not null -- clocked out
        return false;
    }

    }
}
