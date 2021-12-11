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
    public partial class UserForm : Form
    {
        RestClient client = null;
        public UserForm()
        {
            InitializeComponent();

            string server = "127.0.0.1";
            string port = "80";

            client = new RestClient(string.Format("http://{0}:{1}/Server/user.php", server, port));
            AddUsers2Grid();
        }

        private void AddUsers2Grid()
        {
            var request = new RestRequest(Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }
            var response1 = client.Execute<List<User>>(request);
            List<User> users = new JsonSerializer().Deserialize<List<User>>(response);
            dataGridView1.DataSource = users;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pwBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            isAdminBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                username = nameBox.Text,
                password = pwBox.Text,
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            AddUsers2Grid();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(label6.Text),
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            AddUsers2Grid();
        }

        private void upd_button_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.PUT);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(label6.Text),
                username = nameBox.Text,
                password = pwBox.Text,
                isAdmin = isAdminBox.Text
            });


            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            AddUsers2Grid();
        }
    }
}
