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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroGrid1.Rows.Clear();

            string destination = des_text.Text;
            DataTable dt = new DataTable();
            dt.Columns.Add("Flight Number");
            dt.Columns.Add("Arrival Date");
            dt.Columns.Add("Destination");
            foreach (Flight flight in Flight.flights)
            {
                string fd = new string(flight.destination);
                int comp = string.Compare(destination, fd);
                if (comp==0)
                {
                    DataRow row = dt.NewRow();
                    string fn=new string(flight.num);
                    string fad = new string(flight.arrival_date);
                    row["Flight Number"] = fn;
                    row["Arrival Date"] = fad;
                    row["Destination"] = fd;
                    dt.Rows.Add(row);
                }
            }

            foreach (DataRow Drow in dt.Rows){
                int num = metroGrid1.Rows.Add();
                metroGrid1.Rows[num].Cells[0].Value = Drow["Flight Number"].ToString();
                metroGrid1.Rows[num].Cells[1].Value = Drow["Arrival Date"].ToString();
                metroGrid1.Rows[num].Cells[2].Value = Drow["Destination"].ToString();
            }
        }
        //terminate on pressing exit
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Flight.Write();
            Passenger.Write();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
