using HackerWe.Entities;
using HackerWe.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerWe.UI
{
    public partial class ClientsUserControl : UserControl
    {
        public event Action<Client> ClientSaved;
        public ClientsUserControl()
        {
            InitializeComponent();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            Client client;
            bool isValidClient = true;
            if (txtIdentityNumber.Text == String.Empty)
            {
                lblIdentityNumberValidation.Visible = true;
                isValidClient = false;
            }
            else lblIdentityNumberValidation.Visible = false;
            Regex nameRegex = new Regex(@"\D{2,}");
            if (!nameRegex.IsMatch(txtFirstName.Text))
            {
                lblFirstNameValidation.Visible = true;
                isValidClient = false;
            }
            else lblFirstNameValidation.Visible = false;
            if (!nameRegex.IsMatch(txtLastName.Text))
            {
                lblLastNameValidation.Visible = true;
                isValidClient = false;
            }
            else lblLastNameValidation.Visible = false;
            Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (!emailRegex.IsMatch(txtEmail.Text))
            {
                lblEmailValidation.Visible = true;
                isValidClient = false;
            }
            else lblEmailValidation.Visible = false;
            Regex phoneRegex = new Regex(@"[0]{1}[0-9]{8,9}");
            if (!phoneRegex.IsMatch(txtPhoneNumber.Text))
            {
                lblPhoneNumberValidation.Visible = true;
                isValidClient = false;
            }
            else lblPhoneNumberValidation.Visible = false;

            if (isValidClient)
            {
                client = new Client();
                client.Id = Library.Clients.Count + 1;
                client.IdentityNumber = txtIdentityNumber.Text;
                client.FirstName = txtFirstName.Text;
                client.LastName = txtLastName.Text;
                client.Email = txtEmail.Text;
                client.PhoneNumber = txtPhoneNumber.Text;
                Library.Clients.Add(client);
                Library.SaveClients();
                ClientSaved(client);
            }
            else return;

        }
    }
}
