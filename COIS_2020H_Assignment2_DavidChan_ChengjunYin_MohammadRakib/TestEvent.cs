using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestEvent
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
            Event event1 = new Event(patient1, "Arrival", 13);
            Patient patient2 = new Patient(142, 22);
            Event event2 = new Event(patient2, "Arrival", 22, 44);


            Console.WriteLine(event1.Patient + " " + event1.eventType + " " + event1.eventTime);
			Console.WriteLine(event2.Patient + " " + event2.eventType + " " + event2.eventTime + event2.assignedDoctor);
		}

	}
}