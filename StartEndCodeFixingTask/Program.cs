namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The algorithm in the Readme contains an error
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#

            bool validChoice = false;
    		do
    		{
        		int difference = -1;
        		Console.WriteLine("enter a start year");
        		int startYear = Convert.ToInt16(Console.ReadLine());
        		Console.WriteLine("enter an end year");
        		int endYear = Convert.ToInt32(Console.ReadLine());
    		if (startYear >= endYear)
    		{
    			Console.WriteLine("start year must be before 2000");
    		}
    		else
    		{
    			validChoice = true;
    			difference = endYear - startYear;
    			Console.WriteLine(difference);
    		}
    		} while (validChoice == false);

        }
    }
}
