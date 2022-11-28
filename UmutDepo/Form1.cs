using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UmutDepo.Core.Entities;
using UmutDepo.Interfaces;
using UmutDepo.Repos;

namespace UmutDepo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Repos.DataGrid dg = new Repos.DataGrid();

            GrsDatagrd.DataSource = await dg.GetData("Girisler");
            GrsDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void GrsUrunadiTxt_TextChanged(object sender, EventArgs e)
        {

            if (GrsUrunadiTxt.Text.Trim() != "")
            {
                try
                {
                    var dataTable = (DataTable)GrsDatagrd.DataSource;
                    var dataView = dataTable.DefaultView;
                    dataView.RowFilter = string.Format("UrunAdi like '{0}%'", GrsUrunadiTxt.Text);

                }
                catch
                {

                }

            }
            else
            {
                Repos.DataGrid dg = new Repos.DataGrid();

                GrsDatagrd.DataSource = await dg.GetData("Girisler");

                GrsDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                GrsUrunadiTxt.Text = "";
                GrsCombo.Text = "";
                GrsTarihtxt.Text = "";
                GrsMiktartxt.Text = "";

            }
        }

        private void GrsDatagrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrsDatagrd.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = GrsDatagrd.Rows[e.RowIndex];
                    GrsCombo.Text = row.Cells[3].Value.ToString();
                    GrsUrunadiTxt.Text = row.Cells[2].Value.ToString();
                }
                catch { }


            }
        }

        private void GrsKaydetBtn_Click(object sender, EventArgs e)
        {
            CrudClass crud = new CrudClass();
            int id = crud.StoktaVarmi(GrsUrunadiTxt.Text, GrsCombo.Text, Convert.ToDouble(GrsMiktartxt.Text), GrsTarihtxt.Text);
            crud.GrsKaydet(id, GrsUrunadiTxt.Text, GrsCombo.Text, GrsTarihtxt.Text, Convert.ToDouble(GrsMiktartxt.Text));
            GrsIptalbtn_Click(sender, e);
           


        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Repos.DataGrid dg = new Repos.DataGrid();

                GrsDatagrd.DataSource = await dg.GetData("Girisler");
                GrsDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Repos.DataGrid dg = new Repos.DataGrid();

                CksDatagrd.DataSource = await dg.GetData("Stocks");
                CksDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridStyles(CksDatagrd, 3);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                Repos.DataGrid dg = new Repos.DataGrid();

                rprDatagrd.DataSource = await dg.GetData("Stocks");
                rprDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridStyles(rprDatagrd, 3);
            }
        }

        private void CksKaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Rapors rp = new Rapors();
                CrudClass crud = new CrudClass();
                int id = crud.StoktaVarmiCıkıs(CksUrunaditxt.Text, CksCombo.Text, Convert.ToDouble(CksMiktartxt.Text), CksTarihtxt.Text);
                if (id == 0)
                {
                    MessageBox.Show("Stokta olmayan ürünü silimezsiniz", "Umut Bey");
                    return;
                }
                crud.CksKaydet(id, CksUrunaditxt.Text, CksCombo.Text, CksTarihtxt.Text, Convert.ToDouble(CksMiktartxt.Text), Cksteslimalantxt.Text);
                rp.teslimAlmaRaporu(id, CksUrunaditxt.Text, CksCombo.Text, CksTarihtxt.Text, Convert.ToDouble(CksMiktartxt.Text), Cksteslimalantxt.Text);
                CksIptalbtn_Click(sender, e);
                DataGridStyles(CksDatagrd, 3);
            }
            catch(Exception ex) { string a =ex.Message; }

        }

        private void CksDatagrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CksDatagrd.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = CksDatagrd.Rows[e.RowIndex];
                    CksCombo.Text = row.Cells[2].Value.ToString();
                    CksUrunaditxt.Text = row.Cells[1].Value.ToString();
                }
                catch { }


            }
        }

        private async void GetStockbtn_Click(object sender, EventArgs e)
        {
            Rapors rp = new Rapors();
            Repos.DataGrid dg = new Repos.DataGrid();

            string answer = rp.DataToExcel(await dg.GetData("Stocks"), "Stok");
        }

        private async void Getgrsbtn_Click(object sender, EventArgs e)
        { 

         Rapors rp = new Rapors();
        Repos.DataGrid dg = new Repos.DataGrid();

        string answer = rp.DataToExcel(await dg.GetData("Girisler"), "Girisler");

    }

        private async void Getcksbtn_Click(object sender, EventArgs e)
        {
            Rapors rp = new Rapors();
            Repos.DataGrid dg = new Repos.DataGrid();

            string answer = rp.DataToExcel(await dg.GetData("Cikislar"), "cikislar");
        }

        private async void RprCleanbtn_Click(object sender, EventArgs e)
        {
            Repos.DataGrid dg = new Repos.DataGrid();

            rprDatagrd.DataSource = await dg.GetData("Stocks");
            rprDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GrsIptalbtn_Click(object sender, EventArgs e)
        {
            Repos.DataGrid dg = new Repos.DataGrid();

            GrsDatagrd.DataSource = dg.GetData("Girisler");

            GrsDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrsUrunadiTxt.Text = "";
            GrsCombo.Text = "";
            GrsTarihtxt.Text = "";
            GrsMiktartxt.Text = "";
        }

        private void CksIptalbtn_Click(object sender, EventArgs e)
        {
            CksUrunaditxt.Text = "";
            CksCombo.Text = "";
            CksTarihtxt.Text = "";
            CksMiktartxt.Text = "";
            Cksteslimalantxt.Text = "";
            //Repos.DataGrid dg = new Repos.DataGrid();

            //CksDatagrd.DataSource = dg.GetData("Girisler");

            //CksDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private async void CksUrunaditxt_TextChanged(object sender, EventArgs e)
        {
            if (CksUrunaditxt.Text.Trim() != "")
            {
                try
                {
                    var dataTable = (DataTable)CksDatagrd.DataSource;
                    var dataView = dataTable.DefaultView;
                    dataView.RowFilter = string.Format("UrunAdi like '{0}%'", CksUrunaditxt.Text);

                }
                catch
                {

                }

            }
            else
            {
                Repos.DataGrid dg = new Repos.DataGrid();

                CksDatagrd.DataSource =await dg.GetData("Stocks");

                CksDatagrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                GrsUrunadiTxt.Text = "";
                GrsCombo.Text = "";
                GrsTarihtxt.Text = "";
                GrsMiktartxt.Text = "";

            }
        }
        public async void DataGridStyles(DataGridView dw,int index)
        {
             foreach (DataGridViewRow row in dw.Rows)
            {

                if (Convert.ToInt32(row.Cells[index].Value) < 1)
                    row.DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
