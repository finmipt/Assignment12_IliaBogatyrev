namespace Assignment12_IliaBogatyrev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Employee
        {
            // Properties for the employee name and employee number
            public string Name { get; set; }
            public int EmployeeNumber { get; set; }
        }
        class ProductionWorker : Employee
        {
            // Properties for the shift number and hourly pay rate
            public int ShiftNumber { get; set; }
            public double HourlyPayRate { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Create an object of the ProductionWorker class
            ProductionWorker worker = new ProductionWorker();

            // Set the values of the object's properties using the input fields
            worker.Name = textBoxName.Text;
            worker.EmployeeNumber = Convert.ToInt32(textBoxEmployeeNumber.Text);
            worker.ShiftNumber = Convert.ToInt32(textBoxShiftNumber.Text);
            worker.HourlyPayRate = Convert.ToDouble(textBoxHourlyPayRate.Text);

            // Display the values of the object's properties
            labelOutput.Text = "Name: " + worker.Name + "\n" +
                               "Employee Number: " + worker.EmployeeNumber + "\n" +
                               "Shift Number: " + worker.ShiftNumber + "\n" +
                               "Hourly Pay Rate: " + worker.HourlyPayRate;

        }
    }
}