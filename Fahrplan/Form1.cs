using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net.Mail;

namespace Fahrplan
{
    public partial class Fahrplan : Form
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();
        
        public Fahrplan()
        {
            InitializeComponent();
            
        }
        private void getstations(string text, ListBox listBox)
        {
            if (text.Length >= 3)
            {
                listBox.Items.Clear();
                Stations stations = transport.GetStations(text);
                foreach (Station station in stations.StationList)
                {
                    listBox.Items.Add(station.Name);
                    listBox.Visible = true;
                    listBox.BringToFront();
                }
                
            }
        }
        public string Get_TableFromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append("<table border='1' cellpadding='0' cellspacing='0'>");
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in dgvResultat.Columns)
                {
                    strTable.AppendFormat("<th>{0}</th>", col.HeaderText);
                }
                strTable.Append("</tr>");
                for (int i = 0; i < dgvResultat.Rows.Count; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in dgvResultat.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }
                    strTable.Append("</tr>");
                }
                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return strTable.ToString();
        }
        private void Get_Grid()
        {
            Cursor.Current = Cursors.WaitCursor;
            lblLaden.Visible = true;
            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("Von");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Nach");
            dtt_connections.Columns.Add("Ankunft");
            dtt_connections.Columns.Add("Gleis");
            
            //Abfrarge
            Connections connections = transport.GetConnections(txtAbfahrtsort.Text, txtZiel.Text, dtpDatum.Value.ToString("yyyy-MM-dd"), dtpUhrzeit.Text);

            //Resultat wird zur Lsite hinzugefügt
            foreach (Connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(Get_Date(connection.From.Departure), connection.From.Station.Name, Get_Time(connection.From.Departure), connection.To.Station.Name, Get_Time(connection.To.Arrival), connection.To.Platform);
            }

            dgvResultat.DataSource = dtt_connections;
            lblLaden.Visible = false;
            UseWaitCursor = false;
        }
        private void Get_2_Grid()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");

            //Inhalt der Textbox wird übergeben
            Station station = transport.GetStations(txtVon.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id); 

            foreach (StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(Get_Time(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number)); 
            }

            dgvAbfahrtsplan.DataSource = dtt_routes;
        }

        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.mm.yyyy");
        }
        private string Get_Time(string time1) 
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }

        private void btnWechseln_Click(object sender, EventArgs e)
        {
            string abfahrtsort = txtAbfahrtsort.Text;
            string ziel = txtZiel.Text;

            txtAbfahrtsort.Text = ziel;
            txtZiel.Text = abfahrtsort;   
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (txtAbfahrtsort.Text != string.Empty)
            {
                Get_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Orte ein!");
            }
        }
    


        private void lsbAbfahrtsort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtAbfahrtsort.Text = lsbAbfahrtsort.SelectedItem.ToString();
            btnSuchen.Focus();
            lsbAbfahrtsort.Visible = false;
        }

        private void lsbZiel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtZiel.Text = lsbZiel.SelectedItem.ToString();
            btnSuchen.Focus();
            lsbZiel.Visible = false;

        }

        private void txtAbfahrtsort_TextChanged_1(object sender, EventArgs e)
        {
            getstations(txtAbfahrtsort.Text, lsbAbfahrtsort);
        }

        private void txtZiel_TextChanged_1(object sender, EventArgs e)
        {
            getstations(txtZiel.Text, lsbZiel);
        }
        
        //Navigation
        private void btnVerbindung_Click(object sender, EventArgs e)
        {
            pnlfahrplan.Visible = true;
            pnlAbfahrtsplan.Visible = false;         
        }

        private void btnabfahrtstafel_Click(object sender, EventArgs e)
        {
            pnlAbfahrtsplan.Visible = true;            
        }

        private void txtVon_TextChanged(object sender, EventArgs e)
        {
            getstations(txtVon.Text, lsbVon);
        }

       

        private void btnAbfahrt_Click(object sender, EventArgs e)
        {
            lblLädt2.Visible = true;
            if (txtVon.Text != string.Empty)
            {
                Get_2_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
            lblLädt2.Visible = false;
        }

        private void lsbVon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVon.Text = lsbVon.SelectedItem.ToString();
            txtVon.Focus();
            lsbVon.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 exit = new Form2();
            exit.Visible = false;
            if (exit.ShowDialog(this) == DialogResult.OK)
            {
                Close();
            }
            else
            {
                exit.Dispose();
            }
        }

        private void btnKarte_Click(object sender, EventArgs e)
        {
            Form neuesFormular = new Maps();
            neuesFormular.Show(this);
        }


        private void txtMail_Click(object sender, EventArgs e)
        {
            string mail = " ";
            this.txtMail.Text = mail;
            this.txtMail.ForeColor = Color.Black;
        }

        //Email Verschiken
        private void btnMail_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "max@gmail.ch")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("Martin64flex@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.txtMail)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hallo, hier ein Fahrplan, den ich mit dir teilen wollte. ";
                    mail.Body += "<b>" + Get_TableFromDataGrid() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("Martin64flex@gmail.com", "Martin17*");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email wurde erfolgreich gesendet");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

      
    }
}
