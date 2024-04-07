double roomlength, roomwidth, cost;

// prompt the user to input values for roomwidth and roomlength here:


Console.WriteLine("Please input room width: ");
roomwidth = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please input room length: ");
roomlength = Convert.ToDouble(Console.ReadLine());



// this creates the instance:
CarpetJob C = new CarpetJob(roomwidth, roomlength);



// display the cost here:



cost = C.GetCost();   // get the cost
string formattedCost = cost.ToString("C");  // format for output
Console.WriteLine("The cost is {0}", formattedCost);   // write the cost



// carpetjob class definition:

class CarpetJob
{
    private double roomwidth, roomlength;

    public CarpetJob(double wid, double len)   // constructor with two arguments
    {
        roomwidth = wid;
        roomlength = len;
    }

    public double GetCost()  // method to calculate cost
    {
        // *** enter the code here to calculate and return the cost. ***

        double cost = 0;

        double area = roomlength * roomwidth;

        if(area > 120)
        {
            cost = 300 + (area - 120) * 1.5;
        }
        else if(area > 0 ||  area <= 120)
        {
            cost = area * 2.5;
        }
        else
        {
            Console.WriteLine("Invalid area.");
        }

        return cost;



    }

}