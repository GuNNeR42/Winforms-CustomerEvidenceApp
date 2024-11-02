using CustomerEvidenceApp.Entities;

namespace CustomerEvidenceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Gender comboxu dát hodnoty
            List<KeyValuePair<string, string>> genders = new List<KeyValuePair<string, string>>();

            var maleGender = new KeyValuePair<string, string>("Muž", "male");
            var femaleGender = new KeyValuePair<string, string>("Žena", "female");

            genders.Add(maleGender);
            genders.Add(femaleGender);
            /*
            KeyValuePair<string, string> male2Gender = new("Muž", "male");
            KeyValuePair<string, string> male3Gender = new KeyValuePair<string, string>("Muž", "male");
            */

            comboBox_Gender.DataSource = genders;
            comboBox_Gender.DisplayMember = "Key";
            comboBox_Gender.ValueMember = "Value";

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FullName = textBox_FullName.Text;
            customer.Birthday = dateTimePicker_Birthday.Value;
            customer.IQ = Convert.ToInt32(numericUpDown_IQ.Value);

            if(comboBox_Gender.SelectedValue is not null)
            {
                customer.Gender = comboBox_Gender.SelectedValue.ToString()!;
            }

            customer.GdprAgreement = checkBox_GdprAgreement.Checked;
        }

    }
}
