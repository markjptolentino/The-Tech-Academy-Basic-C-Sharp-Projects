using System;

class Program
{
    static void Main()
    {
        // Print the college name as the header
        Console.WriteLine("Academy of Learning Career College");

        // Print the report title
        Console.WriteLine("Student Daily Report");

        // Store the student's name as a string
        string name = "Mark JP Tolentino";

        // Store the course name as a string
        string course = "Software Web Development";

        // Store the page number as a string
        string pageNumber = "TACN12E1";

        // Store the help needed response as a boolean
        bool helpNeeded = false;

        // Store positive experiences as a string
        string positiveExperiences = "A positive experience was working on a C# project. It was rewarding to see everything come together and really boosted my confidence in C# programming.";

        // Store additional feedback as a string
        string feedback = "One piece of feedback I would provide is that it would be helpful to have more real-world examples incorporated into the course material. While the theoretical concepts were well-explained, seeing more practical applications in industry scenarios would help deepen the understanding of how to apply C# in different projects.";

        // Store study hours as a float
        float studyHours = 5.0f;

        // Print the report details
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Page Number: {pageNumber}");
        Console.WriteLine($"Help Needed: {helpNeeded}");
        Console.WriteLine($"Positive Experience: {positiveExperiences}");
        Console.WriteLine($"Feedback: {feedback}");
        Console.WriteLine($"Study Hours: {studyHours} hours");

        // Print the closing message
        Console.WriteLine("\nThank you and have a wonderful day!");
    }
}
