using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WebAPI_Core_Client_Malkin.Forms.Auth;
using WebAPI_Core_Client_Malkin.Models;

namespace WebAPI_Core_Client_Malkin
{
    public partial class Login : Form
    {   
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ExtUser currentUser = null;
            var login = tbLogin.Text;
            var password = tbPassword.Text;
            bool result = false;
            var client = new HttpClient();
            var response = client.GetAsync(GameContext.urls + "/api/User").Result;
            string msg = response.Content.ReadAsStringAsync().Result;
            List<User> user = (List<User>)JsonConvert.DeserializeObject(msg, typeof(List<User>));
            for (int i = 0; i < user.Count(); i++)
            {
                if (user[i].Login == login && user[i].Password == password)
                {
                    currentUser = getCurrentUser(client, user[i].ID);
                    result = true;
                    break;
                }
            }
            if(result)
            {
                Main.currentUser = currentUser;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private ExtUser getCurrentUser(HttpClient httpClient, int id)
        {
            HttpResponseMessage resp = httpClient.GetAsync(GameContext.urls + $"/api/ExtUser/{id}").Result;
            string msg = resp.Content.ReadAsStringAsync().Result;
            return (ExtUser) JsonConvert.DeserializeObject(msg, typeof(ExtUser));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}
