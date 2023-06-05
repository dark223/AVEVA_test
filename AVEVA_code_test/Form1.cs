using AVEVA_code_test.Models;
using RestSharp;
using UserInterface.UtilityFunctions;

namespace AVEVA_code_test
{
    /// <summary>
    /// The desktop application a user can interact with the WebAPI without having to construct the requests themselves
    /// </summary>
    public partial class Form1 : Form
    {

        RestClient client = new RestClient("https://localhost:7057/Employee/");

        public Form1()
        {
            InitializeComponent();
            ListEmployeesPanel.BringToFront();
        }
        #region Panel position
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEmployeesPanel.BringToFront();   
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeUpdatePanel.BringToFront();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEmployeePanel.BringToFront();
        }

        #endregion

        

        private void SearchDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedItem = SearchDropDown.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "first name":
                case "last name":
                case "email":
                case "id":
                    SearchTextBox.Visible = true;
                    ListSearchDate.Visible = false;
                    ListSearchCheckBox.Visible = false;
                    break;
                case "date of birth":
                    SearchTextBox.Visible = false;
                    ListSearchDate.Visible = true;
                    ListSearchCheckBox.Visible = false;
                    break;

                case "currently employed":
                    SearchTextBox.Visible = false;
                    ListSearchDate.Visible = false;
                    ListSearchCheckBox.Visible = true;
                    break;
                default:
                    SearchTextBox.Visible = true;
                    ListSearchDate.Visible = false;
                    ListSearchCheckBox.Visible = false;
                    break;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string value = "";
            string field = "";
            if (SearchDropDown.SelectedItem != null)
            {
                field = SearchDropDown.SelectedItem.ToString();

                switch (field)
                {
                    case "first name":
                    case "last name":
                    case "email":
                    case "id":
                        value = SearchTextBox.Text;
                        break;
                    case "date of birth":
                        value = ListSearchDate.Value.ToShortDateString();
                        break;

                    case "currently employed":
                        value = ListSearchCheckBox.Checked.ToString();
                        break;
                    default:
                        value = SearchTextBox.Text;
                        break;
                }
            }
            // call api for list over employees
            List<Employee> result = ApiHandler.GetEmployees(field, value, client);
            if (result != null)
            {
                EmployeeDataGridView.DataSource = result;
            }

        }

       


        private void CreateButton_Click(object sender, EventArgs e)
        {
           string firstName= CreateFirstNameTextBox.Text;
           string lastName= CreateLastNameTextBox.Text;
           string email = CreateEmailTextBox.Text;
           DateTime dateOfBirth = CreateDateOfBirthPicker.Value;
           bool currentlyEmployed = CreateCurrentlyEmployedCheckBox.Checked;

          string message = UiVerification.VerifyInputOfEmpolyee(firstName,lastName,email,dateOfBirth);

            if (message =="valid")
            {
                MessageCreateEmployee.ForeColor = Color.Black;
                MessageCreateEmployee.Text = "";
                //call api
                message= ApiHandler.CreateEmployee(firstName, lastName, email, dateOfBirth, currentlyEmployed, client);
                MessageCreateEmployee.Text = message;
            }
            else
            {
                MessageCreateEmployee.ForeColor= Color.Red;
                MessageCreateEmployee.Text = message;
            }

        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
           int id;
           bool success = int.TryParse(UpdateID.Text, out id);
           string firstName = UpdateFirstName.Text;
           string lastName = UpdateLastName.Text;
           string email = UpdateEmail.Text;
           DateTime dateOfBirth = UpdateDateOfBirth.Value;
           bool currentlyEmployed = UpdateCurrentlyEmployed.Checked;
            if (!success)
            {
                UpdateEmployeeMessage.ForeColor = Color.Red;
                UpdateEmployeeMessage.Text = "Id must be a number";
                return;
            }
                string message = UiVerification.VerifyInputOfEmpolyee(firstName, lastName, email, dateOfBirth);

            if (message == "valid")
            {
                UpdateEmployeeMessage.ForeColor = Color.Black;
                UpdateEmployeeMessage.Text = "";
                //call api
                string result = ApiHandler.UpdateEmployee(id,firstName, lastName, email, dateOfBirth, currentlyEmployed, client);
                UpdateEmployeeMessage.Text= result; 
            }
            else
            {
                UpdateEmployeeMessage.ForeColor= Color.Red;
                UpdateEmployeeMessage.Text = message;
            }
        }

    }
}