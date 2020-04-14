using System.Management.Automation;

namespace ProcessStartDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = @"";

            using (var ps = PowerShell.Create())
            {
                var results = ps.AddScript(command).Invoke();

                foreach (var item in results)
                {
                    System.Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
