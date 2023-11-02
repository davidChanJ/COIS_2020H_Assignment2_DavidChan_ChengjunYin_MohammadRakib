using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestPatient
{
    //Methods
    public static void Test()
    {
        bool testEmergencyCheck = true;
        bool testTTimeCheck = true;
        //SSS
        if (testEmergencyCheck)
        {
            Patient patient1 = new Patient(223, 12);
            if (patient1.emegLevel != 1 && patient1.emegLevel!= 2 && patient1.emegLevel != 3)
            {
                throw new Exception("Invalid emegLevel for patient");
            }
            if (patient1.remainingTime == 0)
            {
                throw new Exception("Invalid waiting time for patient");
            }
            Console.WriteLine("Case 1 PASSED");
        }
        

        //Test for treatment time
        if (testTTimeCheck)
        {
            Patient patient1 = new Patient(223, 12);
            //Patient.treatmentTimeCheck(5);
        }

    }
}