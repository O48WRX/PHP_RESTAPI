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
    public partial class MovieForm : Form
    {
        RestClient client = null;
        public MovieForm()
        {
            InitializeComponent();

            string server = "127.0.0.1";
            string port = "80";

            client = new RestClient(string.Format("http://{0}:{1}/Server/index.php", server, port));
            Movies2DataGrid();
        }

        private void Movies2DataGrid()
        {
            var request = new RestRequest(Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            List<Movie> movies = new JsonSerializer().Deserialize<List<Movie>>(response);

            dataGridView1.DataSource = movies;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            titleBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.PUT);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(label3.Text),
                title = titleBox.Text,
                username = Form1.UserLoggedIn.Name,
                password = Form1.UserLoggedIn.Password
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }
            Movies2DataGrid();
        }

        private void INS_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            MessageBox.Show(titleBox.Text);
            request.AddJsonBody(new
            {
                title = titleBox.Text,
                username = Form1.UserLoggedIn.Name,
                password = Form1.UserLoggedIn.Password
            });


            MessageBox.Show(String.Format("{0}", request));
            var response = client.Execute(request);



            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            Movies2DataGrid();
        }

        private void del_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(label3.Text),
                username = Form1.UserLoggedIn.Name,
                password = Form1.UserLoggedIn.Password

            }); ;


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            Movies2DataGrid();
        }
    }
}
