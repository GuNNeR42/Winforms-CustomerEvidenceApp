using CustomerEvidenceApp.Data.Models;

namespace CustomerEvidenceApp
{
    public partial class AddCustomerForm : Form
    {
        private Customer _customer;
        public AddCustomerForm(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            //Gender comboxu d�t hodnoty
            List<KeyValuePair<string, string>> genders = new List<KeyValuePair<string, string>>();

            var maleGender = new KeyValuePair<string, string>("Mu�", "male");
            var femaleGender = new KeyValuePair<string, string>("�ena", "female");

            genders.Add(maleGender);
            genders.Add(femaleGender);
            /*
            KeyValuePair<string, string> male2Gender = new("Mu�", "male");
            KeyValuePair<string, string> male3Gender = new KeyValuePair<string, string>("Mu�", "male");
            */

            comboBox_Gender.DataSource = genders;
            comboBox_Gender.DisplayMember = "Key";
            comboBox_Gender.ValueMember = "Value";

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            _customer.FullName = textBox_FullName.Text;
            _customer.Birthday = dateTimePicker_Birthday.Value;
            _customer.IQ = Convert.ToInt32(numericUpDown_IQ.Value);

            if(comboBox_Gender.SelectedValue is not null)
            {
                _customer.Gender = comboBox_Gender.SelectedValue.ToString()!;
            }

            _customer.GdprAgreement = checkBox_GdprAgreement.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
