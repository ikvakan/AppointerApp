using ClassLibrary.DAL;
using ClassLibrary.Model;
using OICAR_Desktop.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICAR_Desktop
{
    public partial class CompanyForm : Form
    {
        private UniteOfWork uow;
        private CompanyLogin _companyLogin;
        private Company _company;
        private Panel _pnlChildForm;
       

        public CompanyForm(CompanyLogin companyLogin,Company company,Panel childForm)
        {
            _companyLogin= companyLogin;
            _company = company;
            _pnlChildForm = childForm;
            InitializeComponent();
            InitRepository();
            LoadPicture();
         

        }

        private void LoadPicture()
        {

            pbCompanyImage.Image = String.IsNullOrEmpty(_company.PicPath) ? pbCompanyImage.ErrorImage:new Bitmap(_company.PicPath);

           
        }

        private void FillForm()
        {
        
            txtName.Text = _company.Name;
            descriptionTextBox.Text = _company.Description;
            cityTextBox.Text = _company.City;
            adressTextBox.Text = _company.Adress;
            contactTextBox.Text = _company.Contact;
            emailTextBox.Text = _company.Email;



        }

    
        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                    var company = GetCompany();

                    uow.Company.Update(company);


                    uow.SaveChanges();



                DialogResult result = HelperMethods.DialogHelper("Tvrtka uspješno ažurirana.", "Update", MessageBoxButtons.OK);

                if (result==DialogResult.OK)
                {

                    Close();
                }

            }
            catch (UpdateException ex)
            {

                MessageBox.Show("Pogreška kod ažuriranja informacija tvrtke." + ex.Message);
            }


        }

        private Company GetCompany()
        {

            Company company = new Company();
            company.IdCompany = _company.IdCompany;
            company.Name = txtName.Text;
            company.Description = String.IsNullOrEmpty(descriptionTextBox.Text) ? "" : descriptionTextBox.Text;
            company.City = cityTextBox.Text;
            company.Adress =adressTextBox.Text;
            company.Contact = contactTextBox.Text;
            company.Email = emailTextBox.Text;
            //company.PicPath = openFileDialog.FileName;
            company.PicPath = _company.PicPath;
            company.CategoryIdCategory = _company.CategoryIdCategory;
            company.CompanyLoginIdCompanyLogin = _companyLogin.IdCompanyLogin;

            return company;
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void CompanyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetupForm setupForm = new SetupForm(_pnlChildForm,_companyLogin);
            OpenFormHelper.OpenChildForm(setupForm, _pnlChildForm);
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
             
            openFileDialog.Filter= "Image Files (*.jpg;*.jpeg;.*.gif;.*png;)|*.jpg;*.jpeg;.*.gif.*.png;";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                _company.PicPath = openFileDialog.FileName;
                pbCompanyImage.Image = new Bitmap(_company.PicPath);
                
            }
        }
    }
}
