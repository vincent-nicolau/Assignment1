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
            firstName = txtFirstName.Text.Trim();
            lastName = txtLastName.Text.Trim();
            
            try
            {
                hoursWorked = float.Parse(txtHoursWorked.Text);
                totalPay = hoursWorked * PAY_RATE;
            } 
            catch (FormatException)
            {
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = ("Enter a valid number for Hours Worked.");
                return;
            }
            lblOutput.ForeColor = Color.Black;
            lblOutput.Text = ($"{firstName} {lastName} worked {hoursWorked} hours at a rate of ${PAY_RATE}/hour and made ${totalPay}.");
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
