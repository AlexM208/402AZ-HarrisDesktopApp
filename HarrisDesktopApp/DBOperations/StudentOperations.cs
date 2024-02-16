using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HarrisDesktopApp.Models;

namespace HarrisDesktopApp.DBOperations
{
    internal class StudentOperations
    {
        private DataAccess dataAccess = new DataAccess();




        //operation to show Timetable details table 
        public DataTable GetTimetable()
        {
            string query = "Call getJoinTimetable()";
            return dataAccess.ExecuteQuery(query);
        }

        //operation to show Materials details table 
        public DataTable GetMaterials()
        {
            string query = "Call getMaterials()";
            return dataAccess.ExecuteQuery(query);
        }


    }
}
