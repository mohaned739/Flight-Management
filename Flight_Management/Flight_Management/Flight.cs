using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Flight_Management
{
   public class Flight
    {
        public char[] num = new char[5];
        public char[] destination = new char[15];
        public char[] arrival_date = new char[10];

        public static List<Flight> flights = new List<Flight>();
        public static void Load()
        {
            FileStream fs = new FileStream("Flight.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                
                string line = sr.ReadLine();
                string[] data = line.Split('#');

                for (int i = 0; i < data.Length; i++)
                {
                    Flight flight = new Flight();
                    if (data[i] != "")
                    {
                        flight.num = data[i].Substring(0, 5).ToCharArray();
                        flight.destination = data[i].Substring(5, 15).ToCharArray();
                        flight.arrival_date = data[i].Substring(20, 10).ToCharArray();
                        flights.Add(flight);
                    }
                }
            }
            sr.Close();
        }

        public static void Write()
        {
            FileStream fs1 = new FileStream("Flight.txt", FileMode.Truncate);
            fs1.Close();
            FileStream fs = new FileStream("Flight.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Flight flight in Flight.flights)
            {
                sw.Write(flight.num);
                sw.Write(flight.destination);
                sw.Write(flight.arrival_date);
                sw.Write("#");
            }
                sw.Close();
        }

    }
}
