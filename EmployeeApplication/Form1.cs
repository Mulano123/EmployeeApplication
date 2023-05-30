using EmployeeNamespaces;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txtbox1.Text))
                {
                    MessageBox.Show("Please input the Employee ID!!");

                    txtbox2.Clear();
                    txtbox3.Clear();
                    txtbox4.Clear();

                }
                else if (string.IsNullOrEmpty(txtbox2.Text))
                {
                    MessageBox.Show("Please input the Employee First Name!!");


                    txtbox1.Clear();
                    txtbox3.Clear();
                    txtbox4.Clear();
                }
                else if (string.IsNullOrEmpty(txtbox3.Text))
                {
                    MessageBox.Show("Please input the Employee Last Name!!");

                    txtbox1.Clear();
                    txtbox2.Clear();
                    txtbox4.Clear();

                }
                else if (string.IsNullOrEmpty(txtbox4.Text))
                {
                    MessageBox.Show("Please input the Employee Position!!");

                    txtbox1.Clear();
                    txtbox2.Clear();
                    txtbox3.Clear();
                }
                else
                {
                    int newID = Convert.ToInt32(txtbox1.Text);
                    string firstname = txtbox2.Text;
                    string lastname = txtbox3.Text;
                    string positon = txtbox4.Text;


                    Employee employee = new Employee(newID, firstname, lastname, positon);


                    //int addRow = dataGW.Rows.Add();

                    //dataGW.Rows[addRow].Cells[0].Value = employee.EmpID.ToString();
                    //dataGW.Rows[addRow].Cells[1].Value = employee.EmployeeFirstName;
                    //dataGW.Rows[addRow].Cells[2].Value = employee.EmployeeLastName;
                    //dataGW.Rows[addRow].Cells[3].Value = employee.Position;

                    dataGW.Rows.Add(newID,firstname, lastname, positon);

                    txtbox1.Clear();
                    txtbox2.Clear();
                    txtbox3.Clear();
                    txtbox4.Clear();

                }
            }
            catch (Exception)
            {

            }
        }
    }
}