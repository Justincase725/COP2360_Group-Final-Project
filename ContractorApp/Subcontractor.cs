using System;

public class Subcontractor : Contractor
{
    // 1 = Day shift, 2 = Night shift
    private int shift;
    private double hourlyPayRate;

    // Default constructor
    public Subcontractor() : base()
    {
        shift = 1;              // default to day shift
        hourlyPayRate = 0.0;
    }

    // Constructor with parameters (includes Contractor info)
    public Subcontractor(string name, int number, DateTime startDate,
                         int shift, double hourlyPayRate)
        : base(name, number, startDate)
    {
        this.shift = shift;
        this.hourlyPayRate = hourlyPayRate;
    }

    // Accessors (getters)
    public int GetShift()
    {
        return shift;
    }

    public double GetHourlyPayRate()
    {
        return hourlyPayRate;
    }

    // Mutators (setters)
    public void SetShift(int shift)
    {
        this.shift = shift;
    }

    public void SetHourlyPayRate(double rate)
    {
        hourlyPayRate = rate;
    }
}
