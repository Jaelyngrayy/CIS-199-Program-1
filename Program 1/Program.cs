//Grading ID: R5560
//Program 1
//Due Date: February 16, 2021
//Course Section CIS 199-01
//Description: Program takes in garden length and width, soil price, and if you need fertilizer or if this is your first garden
//and outputs the size of the garden in sq yards and how much it will cost in total
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, //width of the garden, inputted by user
                length, //length of the garden, inputted by user
                soilPrice, //price of the soil, inputted by the user
                squareYards, // square yards of the garden. Found by dividing the area in feet by 9
                soilCost, // total costs of the soil. Found by multiplying soil price by the square yards and by the extra soil percentage
                fertCost, // total costs of the fertilizer. Found by multiplying square yards by the fertilizer charge fee. Costs is 0 if no fert needed
                laborCost, // total costs of the labor. Found by multiplying square yards by Labor Charge. 50 is added if it is the first garden.
                totalCost; // Total costs of the job. Adding soil cost, fertilizer cost and labor cost together. 

            int fertilizer, // used to figure out if fertilizer is needed. 1 means yes, 0 means no. Used in an if-else statement
                firstGarden; //used to figure out if this is the first garden. 1 means yes, 0 means no. Used in an if-else statement.
            
            //NAMED CONSTANTS
            const double COMPANY_FEE = 50; //50 dollar company fee
            const double WASTE_PERCENTAGE = 1.10; // 10% extra in the estimate of the soil cost
            const double FERT_CHARGE = 4.25; // $4.25 fertilizer fee per square yard of garden
            const double LABOR_CHARGE = 3.25; // $3.25 labor fee per square yard of garden
            const double YARD_CONVERSION = 9; //Conversion rate used to convert feet to square yards

            //Takes user input for width and converts to a double
            Write("What will be the maximum width of your garden? (feet)... ");
            width = Convert.ToDouble(ReadLine());

            //Takes user input for length and converts to a double
            Write("What will be the maximum length of your garden? (feet)... ");
            length = Convert.ToDouble(ReadLine());

            //User unput for soil price and converts to a double
            Write("Enter the soil price (Per square yard)... ");
            soilPrice = Convert.ToDouble(ReadLine());

            //user input if user needs fertilizer and converts to an int
            Write("Do you need fertilizer and additional ground preparation? Type 1 if yes, 0 if no... ");
            fertilizer = Convert.ToInt32(ReadLine());

            //user input if this is the user's first garden and converts to an int
            Write("Is this the first garden? Type 1 if yes, 0 if no... ");
            firstGarden = Convert.ToInt32(ReadLine());


            squareYards = length * width / YARD_CONVERSION; //find square yards
            soilCost = soilPrice * squareYards * WASTE_PERCENTAGE; //find soil cost

            //if else statement to decide what to do if fertilizer is needed or not
            if (fertilizer == 1)
                fertCost = squareYards * FERT_CHARGE; //if yes, calculates cost
            else
                fertCost = 0; //if no, cost is 0

            //if else statement to decide what to do if this is the first garden or not
            laborCost = squareYards * LABOR_CHARGE; // calculates labor cost
            if (firstGarden == 1)
                laborCost = laborCost + COMPANY_FEE; //if yes, adds company fee to labor cost
            else
                laborCost = laborCost; // if no, labor cost is unchanged

            totalCost = soilCost + fertCost + laborCost; //find total cost


            //outputs all variables and converts them to currency format and 1 digit of precision for square yards
            WriteLine("");
            WriteLine($"Square Yards Needed: {squareYards,6:F1}");
            WriteLine($"Soil Cost: {soilCost,17:C}");
            WriteLine($"Fertilizer Cost: {fertCost,11:C}");
            WriteLine($"Labor Cost: {laborCost,16:C}");
            WriteLine($"Total Cost: {totalCost,16:C}");



        }
    }
}
