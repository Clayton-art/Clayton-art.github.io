using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;

namespace MyApp
{
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
        }

       
         
        private void clear()
        {
            studIdTxt.Text = " ";
            nameTxt.Text = " ";
            emailTxt.Text = " ";
            progTxt.Text = " ";
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;

            if (studIdTxt.Text !="" & nameTxt.Text !="" & emailTxt.Text !="" & progTxt.Text !="")
            {
                try
                {
                    string countQuery = "select count(*) from student where sId =  '" + studIdTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Student already Exists");
                        db.closeConnection();
                    }
                    else
                    {
                        string query = "insert into  student values( '" + studIdTxt.Text + "', '" + nameTxt.Text + "', '" + progTxt.Text + "' )";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Student added succesfully");
                        db.closeConnection();
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Complete every field");
            }
          
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;

            if (studIdTxt.Text != "" )
            {
                try
                {
                    string countQuery = "select count(*) from student where sId =  '" + studIdTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "delete from student where sId = '" + studIdTxt.Text+"' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Student added succesfully");
                        db.closeConnection();
                        clear();
                    }
                    else
                    {

                        MessageBox.Show("Student doesn't Exists");
                        db.closeConnection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Enter student ID");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clear();
        
        }
    }
}
