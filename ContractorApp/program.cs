using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Subcontractor> subcontractors = new List<Subcontractor>();
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.WriteLine("=== Create Subcontractor ===");

            // Contractor info
            Console.Write("Enter contractor name: ");
            string? nameInput = Console.ReadLine();
            string name = string.IsNullOrWhiteSpace(nameInput) ? "Unknown" : nameInput;

            Console.Write("Enter contractor number (integer): ");
            string? numberInput = Console.ReadLine();
            int contractorNumber = int.TryParse(numberInput, out int n) ? n : 0;

            Console.Write("Enter start date (yyyy-mm-dd): ");
            string? dateInput = Console.ReadLine();
            DateTime startDate = DateTime.TryParse(dateInput, out DateTime d)
                ? d
                : DateTime.Now;

            // Subcontractor info
            Console.Write("Enter shift (1 = Day, 2 = Night): ");
            string? shiftInput = Console.ReadLine();
            int shift = int.TryParse(shiftInput, out int s) ? s : 1;

            Console.Write("Enter hourly pay rate: ");
            string? rateInput = Console.ReadLine();
            double hourlyRate = double.TryParse(rateInput, out double r) ? r : 0.0;

            // Create Subcontractor object using your Person 2 class
            Subcontractor sub = new Subcontractor(
                name,
                contractorNumber,
                startDate,
                shift,
                hourlyRate
            );

            subcontractors.Add(sub);

            Console.WriteLine();
            Console.WriteLine("Subcontractor created:");
            Console.WriteLine($"Name: {sub.GetContractorName()}");
            Console.WriteLine($"Number: {sub.GetContractorNumber()}");
            Console.WriteLine($"Start Date: {sub.GetStartDate():d}");
            Console.WriteLine($"Shift: {(sub.GetShift() == 1 ? "Day" : "Night")}");
            Console.WriteLine($"Hourly Rate: {sub.GetHourlyPayRate():C}");

            // NOTE: Person 3 will later add a pay-calculation method to Subcontractor
            // and Person 4 can call it here to display pay.

            Console.WriteLine();
            Console.Write("Create another subcontractor? (y/n): ");
            string? again = Console.ReadLine();
            if (!string.Equals(again, "y", StringComparison.OrdinalIgnoreCase))
            {
                keepGoing = false;
            }

            Console.WriteLine();
        }

        Console.WriteLine("=== Summary of Subcontractors ===");
        foreach (var s in subcontractors)
        {
            Console.WriteLine(
                $"{s.GetContractorName()} (#{s.GetContractorNumber()}) - " +
                $"Shift {s.GetShift()} - Rate {s.GetHourlyPayRate():C}"
            );
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
