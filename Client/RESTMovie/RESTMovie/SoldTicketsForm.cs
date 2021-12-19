using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTMovie
{
    public partial class SoldTicketsForm : Form
    {
        static RestClient client;
        public SoldTicketsForm()
        {
            InitializeComponent();

            string server = "127.0.0.1";
            string port = "80";
            client = new RestClient(string.Format("http://{0}:{1}/Server/soldtickets.php", server, port));

            if (Form1.UserLoggedIn == null || Form1.UserLoggedIn.isAdmin != 1)
            {
                groupBox2.Visible = false;
                add_button.Visible = false;
                upd_button.Visible = false;
                del_button.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
                add_button.Visible = true;
                upd_button.Visible = true;
                del_button.Visible = true;
            }

            SoldTickets2DataGrid();
        }

        public void SoldTickets2DataGrid()
        {
            var request = new RestRequest(Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            List<SoldTicket> soldtickets = new JsonSerializer().Deserialize<List<SoldTicket>>(response);

            TicketsGrid.DataSource = soldtickets;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;


            request.AddJsonBody(new
            {
                ticket_id = int.Parse(ticketIdBox.Text),
                user_id = int.Parse(userIdBox.Text),
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            SoldTickets2DataGrid();
        }

        private void upd_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.PUT);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(IdStoreLabel.Text),
                ticket_id = int.Parse(ticketIdBox.Text),
                user_id = userIdBox.Text,
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }
            SoldTickets2DataGrid();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(IdStoreLabel.Text),
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            SoldTickets2DataGrid();
        }

        private void TicketsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdStoreLabel.Text = TicketsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            ticketIdBox.Text = TicketsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            userIdBox.Text = TicketsGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
