using System;
using System.Data.SqlClient;

namespace AssDbmslib
{
    public abstract class Common
    {
        protected SqlConnection conn; // Make this protected to access in derived classes
        protected SqlDataAdapter da;
        protected SqlDataReader dr;
        protected SqlCommand cmd;

        public Common()
        {

            conn = new SqlConnection("Data Source=Pratham;Initial Catalog=College;Integrated Security=True;Encrypt=True");
        }

        protected void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        protected void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

    public class Student : Common
    {
        // Instance variables
        public string stu_id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }
        public string Year { get; set; }
        public string Gender { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }

        // Constructor
        public Student() {
            stu_id = "0";
        }

        public Student(string name, string course, string address, string year, string gender, string fatherName, string motherName, string contact, string email, string age)
        {
            Name = name;
            Course = course;
            Address = address;
            Year = year;
            Gender = gender;
            FatherName = fatherName;
            MotherName = motherName;
            Contact = contact;
            Email = email;
            Age = age;
        }
    }

    public class Teacher : Common
    {
        // Instance variables
        public string t_id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Salary { get; set; }
        public string Email { get; set; }
        public string EmploymentStatus { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
        public string Age { get; set; }

        // Constructor
        public Teacher() { }

        public Teacher(string name, string department, string address, string gender, string contact, string salary, string email, string employmentStatus, string qualification, string experience, string age)
        {
            Name = name;
            Department = department;
            Address = address;
            Gender = gender;
            Contact = contact;
            Salary = salary;
            Email = email;
            EmploymentStatus = employmentStatus;
            Qualification = qualification;
            Experience = experience;
            Age = age;
        }
    }

    public class Staff : Common
    {
        public string st_id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Salary { get; set; }
        public string Email { get; set; }
        public string EmploymentStatus { get; set; }
        public string Experience { get; set; }
        public string Age { get; set; }

        // Constructor
        public Staff() { }

        public Staff(string name, string department, string address, string gender, string contact, string salary, string email, string employmentStatus, string experience, string age)
        {

            Name = name;
            Department = department;
            Address = address;
            Gender = gender;
            Contact = contact;
            Salary = salary;
            Email = email;
            EmploymentStatus = employmentStatus;
            Experience = experience;
            Age = age;
        }
        //end of staff
    }
    public class Sql1 : Common
    {
        public int Insert(Student student)
        {
            try
            {
                string query = "INSERT INTO Student (stu_name, stu_course, stu_address, stu_year, stu_gender, stu_father, stu_mother, stu_contact, stu_email, stu_age) " +
                               $"VALUES ('{student.Name}', '{student.Course}', '{student.Address}', '{student.Year}', '{student.Gender}', '{student.FatherName}', '{student.MotherName}', '{student.Contact}', '{student.Email}', '{student.Age}');" +
                               "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                OpenConnection();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception ex)
            {
                // Log the error (optional)
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }
    

        public int Insert(Teacher teacher)
        {
            try
            {
                string query = "INSERT INTO Teacher (teach_name, teach_dept, teach_address, teach_gender, teach_contact, teach_salary, teach_email, teach_emp_status, teach_qualification, teach_experience, teach_age) " +
                               $"VALUES ('{teacher.Name}', '{teacher.Department}', '{teacher.Address}', '{teacher.Gender}', '{teacher.Contact}', '{teacher.Salary}', '{teacher.Email}', '{teacher.EmploymentStatus}', '{teacher.Qualification}', '{teacher.Experience}', '{teacher.Age}');" +
                               "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                OpenConnection();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception ex)
            {
                // Log the error (optional)
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int Insert(Staff staff)
        {
            try
            {
                string query = "INSERT INTO Staff (staff_name, staff_dept, staff_address, staff_gender, staff_contact, staff_salary, staff_email, staff_emp_status, staff_experience, staff_age) " +
                               $"VALUES ('{staff.Name}', '{staff.Department}', '{staff.Address}', '{staff.Gender}', '{staff.Contact}', '{staff.Salary}', '{staff.Email}', '{staff.EmploymentStatus}', '{staff.Experience}', '{staff.Age}');" +
                               "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                OpenConnection();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception)
            {
            
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }

        public Student Get(int id)
        {
            try
            {
                string q = "SELECT * FROM Student WHERE stu_id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id); 
                OpenConnection();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows && dr.Read())
                    {
                        Student student = new Student
                        {
                            Name = dr["stu_name"].ToString()!,
                            Course = dr["stu_course"].ToString()!,
                            Address = dr["stu_address"].ToString()!,
                            Year = dr["stu_year"].ToString()!,
                            Gender = dr["stu_gender"].ToString()!,
                            FatherName = dr["stu_father"].ToString()!,
                            MotherName = dr["stu_mother"].ToString()!,
                            Contact = dr["stu_contact"].ToString()!,
                            Email = dr["stu_email"].ToString()!,
                            Age = dr["stu_age"].ToString()!
                        };
                        return student;
                    }
                }
            }
            catch (Exception)
            {
                return null!;
                // Consider logging the error or handling it accordingly
            }
            finally
            {
                CloseConnection(); // Ensure the connection is closed
            }

            return null!;
        }

        public Teacher GetTeacher(int id)
        {
            try
            {
                string q = "SELECT * FROM Teacher WHERE teach_id=" + id;
                SqlCommand cmd = new SqlCommand(q, conn);
                OpenConnection();

                SqlDataReader dr = cmd.ExecuteReader();
                Teacher teacher = new Teacher();

                if (dr.HasRows && dr.Read())
                {
                    teacher.Name = dr["teach_name"].ToString()!;
                    teacher.Department = dr["teach_dept"].ToString()!;
                    teacher.Address = dr["teach_address"].ToString()!;
                    teacher.Gender = dr["teach_gender"].ToString()!;
                    teacher.Contact = dr["teach_contact"].ToString()!;
                    teacher.Salary = dr["teach_salary"].ToString()!;
                    teacher.Email = dr["teach_email"].ToString()!;
                    teacher.EmploymentStatus = dr["teach_emp_status"].ToString()!;
                    teacher.Qualification = dr["teach_qualification"].ToString()!;
                    teacher.Experience = dr["teach_experience"].ToString()!;
                    teacher.Age = dr["teach_age"].ToString()!;
                }

                return teacher;
            }
            catch (Exception ex)
            {
                // Log the error (optional)
                Console.WriteLine(ex.Message);
                return null!;
            }
            finally
            {
                CloseConnection();
            }
        }

        public Staff GetStaff(int id)
        {
            try
            {
                string q = "SELECT * FROM Staff WHERE staff_id=" + id;
                SqlCommand cmd = new SqlCommand(q, conn);
                OpenConnection();

                SqlDataReader dr = cmd.ExecuteReader();
                Staff staff = new Staff();

                if (dr.HasRows && dr.Read())
                {
                    staff.Name = dr["staff_name"].ToString()!;
                    staff.Department = dr["staff_dept"].ToString()!;
                    staff.Address = dr["staff_address"].ToString()!;
                    staff.Gender = dr["staff_gender"].ToString()!;
                    staff.Contact = dr["staff_contact"].ToString()!;
                    staff.Salary = dr["staff_salary"].ToString()!;
                    staff.Email = dr["staff_email"].ToString()!;
                    staff.EmploymentStatus = dr["staff_emp_status"].ToString()!;
                    staff.Experience = dr["staff_experience"].ToString()!;
                    staff.Age = dr["staff_age"].ToString()!;
                }

                return staff;
            }
            catch (Exception ex)
            {
                // Log the error (optional)
                Console.WriteLine(ex.Message);
                return null!;
            }
            finally
            {
                CloseConnection();
            }
        }



        public List<Student> Get(string name)
        {
            try
            {
                string q = $"SELECT * FROM Student WHERE stu_name = '{name}'";
                SqlCommand cmd = new SqlCommand(q, conn);
                
                OpenConnection();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        List<Student> list = new List<Student>();
                        while (dr.Read())
                        {
                            Student student = new Student
                            {
                                stu_id = dr["stu_id"].ToString()!,
                                Name = dr["stu_name"].ToString()!,
                                Course = dr["stu_course"].ToString()!,
                                Address = dr["stu_address"].ToString()!,
                                Year = dr["stu_year"].ToString()!,
                                Gender = dr["stu_gender"].ToString()!,
                                FatherName = dr["stu_father"].ToString()!,
                                MotherName = dr["stu_mother"].ToString()!,
                                Contact = dr["stu_contact"].ToString()!,
                                Email = dr["stu_email"].ToString()!,
                                Age = dr["stu_age"].ToString()!
                            };
                            list.Add(student);
                        }
                        dr.Close();
                        cmd.Dispose();
                        return list;
                    }
                }
            }
            catch (Exception)
            {
                dr.Close();
                cmd.Dispose();
                return null!;
               
            }
            finally
            {
                CloseConnection(); // Ensure the connection is closed
            }

            return null!;

        }


        public List<Teacher> GetTeacher(string name)
        {
            try
            {
                string q = $"SELECT * FROM Teacher WHERE t_name = '{name}'";
                SqlCommand cmd = new SqlCommand(q, conn);

                OpenConnection();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        List<Teacher> list = new List<Teacher>();
                        while (dr.Read())
                        {
                            Teacher teacher = new Teacher();
                            teacher.t_id = dr["stu_id"].ToString()!;
                            teacher.Name = dr["teach_name"].ToString()!;
                            teacher.Department = dr["teach_dept"].ToString()!;
                            teacher.Address = dr["teach_address"].ToString()!;
                            teacher.Gender = dr["teach_gender"].ToString()!;
                            teacher.Contact = dr["teach_contact"].ToString()!;
                            teacher.Salary = dr["teach_salary"].ToString()!;
                            teacher.Email = dr["teach_email"].ToString()!;
                            teacher.EmploymentStatus = dr["teach_emp_status"].ToString()!;
                            teacher.Qualification = dr["teach_qualification"].ToString()!;
                            teacher.Experience = dr["teach_experience"].ToString()!;
                            teacher.Age = dr["teach_age"].ToString()!;
                            list.Add(teacher);
                        }
                        dr.Close();
                        cmd.Dispose();
                        return list;
                    }
                }
            }
            catch (Exception)
            {
                dr.Close();
                cmd.Dispose();
                return null!;
                // Consider logging the error or handling it accordingly
            }
            finally
            {
                CloseConnection(); // Ensure the connection is closed
            }

            return null!;

        }




        public List<Staff> GetStaff(string name)
        {
            try
            {
                string q = "SELECT * FROM Staff WHERE s_name=" + name;
                SqlCommand cmd = new SqlCommand(q, conn);
                OpenConnection();

                SqlDataReader dr = cmd.ExecuteReader();
               

                if (dr.HasRows)
                {
                    List<Staff> list = new List<Staff>();
                    while (dr.Read())
                    {
                        Staff staff = new Staff();
                        staff.st_id = dr["stu_id"].ToString()!;
                        staff.Name = dr["staff_name"].ToString()!;
                        staff.Department = dr["staff_dept"].ToString()!;
                        staff.Address = dr["staff_address"].ToString()!;
                        staff.Gender = dr["staff_gender"].ToString()!;
                        staff.Contact = dr["staff_contact"].ToString()!;
                        staff.Salary = dr["staff_salary"].ToString()!;
                        staff.Email = dr["staff_email"].ToString()!;
                        staff.EmploymentStatus = dr["staff_emp_status"].ToString()!;
                        staff.Experience = dr["staff_experience"].ToString()!;
                        staff.Age = dr["staff_age"].ToString()!;
                        list.Add(staff);
                    }
                    return list;
                }
                dr.Close();
                cmd.Dispose();
                return null!;
                
            }
            catch (Exception)
            {
                return null!;
            }
            finally
            {
                CloseConnection();
            }
        }



    }// end of class SQL



    



    public class Login : Common
    {

        public bool userexist(string n)
        {
            try
            {

                OpenConnection();
                using (var cmd = new SqlCommand("SELECT COUNT(1) FROM User_ WHERE name_ = @Username", conn))
                {

                    cmd.Parameters.AddWithValue("@Username", n);


                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }



            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                CloseConnection();

            }
        }
        

        public bool ValidateLogin(string n, string p)
        {
            try
            {
                OpenConnection();
                using (var cmd = new SqlCommand("SELECT * FROM User_ WHERE name_ = @Username AND pass = @Password", conn))
                {

                    cmd.Parameters.AddWithValue("@Username", n);

                    cmd.Parameters.AddWithValue("@Password", p);

                    using (var dr = cmd.ExecuteReader())
                    {
                        // Simply check if any matching record exists
                        return dr.HasRows;
                    }
                }


            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
