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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        const int Max_flight_num_length =5, Max_Flight_destination_length=15, Max_arrival_date_length = 10;
        public Form1()
        {
            InitializeComponent();
            flightno.MaxLength = Max_flight_num_length;
            flightdes.MaxLength = Max_Flight_destination_length;
            arrivaldate.MaxLength = Max_arrival_date_length;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void flightno_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string flight_num=flightno.Text;
            string flight_des=flightdes.Text;
            string arrival_date=arrivaldate.Text;
            Flight flight = new Flight();
                if (flight_num.Length == 0 || flight_des.Length == 0 || arrival_date.Length == 0)
                {
                    MessageBox.Show("Please enter all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(flight_num.All(char.IsDigit)) || int.Parse(flight_num) <= 0)
                {
                    MessageBox.Show("Flight number must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool found = false;
                    foreach (Flight flight1 in Flight.flights)
                    {
                        string flightnum = new string(flight1.num);
                        if (flight_num.CompareTo(flightnum) == 0)
                        {
                            MessageBox.Show("This Flight Number Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            found = true;
                            break;
                        }
                    }
                       if(found==false)
                        {
                            flight_num.CopyTo(0, flight.num, 0, flight_num.Length);
                            for (int i = flight_num.Length; i < Max_flight_num_length; i++)
                            {
                                flight.num[i] = '\0';
                            }
                            flight_des.CopyTo(0, flight.destination, 0, flight_des.Length);
                            for (int i = flight_des.Length; i < Max_Flight_destination_length; i++)
                            {
                                flight.destination[i] = '\0';
                            }
                            arrival_date.CopyTo(0, flight.arrival_date, 0, arrival_date.Length);
                            for (int i = arrival_date.Length; i < Max_arrival_date_length; i++)
                            {
                                flight.arrival_date[i] = '\0';
                            }

                            MessageBox.Show("flight added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            flightno.Clear();
                            flightdes.Clear();
                            arrivaldate.Clear();
                            Flight.flights.Add(flight);
                        }
                }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //terminate on pressing exit
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Flight.Write();
            Passenger.Write();
            Environment.Exit(0);
        }
    }
}
