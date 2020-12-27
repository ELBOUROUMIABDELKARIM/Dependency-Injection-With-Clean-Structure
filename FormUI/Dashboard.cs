using ClassLibrary;
using ClassLibrary.Validators;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        IBusinessLogic _businessLogic;
        List<Person> people = new List<Person>();
        public Dashboard(IBusinessLogic businessLogic)
        {
            InitializeComponent();
            _businessLogic = businessLogic;
            updatebinding();
        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            people = _businessLogic.GetPeopleByLastName(LastNameText.Text);
            updatebinding();
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            people = _businessLogic.GetAllPeople();
            updatebinding();
        }
        public void updatebinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void personPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        [Obsolete]
        private void addPerson_Click(object sender, EventArgs e)
        {
            errorListBox.DataSource = null;
            Person person = new Person();
            person.FirstName = personFnameText.Text;
            person.LastName = personLnameText.Text;
            person.EmailAddress = personEmailText.Text;
            person.PhoneNumber = personPhone.Text;
            //
            (bool IsAdded, List<string> errorList) = _businessLogic.AddPerson(person);
            if (IsAdded)
            {
                errorListBox.Visible = false;
                MessageBox.Show("Added Successfly");
                return;
            }
            errorListBox.Visible = true;
            errorListBox.DataSource = errorList;
            personFnameText.Clear();
            personLnameText.Clear();
            personEmailText.Clear();
            personPhone.Clear();
            //
        }
    }
}
