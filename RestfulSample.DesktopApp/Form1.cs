using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using RestfulSample.DesktopApp.Business;

namespace RestfulSample.DesktopApp
{
    public partial class Form1 : Form
    {
        //string _apiUrl = "http://sample.api/api/sample/";
        //private string _apiSessionUrl = "http://sample.api/api/";
        //private string _sampleResponseApiUrl = "http://sample.api/api/SampleResponse/";

        string _apiUrl = "http://localhost:8001/sampleapi/api/sample/";
        private string _apiSessionUrl = "http://localhost:8001/sampleapi/api/";
        private string _sampleResponseApiUrl = "http://localhost:8001/sampleapi/api/SampleResponse/";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ListAll();
        }
        private void btnSearchById_Click(object sender, EventArgs e)
        {
            int ids;
            if (!int.TryParse(txtSearch.Text, out ids))
            {
                MessageBox.Show("Search by id keywords must be integer");
                return;
            }

            var id = 0;
            int.TryParse(txtId.Text, out id);


            var req = (HttpWebRequest)HttpWebRequest.Create(_apiUrl + ids);
            req.Method = "GET";

            var response = req.GetResponse();
            var responseData = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();

            var obj = new JavaScriptSerializer().Deserialize<SampleObject>(responseData);
            var list = new List<SampleObject>();
            if (obj != null)
            {
                list.Add(obj);
            }
            dgvList.DataSource = list;
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            ListAll();
        }

        private void ListAll()
        {
            var req = (HttpWebRequest)HttpWebRequest.Create(_apiUrl);
            req.Method = "GET";

            var response = req.GetResponse();
            var responseData = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();

            var list = new JavaScriptSerializer().Deserialize<List<SampleObject>>(responseData);

            dgvList.DataSource = list;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            var data = new SampleObject()
            {
                Value = txtValue.Text
            };

            var req = (HttpWebRequest)HttpWebRequest.Create(_apiUrl);
            req.Method = "POST";
            var sentData = Encoding.UTF8.GetBytes(data.ToJson());
            req.ContentType = "application/json";
            req.ContentLength = sentData.Length;
            using (var stream = req.GetRequestStream())
            {
                stream.Write(sentData, 0, sentData.Length);
            }
            var response = req.GetResponse();
            lblMsg.Text = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();

            ListAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var id = 0;
            if (!int.TryParse(txtId.Text, out id))
            {
                lblMsg.Text = "Id must be integer";
                return;
            }
            var data = new SampleObject()
            {
                Id = id,
                Value = txtValue.Text
            };

            var req = (HttpWebRequest)HttpWebRequest.Create(_apiUrl + id);
            req.Method = "PUT";
            var sentData = Encoding.UTF8.GetBytes(data.ToJson());
            req.ContentType = "application/json";
            req.ContentLength = sentData.Length;
            using (var stream = req.GetRequestStream())
            {
                stream.Write(sentData, 0, sentData.Length);
            }
            var response = req.GetResponse();
            lblMsg.Text = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();


            ListAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (!int.TryParse(txtId.Text, out id))
            {
                lblMsg.Text = "Id must be integer";
                return;
            }
            var data = new SampleObject()
            {
                Id = id,
                Value = txtValue.Text
            };

            var req = (HttpWebRequest)HttpWebRequest.Create(_apiUrl + id);
            req.Method = "DELETE";
            var sentData = Encoding.UTF8.GetBytes(data.ToJson());
            req.ContentType = "application/json";
            req.ContentLength = sentData.Length;
            using (var stream = req.GetRequestStream())
            {
                stream.Write(sentData, 0, sentData.Length);
            }
            var response = req.GetResponse();
            lblMsg.Text = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();


            ListAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var req = (HttpWebRequest)HttpWebRequest.Create(_apiUrl);
            req.Method = "GET";

            var response = req.GetResponse();
            var responseData = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();

            var list = new JavaScriptSerializer().Deserialize<List<SampleObject>>(responseData);
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvList.DataSource = list;
            }
            else
            {
                dgvList.DataSource = list.Where(i => i.Value.Contains(txtSearch.Text)).ToList();
            }
        }

        private void btnGetToken_Click(object sender, EventArgs e)
        {
            var req = (HttpWebRequest)HttpWebRequest.Create(_apiSessionUrl + "app/GetToken/" + txtApiKey.Text);
            req.Method = "GET";

            var response = req.GetResponse();
            var responseData = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();

            var obj = ResponseResult.FromJson(responseData);

            txtApiToken.Text = obj.Content as string;
        }

        private void btnIsValidToken_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApiToken.Text))
            {
                MessageBox.Show("Must get tokenkey first");
                return;
            }

            var req = (HttpWebRequest)HttpWebRequest.Create(_apiSessionUrl + "app/IsValidSession/" + txtApiToken.Text);
            req.Method = "GET";

            var response = req.GetResponse();
            var responseData = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();

            var obj = ResponseResult.FromJson(responseData);

            MessageBox.Show(obj.ToJson());
        }

        private void btnSampleResponse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApiToken.Text))
            {
                MessageBox.Show("Must get tokenkey first");
                return;
            }
            var testData = 1;
            var data = new RequestObject(testData)
            {
                Action = "GetById",
                Token = txtApiToken.Text
            };
            var sentData = Encoding.UTF8.GetBytes(data.ToJson());

            var req = (HttpWebRequest)HttpWebRequest.Create(_sampleResponseApiUrl);
            req.Method = "POST";
            req.ContentType = "application/json";
            req.ContentLength = sentData.Length;
            using (var stream = req.GetRequestStream())
            {
                stream.Write(sentData, 0, sentData.Length);
            }
            var response = req.GetResponse();
            var responseData = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();

            var res = ResponseResult.FromJson(responseData);

            MessageBox.Show(responseData);
        }

        private void btnSrGetAll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApiToken.Text))
            {
                MessageBox.Show("Must get tokenkey first");
                return;
            }
            var testData = 1;
            var data = new RequestObject(testData)
            {
                Action = "GetAll",
                Token = txtApiToken.Text
            };
            var sentData = Encoding.UTF8.GetBytes(data.ToJson());

            var req = (HttpWebRequest)HttpWebRequest.Create(_sampleResponseApiUrl);
            req.Method = "POST";
            req.ContentType = "application/json";
            req.ContentLength = sentData.Length;
            using (var stream = req.GetRequestStream())
            {
                stream.Write(sentData, 0, sentData.Length);
            }
            var response = req.GetResponse();
            var responseData = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            req.Abort();

            var res = ResponseResult.FromJson(responseData);

            MessageBox.Show(responseData);
        }

        private void btnHttpClient_Click(object sender, EventArgs e)
        {
            using (var c = new HttpClient())
            {
                var testData = 1;

                var data = new RequestObject(testData)
                {
                    Action = "GetAll",
                    Token = txtApiToken.Text
                };

                var response = c.PostAsync(_sampleResponseApiUrl, new StringContent(data.ToJson(), Encoding.UTF8, "application/json"));
                MessageBox.Show(response.Result.Content.ReadAsStringAsync().Result);
            }
        }

        OpenFileDialog _opf = new OpenFileDialog();

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (_opf.ShowDialog() == DialogResult.OK)
            {
                _opf.Multiselect = false;
                txtFileToUpload.Text = _opf.FileName;
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (var c = new HttpClient())
            {
                var file = new UploadOjbect(_opf.FileName, _opf.SafeFileName);

                var data = new RequestObject(file)
                {
                    Action = "UploadFile",
                    Token = txtApiToken.Text
                };


                var response = c.PostAsync(_sampleResponseApiUrl, new StringContent(data.ToJson(), Encoding.UTF8, "application/json"));
                var result = response.Result.Content.ReadAsStringAsync().Result;
                MessageBox.Show(result);
            }
        }

        private void dgvList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = (int)dgvList.Rows[e.RowIndex].Cells[0].Value;
                var val = dgvList.Rows[e.RowIndex].Cells[1].Value as string;

                txtId.Text = id.ToString();
                txtValue.Text = val;
            }
            catch
            {

            }
        }

    }
}
