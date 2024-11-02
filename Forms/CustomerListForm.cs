using CustomerEvidenceApp.Data;
using CustomerEvidenceApp.Data.Models;
using System.ComponentModel;

namespace CustomerEvidenceApp.Forms
{
    public partial class CustomerListForm : Form
    {
        private readonly SQLiteDbContext _context;
        private BindingList<Customer> _customers;

        public CustomerListForm(SQLiteDbContext context)
        {
            InitializeComponent();
            _context = context;

            _customers = new BindingList<Customer>(_context.Customers.ToList());
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            // Load Customers from databse and convert it to binding list
            
            dataGridViewCustomers.DataSource = _customers;
        }

        private void button_addCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            AddCustomerForm addCustomerForm = new AddCustomerForm(customer);

            if (DialogResult.OK == addCustomerForm.ShowDialog())
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();

                _customers.Add(customer);
            }
        }
    }
}
