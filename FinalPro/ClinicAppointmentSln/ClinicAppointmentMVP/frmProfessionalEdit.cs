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
    public partial class frmProfessionalEdit : Form, IProfessionalEdit
    {
        private List<Professional> professionalList;
        private DataTable professionalTable = new DataTable();
        private DBconnectionConfig dbconfig = new DBconnectionConfig();
        private ProfessionalDAL professionalDAL = new ProfessionalDAL();
        public frmProfessionalEdit()
        {
            InitializeComponent();
            PopulateProfessionalInformation();
        }
        private List<Professional> LoadProfessionalInformation()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();

            professionalList = professionalDAL.getProfessionalList(con);
            return professionalList;

            dbconfig.CloseConnection();
        }

        private void PopulateProfessionalInformation()
        {
            DBProfession.DataSource = null;
            DataTable professionalTable = new DataTable();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            professionalTable = professionalDAL.getProfessionalTable(con);
            this.DBProfession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DBProfession.DataSource = professionalTable;
            con.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtProID.Text.ToString().Trim();
            if (id == "") {
                MessageBox.Show("Please select a health professional to update;");
                return;
            }
            btnSaveNew.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            groupBoxInfo.Enabled = true;
            txtProID.Enabled = false;
            txtDOB.Visible = false;
            dateTimePicker1.Visible = true;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string firstname = txtproFirstName.Text.ToString().Trim();
            string lastname = txtproLastName.Text.ToString().Trim();
            string id = txtProID.Text.ToString().Trim();
            string profession;
            string dob = this.dateTimePicker1.Value.ToString("yyyyMMdd");
            DateTime dt = DateTime.ParseExact(dob, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            
            if (DateTime.Compare(dt, DateTime.Today) > 0)
            {
                MessageBox.Show("Date of birth can not be later than today");
                return;
            }
            if (firstname == "")
            {
                MessageBox.Show("First Name can not be empty!");
                return;
            }
            if (lastname == "")
            {
                MessageBox.Show("Last Name can not be empty!");
                return;
            }
            if (rbtDoctor.Checked == true)
            {
                profession = Professional.Profession.Doctor.ToString().Trim();
            }
            else
            {
                profession = Professional.Profession.Nurse.ToString().Trim();
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            professionalDAL.UpdateProfessional(id, profession, firstname, lastname, dt, con);
            con.Close();
            MessageBox.Show("Profesional information updated!");
            PopulateProfessionalInformation();
            btnSaveNew.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            groupBoxInfo.Enabled = false;
            txtProID.Enabled = false;
            btnDelete.Enabled = true;
            txtDOB.Text = "";
            txtproFirstName.Text = "";
            txtproLastName.Text = "";
            txtProID.Text = "";
            txtDOB.Visible = true;
            dateTimePicker1.Visible = false;

        }

        private void DBProfession_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DBProfession.SelectedRows)
            {
                txtProID.Text = row.Cells[3].Value.ToString();
                txtproFirstName.Text = row.Cells[0].Value.ToString();
                txtproLastName.Text = row.Cells[1].Value.ToString();
                txtDOB.Text = row.Cells[2].Value.ToString().Trim();

                string Type = row.Cells[4].Value.ToString().Trim();
                if (rbtDoctor.Text.Trim() == Type)
                {
                    rbtDoctor.Checked = true;
                }
                else if (rbtNurse.Text.Trim() == Type)
                {
                    rbtNurse.Checked = true;
                }

            }
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
            string proID = txtProID.Text.ToString().Trim();
            if (proID == "") {
                MessageBox.Show("Please select a Health professonal from table.");
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            professionalDAL.DeleteProfessional(proID, con);
            con.Close();
            MessageBox.Show("Profesional disactived updated!");
            PopulateProfessionalInformation();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string firstname = txtproFirstName.Text.ToString().Trim();
            string lastname = txtproLastName.Text.ToString().Trim();
            string id = txtProID.Text.ToString().Trim();
            string profession;
            string dob = this.dateTimePicker1.Value.ToString("yyyyMMdd");
            DateTime dt = DateTime.ParseExact(dob, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);

            if (DateTime.Compare(dt, DateTime.Today) > 0)
            {
                MessageBox.Show("Date of birth can not be later than today");
                return;
            }
            if (firstname == "")
            {
                MessageBox.Show("First Name can not be empty!");
                return;
            }
            if (lastname == "")
            {
                MessageBox.Show("Last Name can not be empty!");
                return;
            }
            if (rbtDoctor.Checked == true)
            {
                profession = Professional.Profession.Doctor.ToString().Trim();
            }
            else
            {
                profession = Professional.Profession.Nurse.ToString().Trim();
            }

            Professional newProfessional = new Professional();
            newProfessional.FirstName = firstname;
            newProfessional.LastName = lastname;
            newProfessional.profession = profession;
            newProfessional.DOB = dt;
            newProfessional.active = "Active";
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = dbconfig.StringBuilder();
            sql.Open();
            string proID = professionalDAL.getNextProfessionID(profession, sql);
            
            sql.Close();
            newProfessional.ProfessionalID = proID;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = dbconfig.StringBuilder();
            con.Open();
            professionalDAL.InsertProfessional(newProfessional, con);
            con.Close();




            MessageBox.Show("Profesional information added");
            PopulateProfessionalInformation();
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnSaveNew.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            txtProID.Enabled = false;
            groupBoxInfo.Enabled = false;
            txtDOB.Text = "";
            txtproFirstName.Text = "";
            txtproLastName.Text = "";
            txtProID.Text = "";
            txtDOB.Visible = true;
            dateTimePicker1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSaveNew.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            groupBoxInfo.Enabled = true;
            txtProID.Enabled = false;
            txtDOB.Visible = false;
            dateTimePicker1.Visible = true;
        }
    }
}
