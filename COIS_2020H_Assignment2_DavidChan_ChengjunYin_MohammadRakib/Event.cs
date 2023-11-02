using System;
//Creating an abstract base class for all enumeration types(from Microsoft learn)
public enum eType
{
    Arrival,
    Departure
}

public class Event
{
    //Attributes
    public Patient Patient { get; set; }        //Patient Class
    public string eventType { get; set; }       //Event type
    public int assignedDoctor { get; set; }     //Assigned doctor
    public double eventTime { get; set; }       //Event time


    //Constructor for Arrival Event, in patient, event-type and event-time
    public Event(Patient ptt, string eventtype, double eventtime)
    {
        Patient = ptt;
        eventTime = eventtime;
        eventType = eventtype;
    }

    //Constructor for Departure Event, in patient, event-type and event-time, and assignedDoctor
    public Event(Patient ptt, string eventtype, int eventtime, int assigneddoctor)
    {
        //Setting values
        Patient = ptt;
        eventTime = eventtime;
        eventType = eventtype;

        //Checking to make sure if event type and depart event type matches
        if (eventtype != eType.Departure.ToString())
            throw new ArgumentException("Invalid event type!");
        //Setting doctor
        assignedDoctor = assigneddoctor;
    }
}