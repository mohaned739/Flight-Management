using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Flight_Management
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2( )
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            char[] record = new char[50];
            Passenger passenger = new Passenger();
            passenger.Name = passenger_name.Text;
            passenger.phone= passenger_phone.Text;
            passenger.flight_no = flight_number.Text;
           
            bool flightNumber_ch = true;

            if (passenger_name.Text.Length == 0 || passenger_phone.Text.Length == 0 || flight_number.Text.Length == 0)
            {
                MessageBox.Show("Plese enter all data", "some data missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                int recordSize = passenger_name.Text.Length + passenger_phone.Text.Length + flight_number.Text.Length;
               
                if (recordSize > 47)
                {
                    MessageBox.Show("you have exceeded total number of allowed characters by "+(recordSize-47)+" characters", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (passenger.flight_no.Length > 5)
           
                    {
                        MessageBox.Show("flight number must not exceed five number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flightNumber_ch = false;
            
                    }
           
                    if (flightNumber_ch == true)
            
                    {
                
                        bool found = false;
               
                        foreach (Flight flight in Flight.flights)
                
                        {
                            string flightnum = new string(flight.num);
                            if (passenger.flight_no.CompareTo(flightnum)==0){


                                string Name =passenger.Name+ '@';
                                string phone= passenger.phone+ '@';
                                string flight_no =passenger.flight_no+ '@';
                
                Name.CopyTo(0, record, 0, Name.Length);

                phone.CopyTo(0, record, Name.Length, phone.Length);

                flight_no.CopyTo(0, record, phone.Length+Name.Length,flight_no.Length);
                for (int i = record.Length; i < 50; i++)
                {
                    record[i] = '\0';
                }

                passenger.record = record;
                Passenger.passengers.Add(passenger);
                MessageBox.Show("Passenger Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                passenger_name.Clear();
                passenger_phone.Clear();
                flight_number.Clear();
                found = true;
                break;
                    }
                }
                if (found==false)
                {
                    MessageBox.Show("Can Not Find This Flight Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
                }
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //terminate on pressing exit
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Flight.Write();
            Passenger.Write();
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

    }
}
