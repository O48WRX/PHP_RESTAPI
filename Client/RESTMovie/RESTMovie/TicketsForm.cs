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
    public partial class TicketsForm : Form
    {
        static RestClient client;
        public TicketsForm()
        {
            InitializeComponent();
            string server = "127.0.0.1";
            string port = "80";

            client = new RestClient(string.Format("http://{0}:{1}/Server/tickets.php", server, port));
            Tickets2DataGrid();
        }

        public void Tickets2DataGrid()
        {
            var request = new RestRequest(Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            List<Tickets> tickets = new JsonSerializer().Deserialize<List<Tickets>>(response);

            TicketsGrid.DataSource = tickets;
        }

        private void TicketsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketIdBox.Text = TicketsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            movieIdBox.Text = TicketsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            movieTitleBox.Text = TicketsGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            streamTimeBox.Text = TicketsGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;


            request.AddJsonBody(new
            {
                ticket_id = int.Parse(ticketIdBox.Text),
                movie_id = int.Parse(movieIdBox.Text),
                movie_title = movieTitleBox.Text,
                stream_time = streamTimeBox.Text,
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            Tickets2DataGrid();
        }

        private void upd_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.PUT);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                ticket_id = int.Parse(ticketIdBox.Text),
                movie_id = int.Parse(movieIdBox.Text),
                movie_title = movieTitleBox.Text,
                stream_time = streamTimeBox.Text,
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            Tickets2DataGrid();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(ticketIdLabel.Text),
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            Tickets2DataGrid();
        }
    }
}
