using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QLBSach
{
    public partial class FormTimKiem : Form
    {
        DBAcess dbacess = new DBAcess();
        // DataTable dt = new DataTable();
        public static Boolean tg;
        public static Boolean tl;
        public static Boolean nxb;
        public FormTimKiem()
        {
            InitializeComponent();
        }

    
        private void Btntimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            string thongtin = texttimkiem.Text;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            string patternFi = @"\d";
            Regex myRegex = new Regex(patternFi);

            if (texttimkiem.Text == "")
            {
                MessageBox.Show("Ban chua nhap thon tin !");
            }
            if (rbnamxuatban.Checked == false && rbtacgia.Checked == false && rbtheloai.Checked == false)
            {
                MessageBox.Show("Ban chua chon thong tin !!");
            }

            if (rbtacgia.Checked == true)
            {
                //tg = true;
                string query = "select TenS, TenTL, TenTG, Nhaxuatban.MaNXB ,GiaBan from SACH, THELOAI,TACGIA,NHAXUATBAN where sach.MaTG = TACGIA.MaTG and sach.MaTL = THELOAI.MaTL and SACH.MaNXB = NHAXUATBAN.MaNXB" +
                              " and tacgia.tentg = '" + thongtin + "'";


                dt = dbacess.readDatathroughAdapter(query);
                dataGridView1.DataSource = dt;
            }
            if (rbtheloai.Checked == true)
            {
                //tg = true;
                string query1 = "select TenS, TenTL, TenTG, Nhaxuatban.MaNXB ,GiaBan from SACH, THELOAI,TACGIA,NHAXUATBAN where sach.MaTG = TACGIA.MaTG and sach.MaTL = THELOAI.MaTL and SACH.MaNXB = NHAXUATBAN.MaNXB" +
                              " and theloai.tentl = '" + thongtin + "'";


                dt1 = dbacess.readDatathroughAdapter(query1);
                dataGridView1.DataSource = dt1;
            }
            if (rbnamxuatban.Checked == true)
            {
                //tg = true;
                if (myRegex.IsMatch(thongtin) == false)
                {
                    MessageBox.Show("BAN CHI DC NHAP SO");
                    texttimkiem.Text = "";
                }
                if (myRegex.IsMatch(thongtin) == true)
                {

                    string query2 = "select TenS, TenTL, TenTG, Nhaxuatban.MaNXB, NamXB ,GiaBan from sanpham, SACH, THELOAI,TACGIA,NHAXUATBAN where sach.MaTG = TACGIA.MaTG and sach.MaTL = THELOAI.MaTL and SACH.MaNXB = NHAXUATBAN.MaNXB and sanpham.mas=sach.mas" +
                              " and sanpham.namXB = '" + float.Parse(thongtin) + "'";


                    dt2 = dbacess.readDatathroughAdapter(query2);
                    dataGridView1.DataSource = dt2;
                }

            }
        }

       

        private void Rbtacgia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtacgia.Checked)
            {
                tg = true;
                texttimkiem.Text = "";
                btntimkiem.Text = "Tim kiem sach theo ten tac gia";
            }
        }

        private void Rbtheloai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtheloai.Checked)
            {
                tl = true;
                texttimkiem.Text = "";
                btntimkiem.Text = "Tim kiem sach theo ten the loai";
            }
        }

        private void Rbnamxuatban_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnamxuatban.Checked)
            {
                nxb = true;
                texttimkiem.Text = "";
                btntimkiem.Text = "Tim kiem sach theo nam xuat ban";
            }
        }
    }
}
