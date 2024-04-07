// Create an instance of Automobile:
Automobile auto1 = new Automobile(2020, 41400, 3200);

// invoke GetInfo() to print the data about the car;
auto1.GetInfo();

class Vehicle
{
    protected int numberOfWheels;
    public Vehicle(int numwheels)  // customized constructor
    {
        numberOfWheels = numwheels;
    }
    public Vehicle() { }  // default constructor

}



class Automobile : Vehicle
{
    private int yearOfManufacture;
    private int odometerReading;
    private double weight;


    public Automobile(int year, int reading, int wt) // custom constructor
    {
        // *** insert code here to set the values of the variables for this method,
        // *** based on the data passed into the method.

        this.yearOfManufacture = year;
        this.odometerReading = reading;
        this.weight = wt;
        // *** set the number of wheels to 4.
        this.numberOfWheels = 4;


    }

    public void GetInfo()
    {


        // *** insert code here to display the values of numberOfWheels,
        // *** yearOfManufacture, odometerReading, and weight.
        // *** also calculate and display the number of miles per year with
        // *** 2023 as the current year.

        Console.WriteLine("Wheels: " + this.numberOfWheels);
        Console.WriteLine("Year: " + this.yearOfManufacture);
        Console.WriteLine("Odometer: "+ this.odometerReading);
        Console.WriteLine("Weight: " + this.weight);
        Console.WriteLine("Miles per year: " + this.odometerReading / (2023 - this.yearOfManufacture));


    }

}