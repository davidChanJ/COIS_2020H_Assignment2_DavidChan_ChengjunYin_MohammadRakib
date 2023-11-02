public class Patient
{
    //Attributes
    public int patientNum;          //Patient's number
    public int emegLevel;           //The emergency level of the patient
    public double remainingTime;    //Remaining time for patient to get healed in limited time

    //Constructor
    public Patient(int pNum, double avgWaitingTime)
    {
        patientNum = pNum;
        emergencyLevelCheck();
        treatmentTimeCheck(avgWaitingTime);
    }

    //Methods

    //Emergency Level
    public void emergencyLevelCheck()
    {
        //Setting random values
        double random = new Random().NextDouble();      //Random number that sets % seriousness of disease
        //random = 1; //As example for max
        //If else statement to determine levels
        if (random < 0.6)   //Level 1 (r < 60%)
            emegLevel = 1;
        else if (random < (0.6 + 0.3))  //Level 2 (r < 90%)
            emegLevel = 2;
        else if (random <= (0.9 + 0.1))  //Level 3 (r < 100%)
            emegLevel = 3;
        else
            throw new Exception("Your percentage is not possible");
    }

    //Treatment Level
    public void treatmentTimeCheck(double avgWaitingTime)
    {
        //Attributes ranVal and exponentional value
        double ranval = new Random().NextDouble();    //Shows random value
        double expoVal = -avgWaitingTime * Math.Log(ranval);    //Making exponentional value using average waiting time


        //Determining treatment time on level, in switch

        switch (emegLevel)
        {
            case 1:
                remainingTime = expoVal; 
                break;
            case 2:
                remainingTime = 2* expoVal;
                break;
            case 3:
                remainingTime = 4 * expoVal;
                break;
            default:
                throw new Exception("Invaoid emegLevel!");
        }

    }

}
