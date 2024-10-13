// Author: Ugochinyere Blessing Okogeri
// Class: IGME.201

using System;

class Program
{
    static void Main(string[] args)
    {
        
        string studentName = "Blessing";  

        // grade array
        int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

        // Print custom greeting
        Console.WriteLine($"Welcome {studentName}!");
        Console.WriteLine("Here are your grades:");

        // Variable to calculate the sum of valid grades
        int sumOfGrades = 0;
        int validGradeCount = 0;

        // Loop through the grades array and print each grade with corresponding messages
        for (int i = 0; i < grades.Length; i++)
        {
            int grade = grades[i];

            // Check if the grade in acceptable range of 0-100
            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine(grade);
                Console.WriteLine("This grade is an A!");
                if (grade == 100)
                {
                    Console.WriteLine("WOW! A perfect score!");
                }
                sumOfGrades += grade;
                validGradeCount++;
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine(grade);
                Console.WriteLine("This grade is a B.");
                sumOfGrades += grade;
                validGradeCount++;
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine(grade);
                Console.WriteLine("This grade is a C.");
                sumOfGrades += grade;
                validGradeCount++;
            }
            else if (grade >= 65 && grade <= 69)
            {
                Console.WriteLine(grade);
                Console.WriteLine("This grade is a D.");
                sumOfGrades += grade;
                validGradeCount++;
            }
            else if (grade >= 0 && grade <= 64)
            {
                Console.WriteLine(grade);
                Console.WriteLine("This grade is an F.");
                sumOfGrades += grade;
                validGradeCount++;
            }
            else
            {
                // outside the range of 0-100
                Console.WriteLine(grade);
                Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
            }
        }

        // average for valid grades
        double average = (validGradeCount > 0) ? (double)sumOfGrades / validGradeCount : 0;

        // final calculated average
        Console.WriteLine($"\nYour final calculated average is: {average}");

        Console.WriteLine($"\nWe have displayed all grades for {studentName}");
    }
}
