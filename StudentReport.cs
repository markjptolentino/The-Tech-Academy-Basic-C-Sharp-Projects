using System;

class Program
{
    static void Main()
    {
        // Print the name of the college
        Console.WriteLine("Academy of Learning Career College");

        // Print the title of the report
        Console.WriteLine("Student Daily Report");

        // Ask for the student's name and store it as a string
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        // Ask for the course name and store it as a string
        Console.Write("What course are you on? ");
        string course = Console.ReadLine();

        // Ask for the page number and convert the input to an integer
        Console.Write("What page number? ");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        // Ask if the student needs help and store the response as a boolean
        Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
        bool helpNeeded = Convert.ToBoolean(Console.ReadLine());

        // Ask for any positive experiences and store the response as a string
        Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
        string positiveExperiences = Console.ReadLine();

        // Ask for additional feedback and store it as a string
        Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
        string feedback = Console.ReadLine();

        // Ask for the number of study hours and store it as a float
        Console.Write("How many hours did you study today? ");
        float studyHours = float.Parse(Console.ReadLine());

        // End of the program - thank the user
        Console.WriteLine("\nThank you for your answers. An Instructor will respond shortly. Have a great day!");
    }
}
