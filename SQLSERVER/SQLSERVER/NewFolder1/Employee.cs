using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace SQLSERVER
{
    internal class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public Image Img { get; set; }

        public Employee()
        {

        }

        public Employee(int iD, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, Image img)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Img = img;
        }
        public override string ToString()
        {
            return $"{ID:0000}, {FirstName} {LastName}";
        }

        public  static List<Employee> GetEmployees(SqlDataReader r)
        {
            List<Employee> employees = new List<Employee>();
            while (r.Read())
            {
                int id = Convert.ToInt32(r["ID"]);
                string firstName = r[1].ToString();
                string lastName = r[2].ToString();
                DateTime dob = DateTime.Parse(r[3].ToString());
                string phoneNumber = r[4].ToString();
                MemoryStream ms = new MemoryStream((byte[])r[5]);
                Image img = Image.FromStream(ms);
                Employee employee = new
                    Employee(id, firstName, lastName, dob, phoneNumber, img);
                employees.Add(employee);
            }
            return employees;
        }
    }
}
