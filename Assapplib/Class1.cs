using System.Data.SqlClient;
namespace Assapplib
{
    public abstract class Common
    {
        protected SqlConnection conn;
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

        public Student()
        {
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
    }

    public class Sql : Common
    {
        public int Insert(Student student)
        {
            try
            {
                string query = "INSERT INTO Student (stu_name, stu_course, stu_address, stu_year, stu_gender, stu_father, stu_mother, stu_contact, stu_email, stu_age) " +
                               $"VALUES ('{student.Name}', '{student.Course}', '{student.Address}', '{student.Year}', '{student.Gender}', '{student.FatherName}', '{student.MotherName}', '{student.Contact}', '{student.Email}', '{student.Age}');" +
                               "SELECT SCOPE_IDENTITY();";

                cmd = new SqlCommand(query, conn);
                OpenConnection();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception ex)
            {
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

                cmd = new SqlCommand(query, conn);
                OpenConnection();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception ex)
            {
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

                cmd = new SqlCommand(query, conn);
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
                cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);
                OpenConnection();

                dr = cmd.ExecuteReader();
                Student student = null;

                if (dr.HasRows && dr.Read())
                {
                    student = new Student
                    {
                        stu_id = dr["stu_id"].ToString(),
                        Name = dr["stu_name"].ToString(),
                        Course = dr["stu_course"].ToString(),
                        Address = dr["stu_address"].ToString(),
                        Year = dr["stu_year"].ToString(),
                        Gender = dr["stu_gender"].ToString(),
                        FatherName = dr["stu_father"].ToString(),
                        MotherName = dr["stu_mother"].ToString(),
                        Contact = dr["stu_contact"].ToString(),
                        Email = dr["stu_email"].ToString(),
                        Age = dr["stu_age"].ToString()
                    };
                }
                return student;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (dr != null) dr.Close();
                CloseConnection();
            }
        }

        public List<Student> Get(string name)
        {
            try
            {
                string q = "SELECT * FROM Student WHERE stu_name LIKE @name";
                cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                OpenConnection();

                dr = cmd.ExecuteReader();
                List<Student> list = new List<Student>();

                while (dr.Read())
                {
                    Student student = new Student
                    {
                        stu_id = dr["stu_id"].ToString(),
                        Name = dr["stu_name"].ToString(),
                        Course = dr["stu_course"].ToString(),
                        Address = dr["stu_address"].ToString(),
                        Year = dr["stu_year"].ToString(),
                        Gender = dr["stu_gender"].ToString(),
                        FatherName = dr["stu_father"].ToString(),
                        MotherName = dr["stu_mother"].ToString(),
                        Contact = dr["stu_contact"].ToString(),
                        Email = dr["stu_email"].ToString(),
                        Age = dr["stu_age"].ToString()
                    };
                    list.Add(student);
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (dr != null) dr.Close();
                CloseConnection();
            }
        }

        public Teacher GetTeacher(int id)
        {
            try
            {
                string q = "SELECT * FROM Teacher WHERE teach_id = @id";
                cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);
                OpenConnection();

                dr = cmd.ExecuteReader();
                Teacher teacher = null;

                if (dr.HasRows && dr.Read())
                {
                    teacher = new Teacher
                    {
                        t_id = dr["teach_id"].ToString(),
                        Name = dr["teach_name"].ToString(),
                        Department = dr["teach_dept"].ToString(),
                        Address = dr["teach_address"].ToString(),
                        Gender = dr["teach_gender"].ToString(),
                        Contact = dr["teach_contact"].ToString(),
                        Salary = dr["teach_salary"].ToString(),
                        Email = dr["teach_email"].ToString(),
                        EmploymentStatus = dr["teach_emp_status"].ToString(),
                        Qualification = dr["teach_qualification"].ToString(),
                        Experience = dr["teach_experience"].ToString(),
                        Age = dr["teach_age"].ToString()
                    };
                }
                return teacher;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (dr != null) dr.Close();
                CloseConnection();
            }
        }

        public List<Teacher> GetTeacher(string name)
        {
            try
            {
                string q = "SELECT * FROM Teacher WHERE teach_name LIKE @name";
                cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                OpenConnection();

                dr = cmd.ExecuteReader();
                List<Teacher> list = new List<Teacher>();

                while (dr.Read())
                {
                    Teacher teacher = new Teacher
                    {
                        t_id = dr["teach_id"].ToString(),
                        Name = dr["teach_name"].ToString(),
                        Department = dr["teach_dept"].ToString(),
                        Address = dr["teach_address"].ToString(),
                        Gender = dr["teach_gender"].ToString(),
                        Contact = dr["teach_contact"].ToString(),
                        Salary = dr["teach_salary"].ToString(),
                        Email = dr["teach_email"].ToString(),
                        EmploymentStatus = dr["teach_emp_status"].ToString(),
                        Qualification = dr["teach_qualification"].ToString(),
                        Experience = dr["teach_experience"].ToString(),
                        Age = dr["teach_age"].ToString()
                    };
                    list.Add(teacher);
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (dr != null) dr.Close();
                CloseConnection();
            }
        }

        public Staff GetStaff(int id)
        {
            try
            {
                string q = "SELECT * FROM Staff WHERE staff_id = @id";
                cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);
                OpenConnection();

                dr = cmd.ExecuteReader();
                Staff staff = null;

                if (dr.HasRows && dr.Read())
                {
                    staff = new Staff
                    {
                        st_id = dr["staff_id"].ToString(),
                        Name = dr["staff_name"].ToString(),
                        Department = dr["staff_dept"].ToString(),
                        Address = dr["staff_address"].ToString(),
                        Gender = dr["staff_gender"].ToString(),
                        Contact = dr["staff_contact"].ToString(),
                        Salary = dr["staff_salary"].ToString(),
                        Email = dr["staff_email"].ToString(),
                        EmploymentStatus = dr["staff_emp_status"].ToString(),
                        Experience = dr["staff_experience"].ToString(),
                        Age = dr["staff_age"].ToString()
                    };
                }
                return staff;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (dr != null) dr.Close();
                CloseConnection();
            }
        }

        public List<Staff> GetStaff(string name)
        {
            try
            {
                string q = "SELECT * FROM Staff WHERE staff_name LIKE @name";
                cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                OpenConnection();

                dr = cmd.ExecuteReader();
                List<Staff> list = new List<Staff>();

                while (dr.Read())
                {
                    Staff staff = new Staff
                    {
                        st_id = dr["staff_id"].ToString(),
                        Name = dr["staff_name"].ToString(),
                        Department = dr["staff_dept"].ToString(),
                        Address = dr["staff_address"].ToString(),
                        Gender = dr["staff_gender"].ToString(),
                        Contact = dr["staff_contact"].ToString(),
                        Salary = dr["staff_salary"].ToString(),
                        Email = dr["staff_email"].ToString(),
                        EmploymentStatus = dr["staff_emp_status"].ToString(),
                        Experience = dr["staff_experience"].ToString(),
                        Age = dr["staff_age"].ToString()
                    };
                    list.Add(staff);
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (dr != null) dr.Close();
                CloseConnection();
            }
        }
    }

    public class Login : Common
    {
        public bool userexist(string n)
        {
            try
            {
                OpenConnection();
                using (cmd = new SqlCommand("SELECT COUNT(1) FROM User_ WHERE name_ = @Username", conn))
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
                using (cmd = new SqlCommand("SELECT * FROM User_ WHERE name_ = @Username AND pass = @Password", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", n);
                    cmd.Parameters.AddWithValue("@Password", p);

                    using (dr = cmd.ExecuteReader())
                    {
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