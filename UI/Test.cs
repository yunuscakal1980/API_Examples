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
using UI.Models;

namespace UI
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        //grid temizle
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        //test event (aa-sync)
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = (int.Parse(button3.Text) + 1).ToString();
        }

        //C : POST: Sync
        private void button5_Click(object sender, EventArgs e)
        {
            Ogrenci _ogrenci = new Ogrenci();
            _ogrenci.Id = 3;
            _ogrenci.Adi = "Zeynep Ece";
            HttpContent hcOgrenci = new StringContent(JsonConvert.SerializeObject(_ogrenci), Encoding.UTF8, "application/json");

            bool result = false;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = client.PostAsync("api/Ogrenci/Post", hcOgrenci).Result;
            if (response.IsSuccessStatusCode)
            {
                string strJson = response.Content.ReadAsStringAsync().Result;
                result = (bool)JsonConvert.DeserializeObject(strJson, (typeof(bool)));
            }

            //grid refresh
            //button2_Click(null, null);

            label4.Text += "\n" + "Response: " + result.ToString();
        }

        //C : POST: Async
        private async void button6_Click(object sender, EventArgs e)
        {
            Ogrenci _ogrenci = new Ogrenci();
            _ogrenci.Id = 3;
            _ogrenci.Adi = "Zeynep Ece";
            HttpContent hcOgrenci = new StringContent(JsonConvert.SerializeObject(_ogrenci), Encoding.UTF8, "application/json");

            bool result = false;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = await client.PostAsync("api/Ogrenci/PostAsync", hcOgrenci);
            if (response.IsSuccessStatusCode)
            {
                string strJson = await response.Content.ReadAsStringAsync();
                result = (bool)JsonConvert.DeserializeObject(strJson, (typeof(bool)));
            }

            //grid refresh
            //button2_Click(null, null);

            label4.Text += "\n" + "Response: " + result.ToString();
        }

        //R : GET: Sync
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtResult = new DataTable();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = client.GetAsync("api/Ogrenci/Get").Result;
            if (response.IsSuccessStatusCode)
            {
                string strJson = response.Content.ReadAsStringAsync().Result;
                dtResult = (DataTable)JsonConvert.DeserializeObject(strJson, (typeof(DataTable)));
            }

            dataGridView1.DataSource = dtResult;

            label4.Text += "\n" + "Row Count: " + dtResult.Rows.Count.ToString();
        }

        //R : GET: Async
        private async void button1_Click(object sender, EventArgs e)
        {
            DataTable dtResult = new DataTable();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = await client.GetAsync("api/Ogrenci/GetAsync");
            if (response.IsSuccessStatusCode)
            {
                string strJson = await response.Content.ReadAsStringAsync();
                dtResult = (DataTable)JsonConvert.DeserializeObject(strJson, (typeof(DataTable)));
            }

            dataGridView1.DataSource =dtResult;

            label4.Text += "\n" + "Row Count: " + dtResult.Rows.Count.ToString();
        }

        //R : GET [id]: Sync
        private void button11_Click(object sender, EventArgs e)
        {
            int _id = 3;

            DataTable dtResult = new DataTable();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = client.GetAsync("api/Ogrenci/Get/" + _id.ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                string strJson = response.Content.ReadAsStringAsync().Result;
                dtResult = (DataTable)JsonConvert.DeserializeObject(strJson, (typeof(DataTable)));
            }

            dataGridView1.DataSource = dtResult;

            label4.Text += "\n" + "Row Count: " + dtResult.Rows.Count.ToString();
        }

        //R : GET [id]: Async
        private async void button12_Click(object sender, EventArgs e)
        {
            int _id = 3;

            DataTable dtResult = new DataTable();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = await client.GetAsync("api/Ogrenci/GetAsync/" + _id.ToString());
            if (response.IsSuccessStatusCode)
            {
                string strJson = await response.Content.ReadAsStringAsync();
                dtResult = (DataTable)JsonConvert.DeserializeObject(strJson, (typeof(DataTable)));
            }

            dataGridView1.DataSource = dtResult;

            label4.Text += "\n" + "Row Count: " + dtResult.Rows.Count.ToString();
        }

        //U : PUT: Sync
        private void button9_Click(object sender, EventArgs e)
        {
            Ogrenci _ogrenci = new Ogrenci();
            _ogrenci.Id = 3;
            _ogrenci.Adi = "Zeynep Ece";
            HttpContent hcOgrenci = new StringContent(JsonConvert.SerializeObject(_ogrenci), Encoding.UTF8, "application/json");

            bool result = false;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = client.PutAsync("api/Ogrenci/Put", hcOgrenci).Result;
            if (response.IsSuccessStatusCode)
            {
                string strJson = response.Content.ReadAsStringAsync().Result;
                result = (bool)JsonConvert.DeserializeObject(strJson, (typeof(bool)));
            }

            //grid refresh
            //button2_Click(null, null);

            label4.Text += "\n" + "Response: " + result.ToString();
        }

        //U : PUT: Async
        private async void button7_Click(object sender, EventArgs e)
        {
            Ogrenci _ogrenci = new Ogrenci();
            _ogrenci.Id = 3;
            _ogrenci.Adi = "Zeynep Ece";
            HttpContent hcOgrenci = new StringContent(JsonConvert.SerializeObject(_ogrenci), Encoding.UTF8, "application/json");

            bool result = false;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = await client.PutAsync("api/Ogrenci/PutAsync", hcOgrenci);
            if (response.IsSuccessStatusCode)
            {
                string strJson = await response.Content.ReadAsStringAsync();
                result = (bool)JsonConvert.DeserializeObject(strJson, (typeof(bool)));
            }

            //grid refresh
            //button2_Click(null, null);

            label4.Text += "\n" + "Response: " + result.ToString();
        }

        //D : DELETE: Sync
        private void button10_Click(object sender, EventArgs e)
        {
            int _id = 3;

            bool result = false;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = client.DeleteAsync("api/Ogrenci/Delete/" + _id.ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                string strJson = response.Content.ReadAsStringAsync().Result;
                result = (bool)JsonConvert.DeserializeObject(strJson, (typeof(bool)));
            }

            //grid refresh
            //button2_Click(null, null);

            label4.Text += "\n" + "Response: " + result.ToString();
        }

        //D : DELETE: Async
        private async void button8_Click(object sender, EventArgs e)
        {
            int _id = 3;

            bool result = false;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52673/");
            HttpResponseMessage response = await client.DeleteAsync("api/Ogrenci/DeleteAsync/" + _id.ToString());
            if (response.IsSuccessStatusCode)
            {
                string strJson = await response.Content.ReadAsStringAsync();
                result = (bool)JsonConvert.DeserializeObject(strJson, (typeof(bool)));
            }

            //grid refresh
            //button2_Click(null, null);

            label4.Text += "\n" + "Response: " + result.ToString();
        }
    }
}
