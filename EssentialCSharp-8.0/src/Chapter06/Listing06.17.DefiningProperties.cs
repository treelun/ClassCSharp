// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618
// Disabled pending introductin to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_17
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();

            // Call the FirstName property's setter
            employee.FirstName = "Inigo";

            // Call the FirstName property's getter
            System.Console.WriteLine(employee.FirstName);
        }
    }

    class Employee
    {
        // FirstName property(프로퍼티형식)
        public string FirstName
        {
            get//(가져옴)
            {
                return _FirstName;
            }
            set//(입력함)
            {
                _FirstName = value;
            }
        }

        private string _FirstName;

    }
}
