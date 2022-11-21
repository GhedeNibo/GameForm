using Newtonsoft.Json;
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
using WebAPI_Core_Client_Malkin.Models;

namespace WebAPI_Core_Client_Malkin.Forms.Tables.Users
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            User userType = new User();
            userType.ID = 0;
            userType.Login = tbLogin.Text;
            userType.Password = tbPassword.Text;
            userType.UserType = int.Parse(tbUserType.Text);
            using (var client = new HttpClient())
            {
                var serializedGame = JsonConvert.SerializeObject(userType);
                var content = new StringContent(serializedGame, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(GameContext.urls + "/api/User", content);
                if (result.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                }
                else { MessageBox.Show("Проблемы с добавлением в базу !!??"); }
            }
        }
    }
}
