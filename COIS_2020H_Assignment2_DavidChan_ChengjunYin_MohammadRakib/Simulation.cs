using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Simulation
{
    //Attributes
    //private PriorityQueue<Event> eventQueue;
    private Queue<Event>[] waitingQueue;
    private int[] drAvaliable;
    //Constructor
    public Simulation()
    {
        //eventQueue
        //eventQueue = new PriorityQueue<Event>();
        waitingQueue = new Queue<Event>[3]; // 3 Waiting queue since 3 emergency levels
        for (int i = 0; i < 3; i++)
            waitingQueue[i] = new Queue<Event>();
        drAvaliable = new int[new Random().NextInt64()];
    }

    //run simulation
    public static void processRunSimulation()
    {
        //Run the whole siulation
        //Set simulation parameters and state
        double currTime = 0;    //Current time
        Random random = new Random();     //Random values

        //Run the simulation until meeting termination condition
        if (currTime <= 17 * 60) //Assuming 17:00 is 17 * 70 minutes
        {
            double interArrivalTime;
        }

        //Process the event

        //Arrive event
        processArrivalEvent();

        //Depart event
        processDepartEvent();
    }
    //Process arrival event
    public static void processArrivalEvent()
    {

    }
    //Process Departure Event
    public static void processDepartEvent()
    {

    }

}