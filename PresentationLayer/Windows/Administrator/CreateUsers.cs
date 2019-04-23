using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer.Services.AdministratorService;
using DataLayer;
using BizzLayer.Services.Registration.Exceptions;

namespace MedicalClinic
{
    public partial class CreateUsers : Form
    {
        private AdministratorService service;
        private user userData;
        public CreateUsers(AdministratorService service, user person)
        {
            this.service = service;
            this.userData = person;
            InitializeComponent();
        }

        private void CreateUsers_Load(object sender, EventArgs e)
        {
            this.drawUserType();
        }
        private void drawUserType()
        {
            foreach (string role in this.service.getRoles())
            {
                this.boxUserType.Items.Add(role);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.txtLastName.Text = "";
            this.txtLogin.Text = "";
            this.txtName.Text = "";
            this.txtPassword.Text = "";
            this.expirationDate.Value = DateTime.Now;

            this.boxUserType.Items.Clear();
            this.drawUserType();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            user userData = this.getUserData();

            switch ( this.boxUserType.SelectedItem )
            {
                case "REG":
                    userData.registration = this.getRegData();
                    break;

                case "DOC":
                    userData.doctor = this.getDocData();
                    break;

                case "LAB":
                    userData.lab = this.getLabData();
                    break;

                case "MAN":
                    userData.lab_manager = this.getManData();
                    break;

                case "ADM":
                    userData.personel_id = -1;
                    break;
            }

            try
            {
                this.service.addUserToDatabase(userData);
                MessageBoxDecorator.SuccessBox("Użytkownik został dodany pomyślnie!");
            }
            catch(DatabaseSubmitErrorException)
            {
                MessageBoxDecorator.ErrorBox("Wystąpił błąd podczas komunikacji z bazą!\n Proszę spróbować ponownie.\n\nJeżeli problem się powtórzy proszę niezwłocznie skontatktować się z administratorem");
            }
            finally
            {
                this.btnClean_Click(sender, e);
            }
        }

        private registration getRegData()
        {
            registration regData = new registration();
            regData.last_name = this.txtLastName.Text;
            regData.name = this.txtName.Text;
            return regData;
        }

        private doctor getDocData()
        {
            doctor regData = new doctor();
            regData.last_name = this.txtLastName.Text;
            regData.name = this.txtName.Text;
            return regData;
        }

        private lab getLabData()
        {
            lab regData = new lab();
            regData.last_name = this.txtLastName.Text;
            regData.name = this.txtName.Text;
            return regData;
        }

        private lab_manager getManData()
        {
            lab_manager regData = new lab_manager();
            regData.last_name = this.txtLastName.Text;
            regData.name = this.txtName.Text;
            return regData;
        }

        private user getUserData()
        {
            user userData = new user();
            userData.uname = this.txtLogin.Text;
            userData.password = this.txtPassword.Text;
            userData.role = (string)this.boxUserType.SelectedItem;
            userData.expiration_date = this.expirationDate.Value.Date;
            return userData;
        }
    }
}
