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


namespace Fahrplan
{
    public partial class Maps : Form
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();
        public Maps()
        {
            InitializeComponent();
        }

        private void btnSchliesen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStation.Text = lsbStation.SelectedItem.ToString();
           btnAnzeigen.Focus();
            lsbStation.Visible = false;
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

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            getstations(txtStation.Text, lsbStation);
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            if (txtStation.Text != string.Empty)
            {
                Stations stations = transport.GetStations(txtStation.Text);
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }
        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            webKarte.Navigate(url);
        }
    }
}
