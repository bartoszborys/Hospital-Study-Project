using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using MedicalClinic.windowFactory;
using BizzLayer.Services.LoginService;

namespace MedicalClinic
{ 
    public partial class Login : Form
    {
        UserLoginService service;
        public Login(UserLoginService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            user loginData = new user();
            loginData.uname = this.loginName.Text;
            loginData.password = this.password.Text;

            try{
                loginData = this.service.updateUserData(loginData);
            }catch (ThereIsNotOnlyOneResult ex){
                MessageBoxDecorator.ErrorBoxLogin("Nieprawidłowy login lub hasło.");
                return;
            }catch (AccountExpiredException ex){
                MessageBoxDecorator.InfoBox("Twoje konto nie jest już ważne.\nSkontaktuj się z administratorem!");
                return;
            }

            IWindowFactory factory = new WindowFactoryImp(this);
            try
            {
                this.Hide();
                factory.GetCorrectWindow(loginData).ShowDialog();
            }catch(UnknowFactoryValueException ex){
                MessageBoxDecorator.ErrorBoxLogin("Nieznany błąd krytyczny.\nSkontaktuj się z administratorem");
                return;
            }catch(Exception ex)
            {
                MessageBoxDecorator.ErrorBox("Something went wrong :< To repair xD ERROR: " + ex.Message );
            }
            finally
            {
                this.Show();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
