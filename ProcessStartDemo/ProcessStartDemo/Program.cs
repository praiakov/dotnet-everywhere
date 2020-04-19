using Cassia;
using System;

namespace ProcessStartDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new TerminalServicesManager();
            using (var server = manager.GetRemoteServer("server"))
            {
                server.Open();
                foreach (var session in server.GetSessions())
                {
                    if (session.ConnectionState == ConnectionState.Active)
                    {
                        Console.WriteLine(session.ClientName);
                    }
                }
            }
        }
    }
}
