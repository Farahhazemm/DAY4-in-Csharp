using System;

class Program
{
    static void Main()
    {
        /*───────────────────────────────────────────────────────────────────────────
        # Problem 1: Array Initialization and IndexOutOfRangeException ────────────*/
        int[] arr1 = new int[3];         
        int[] arr2 = new int[] { 1, 2, 3 }; 
        int[] arr3 = { 4, 5, 6 };          

        
        try
        {
            arr1[3] = 99;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Problem 1 Exception: {e.Message}\n");
        }
        /* Question Answer: The default value for array elements in C# is 0 for integers */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 2: Shallow vs Deep Copy ─────────────────────────────────────────*/
        int[] original = { 10, 20, 30 };

       
        int[] shallowCopy = original;
        shallowCopy[0] = 999;
        Console.WriteLine($"Problem 2 Shallow Copy: Original[0] = {original[0]}"); // 999

  
        int[] deepCopy = (int[])original.Clone();
        deepCopy[0] = 111;
        Console.WriteLine($"Problem 2 Deep Copy: Original[0] = {original[0]}\n"); 
        /* Question Answer: Clone() creates new array object, Copy() copies elements between existing arrays */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 3: 2D Student Grades Array ───────────────────────────────────────*/
        int[,] grades = new int[3, 3]; 
        for (int i = 0; i < grades.GetLength(0); i++)
            for (int j = 0; j < grades.GetLength(1); j++)
                grades[i, j] = (i + 1) * 10 + j;
        /* Question Answer: GetLength() gets specific dimension size, Length gives total elements */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 4: Array Methods Demonstration ───────────────────────────────────*/
        int[] numbers = { 5, 3, 9, 1, 7 };
        Array.Sort(numbers);    // [1,3,5,7,9]
        Array.Reverse(numbers); // [9,7,5,3,1]
        /* Question Answer: ConstrainedCopy() guarantees atomic operation, Copy() doesn't */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 5: Array Looping Techniques ──────────────────────────────────────*/
        int[] loopArray = { 10, 20, 30 };
        Console.Write("Problem 5 Foreach: ");
        foreach (int num in loopArray) Console.Write(num + " "); // Read-only iteration
        /* Question Answer: foreach prevents accidental modification and is more readable */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 6: Input Validation ──────────────────────────────────────────────*/
        int userNumber;
        do
        {
            Console.Write("\nProblem 6: Enter positive odd number: ");
        } while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber <= 0 || userNumber % 2 == 0);
        /* Question Answer: Input validation prevents crashes and data corruption */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 7: Matrix Format Output ──────────────────────────────────────────*/
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("\nProblem 7 Matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j].ToString().PadRight(3));
            Console.WriteLine();
        }
        /* Question Answer: Use PadRight() or \t for column alignment */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 8: Month Number to Name ──────────────────────────────────────────*/
        int month = 2;
        Console.WriteLine("\nProblem 8 Month Check:");
        // Switch version (preferred for multiple conditions)
        switch (month)
        {
            case 1: Console.WriteLine("January"); break;
            case 2: Console.WriteLine("February"); break;
            default: Console.WriteLine("Invalid"); break;
        }
        /* Question Answer: Prefer switch for multiple constant value checks */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 9: Sorting and Searching ─────────────────────────────────────────*/
        int[] searchArray = { 5, 3, 9, 1, 3 };
        Array.Sort(searchArray); // O(n log n) complexity
        Console.WriteLine($"\nProblem 9: First 3 at index {Array.IndexOf(searchArray, 3)}");
        /* Question Answer: Array.Sort() typically uses O(n log n) algorithm */


        /*───────────────────────────────────────────────────────────────────────────
        # Problem 10: Array Sum Calculation ────────────────────────────────────────*/
        int[] sumArray = { 10, 20, 30 };
        int sum = 0;
        foreach (int num in sumArray) sum += num;
        Console.WriteLine($"\nProblem 10: Array sum = {sum}");
        /* Question Answer: Both loops have same efficiency, foreach is cleaner */
    }
}