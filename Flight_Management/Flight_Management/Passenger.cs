using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Management
{
   public class Passenger
    {
        public  string phone;
        public string Name;
        public string flight_no;
        static string []data2;
        public char[]record=new char[50];
      
       
       
       public static List<Passenger> passengers = new List<Passenger>() ;


        public static void Load()
        {
            try {
                FileStream fs = new FileStream("Passenger.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() != -1)
                {
                    Passenger p = new Passenger();
                    sr.Read(p.record, 0, 50);
                    string data = new string(p.record);
                    data2 = data.Split('@');
                    p.Name = data2[0];
                    p.phone = data2[1];                    
                    p.flight_no = data2[2];
                    passengers.Add(p);
                }
                sr.Close();
       
            }
            catch { MessageBox.Show("File Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static void Write()
        {
            FileStream fs1=new FileStream("Passenger.txt",FileMode.Truncate);
            fs1.Close();

            FileStream fs = new FileStream("Passenger.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Passenger passenger in Passenger.passengers){
            sw.Write(passenger.record);     
            }
            sw.Close();
        }
    }
}
