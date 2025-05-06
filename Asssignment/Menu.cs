using AssDbmslib;
//using Assapplib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment
{
    public partial class Menu : Form
    {
        public Form1 _f;
        public Sql1 sql;

        public Menu(Form1 f)
        {
            InitializeComponent();
            _f = f;
            sql = new Sql1();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            comboBoxsta_dept.Items.Add("Computer Science");
            comboBoxsta_dept.Items.Add("Psychology");
            comboBoxsta_dept.Items.Add("Science");
            comboBoxsta_dept.Items.Add("Commerce");
            comboBoxsta_dept.Items.Add("Arts");


            comboBoxt_dept.Items.Add("Computer Science");
            comboBoxt_dept.Items.Add("Psychology");
            comboBoxt_dept.Items.Add("Science");
            comboBoxt_dept.Items.Add("Commerce");
            comboBoxt_dept.Items.Add("Arts");


            comboBoxt_qual.Items.Add("Graduation");
            comboBoxt_qual.Items.Add("Post Graduation");
            comboBoxt_qual.Items.Add("Masters");
            comboBoxt_qual.Items.Add("Phd");


            comboBoxstu_course.Items.Add("BCA");
            comboBoxstu_course.Items.Add("BBA");
            comboBoxstu_course.Items.Add("BA");
            comboBoxstu_course.Items.Add("BJAMC");
            comboBoxstu_course.Items.Add("BSc");
            comboBoxstu_course.Items.Add("BCom");
            comboBoxstu_course.Items.Add("BCom hons");
            comboBoxstu_course.Items.Add("BVoc");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        public bool IsValidEmail(string email)
        {
            // Regular expression for validating email format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }
        public bool IsValidContact(string contact)
        {
            // Regular expression for validating contact numbers (allows only 10 digits)
            string contactPattern = @"^\d{10}$";

            return System.Text.RegularExpressions.Regex.IsMatch(contact, contactPattern);
        }

        private void stu_save_Click(object sender, EventArgs e)
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(stu_name.Text))
            {
                MessageBox.Show("Student name cannot be empty.");
                return;
            }

            // Validate Father's Name
            if (string.IsNullOrWhiteSpace(stu_father.Text))
            {
                MessageBox.Show("Father's name cannot be empty.");
                return;
            }

            // Validate Mother's Name
            if (string.IsNullOrWhiteSpace(stu_mother.Text))
            {
                MessageBox.Show("Mother's name cannot be empty.");
                return;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(stu_email.Text) || !IsValidEmail(stu_email.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Validate Contact
            if (string.IsNullOrWhiteSpace(stu_contact.Text) || !IsValidContact(stu_contact.Text))
            {
                MessageBox.Show("Please enter a valid 10-digit contact number.");
                return;
            }

            // Validate Course Selection
            if (comboBoxstu_course.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            // Validate Gender Selection
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            // Validate Year
            if (numericUpDownstu_year.Value <= 0)
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            // Validate Age
            if (numericUpDownstu_age.Value <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            // If all validations pass, insert the student data
            Student student = new Student
            {
                Name = stu_name.Text,
                FatherName = stu_father.Text,
                MotherName = stu_mother.Text,
                Email = stu_email.Text,
                Contact = stu_contact.Text,
                Course = comboBoxstu_course.Text,
                Gender = radioButton1.Checked ? "Male" : "Female",  // Assuming radioButton1 is Male and radioButton2 is Female
                Year = ((int)numericUpDownstu_year.Value).ToString(),
                Age = ((int)numericUpDownstu_age.Value).ToString()
            };

            int insertedId = sql.Insert(student);
            if (insertedId > 0)
            {
                MessageBox.Show("Student saved successfully. ID: " + insertedId);
            }
            else
            {
                MessageBox.Show("Error occurred while saving the student.");
            }

        }

        private void stu_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void stu_father_TextChanged(object sender, EventArgs e)
        {

        }

        private void stu_mother_TextChanged(object sender, EventArgs e)
        {

        }

        private void stu_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void stu_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownstu_year_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownstu_age_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxstu_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void t_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_sal_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownt_age_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownt_experience_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxt_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxt_qual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void t_save_Click(object sender, EventArgs e, Teacher teacher)
        {
            // Validate name, salary, address, email, contact, age, experience, dept, qualification
            if (string.IsNullOrWhiteSpace(t_name.Text) ||
                string.IsNullOrWhiteSpace(t_sal.Text) ||
                string.IsNullOrWhiteSpace(t_address.Text) ||
                string.IsNullOrWhiteSpace(t_email.Text) ||
                string.IsNullOrWhiteSpace(t_contact.Text) ||
                numericUpDownt_age.Value <= 0 ||
                numericUpDownt_experience.Value < 0 ||
                string.IsNullOrWhiteSpace(comboBoxt_dept.Text) ||
                string.IsNullOrWhiteSpace(comboBoxt_qual.Text))
            {
                MessageBox.Show("Please fill in all the fields correctly.");
                return;
            }

            // Check if an email and contact are valid
            if (!IsValidEmail(t_email.Text))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (!IsValidContact(t_contact.Text))
            {
                MessageBox.Show("Invalid contact number. Must be 10 digits.");
                return;
            }

            
            if(!(radioButton4.Checked || radioButton3.Checked))
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            
            if(!(radioButton7.Checked || radioButton8.Checked))
            {
                MessageBox.Show("Please select employment status.");
                return;
            }

            // Create a new Teacher object
            Teacher teacher = new Teacher()
            {
                Name = t_name.Text,
                Department = comboBoxt_dept.Text,
                Address = t_address.Text,
                Gender = radioButton4.Checked ? "Male" : "Female",
                Contact = t_contact.Text,
                Salary = t_sal.Text,
                Email = t_email.Text,
                EmploymentStatus = radioButton7.Checked ? "Employed" : "Unemployed",
                Qualification = comboBoxt_qual.Text,
                Experience = ((int)numericUpDownt_experience.Value).ToString(),
                Age = ((int)numericUpDownt_age.Value).ToString()
            };
            int isInserted = sql.Insert(teacher);

            if (isInserted > 0)
            {
                MessageBox.Show("Teacher saved successfully. Id =" + isInserted);
            }
            else
            {
                MessageBox.Show("Error occurred while saving the teacher.");
            }
        }

        private void sta_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void sta_sal_TextChanged(object sender, EventArgs e)
        {

        }

        private void sta_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void sta_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void sta_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownsta_age_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownsta_experience_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxsta_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sta_save_Click(object sender, EventArgs e)
        {
            // Validate required fields for staff
            if (string.IsNullOrWhiteSpace(sta_name.Text) || string.IsNullOrWhiteSpace(comboBoxsta_dept.Text) ||
                string.IsNullOrWhiteSpace(sta_address.Text) || string.IsNullOrWhiteSpace(sta_contact.Text) ||
                string.IsNullOrWhiteSpace(sta_sal.Text) || string.IsNullOrWhiteSpace(sta_email.Text) ||
                (!radioButton6.Checked && !radioButton5.Checked) || // Gender validation
                (!radioButton10.Checked && !radioButton9.Checked)) // Employment status validation
            {
                MessageBox.Show("Please fill in all required fields for the staff.");
                return;
            }
            if (string.IsNullOrWhiteSpace(sta_name.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBoxsta_dept.Text))
            {
                MessageBox.Show("Department must be selected.");
                return;
            }

            if (string.IsNullOrWhiteSpace(sta_address.Text))
            {
                MessageBox.Show("Address cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(sta_contact.Text))
            {
                MessageBox.Show("Contact number cannot be empty.");
                return;
            }

            if (!IsValidContact(sta_contact.Text))
            {
                MessageBox.Show("Please enter a valid contact number (10 digits).");
                return;
            }

            if (string.IsNullOrWhiteSpace(sta_sal.Text))
            {
                MessageBox.Show("Salary cannot be empty.");
                return;
            }

            if (!int.TryParse(sta_sal.Text, out int salary))
            {
                MessageBox.Show("Please enter a valid numeric value for salary.");
                return;
            }

            if (string.IsNullOrWhiteSpace(sta_email.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                return;
            }

            if (!IsValidEmail(sta_email.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!radioButton6.Checked && !radioButton5.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            if (!radioButton10.Checked && !radioButton9.Checked)
            {
                MessageBox.Show("Please select employment status.");
                return;
            }
            // If all validations pass, insert the staff data
            Staff staff = new Staff
            {
                Name = sta_name.Text,
                Department = comboBoxsta_dept.Text,
                Address = sta_address.Text,
                Gender = radioButton6.Checked ? "Male" : "Female",
                Contact = sta_contact.Text,
                Salary = sta_sal.Text,
                Email = sta_email.Text,
                EmploymentStatus = radioButton10.Checked ? "Employed" : "Unemployed",
                Experience = ((int)numericUpDownsta_experience.Value).ToString(),
                Age = ((int)numericUpDownsta_age.Value).ToString()
            };

            int d = sql.Insert(staff);
            if (d > 0)
            {
                MessageBox.Show("Staff saved successfully Id=" + d);
            }
            else
            {
                MessageBox.Show("Error occurred while saving staff.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7_Click(sender, e, sql);
        }

        private void button7_Click(object sender, EventArgs e, Sql1 sql)
        {
            try
            {

                Student student = sql.Get(Convert.ToInt32(textBox1.Text));

                if (student != null)
                {
                    // Clear the ListBox to remove previous data
                    listBox21.Items.Clear();

                    // Add the student information to the ListBox
                    listBox21.Items.Add("Name: " + student.Name);
                    listBox21.Items.Add("Course: " + student.Course);
                    listBox21.Items.Add("Address: " + student.Address);
                    listBox21.Items.Add("Year: " + student.Year);
                    listBox21.Items.Add("Gender: " + student.Gender);
                    listBox21.Items.Add("Father's Name: " + student.FatherName);
                    listBox21.Items.Add("Mother's Name: " + student.MotherName);
                    listBox21.Items.Add("Contact: " + student.Contact);
                    listBox21.Items.Add("Email: " + student.Email);
                    listBox21.Items.Add("Age: " + student.Age);
                    groupBox6.Visible = true;
                }
                else
                {
                    // If no student is found, show a message box
                    MessageBox.Show("No student found with the given ID.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _))
            {
              
                MessageBox.Show("Please enter only integer values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

              
                textBox1.Text = string.Empty;

              
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _))
            {
              
                MessageBox.Show("Please enter only integer values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

              
                textBox1.Text = string.Empty;

                
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _))
            {
               
                MessageBox.Show("Please enter only integer values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
                textBox1.Text = string.Empty;

                
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = sql.GetTeacher(Convert.ToInt32(textBox2.Text));

                if (teacher != null)
                {
                  
                    listBox22.Items.Clear();

                  
                    listBox22.Items.Add("Name: " + teacher.Name);
                    listBox22.Items.Add("Department: " + teacher.Department);
                    listBox22.Items.Add("Address: " + teacher.Address);
                    listBox22.Items.Add("Gender: " + teacher.Gender);
                    listBox22.Items.Add("Contact: " + teacher.Contact);
                    listBox22.Items.Add("Salary: " + teacher.Salary);
                    listBox22.Items.Add("Email: " + teacher.Email);
                    listBox22.Items.Add("Employment Status: " + teacher.EmploymentStatus);
                    listBox22.Items.Add("Qualification: " + teacher.Qualification);
                    listBox22.Items.Add("Experience: " + teacher.Experience);
                    listBox22.Items.Add("Age: " + teacher.Age);
                    groupBox7.Visible = true;
                }
                else
                {
                  
                    MessageBox.Show("No teacher found with the given ID.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Staff staff = sql.GetStaff(Convert.ToInt32(textBox3.Text));

                if (staff != null)
                {
                  
                    listBox23.Items.Clear();

                    
                    listBox23.Items.Add("Name: " + staff.Name);
                    listBox23.Items.Add("Department: " + staff.Department);
                    listBox23.Items.Add("Address: " + staff.Address);
                    listBox23.Items.Add("Gender: " + staff.Gender);
                    listBox23.Items.Add("Contact: " + staff.Contact);
                    listBox23.Items.Add("Salary: " + staff.Salary);
                    listBox23.Items.Add("Email: " + staff.Email);
                    listBox23.Items.Add("Employment Status: " + staff.EmploymentStatus);
                    listBox23.Items.Add("Experience: " + staff.Experience);
                    listBox23.Items.Add("Age: " + staff.Age);
                    groupBox8.Visible = true;
                }
                else
                {
                    
                    MessageBox.Show("No staff found with the given ID.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
    }

    
}
