
using System;
using System.Collections.Generic;

namespace CSharpLearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new LearningApp();
            app.Run();
        }
    }

    class LearningApp
    {
        private readonly List<Exercise> _exercises;

        public LearningApp()
        {
            _exercises = new List<Exercise>
            {
                // 1. Variables
                new Exercise(
                    "Declaring Variables",
                    "Declare an integer variable named 'age' and assign it the value 25.",
                    input => Normalize(input).Contains("intage=25;")
                ),

                // 2. Mathematics
                new Exercise(
                    "Mathematical Equations",
                    "Calculate the average of 'a' and 'b'. Write: int result = (a + b) / 2;",
                    input => Normalize(input).Contains("intresult=(a+b)/2;")
                ),

                // 3. If statements
                new Exercise(
                    "If Conditions",
                    "Check if 'score' is greater than 90. Print 'A'.",
                    input => Normalize(input).Contains("if(score>90)") &&
                             input.Contains("Console.WriteLine") &&
                             input.Contains("\"A\"")
                ),

                // 4. Arrays
                new Exercise(
                    "Creating Arrays",
                    "Declare an integer array named 'numbers' containing 1, 2, and 3.",
                    input => Normalize(input).Contains("int[]numbers={1,2,3};") ||
                             Normalize(input).Contains("int[]numbers=newint[]{1,2,3};")
                ),

                // 5. Lists
                new Exercise(
                    "Making Lists",
                    "Create a new List of strings named 'names'.",
                    input => Normalize(input).Contains(
                        "List<string>names=newList<string>();")
                ),

                // 6. While loops
                new Exercise(
                    "While Loop Statements",
                    "Write a while loop that runs while 'count' is less than 5.",
                    input => Normalize(input).Contains("while(count<5)")
                ),

                // 7. Methods
                new Exercise(
                    "Creating Methods",
                    "Write a method signature returning int named Add with parameters int x and int y.",
                    input => Normalize(input).Contains("intadd(intx,inty)")
                ),

                // 8. Double variables
                new Exercise(
                    "Declaring Double Variables",
                    "Declare a double named 'price' and assign it 19.99.",
                    input => Normalize(input).Contains("doubleprice=19.99;")
                ),

                // 9. Strings
                new Exercise(
                    "Working with Strings",
                    "Declare a string named 'name' and assign it \"Alex\".",
                    input => Normalize(input).Contains("stringname=\"Alex\";")
                ),

                // 10. User input
                new Exercise(
                    "Getting User Input",
                    "Read a line from the console and store it in a string named 'input'.",
                    input => Normalize(input).Contains(
                        "stringinput=Console.ReadLine();") ||
                        Normalize(input).Contains(
                        "stringinput=Console.ReadLine()!;")
                ),

                // 11. Multiplication
                new Exercise(
                    "Multiplication",
                    "Multiply 'a' by 'b' and store the result in an int named 'result'.",
                    input => Normalize(input).Contains("intresult=a*b;")
                ),

                // 12. If and else
                new Exercise(
                    "If and Else",
                    "Write an if statement checking whether 'age' is at least 18.",
                    input => Normalize(input).Contains("if(age>=18)")
                ),

                // 13. For loops
                new Exercise(
                    "For Loops",
                    "Write a for loop that counts from 1 through 5.",
                    input => Normalize(input).Contains(
                        "for(inti=1;i<=5;i++)")
                ),

                // 14. While loops
                new Exercise(
                    "Counting with While Loops",
                    "Write a while loop that runs while 'count' is less than 10.",
                    input => Normalize(input).Contains("while(count<10)")
                ),

                // 15. Array elements
                new Exercise(
                    "Accessing Arrays",
                    "Store the first element of 'numbers' in an int named 'first'.",
                    input => Normalize(input).Contains(
                        "intfirst=numbers[0];")
                ),

                // 16. Adding to lists
                new Exercise(
                    "Adding to Lists",
                    "Add the string \"Alex\" to the list named 'names'.",
                    input => Normalize(input).Contains(
                        "names.Add(\"Alex\");")
                ),

                // 17. Classes
                new Exercise(
                    "Creating Classes",
                    "Declare a class named 'Student'.",
                    input => Normalize(input).Contains("classStudent")
                ),

                // 18. Boolean variables
                new Exercise(
                    "Boolean Variables",
                    "Declare a bool named 'isReady' and set it to true.",
                    input => Normalize(input).Contains(
                        "boolisReady=true;")
                ),

                // 19. Comparison operators
                new Exercise(
                    "Comparison Operators",
                    "Declare a bool named 'isEqual' and check whether 'a' equals 'b'.",
                    input => Normalize(input).Contains(
                        "boolisEqual=a==b;")
                ),

                // 20. Incrementing
                new Exercise(
                    "Incrementing Variables",
                    "Increase the variable 'count' by one using the increment operator.",
                    input => Normalize(input).Contains("count++;")
                ),

                // 21. String interpolation
                new Exercise(
                    "String Interpolation",
                    "Print the variable 'name' using string interpolation.",
                    input => Normalize(input).Contains(
                        "Console.WriteLine($\"{name}\");")
                ),

                // 22. Switch statements
                new Exercise(
                    "Switch Statements",
                    "Write a switch statement that checks the variable 'choice'.",
                    input => Normalize(input).Contains("switch(choice)")
                ),

                // 23. Exception handling
                new Exercise(
                    "Try and Catch",
                    "Write the opening of a try block: try {",
                    input => Normalize(input).Contains("try{")
                ),

                // 24. Creating objects
                new Exercise(
                    "Creating Objects",
                    "Create a Student object and store it in 'student'.",
                    input => Normalize(input).Contains(
                        "Studentstudent=newStudent();")
                ),

                // 25. Division
                new Exercise(
                    "Division",
                    "Divide 'a' by 'b' and store the result in an int named 'result'.",
                    input => Normalize(input).Contains("intresult=a/b;")
                )
            };
        }

        private static string Normalize(string input)
        {
            return input.Replace(" ", "")
                        .Replace("\t", "")
                        .Replace("\r", "")
                        .Replace("\n", "");
        }

        public void Run()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================================");
            Console.WriteLine("       WELCOME TO THE INTERACTIVE C# ACADEMY");
            Console.WriteLine("====================================================");
            Console.ResetColor();

            Console.WriteLine($"\nThere are {_exercises.Count} exercises to complete.");
            Console.WriteLine("Enter the requested C# code for each exercise.");
            Console.WriteLine("Type 'exit' to quit at any time.\n");

            int completed = 0;

            for (int i = 0; i < _exercises.Count; i++)
            {
                bool solved = RunExercise(_exercises[i], i + 1);

                if (!solved)
                {
                    Console.WriteLine(
                        $"\nYou completed {completed} of {_exercises.Count} exercises.");
                    Console.WriteLine("Thanks for practicing C#!");
                    return;
                }

                completed++;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n====================================================");
            Console.WriteLine(" CONGRATULATIONS! YOU COMPLETED ALL EXERCISES!");
            Console.WriteLine("====================================================");
            Console.ResetColor();

            Console.WriteLine($"Final score: {completed}/{_exercises.Count}");
            Console.WriteLine("Keep practicing to master C#!");
        }

        private bool RunExercise(Exercise exercise, int stageNumber)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(
                    $"\n[Stage {stageNumber}/{_exercises.Count}] {exercise.Title}");
                Console.ResetColor();

                Console.WriteLine(exercise.Instruction);
                Console.Write("\nYour Code > ");

                string userInput = Console.ReadLine() ?? "";

                if (userInput.Trim().Equals(
                    "exit", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                if (exercise.CheckSolution(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct! Exercise completed.");
                    Console.ResetColor();

                    Console.WriteLine(new string('-', 50));
                    return true;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    "Incorrect syntax. Try again!");
                Console.ResetColor();

                Console.WriteLine(new string('-', 50));
            }
        }
    }

    class Exercise
    {
        public string Title { get; }
        public string Instruction { get; }

        private readonly Func<string, bool> _validator;

        public Exercise(
            string title,
            string instruction,
            Func<string, bool> validator)
        {
            Title = title;
            Instruction = instruction;
            _validator = validator;
        }

        public bool CheckSolution(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            return _validator(input);
        }
    }
}
