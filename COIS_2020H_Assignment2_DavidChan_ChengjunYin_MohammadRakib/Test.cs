using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Test
{
    public static void Main(string[] args)
    {
        bool testPatient = false;
        bool testEvent = true;
        bool testpriorityQueue = false;
        bool testSimulation = false;

        //Test classes
        if (testPatient)
            TestPatient.Test();
        if (testEvent)
            TestEvent.Test();
        if (testpriorityQueue)
            TestPriorityQueue.Test();
        if (testSimulation)
            TestSimulation.Test();

    }
}