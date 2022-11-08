using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebAPI_Core_Client_Malkin
{
    public partial class Form1 : Form
    {
        private const string APP_PATH = "http://10.2.22.5:33833";
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = client.GetAsync(APP_PATH + "/api/Game/").Result;
            string msg = response.Content.ReadAsStringAsync().Result;
            List<Game> game = (List<Game>)JsonConvert.DeserializeObject(msg, typeof(List<Game>));
            dataGridView1.ColumnCount = 5;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Описание";
            dataGridView1.Columns[3].HeaderText = "Цена";
            dataGridView1.Columns[4].HeaderText = "Оценка";

            for (int i = 0; i < game.Count(); i++)
            {
                dataGridView1.Rows.Add(); //формируем строку таблицы на форме
                dataGridView1[0, i].Value = game[i].ID.ToString();
                dataGridView1[1, i].Value = game[i].NameG;
                dataGridView1[2, i].Value = game[i].Description;
                dataGridView1[3, i].Value = game[i].Price.ToString();
                dataGridView1[4, i].Value = game[i].Rating.ToString();

            }

        }
    }
}
