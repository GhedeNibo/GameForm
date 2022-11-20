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
    public partial class AddUserType : Form
    {
        public AddUserType()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            UserType userType = new UserType();
            userType.ID = 0;
            userType.TypeName = tbTypeName.Text;
            userType.Read = cbRead.Checked;
            userType.Create = cbCreate.Checked;
            userType.Edit = cbEdit.Checked;
            userType.EditAll = cbEditAll.Checked;
            userType.Delete = cbDelete.Checked;
            userType.DeleteAll = cbDeleteAll.Checked;
            userType.RezTable = cbRezTable.Checked;
            using (var client = new HttpClient())
            {
                var serializedGame = JsonConvert.SerializeObject(userType);
                var content = new StringContent(serializedGame, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(GameContext.urls + "/api/UserType", content);
                if (result.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                }
                else { MessageBox.Show("Проблемы с добавлением в базу !!??"); }
            }
        }
    }
}
