using DuAnQuanLyHieuThuoc.BUS;
using DuAnQuanLyHieuThuoc.DAO;
using DuAnQuanLyHieuThuoc.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DuAnQuanLyHieuThuoc
{
    public partial class UserThanhToan : UserControl
    {
        BUS_ThanhToan bThanhToan;
        public UserThanhToan()
        {
            InitializeComponent();
            bThanhToan = new BUS_ThanhToan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var apiRequest = new ApiRequest();
                apiRequest.acqId = Convert.ToInt32(cbNganHang.SelectedValue.ToString());
                apiRequest.accountNo = long.Parse(txtSoTaiKhoan.Text);
                apiRequest.accountName = txtTenTaiKhoan.Text;
                apiRequest.amount = Convert.ToInt32(txtSoTien.Text);
                apiRequest.format = cbTemplate.Text;
                var jsonRequest = JsonConvert.SerializeObject(apiRequest);

                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");
                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    var content = response.Content;
                    var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);

                    var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                    pictureBox1.Image = image;
                }
                else
                {
                    MessageBox.Show("Lỗi khi gửi yêu cầu đến API. Vui lòng thử lại.", "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Không thể kết nối đến API. Vui lòng kiểm tra kết nối Internet và thử lại.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void UserThanhToan_Load(object sender, EventArgs e)
        {
            cbHinhThucThanhToan.Items.Add("Tiền mặt");
            cbHinhThucThanhToan.Items.Add("Chuyển khoản");
            TaoMa();
        }
        public void TaoMa()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                    var bankRawJson = Encoding.UTF8.GetString(htmlData);
                    var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                    cbNganHang.DataSource = listBankData.data;
                    cbNganHang.DisplayMember = "custom_name";
                    cbNganHang.ValueMember = "bin";
                    cbNganHang.SelectedValue = listBankData.data.FirstOrDefault().bin;
                    cbTemplate.SelectedIndex = 0;
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Không thể kết nối để tải danh sách ngân hàng. Vui lòng kiểm tra kết nối Internet và thử lại.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách ngân hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetSoTien(float soTien)
        {
            txtSoTien.Text = soTien.ToString();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                var hoaDon = new HoaDon
                {
                    NgayLap = DateTime.Now,
                    HinhThucThanhToan = cbHinhThucThanhToan.Text,
                    TrangThai = "Đã thanh toán",
                    TongTien = double.Parse(txtSoTien.Text),
                    //IdNhanVien = 
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
