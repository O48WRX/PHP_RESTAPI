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
    public partial class Form1 : Form
    {
        RestClient client = null;

        public static User UserLoggedIn = null;
        public Form1()
        {
            InitializeComponent();
            F1_LOGOUT.Visible = false;

            string server = "127.0.0.1";
            string port = "80";

            client = new RestClient(string.Format("http://{0}:{1}/Server/index.php",server, port));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == Users_MenuStripItem)
            {
                UserForm form = new UserForm();
                form.ShowDialog();
            }
            else
            {
                MovieForm form = new MovieForm();
                form.ShowDialog();
            }
        }

        private void F1_LOGIN_Click(object sender, EventArgs e)
        {
            var request = new RestRequest(Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddObject(new
            {
                username = F1_USERNAMEBOX.Text,
                password = F1_PWBOX.Text
            });
            string tempusername = F1_USERNAMEBOX.Text;
            string tempPassword = F1_PWBOX.Text;

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            var response1 = client.Execute<List<User>>(request);

            var deserializer = new JsonDeserializer();

            var deserializedJSON = deserializer.Deserialize<List<User>>(response1);

            for (int i = 0; i < deserializedJSON.Count; i++)
            {
                if (deserializedJSON[i].Name == tempusername && deserializedJSON[i].Password == tempPassword)
                {
                    MessageBox.Show("User Found!");
                    UserLoggedIn = new User(deserializedJSON[i].Id, deserializedJSON[i].Name, deserializedJSON[i].Password, deserializedJSON[i].isAdmin);
                    LoginBox.Visible = false;
                    F1_LOGOUT.Visible = true;
                    return;
                }
            }

            if (UserLoggedIn == null)
            {
                MessageBox.Show("Invalid login credentials!");
                return;
            }
        }
    }
}
