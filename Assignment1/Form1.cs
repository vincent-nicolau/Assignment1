namespace Assignment1
{
    public partial class Assignment1 : Form
    {
        string firstName = "";
        string lastName = "";
        float hoursWorked = 0;
        const float PAY_RATE = 10.50f;
        float totalPay = 0;

        public Assignment1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            
            try
            {
                hoursWorked = float.Parse(txtHoursWorked.Text);
                totalPay = hoursWorked * PAY_RATE;
            } 
            catch (FormatException)
            {
                MessageBox.Show("enter a float value");
                return;
            }
            lblOutput.Text = ($"{firstName} {lastName} worked {hoursWorked} hours at a rate of {PAY_RATE} and made {totalPay}.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtHoursWorked.Text = "";
            lblOutput.Text = "";
        }
    }
}
