using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;




namespace Lab_Activity
{
    public partial class Form1 : Form
    {
        string gender, hobbie, name, status, con;

        public Form1()
        {
            InitializeComponent();

            string[] country = { "America", "USA ", "Australia ", "Canada ", "Pakistan" };
            foreach (string s in country)
            {
                comboBox1.Items.Add(s);
            }

        }

        private void checkBox_Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void checkBox_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
        private void checkBox_reading_CheckedChanged(object sender, EventArgs e)
        {
            hobbie = "Football";
        }

        private void checkBox_Painting_CheckedChanged(object sender, EventArgs e)
        {
            hobbie = "Driving";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string sqlConnetion = "Data Source = AUMC-LAB3-40\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security = True";
           SqlConnection connection = new SqlConnection(sqlConnetion);
           connection.Open();

           string commandString = " Select * from CustomerTable";
           SqlCommand objCommand = new SqlCommand(commandString, connection);

           DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);

            dataGridView1.DataSource = objDataSet.Tables[0];
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox_Married_CheckedChanged(object sender, EventArgs e)
        {
            status = "Married";
        }

        private void checkBox_Unmarried_CheckedChanged(object sender, EventArgs e)
        {
            status = "Unmarried";
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            con = comboBox1.SelectedItem.ToString();

            Validation v = new Validation();
            v.check_name(name);

            FrmCustomerPriview obj = new FrmCustomerPriview(name, gender, status, hobbie, con);
            obj.ShowDialog();
            
        }

        private void Customer_Name_Click(object sender, EventArgs e)
        {

        }
    }
} 