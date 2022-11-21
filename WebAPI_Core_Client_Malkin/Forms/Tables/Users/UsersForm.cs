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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            btnReload_Click(null, null);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = client.GetAsync(GameContext.urls + "/api/User").Result;
            string msg = response.Content.ReadAsStringAsync().Result;
            List<User> users = (List<User>)JsonConvert.DeserializeObject(msg, typeof(List<User>));
            dgvTable.ColumnCount = 11;
            dgvTable.Rows.Clear();
            dgvTable.Columns[0].HeaderText = "Номер";
            dgvTable.Columns[1].HeaderText = "Логин";
            dgvTable.Columns[2].HeaderText = "Пароль";
            dgvTable.Columns[3].HeaderText = "Тип пользователя";

            for (int i = 0; i < users.Count(); i++)
            {
                dgvTable.Rows.Add(); //формируем строку таблицы на форме
                dgvTable[0, i].Value = users[i].ID.ToString();
                dgvTable[1, i].Value = users[i].Login;
                dgvTable[2, i].Value = users[i].Password;
                dgvTable[3, i].Value = users[i].UserType;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            if (addUser.ShowDialog() == DialogResult.OK)
            {
                btnReload_Click(null, null);
            }
        }

        private async void btnUpdate_ClickAsync(object sender, EventArgs e)
        {
            User user = new User();
            int rowIndex = dgvTable.CurrentCell.RowIndex;
            //MessageBox.Show(selRowNum.ToString());
            user.ID = int.Parse(dgvTable.Rows[rowIndex].Cells[0].Value.ToString());
            user.Login = dgvTable.Rows[rowIndex].Cells[1].Value.ToString();
            user.Password = dgvTable.Rows[rowIndex].Cells[2].Value.ToString();
            user.UserType = int.Parse(dgvTable.Rows[rowIndex].Cells[3].Value.ToString());
            using (var client = new HttpClient())
            {
                var serializeUserType = JsonConvert.SerializeObject(user);
                var content = new StringContent(serializeUserType, Encoding.UTF8, "application/json");
                var result = await client.PutAsync($"{GameContext.urls}/api/User/{user.ID}", content);
                //MessageBox.Show(result.ToString());
            }
        }

        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            int selRowNum = dgvTable.CurrentCell.RowIndex;
            int Num = int.Parse(dgvTable.Rows[selRowNum].Cells[0].Value.ToString());
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync($"{GameContext.urls}/api/User/{Num}");
            }
            btnReload_Click(null, null);
        }
    }
}
