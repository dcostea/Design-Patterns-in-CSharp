using static System.Console;

namespace PrototypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer
            {
                Bio = new Bio
                {
                    Name = "Jake",
                    Role = "Dev"
                },
                PreferredLanguage = "C#",
                LinesPerHour = 11
            };

            Developer devClone = (Developer)dev.Clone();
            devClone.Bio.Name = "John";                      // Not mention Role and PreferredLanguage, it will copy above

            WriteLine(dev.GetDetails());
            WriteLine(devClone.GetDetails());


            Tester tester = new Tester
            {
                Bio = new Bio
                {
                    Name = "Anna",
                    Role = "QA"
                },
                TestsPerHour = 21
            };

            Tester testerClone = (Tester)tester.Clone();
            testerClone.Bio.Name = "Sarah";
            testerClone.TestsPerHour = 18;                   // Not mention Role, it will copy above

            WriteLine(tester.GetDetails());
            WriteLine(testerClone.GetDetails());


            Write("Press any key to continue...");
            ReadKey(true);
        }
    }
}
