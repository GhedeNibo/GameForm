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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addGame();
        }
        private async void addGame()
        {
            Game game = new Game();
            game.ID = 0;
            game.NameG = tbName.Text;
            game.Description = rtbDescription.Text;
            game.Price = decimal.Parse(tbPrice.Text);
            game.Rating = short.Parse(tbRating.Text);
            using (var client = new HttpClient())
            {
                var serializedGame = JsonConvert.SerializeObject(game);
                var content = new StringContent(serializedGame, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(GameContext.urls + "/api/Game", content);
                if (result.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                }
                else { MessageBox.Show("Проблемы с добавлением в базу !!??"); }
            }
        }
    }
}
