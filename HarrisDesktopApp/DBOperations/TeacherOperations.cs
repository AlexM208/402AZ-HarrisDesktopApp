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
    internal class TeacherOperations
    {

        private DataAccess dataAccess = new DataAccess();


        //operation to show Timetable details table 
        public DataTable GetTimetable()
        {
            string query = "Call getJoinTimetable()";
            return dataAccess.ExecuteQuery(query);
        }

        //CRUD for Materials table  ********************************************************************************************************************** 
        //  creating a new Materials
        public void AddMaterial(Materials materials1)
        {
            string query = "CALL AddMaterials(@mm_module_id, @mm_t_id, @mm_material_date_edit)";  //, @mm_material_blob
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@mm_module_id", materials1.mm_moduleID);
            command.Parameters.AddWithValue("@mm_t_id", materials1.mm_tID);
            command.Parameters.AddWithValue("@mm_material_date_edit", materials1.mm_mat_date_edit);
            //command.Parameters.AddWithValue("@mm_material_blob", materials1.mm_material_blob);


            dataAccess.ExecuteNonQuery(command);
        }

        //operation to show Materials details table 
        public DataTable GetMaterials()
        {
            string query = "Call getMaterials()";
            return dataAccess.ExecuteQuery(query);
        }

        //  operation to update Materials details
        public void UpdateMaterial(Materials materials1)
        {
            string query = "CALL UpdateMaterials(@mm_material_id, @mm_module_id, @mm_t_id, @mm_material_date_edit)";  //, @mm_material_blob
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@mm_material_id", materials1.mm_materialID);
            command.Parameters.AddWithValue("@mm_module_id", materials1.mm_moduleID);
            command.Parameters.AddWithValue("@mm_t_id", materials1.mm_tID);
            command.Parameters.AddWithValue("@mm_material_date_edit", materials1.mm_mat_date_edit);
            //command.Parameters.AddWithValue("@mm_material_blob", materials1.mm_material_blob);

            dataAccess.ExecuteNonQuery(command);
        }

        //  operation to delete Materials details
        public void DeleteMaterial(int materialId)
        {
            string query = "Call DeleteMaterial(@mm_material_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@mm_material_id", materialId);
            dataAccess.ExecuteNonQuery(command);
        }

        //operation to show Student details table 
        public DataTable GetStudents()
        {
            string query = "Call getStudents()";
            return dataAccess.ExecuteQuery(query);
        }
       /* 
        // operation show student from class
        public DataTable GetStudentsFromClass(double classRoom1)
        {
            string query = "Call getStudentsFromClass(@ss_class_room)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@ss_class_room", classRoom1);
            //dataAccess.ExecuteNonQuery(command);
            return dataAccess.ExecuteQuery(query);
        }*/



    }
}
