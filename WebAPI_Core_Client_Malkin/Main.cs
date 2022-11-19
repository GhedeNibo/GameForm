using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using WebAPI_Core_Client_Malkin.Models;
using System.Threading.Tasks;

namespace WebAPI_Core_Client_Malkin
{
    
    public partial class Main : Form
    {
        static public User currentUser;
        public Main()
        {
            Login loginForm = new Login();
            loginForm.Owner = this;
            if(loginForm.ShowDialog() != DialogResult.OK)
            {
                loginForm.Close();
                Main main = new Main();
                main.Close();
            }
            else
            {
                InitializeComponent();
            }
          
            lbLogin.Text = currentUser.Login;
            btnReload_Click(null, null);
            
        }
      
        private void btnReload_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = client.GetAsync(GameContext.urls + "/api/Game").Result;
            string msg = response.Content.ReadAsStringAsync().Result;
            List<Game> game = (List<Game>)JsonConvert.DeserializeObject(msg, typeof(List<Game>));
            dgvTable.ColumnCount = 5;
            dgvTable.Rows.Clear();
            dgvTable.Columns[0].HeaderText = "Номер";
            dgvTable.Columns[1].HeaderText = "Название";
            dgvTable.Columns[2].HeaderText = "Описание";
            dgvTable.Columns[3].HeaderText = "Цена";
            dgvTable.Columns[4].HeaderText = "Оценка";

            for (int i = 0; i < game.Count(); i++)
            {
                dgvTable.Rows.Add(); //формируем строку таблицы на форме
                dgvTable[0, i].Value = game[i].ID.ToString();
                dgvTable[1, i].Value = game[i].NameG;
                dgvTable[2, i].Value = game[i].Description;
                dgvTable[3, i].Value = game[i].Price.ToString();
                dgvTable[4, i].Value = game[i].Rating.ToString();

            }
        }

        private async void btnUpdate_ClickAsync(object sender, EventArgs e)
        {
            Game game = new Game();
            int rowIndex = dgvTable.CurrentCell.RowIndex;
            //MessageBox.Show(selRowNum.ToString());
            game.ID = int.Parse(dgvTable.Rows[rowIndex].Cells[0].Value.ToString());
            game.NameG = dgvTable.Rows[rowIndex].Cells[1].Value.ToString();
            game.Description = dgvTable.Rows[rowIndex].Cells[2].Value.ToString();
            game.Price = Convert.ToDecimal(dgvTable.Rows[rowIndex].Cells[3].Value.ToString());
            game.Rating = short.Parse(dgvTable.Rows[rowIndex].Cells[4].Value.ToString());
            using (var client = new HttpClient())
            {
                var serializedGame = JsonConvert.SerializeObject(game);
                var content = new StringContent(serializedGame, Encoding.UTF8, "application/json");
                var result = await client.PutAsync(String.Format("{0}/{1}", GameContext.urls + "/api/Game", game.ID), content);
                //MessageBox.Show(result.ToString());
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int selRowNum = dgvTable.CurrentCell.RowIndex;
            int Num = int.Parse(dgvTable.Rows[selRowNum].Cells[0].Value.ToString());
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync(String.Format("{0}/{1}", GameContext.urls + "/api/Game", Num));
            }
        }
    }
}
