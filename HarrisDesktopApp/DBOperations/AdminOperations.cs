using HarrisDesktopApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.DBOperations
{
    internal class AdminOperations
    {
        private DataAccess dataAccess = new DataAccess();
        

        //**** CRUD operations **********************************************************************************************************************
        // Admin creating a new Teacher
        public void AddTeacher(Teacher teacher)
        {
            string query ="CALL AddTeacher(@tt_Lname, @tt_Fname, @tt_email, @tt_position,@tt_department)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@tt_Lname", teacher.Lname);
            command.Parameters.AddWithValue("@tt_Fname", teacher.Fname);
            command.Parameters.AddWithValue("@tt_email", teacher.email);
            command.Parameters.AddWithValue("@tt_position", teacher.tt_position);
            command.Parameters.AddWithValue("@tt_department", teacher.tt_department);           
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
            string query = "Call UpdateTeacher(@tt_id,@tt_Lname, @tt_Fname, @tt_email, @tt_position, @tt_department)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@tt_id", teacher.Id);
            command.Parameters.AddWithValue("@tt_Lname", teacher.Lname);
            command.Parameters.AddWithValue("@tt_Fname", teacher.Fname);
            command.Parameters.AddWithValue("@tt_email", teacher.email);
            command.Parameters.AddWithValue("@tt_position", teacher.tt_position);
            command.Parameters.AddWithValue("@tt_department", teacher.tt_department);
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


        //CRUD for Student table **********************************************************************************************************************
        // Admin creating a new Student
        public void AddStudent(Student student)
        {
            string query = "CALL AddStudent(@ss_Lname, @ss_Fname, @ss_address, @ss_postcode, @ss_email, @ss_phone, @ss_grade_CW2, @ss_pass_fail, @ss_class_room)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@ss_Lname", student.Lname);
            command.Parameters.AddWithValue("@ss_Fname", student.Fname);
            command.Parameters.AddWithValue("@ss_address", student.ss_address);
            command.Parameters.AddWithValue("@ss_postcode", student.ss_postcode);
            command.Parameters.AddWithValue("@ss_email", student.email);
            command.Parameters.AddWithValue("@ss_phone", student.ss_phone);
            command.Parameters.AddWithValue("@ss_grade_CW2", student.ss_grade_CW2);
            command.Parameters.AddWithValue("@ss_pass_fail", student.ss_pass_fail);
            command.Parameters.AddWithValue("@ss_class_room", student.ss_class_room);

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
            string query = "Call UpdateStudent(@ss_id, @ss_Lname, @ss_Fname, @ss_address, @ss_postcode, @ss_email, @ss_phone, @ss_grade_CW2, @ss_pass_fail, @ss_class_room)";
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
            command.Parameters.AddWithValue("@ss_class_room", student.ss_class_room);
            //command.Parameters.AddWithValue("@ss_timetable_id", student.timetableID);

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


        //CRUD for Class table ********************************************************************************************************************** 
        // Admin creating a new Class
        public void AddClass(Class class1)
        {
            string query = "CALL AddClass(@cc_class_room, @cc_class_building, @cc_class_floor, @cc_class_address, @cc_class_postcode, @cc_t_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@cc_class_room", class1.cc_classRoom);
            command.Parameters.AddWithValue("@cc_class_building", class1.cc_classBuilding);
            command.Parameters.AddWithValue("@cc_class_floor", class1.cc_classFloor);
            command.Parameters.AddWithValue("@cc_class_address", class1.cc_classAddress);
            command.Parameters.AddWithValue("@cc_class_postcode", class1.cc_classPostcode);
            command.Parameters.AddWithValue("@cc_t_id", class1.cc_t_id);

            dataAccess.ExecuteNonQuery(command);

        }

        //operation to show Class details table 
        public DataTable GetClass()
        {
            string query = "Call getClass()";
            return dataAccess.ExecuteQuery(query);
        }

        // Admin operation to update Class details
        public void UpdateClass(Class class1)
        {
            string query = "Call UpdateClass(@cc_class_room, @cc_class_building, @cc_class_floor, @cc_class_address, @cc_class_postcode)";
            MySqlCommand command = new MySqlCommand(query);

           // command.Parameters.AddWithValue("@cc_class_room", class1.cc_classRoom);
            command.Parameters.AddWithValue("@cc_class_building", class1.cc_classBuilding);
           // command.Parameters.AddWithValue("@cc_class_floor", class1.cc_classFloor);
            command.Parameters.AddWithValue("@cc_class_address", class1.cc_classAddress);
            command.Parameters.AddWithValue("@cc_class_postcode", class1.cc_classPostcode);
            command.Parameters.AddWithValue("@cc_t_id", class1.cc_t_id);

            dataAccess.ExecuteNonQuery(command);
        }

        // Admin operation to delete Class details
        public void DeleteClass(double classRoom)
        {
            string query = "Call DeleteClass(@cc_class_room)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@cc_class_room", classRoom);
            dataAccess.ExecuteNonQuery(command);
        }


        //Timetable Projection  ********************************************************************************************************************** 
        //operation to project a Timetable
        public DataTable GetTimetable()
        {
            //string query = "Call getJoinTimetable()";
            string query = "Call getJoinTimetable()";
            return dataAccess.ExecuteQuery(query);
        }       

        //CRUD for Materials table  ********************************************************************************************************************** 
        // Admin creating a new Materials
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

        // Admin operation to update Materials details
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

        // Admin operation to delete Materials details
        public void DeleteMaterial(int materialId)
        {
            string query = "Call DeleteMaterial(@mm_material_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@mm_material_id", materialId);
            dataAccess.ExecuteNonQuery(command);
        }

        //CRUD for Enrolment table  ********************************************************************************************************************** 
        // Admin creating a new Enrolment
        public void AddEnrolment(Enrolment enr1)
        {
            string query = "CALL AddEnrolment(@ee_course_id, @ee_st_id, @ee_year_number, @ee_PT_FT)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@ee_course_id", enr1.courseID);
            command.Parameters.AddWithValue("@ee_st_id", enr1.ee_stId);
            command.Parameters.AddWithValue("@ee_year_number", enr1.ee_yearNumber);
            command.Parameters.AddWithValue("@ee_PT_FT", enr1.ee_PT_FT);

            dataAccess.ExecuteNonQuery(command);
        }

        //operation to show Enrolment details table 
        public DataTable GetEnrolment()
        {
            string query = "Call getEnrolments()";
            return dataAccess.ExecuteQuery(query);
        }

        // Admin operation to update Enrolment details
        public void UpdateEnrolment(Enrolment enr1)
        {
            string query = "CALL UpdateEnrolment(@ee_enrolment_id, @ee_course_id, @ee_st_id, @ee_year_number, @ee_PT_FT)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@ee_enrolment_id", enr1.ee_enrolmentID);
            command.Parameters.AddWithValue("@ee_course_id", enr1.courseID);
            command.Parameters.AddWithValue("@ee_st_id", enr1.ee_stId);
            command.Parameters.AddWithValue("@ee_year_number", enr1.ee_yearNumber);
            command.Parameters.AddWithValue("@ee_PT_FT", enr1.ee_PT_FT);

            dataAccess.ExecuteNonQuery(command);
        }

        // Admin operation to delete Enrolment details
        public void DeleteEnrolment(int enrId)
        {
            string query = "Call DeleteEnrolment(@ee_enrolment_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@ee_enrolment_id", enrId);
            dataAccess.ExecuteNonQuery(command);
        }

        //CRUD for Course List table  ********************************************************************************************************************** 
        // Admin creating a new Course List
        public void AddCourseList(CourseList course1)
        {
            string query = "CALL AddCourse(@xc_course_code, @xc_course_name, @xc_start_date, @xc_end_date, @xc_normal_accelerated)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@xc_course_code", course1.courseCode);
            command.Parameters.AddWithValue("@xc_course_name", course1.xc_courseName);
            command.Parameters.AddWithValue("@xc_start_date", course1.startDate);
            command.Parameters.AddWithValue("@xc_end_date", course1.endDate);
            command.Parameters.AddWithValue("@xc_normal_accelerated", course1.xc_normal_Accelerated);

            dataAccess.ExecuteNonQuery(command);
        }

        //operation to show Course List details table 
        public DataTable GetCourseList()
        {
            string query = "Call getCourseList()";
            return dataAccess.ExecuteQuery(query);
        }

        // Admin operation to update Course List details
        public void UpdateCourseList(CourseList course1)
        {
            string query = "CALL UpdateCourseList(@xc_course_id, @xc_course_code, @xc_course_name, @xc_start_date, @xc_end_date, @xc_normal_accelerated)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@xc_course_id", course1.courseID);
            command.Parameters.AddWithValue("@xc_course_code", course1.courseCode);
            command.Parameters.AddWithValue("@xc_course_name", course1.xc_courseName);
            command.Parameters.AddWithValue("@xc_start_date", course1.startDate);
            command.Parameters.AddWithValue("@xc_end_date", course1.endDate);
            command.Parameters.AddWithValue("@xc_normal_accelerated", course1.xc_normal_Accelerated);

            dataAccess.ExecuteNonQuery(command);
        }

        // Admin operation to delete Course List details
        public void DeleteCourseList(int course1Id)
        {
            string query = "Call DeleteCourse(@xc_course_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@xc_course_id", course1Id);
            dataAccess.ExecuteNonQuery(command);
        }


        //CRUD for Module Name table  ********************************************************************************************************************** 
        // Admin creating a new  Module Name
        public void AddModule(ModuleName module1)
        {
            string query = "CALL AddModule(@xm_course_id, @xm_module_name, @xm_start_date, @xm_end_date, @xm_cw1_pass_fail, @xm_cw2_mark, @xm_class_room)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@xm_course_id", module1.courseID);
            command.Parameters.AddWithValue("@xm_module_name", module1.xm_moduleName);
            command.Parameters.AddWithValue("@xm_start_date", module1.startDate);
            command.Parameters.AddWithValue("@xm_end_date", module1.endDate);
            command.Parameters.AddWithValue("@xm_cw1_pass_fail", module1.xm_cw1_pass_fail);
            command.Parameters.AddWithValue("@xm_cw2_mark", module1.xm_cw2_mark);
            command.Parameters.AddWithValue("@xm_class_room", module1.xm_class_room);
            
            dataAccess.ExecuteNonQuery(command);
        }

        //operation to show Module Name details table 
        public DataTable GetModuleName()
        {
            string query = "Call getModuleName()";
            return dataAccess.ExecuteQuery(query);
        }

        // Admin operation to update Module Name details
        public void UpdateModule(ModuleName module1)
        {
            string query = "CALL UpdateModule(@xm_module_id, @xm_course_id, @xm_module_name, @xm_start_date, @xm_end_date, @xm_cw1_pass_fail, @xm_cw2_mark, @xm_class_room)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@xm_module_id", module1.xm_moduleId);
            command.Parameters.AddWithValue("@xm_course_id", module1.courseID);
            command.Parameters.AddWithValue("@xm_module_name", module1.xm_moduleName);
            command.Parameters.AddWithValue("@xm_start_date", module1.startDate);
            command.Parameters.AddWithValue("@xm_end_date", module1.endDate);
            command.Parameters.AddWithValue("@xm_cw1_pass_fail", module1.xm_cw1_pass_fail);
            command.Parameters.AddWithValue("@xm_cw2_mark", module1.xm_cw2_mark);
            command.Parameters.AddWithValue("@xm_class_room", module1.xm_class_room);

            dataAccess.ExecuteNonQuery(command);
        }

        // Admin operation to delete Module Name details
        public void DeleteModule(int module1)
        {
            string query = "Call DeleteModule(@xm_module_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@xm_module_id", module1);
            dataAccess.ExecuteNonQuery(command);
        }

        /* New Tables to work on
        //CRUD for Submit Work table  ********************************************************************************************************************** 
        // Admin creating a new Worksheet
        public void AddWorksheet(SubmitWork worksheet1)
        {
            string query = "CALL AddWorksheet(@ww_s_id, @ww_s_Lname, @ww_s_Fname, @ww_s_worksubmit, @ww_s_work_grade)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@ww_s_id", worksheet1.ww_stID);
            command.Parameters.AddWithValue("@ww_s_Lname", worksheet1.ww_sLname);
            command.Parameters.AddWithValue("@ww_s_Fname", worksheet1.ww_sFname);
            command.Parameters.AddWithValue("@ww_s_worksubmit", worksheet1.ww_stWorkSubmit);
            command.Parameters.AddWithValue("@ww_s_work_grade", worksheet1.ww_stWorkGrade);



            dataAccess.ExecuteNonQuery(command);
        }

        //operation to show Worksheet details table 
        public DataTable GetWorksheets()
        {
            string query = "Call getWorksheets()";
            return dataAccess.ExecuteQuery(query);
        }

        // Admin operation to update Worksheet details
        public void UpdateWorksheet(SubmitWork worksheet1)
        {
            string query = "CALL UpdateMaterials(@ww_worksheet_id, @mm_material_id, @mm_module_id, @mm_module_name, @mm_t_id, @mm_material_date_edit, @mm_t_Lname, @mm_t_Fname)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@ww_worksheet_id", worksheet1.ww_stID);
            command.Parameters.AddWithValue("@ww_s_id", worksheet1.ww_stID);
            command.Parameters.AddWithValue("@ww_s_Lname", worksheet1.ww_sLname);
            command.Parameters.AddWithValue("@ww_s_Fname", worksheet1.ww_sFname);
            command.Parameters.AddWithValue("@ww_s_worksubmit", worksheet1.ww_stWorkSubmit);
            command.Parameters.AddWithValue("@ww_s_work_grade", worksheet1.ww_stWorkGrade);

            dataAccess.ExecuteNonQuery(command);
        }

        // Admin operation to delete Worksheet details
        public void DeleteWorksheet(int worksheetId)
        {
            string query = "Call DeleteMaterial(@ww_worksheet_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@ww_worksheet_id", worksheetId);
            dataAccess.ExecuteNonQuery(command);
        }*/


        /* Admin creating a new Timetable
        public void AddTimetable(Timetable table1)
        {
            //string query = "CALL AddTimetable(@xt_module_id, @xt_module_name, @xt_class_room, @xt_class_floor, @xt_class_building, @xt_Lname,@xt_Fname,@xt_class_hours)";
            /*command.Parameters.AddWithValue("@xt_class_floor", table1.xt_classFloor);
            command.Parameters.AddWithValue("@xt_class_building", table1.xt_classBuilding);
            command.Parameters.AddWithValue("@xt_module_name", table1.xt_moduleName);
            command.Parameters.AddWithValue("@xt_Lname", table1.xt_tLname);
            command.Parameters.AddWithValue("@xt_Fname", table1.xt_tFname);
            string query = "CALL AddTimetable(@xt_module_id, @xt_class_room,@xt_t_id,@xt_class_hours)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@xt_module_id", table1.xt_moduleID);
            command.Parameters.AddWithValue("@xt_class_room", table1.xt_classRoom);
            command.Parameters.AddWithValue("@xt_t_id", table1.xt_tId);
            command.Parameters.AddWithValue("@xt_class_hours", table1.xt_classHours);

            dataAccess.ExecuteNonQuery(command);
        }


        // Admin operation to update Timetable details
        public void UpdateTimetable(Timetable table1)
        {
            /* command.Parameters.AddWithValue("@xt_module_name", table1.xt_moduleName);
             command.Parameters.AddWithValue("@xt_class_floor", table1.xt_classFloor);
             command.Parameters.AddWithValue("@xt_Lname", table1.xt_tLname);
             command.Parameters.AddWithValue("@xt_Fname", table1.xt_tFname);
             command.Parameters.AddWithValue("@xt_class_building", table1.xt_classBuilding);
            //string query = "CALL UpdateTimetable(@xt_timetable_id, @xt_module_id, @xt_module_name, @xt_class_room, @xt_class_floor, @xt_class_building, @xt_Lname,@xt_Fname,@xt_class_hours)";
            string query = "CALL UpdateTimetable(@xt_timetable_id, @xt_module_id, @xt_class_room,@xt_t_id, @xt_class_hours)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@xt_timetable_id", table1.xt_timetableID);
            command.Parameters.AddWithValue("@xt_module_id", table1.xt_moduleID);
            command.Parameters.AddWithValue("@xt_class_room", table1.xt_classRoom);
            command.Parameters.AddWithValue("@xt_t_id", table1.xt_tId);
            command.Parameters.AddWithValue("@xt_class_hours", table1.xt_classHours);

            dataAccess.ExecuteNonQuery(command);
        }

        // Admin operation to delete Timetable details
        public void DeleteTimetable(int timetableId)
        {
            string query = "Call DeleteTimetable(@xt_timetable_id)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@xt_timetable_id", timetableId);
            dataAccess.ExecuteNonQuery(command);
        }*/






    }
}
