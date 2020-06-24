using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Management
{
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {
        List<Passenger> passengers;
        public Form6()
        {
            InitializeComponent();
            metroLabel3.Hide();
            metroLabel4.Hide();
            metroTextBox3.Hide();
            metroTextBox4.Hide();
            metroTile2.Hide();
            metroButton2.Hide();
            metroTextBox5.Hide();
            metroLabel5.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //closing on "exit"
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Flight.Write();
            Passenger.Write();
            Environment.Exit(0);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
              metroTextBox3.Clear();
              metroTextBox4.Clear();
              metroTextBox5.Clear();


            bool found = false;
            string name = metroTextBox1.Text;
            string phone = metroTextBox2.Text;
            
            foreach (Passenger passenger in Passenger.passengers)
            {
                string name_pass =passenger.Name;
                string phone_pass = passenger.phone;
                int chech_name = string.Compare(name_pass, name);
                int check_phone = string.Compare(phone_pass, phone);
                if (chech_name == 0 && check_phone == 0)
                {
                    found = true;
                    metroLabel3.Show();
                    metroLabel4.Show();
                    metroTextBox3.Show();
                    metroTextBox4.Show();
                    metroTile2.Show();
                    metroButton2.Show();
                    metroTextBox3.AppendText(passenger.Name);
                    metroTextBox4.AppendText(passenger.phone);
                    metroTextBox5.AppendText(passenger.flight_no);
                    metroTextBox4.Show();
                    metroTextBox5.Show();
                    metroLabel5.Show();
                }
                
            }
            if (found == false)
            {
                MessageBox.Show("the passenger name or phone is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            string name = metroTextBox1.Text;
            string phone = metroTextBox2.Text;
            string newName = metroTextBox3.Text;
            string newPhone = metroTextBox4.Text;
            string newFlightNo = metroTextBox5.Text;
            foreach (Passenger passenger in Passenger.passengers)
            {
                string name_pass = passenger.Name;
                string phone_pass = passenger.phone;
                int chech_name = string.Compare(name_pass, name);
                int check_phone = string.Compare(phone_pass, phone);
                if (chech_name == 0 && check_phone == 0)
                {
                    char[] record = new char[50];
                    passenger.Name = newName;
                    passenger.phone = newPhone;
                    passenger.flight_no = newFlightNo;
                    bool found = false;
                    foreach (Flight flight in Flight.flights)
                    {
                        string flightnum = new string(flight.num);
                        if (passenger.flight_no.CompareTo(flightnum) == 0)
                        {
                             string Name =passenger.Name+ '@';
                             string phone1 = passenger.phone+'@';
                             string flight_no =passenger.flight_no+ '@';

                            Name.CopyTo(0, record, 0, Name.Length);

                            phone1.CopyTo(0, record, Name.Length, phone1.Length);

                            flight_no.CopyTo(0, record, phone1.Length + Name.Length, flight_no.Length);
                            for (int i = record.Length; i < 50; i++)
                            {
                                record[i] = '\0';
                            }
                            passenger.record = record;
                            MessageBox.Show("Your Data Is Edited Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            found = true;
                        }
                    }
                    if (found == false)
                    {
                        MessageBox.Show("Can Not Find This Flight Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
