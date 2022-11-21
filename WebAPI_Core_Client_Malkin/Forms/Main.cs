﻿using System;
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
        static public ExtUser currentUser;

        public Main()
        {
            InitializeComponent();
            showLogin();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(currentUser == null)
            {
                Application.Exit();
            }
        }

        private void showLogin()
        {
            Login loginForm = new Login();
            loginForm.Owner = this;

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                loginForm.Close();
                lbLogin.Text = currentUser.Login;
            }
            if (currentUser != null)
            {
                blockInterfce();
            }
        }
        private void blockInterfce()
        {
            UserType ut = currentUser.UserType;
            if (!ut.Read)
            {
                tcMain.Visible = false;
                //btnReload.Visible = false;
            }
            else
            {
                btnReload_Click(null, null);
                btnReloadOwner_Click(null, null);
            }
            if (!ut.Create)
            {
                btnAdd.Visible = false;
                btnAddOwner.Visible = false;
            }
            if (!ut.Edit)
            {
                btnUpdateOwner.Visible = false;
            }
            if (!ut.EditAll)
            {
                btnUpdate.Visible = false;
            }
            if (!ut.Delete)
            {
                btnDeleteOwner.Visible = false;
            }
            if (!ut.DeleteAll)
            {
                btnDelete.Visible = false;
            }
            if (!ut.RezTable)
            {
                //
            }
            if (!ut.EmergTable)
            {
                userTypesToolStripMenuItem.Visible = false;
            }
            if (!ut.UserTable)
            {
                usersToolStripMenuItem.Visible = false;
            }
        }

        // table UserTypes
        private void userTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTypesForm userTypesForm = new UserTypesForm();
            userTypesForm.Show();
        }

        private void logOuttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //
        //  MAIN
        //
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();
            //addGame.Owner = this;
            addGame.currentUser = currentUser;
            if (addGame.ShowDialog() == DialogResult.OK)
            {
                btnReload_Click(null, null);
            }
        }

        //
        //  OWNER
        //

        private void btnReloadOwner_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = client.GetAsync(GameContext.urls + "/api/Game/owner/"+currentUser.ID).Result;
            string msg = response.Content.ReadAsStringAsync().Result;
            List<Game> game = (List<Game>)JsonConvert.DeserializeObject(msg, typeof(List<Game>));
            dgvOwner.ColumnCount = 5;
            dgvOwner.Rows.Clear();
            dgvOwner.Columns[0].HeaderText = "Номер";
            dgvOwner.Columns[1].HeaderText = "Название";
            dgvOwner.Columns[2].HeaderText = "Описание";
            dgvOwner.Columns[3].HeaderText = "Цена";
            dgvOwner.Columns[4].HeaderText = "Оценка";

            for (int i = 0; i < game.Count(); i++)
            {
                dgvOwner.Rows.Add(); //формируем строку таблицы на форме
                dgvOwner[0, i].Value = game[i].ID.ToString();
                dgvOwner[1, i].Value = game[i].NameG;
                dgvOwner[2, i].Value = game[i].Description;
                dgvOwner[3, i].Value = game[i].Price.ToString();
                dgvOwner[4, i].Value = game[i].Rating.ToString();
            }
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();
            //addGame.Owner = this;
            addGame.currentUser = currentUser;
            if (addGame.ShowDialog() == DialogResult.OK)
            {
                btnReloadOwner_Click(null, null);
            }
        }

        private async void btnUpdateOwner_ClickAsync(object sender, EventArgs e)
        {
            Game game = new Game();
            int rowIndex = dgvOwner.CurrentCell.RowIndex;
            //MessageBox.Show(selRowNum.ToString());
            game.ID = int.Parse(dgvOwner.Rows[rowIndex].Cells[0].Value.ToString());
            game.NameG = dgvOwner.Rows[rowIndex].Cells[1].Value.ToString();
            game.Description = dgvOwner.Rows[rowIndex].Cells[2].Value.ToString();
            game.Price = Convert.ToDecimal(dgvOwner.Rows[rowIndex].Cells[3].Value.ToString());
            game.Rating = short.Parse(dgvOwner.Rows[rowIndex].Cells[4].Value.ToString());
            game.OwnerID = currentUser.ID;
            using (var client = new HttpClient())
            {
                var serializedGame = JsonConvert.SerializeObject(game);
                var content = new StringContent(serializedGame, Encoding.UTF8, "application/json");
                var result = await client.PutAsync(String.Format("{0}/{1}", GameContext.urls + "/api/Game", game.ID), content);
                //MessageBox.Show(result.ToString());
            }
        }

        private async void btnDeleteOwner_ClickAsync(object sender, EventArgs e)
        {
            int selRowNum = dgvOwner.CurrentCell.RowIndex;
            int Num = int.Parse(dgvOwner.Rows[selRowNum].Cells[0].Value.ToString());
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync(String.Format("{0}/{1}", GameContext.urls + "/api/Game", Num));
            }
        }

    }
}
