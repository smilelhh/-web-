using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.IDAL;
using System.Configuration;
using System.Reflection;
using DAL.SQLServerDAL;

namespace DAL.DALFactory
{
    public class DALFactory
    {
        private static Assembly assembly = Assembly.Load(ConfigurationManager.AppSettings["DALPath"].ToString());
  
        public static IAttendanceDAL createAttendanceDAL()
        {

            Type type = assembly.GetType(ConfigurationManager.AppSettings["AttendanceDALClass"].ToString());

            return Activator.CreateInstance(type) as AttendanceDAL;
        }

        public static IClassDAL createClassDAL()
        {

            Type type = assembly.GetType(ConfigurationManager.AppSettings["ClassDALClass"].ToString());

            return Activator.CreateInstance(type) as ClassDAL;
        }
        public static ICourseDAL createCourseDAL()
        {

            Type type = assembly.GetType(ConfigurationManager.AppSettings["CourseDALClass"].ToString());

            return Activator.CreateInstance(type) as CourseDAL;
        }

        public static ICourseTableDAL createCourseTableDAL()
        {

            Type type = assembly.GetType(ConfigurationManager.AppSettings["CourseTableDALClass"].ToString());

            return Activator.CreateInstance(type) as CourseTableDAL;
        }

        public static IStaffDAL createStaffDAL()
        {

            Type type = assembly.GetType(ConfigurationManager.AppSettings["StaffDALClass"].ToString());

            return Activator.CreateInstance(type) as StaffDAL;
        }

        public static IStudentDAL createStudentDAL()
        {

            Type type = assembly.GetType(ConfigurationManager.AppSettings["StudentDALClass"].ToString());

            return Activator.CreateInstance(type) as StudentDAL;
        }

        public static ITeacherDAL createTeacherDAL()
        {

            Type type = assembly.GetType(ConfigurationManager.AppSettings["TeacherDALClass"].ToString());

            return Activator.CreateInstance(type) as TeacherDAL;
        }

        public static IUserDAL createUserDAL()
        {

            Type type = assembly.GetType(ConfigurationManager.AppSettings["UserDALClass"].ToString());

            return Activator.CreateInstance(type) as UserDAL;
        }

    }
}
