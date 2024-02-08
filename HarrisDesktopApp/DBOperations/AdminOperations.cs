using HarrisDesktopApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.DBOperations
{
    internal class AdminOperations
    {
        private DataAccess dataAccess = new DataAccess();

        // Admin creatin a new Teacher
        public void AddTeacher(Teacher teacher)
        {
            string query ="CALL AddTeacher(@tt_Lname, @tt_Fname, @tt_email, @tt_position,@tt_department, @tt_timetable_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@tt_Lname", teacher.Lname);
            command.Parameters.AddWithValue("@tt_Fname", teacher.Fname);
            command.Parameters.AddWithValue("@tt_email", teacher.email);
            command.Parameters.AddWithValue("@tt_position", teacher.tt_position);
            command.Parameters.AddWithValue("@tt_department", teacher.tt_department);
            command.Parameters.AddWithValue("@tt_timetable_id", teacher.timetableID);

            dataAccess.ExecuteNonQuery(command);

        }

        //operation to show Teachers details table 
        public DataTable GetTeachers()
        {
            string query = "Call getTeachers()";
            return dataAccess.ExecuteQuery(query);
        }

        // Admin operation to update Teacher details

        public void UpdateTeacher(Teacher teacher)
        {
            string query = "Call UpdateTeacher(@tt_id,@tt_Lname, @tt_Fname, @tt_email, @tt_position, @tt_department, @tt_timetable_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@tt_id", teacher.Id);
            command.Parameters.AddWithValue("@tt_Lname", teacher.Lname);
            command.Parameters.AddWithValue("@tt_Fname", teacher.Fname);
            command.Parameters.AddWithValue("@tt_email", teacher.email);
            command.Parameters.AddWithValue("@tt_position", teacher.tt_position);
            command.Parameters.AddWithValue("@tt_department", teacher.tt_department);
            command.Parameters.AddWithValue("@tt_timetable_id", teacher.timetableID);

            dataAccess.ExecuteNonQuery (command);
        }

        // Admin operation to delete Teacher details
        public void DeleteTeacher(int teacherId)
        {
            string query = "Call DeleteTeacher(@tt_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@tt_id", teacherId);
            dataAccess.ExecuteNonQuery(command);
        }


        // Admin creatin a new Student
        public void AddStudent(Student student)
        {
            string query = "CALL AddStudent(@ss_Lname, @ss_Fname, @ss_address, @ss_postcode, @ss_email, @ss_phone, @ss_grade_CW2, @ss_pass_fail, @ss_timetable_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@ss_Lname", student.Lname);
            command.Parameters.AddWithValue("@ss_Fname", student.Fname);
            command.Parameters.AddWithValue("@ss_address", student.ss_address);
            command.Parameters.AddWithValue("@ss_postcode", student.ss_postcode);
            command.Parameters.AddWithValue("@ss_email", student.email);
            command.Parameters.AddWithValue("@ss_phone", student.ss_phone);
            command.Parameters.AddWithValue("@ss_grade_CW2", student.ss_grade_CW2);
            command.Parameters.AddWithValue("@ss_pass_fail", student.ss_pass_fail);
            command.Parameters.AddWithValue("@ss_timetable_id", student.timetableID);

            dataAccess.ExecuteNonQuery(command);

        }
        //operation to show Student details table 
        public DataTable GetStudents()
        {
            string query = "Call getStudents()";
            return dataAccess.ExecuteQuery(query);
        }


        // Admin operation to update Student details

        public void UpdateStudent(Student student)
        {
            string query = "Call UpdateStudent(@ss_id, @ss_Lname, @ss_Fname, @ss_address, @ss_postcode, @ss_email, @ss_phone, @ss_grade_CW2, @ss_pass_fail, @ss_timetable_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@ss_id", student.Id);
            command.Parameters.AddWithValue("@ss_Lname", student.Lname);
            command.Parameters.AddWithValue("@ss_Fname", student.Fname);
            command.Parameters.AddWithValue("@ss_address", student.ss_address);
            command.Parameters.AddWithValue("@ss_postcode", student.ss_postcode);
            command.Parameters.AddWithValue("@ss_email", student.email);
            command.Parameters.AddWithValue("@ss_phone", student.ss_phone);
            command.Parameters.AddWithValue("@ss_grade_CW2", student.ss_grade_CW2);
            command.Parameters.AddWithValue("@ss_pass_fail", student.ss_pass_fail);
            command.Parameters.AddWithValue("@ss_timetable_id", student.timetableID);
            
            dataAccess.ExecuteNonQuery(command);
        }

        // Admin operation to delete Student details
        public void DeleteStudent(int studentId)
        {
            string query = "Call DeleteStudent(@ss_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@ss_id", studentId);
            dataAccess.ExecuteNonQuery(command);
        }


    }
}
