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

namespace WebAPI_Core_Client_Malkin.Forms.Auth
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            cbUserType.Items.Add("Игрок");
            cbUserType.Items.Add("Разработчик");
            cbUserType.SelectedIndex = 0;
        }

        private async void btnRegister_ClickAsync(object sender, EventArgs e)
        {
            int utype = 0;
            switch (cbUserType.SelectedIndex)
            {
                case 0:
                    utype = 3;
                    break;
                case 1:
                    utype = 4;
                    break;
            }
            if (tbLogin.Text != null && tbPassword.Text != null && tbRePassword.Text != null)
            {
                if(tbPassword.Text == tbRePassword.Text)
                {
                    User userType = new User();
                    userType.ID = 0;
                    userType.Login = tbLogin.Text;
                    userType.Password = tbPassword.Text;
                    userType.UserType = utype;
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
                } else {
                    MessageBox.Show("Пароли не совпадают"); 
                }
            }
            else
            {
                MessageBox.Show("Заполнены не все поля");
            }
        }
    }
}
