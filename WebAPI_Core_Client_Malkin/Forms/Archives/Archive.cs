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

namespace WebAPI_Core_Client_Malkin.Forms.Archives
{
    public partial class Archive : Form
    {
        List<string> dbList;

        public Archive()
        {
            InitializeComponent();
            showDbList();
        }

        private void showDbList()
        {
            getDbList();
            cbDbList.DataSource = dbList;
        }

        private void getDbList()
        {
            HttpResponseMessage resp = new HttpClient().GetAsync(GameContext.urls + $"/api/Rezerv").Result;
            string msg = resp.Content.ReadAsStringAsync().Result;
            dbList = (List<string>)JsonConvert.DeserializeObject(msg, typeof(List<string>));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new HttpClient().GetAsync(GameContext.urls + $"/api/Rezerv/Create");
            showDbList();
        }

        private void cbDbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            new HttpClient().GetAsync(GameContext.urls + $"/api/Rezerv/Curent/{cbDbList.SelectedIndex}");
        }



        private void btnSavePolicy_Click(object sender, EventArgs e)
        {
            int mseconds = int.Parse(tbS.Text)*1000 + int.Parse(tbM.Text)*1000*60 + int.Parse(tbH.Text)*1000*60*60 + int.Parse(tbD.Text)*1000*60*60*24;
            new HttpClient().GetAsync(GameContext.urls + $"/api/Rezerv/TimerToCreate/{mseconds}");

            new HttpClient().GetAsync(GameContext.urls + $"/api/Rezerv/MaxRezervs/{int.Parse(tbCopy.Text)}");
        }
    }
}
