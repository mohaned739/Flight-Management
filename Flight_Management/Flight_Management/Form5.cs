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
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        //terminate on pressing exit
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Flight.Write();
            Passenger.Write();
            Environment.Exit(0);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bool flighfound = false;
            bool passengersExist = false;

            metroGrid1.Rows.Clear();
            
            string flightNum = metroTextBox1.Text;
            string date = metroTextBox2.Text;
            List<Passenger> newList = new List<Passenger>();
            
            foreach (Flight flight in Flight.flights)
            {
                string flightno = new string(flight.num);
                string arrdate = new string(flight.arrival_date);
                if (flightno.CompareTo(flightNum) == 0 && date.CompareTo(arrdate) == 0)
                {
                    flighfound = true;
                    foreach (Passenger p in Passenger.passengers)
                    {
                        if (string.Compare(flightNum, p.flight_no) == 0)
                        {
                            newList.Add(p);
                            passengersExist = true;
                        }
                    }
                }
            }

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Passenger Name");
                    dt.Columns.Add("Passenger Phone");
                    foreach (Passenger p in newList)
                    {
                            DataRow row = dt.NewRow();
                            row["Passenger Name"] = p.Name;
                            row["Passenger Phone"] = p.phone;
                            dt.Rows.Add(row);
                    }

                    foreach (DataRow Drow in dt.Rows)
                    {
                        int num = metroGrid1.Rows.Add();
                        metroGrid1.Rows[num].Cells[0].Value = Drow["Passenger Name"].ToString();
                        metroGrid1.Rows[num].Cells[1].Value = Drow["Passenger Phone"].ToString();
                    }

                    if (flighfound == false)
                {
                    MessageBox.Show("Invalid Flight Number or Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                    else if (passengersExist == false){
                        MessageBox.Show("no passengers for this flight", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
}

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
