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

namespace WebAPI_Core_Client_Malkin
{
    public partial class UserTypesForm : Form
    {
        public UserTypesForm()
        {
            InitializeComponent();
            btnReload_Click(null, null);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = client.GetAsync(GameContext.urls + "/api/UserType").Result;
            string msg = response.Content.ReadAsStringAsync().Result;
            List<UserType> userTypes = (List<UserType>)JsonConvert.DeserializeObject(msg, typeof(List<UserType>));
            dgvTable.ColumnCount = 9;
            dgvTable.Rows.Clear();
            dgvTable.Columns[0].HeaderText = "Номер";
            dgvTable.Columns[1].HeaderText = "Название";
            dgvTable.Columns[2].HeaderText = "Чтение";
            dgvTable.Columns[3].HeaderText = "Создание";
            dgvTable.Columns[4].HeaderText = "Редактирование";
            dgvTable.Columns[5].HeaderText = "Редактирование любых записей";
            dgvTable.Columns[6].HeaderText = "Удаление";
            dgvTable.Columns[7].HeaderText = "Удаление любых записей";
            dgvTable.Columns[8].HeaderText = "Аварийная таблица";

            for (int i = 0; i < userTypes.Count(); i++)
            {
                dgvTable.Rows.Add(); //формируем строку таблицы на форме
                dgvTable[0, i].Value = userTypes[i].ID.ToString();
                dgvTable[1, i].Value = userTypes[i].TypeName;
                dgvTable[2, i].Value = userTypes[i].Read;
                dgvTable[3, i].Value = userTypes[i].Create;
                dgvTable[4, i].Value = userTypes[i].Edit;
                dgvTable[5, i].Value = userTypes[i].EditAll;
                dgvTable[6, i].Value = userTypes[i].Delete;
                dgvTable[7, i].Value = userTypes[i].DeleteAll;
                dgvTable[8, i].Value = userTypes[i].RezTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserType addUserType = new AddUserType();
            if (addUserType.ShowDialog() == DialogResult.OK)
            {
                btnReload_Click(null, null);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            UserType userType = new UserType();
            int rowIndex = dgvTable.CurrentCell.RowIndex;
            //MessageBox.Show(selRowNum.ToString());
            userType.ID = int.Parse(dgvTable.Rows[rowIndex].Cells[0].Value.ToString());
            userType.TypeName = dgvTable.Rows[rowIndex].Cells[1].Value.ToString();
            userType.Read = Convert.ToBoolean(dgvTable.Rows[rowIndex].Cells[2].Value);
            userType.Create = Convert.ToBoolean(dgvTable.Rows[rowIndex].Cells[3].Value);
            userType.Edit = Convert.ToBoolean(dgvTable.Rows[rowIndex].Cells[4].Value);
            userType.EditAll = Convert.ToBoolean(dgvTable.Rows[rowIndex].Cells[5].Value);
            userType.Delete = Convert.ToBoolean(dgvTable.Rows[rowIndex].Cells[6].Value);
            userType.Delete = Convert.ToBoolean(dgvTable.Rows[rowIndex].Cells[7].Value);
            userType.DeleteAll = Convert.ToBoolean(dgvTable.Rows[rowIndex].Cells[8].Value);
            using (var client = new HttpClient())
            {
                var serializeUserType = JsonConvert.SerializeObject(userType);
                var content = new StringContent(serializeUserType, Encoding.UTF8, "application/json");
                var result = await client.PutAsync($"{GameContext.urls}/api/UserType/{userType.ID}", content);
                //MessageBox.Show(result.ToString());
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int selRowNum = dgvTable.CurrentCell.RowIndex;
            int Num = int.Parse(dgvTable.Rows[selRowNum].Cells[0].Value.ToString());
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync($"{GameContext.urls}/api/UserType/{Num}");
            }
            btnReload_Click(null, null);
        }
    }
}
