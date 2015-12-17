using Business;
using Clinic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppointment.MVP
{
    public partial class frmVisitReasonEdit : Form, IVisitReasonEdit
    {
        private List<VisitReason> visitReasonList;
        private DataTable visitReasonTable = new DataTable();
        private DBconnectionConfig dbconfig = new DBconnectionConfig();
        private VisitReasonDAL visitReasonDAL = new VisitReasonDAL();
        public frmVisitReasonEdit()
        {
            InitializeComponent();
            PopulateVisitReasonInformation();
        }

        private List<VisitReason> LoadVisitReasonInformation()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();

            visitReasonList = visitReasonDAL.getVisitReason(con);
            return visitReasonList;

            dbconfig.CloseConnection();
        }

        private void PopulateVisitReasonInformation()
        {
            DBVisitReason.DataSource = null;
            DataTable visitReasonTable = new DataTable();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            visitReasonTable = visitReasonDAL.getVisitReasonTable(con);
            this.DBVisitReason.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DBVisitReason.DataSource = visitReasonTable;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSaveNew.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            groupBoxInfo.Enabled = true;
            txtReasonID.Enabled = false;
            txtReason.Enabled = true;
            txtCost.Enabled = true;
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            string reason = txtReason.Text.ToString().Trim();
            string strCost = txtCost.Text.ToString().Trim();

            if (reason == "")
            {
                MessageBox.Show("reason can not be empty!");
                return;
            }
            if (strCost == "")
            {
                MessageBox.Show("Cost can not be empty!");
                return;
            }
            try { int cost = Int32.Parse(strCost); }
            catch (Exception ex) {
                MessageBox.Show("Cost value invalid!");
                return;
            }

            VisitReason newVisitReason = new VisitReason();
            newVisitReason.Cost = Int32.Parse(strCost);
            newVisitReason.Reason = reason;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = dbconfig.StringBuilder();
            sql.Open();
            string newID = visitReasonDAL.getNextVisitID(sql);
            
            sql.Close();
            newVisitReason.ReasonID = newID;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            visitReasonDAL.InsertVisitReason(newVisitReason, con);
            con.Close();




            MessageBox.Show("New Visit Reason added");
            PopulateVisitReasonInformation();
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnSaveNew.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            txtReasonID.Enabled = false;
            groupBoxInfo.Enabled = false;
            txtReason.Text = "";
            txtCost.Text = "";
            txtReasonID.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtReasonID.Text.ToString().Trim();
            if (id == "")
            {
                MessageBox.Show("Please select VisitReason to update;");
                return;
            }
            btnSaveNew.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            groupBoxInfo.Enabled = true;
            txtReasonID.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtReasonID.Text.ToString().Trim();
            string reason = txtReason.Text.ToString().Trim();
            string strCost = txtCost.Text.ToString().Trim();

            if (reason == "")
            {
                MessageBox.Show("reason can not be empty!");
                return;
            }
            if (strCost == "")
            {
                MessageBox.Show("Cost can not be empty!");
                return;
            }
            try { int cost = Int32.Parse(strCost); }
            catch (Exception ex)
            {
                MessageBox.Show("Cost value invalid!");
                return;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            visitReasonDAL.UpdateVisitReason(id, reason, strCost, con);
            con.Close();
            MessageBox.Show("Visit Reason information updated!");
            PopulateVisitReasonInformation();
            btnSaveNew.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            groupBoxInfo.Enabled = false;
            txtReasonID.Enabled = false;
            txtReasonID.Text = "";
            btnDelete.Enabled = true;
            txtReason.Text = "";
            txtCost.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            IView view = new frmAdminSettings();
            IModel model = new Model();
            var present = new Presenter(model, view);
            present.ShowAdminHome();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = txtReasonID.Text.ToString().Trim();
            if (ID == "")
            {
                MessageBox.Show("Please select a Reason from table.");
                return;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            visitReasonDAL.DeleteVisitReason(ID, con);
            con.Close();
            MessageBox.Show("Visit Reason Deleted!");
            PopulateVisitReasonInformation();
        }

        private void DBVisitReason_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DBVisitReason.SelectedRows)
            {
                txtReasonID.Text = row.Cells[0].Value.ToString();
                txtReason.Text = row.Cells[1].Value.ToString();
                txtCost.Text = row.Cells[2].Value.ToString();


            }
        }
    }
}
