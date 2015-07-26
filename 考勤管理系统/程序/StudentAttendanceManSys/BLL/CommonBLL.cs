using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using Utility;
using Utility.Global;

namespace BLL
{
    public class CommonBLL
    {

        /// <summary>
        /// 处理员工信息
        /// </summary>
        /// <returns></returns>
        public DataTable getStaffs()
        {
            //创建一个新的DataTable表
            DataTable staffDt = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            staffDt.Columns.Add(colNumber);

            staffDt.Columns.Add("name", Type.GetType("System.String"));
            staffDt.Columns.Add("gender", Type.GetType("System.String"));
            staffDt.Columns.Add("phone", Type.GetType("System.String"));
            staffDt.Columns.Add("type", Type.GetType("System.String"));
            staffDt.Columns.Add("ID", Type.GetType("System.String"));
            #endregion

            StaffBLL staffBLL = new StaffBLL();
            DataTable dt = staffBLL.getAll().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建新的一行数据
                DataRow dr = staffDt.NewRow();
                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给name赋值
                dr[1] = dt.Rows[i][1];

                //给gender赋值
                dr[2] = dt.Rows[i][2];

                //给phone赋值
                dr[3] = dt.Rows[i][4];

                //给type赋值
                dr[4] = dt.Rows[i][5];

                //给ID赋值
                dr[5] = dt.Rows[i][0];

                staffDt.Rows.Add(dr);
                #endregion
            }

            return staffDt;
        }

        /// <summary>
        /// 处理教师信息
        /// </summary>
        /// <returns></returns>
        public DataTable getTeachers()
        {
            //创建一个新的DataTable表
            DataTable teacherDt = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            teacherDt.Columns.Add(colNumber);

            teacherDt.Columns.Add("teacherId", Type.GetType("System.String"));
            teacherDt.Columns.Add("name", Type.GetType("System.String"));
            teacherDt.Columns.Add("gender", Type.GetType("System.String"));
            teacherDt.Columns.Add("title", Type.GetType("System.String"));
            teacherDt.Columns.Add("phone", Type.GetType("System.String"));
            teacherDt.Columns.Add("ID", Type.GetType("System.String"));
            #endregion

            TeacherBLL teachBLL = new TeacherBLL();
            DataTable dt = teachBLL.getAll().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建新的一行数据
                DataRow dr = teacherDt.NewRow();
                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给teacherId赋值
                dr[1] = dt.Rows[i][1];

                //给name赋值
                dr[2] = dt.Rows[i][2];

                //给gender赋值
                dr[3] = dt.Rows[i][3];

                //给title赋值
                dr[4] = dt.Rows[i][5];

                //给phone赋值
                dr[5] = dt.Rows[i][6];

                //给ID赋值
                dr[6] = dt.Rows[i][0];

                teacherDt.Rows.Add(dr);
                #endregion
            }

            return teacherDt;
        }

        /// <summary>
        /// 处理学生信息
        /// </summary>
        /// <returns></returns>
        public DataTable getStudents()
        {
            //创建一个新的DataTable表
            DataTable studentDt = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            studentDt.Columns.Add(colNumber);

            studentDt.Columns.Add("stuId", Type.GetType("System.String"));
            studentDt.Columns.Add("name", Type.GetType("System.String"));
            studentDt.Columns.Add("gender", Type.GetType("System.String"));
            studentDt.Columns.Add("className", Type.GetType("System.String"));
            studentDt.Columns.Add("phone", Type.GetType("System.String"));
            studentDt.Columns.Add("ID", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            StudentBLL studBLL = new StudentBLL();
            DataTable dt = studBLL.getAll().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建新的一行数据
                DataRow dr = studentDt.NewRow();
                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给stuId赋值
                dr[1] = dt.Rows[i][1];

                //给name赋值
                dr[2] = dt.Rows[i][2];

                //给gender赋值
                dr[3] = dt.Rows[i][3];

                //给className赋值
                dr[4] = classBLL.get(dt.Rows[i]["classID"].ToString()).Name;

                //给phone赋值
                dr[5] = dt.Rows[i][5];

                //给ID赋值
                dr[6] = dt.Rows[i][0];

                studentDt.Rows.Add(dr);
                #endregion
            }

            return studentDt;
        }

        /// <summary>
        /// 处理课程信息
        /// </summary>
        /// <returns></returns>
        public DataTable getCourses()
        {
            //创建一个新的DataTable表
            DataTable courseDt = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            courseDt.Columns.Add(colNumber);

            courseDt.Columns.Add("name", Type.GetType("System.String"));
            courseDt.Columns.Add("credit", Type.GetType("System.String"));
            courseDt.Columns.Add("schoolHour", Type.GetType("System.String"));
            courseDt.Columns.Add("ID", Type.GetType("System.String"));
            #endregion

            CourseBLL courBLL = new CourseBLL();
            DataTable dt = courBLL.getAll().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建新的一行数据
                DataRow dr = courseDt.NewRow();
                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给name赋值
                dr[1] = dt.Rows[i][1];

                //给credit赋值
                dr[2] = dt.Rows[i][2];

                //给schoolHour赋值
                dr[3] = dt.Rows[i][3];

                //给ID赋值
                dr[4] = dt.Rows[i][0];

                courseDt.Rows.Add(dr);
                #endregion
            }

            return courseDt;
        }

        /// <summary>
        /// 处理课程表信息
        /// </summary>
        /// <returns></returns>
        public DataTable getCourseTables()
        {
            //创建一个新的DataTable表
            DataTable ctDt = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            ctDt.Columns.Add(colNumber);

            ctDt.Columns.Add("courseName", Type.GetType("System.String"));
            ctDt.Columns.Add("teacherName", Type.GetType("System.String"));
            ctDt.Columns.Add("className", Type.GetType("System.String"));
            ctDt.Columns.Add("semester", Type.GetType("System.String"));
            ctDt.Columns.Add("ID", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            CourseBLL courseBLL = new CourseBLL();
            TeacherBLL teacherBLL = new TeacherBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();
            DataTable dt = ctBLL.getAll().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Course cour = courseBLL.get(dt.Rows[i]["courId"].ToString());
                Teacher teacher = teacherBLL.get(dt.Rows[i]["teachID"].ToString());
                Class clazz = classBLL.get(dt.Rows[i]["classID"].ToString());

                string selectFilter = "courseName='" + cour.Name + "' and teacherName='" + teacher.Name + "' and className='" + clazz.Name;
                selectFilter += "' and semester='" + dt.Rows[i]["semester"].ToString() + "'";
                if (ctDt.Select(selectFilter).Length == 0)
                {

                    //创建新的一行数据
                    DataRow dr = ctDt.NewRow();
                    #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                    //给courseName赋值
                    dr[1] = cour.Name;

                    //给teacherName赋值
                    dr[2] = teacher.Name;

                    //给className赋值
                    dr[3] = clazz.Name;

                    //给semester赋值
                    dr[4] = dt.Rows[i]["semester"];

                    //给ID赋值
                    dr[5] = dt.Rows[i][0];

                    ctDt.Rows.Add(dr);
                    #endregion

                }
            }

            return ctDt;
        }

        /// <summary>
        /// 处理课程表详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable getDetailCourseTables(string id)
        {
            //创建一个新的DataTable表
            DataTable ctDt = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            ctDt.Columns.Add(colNumber);

            ctDt.Columns.Add("courseName", Type.GetType("System.String"));
            ctDt.Columns.Add("teacherName", Type.GetType("System.String"));
            ctDt.Columns.Add("className", Type.GetType("System.String"));
            ctDt.Columns.Add("semester", Type.GetType("System.String"));
            ctDt.Columns.Add("week", Type.GetType("System.String"));
            ctDt.Columns.Add("weekDay", Type.GetType("System.String"));
            ctDt.Columns.Add("courseTime", Type.GetType("System.String"));
            ctDt.Columns.Add("ID", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            CourseBLL courseBLL = new CourseBLL();
            TeacherBLL teacherBLL = new TeacherBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();

            CourseTable ct = ctBLL.get(id);

            DataTable dt = ctBLL.getAll().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Course cour = courseBLL.get(ct.CourId);
                Teacher teacher = teacherBLL.get(ct.TeachID);
                Class clazz = classBLL.get(ct.ClassID);

                string selectFilter = "courseName='" + cour.Name + "' and teacherName='" + teacher.Name + "' and className='" + clazz.Name;
                selectFilter += "' and semester='" + ct.Semester + "' and weekDay='" + dt.Rows[i]["weekDay"].ToString() + "' and courseTime='" + dt.Rows[i]["courseTime"].ToString() + "'";
                if (ctDt.Select(selectFilter).Length == 0)
                {
                    string filter = "courId='" + cour.Id + "' and teachID='" + teacher.Id + "' and classID='" + clazz.Id;
                    filter += "' and semester='" + ct.Semester + "' and weekDay='" + dt.Rows[i]["weekDay"].ToString() + "' and courseTime='" + dt.Rows[i]["courseTime"].ToString() + "'";

                    List<DataRow> tempList = dt.Select(filter).ToList<DataRow>();
                    if (tempList.Count != 0)
                    {

                        //创建新的一行数据
                        DataRow dr = ctDt.NewRow();
                        #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                        //给courseName赋值
                        dr[1] = cour.Name;

                        //给teacherName赋值
                        dr[2] = teacher.Name;

                        //给className赋值
                        dr[3] = clazz.Name;

                        //给semester赋值
                        dr[4] = ct.Semester;

                        //给week赋值           
                        dr[5] = tempList.Min(r => int.Parse(r["week"].ToString())) + "-" + tempList.Max(r => int.Parse(r["week"].ToString()));

                        //给weekDay赋值
                        dr[6] = dt.Rows[i]["weekDay"];

                        //给courseTime赋值
                        dr[7] = dt.Rows[i]["courseTime"];

                        //给ID赋值
                        dr[8] = tempList[0]["ID"];

                        ctDt.Rows.Add(dr);
                        #endregion
                    }

                }
            }

            return ctDt;
        }

        /// <summary>
        /// 处理班级信息
        /// </summary>
        /// <returns></returns>
        public DataTable getClasses()
        {
            //创建一个新的DataTable表
            DataTable classesDt = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            classesDt.Columns.Add(colNumber);

            classesDt.Columns.Add("depart", Type.GetType("System.String"));
            classesDt.Columns.Add("grade", Type.GetType("System.String"));
            classesDt.Columns.Add("name", Type.GetType("System.String"));
            classesDt.Columns.Add("studCount", Type.GetType("System.String"));
            classesDt.Columns.Add("monitorName", Type.GetType("System.String"));
            classesDt.Columns.Add("teacherName", Type.GetType("System.String"));
            classesDt.Columns.Add("ID", Type.GetType("System.String"));
            #endregion

            TeacherBLL teachBLL = new TeacherBLL();
            StudentBLL studBLL = new StudentBLL();
            ClassBLL classBLL = new ClassBLL();
            DataTable dt = classBLL.getAll().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建新的一行数据
                DataRow dr = classesDt.NewRow();
                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给depart赋值
                dr[1] = dt.Rows[i][1];
                //给grade赋值
                dr[2] = dt.Rows[i][2];
                //给name赋值
                dr[3] = dt.Rows[i][3];
                //给studCount赋值
                dr[4] = dt.Rows[i][4];
                //给monitorName赋值
                if (!string.IsNullOrEmpty(dt.Rows[i][5].ToString()))
                    dr[5] = studBLL.get(dt.Rows[i][5].ToString()).Name;
                else
                    dr[5] = "无";
                //给teacherName赋值
                if (!string.IsNullOrEmpty(dt.Rows[i][6].ToString()))
                    dr[6] = teachBLL.get(dt.Rows[i][6].ToString()).Name;
                else
                    dr[6] = "无";

                //给ID赋值
                dr[7] = dt.Rows[i][0];

                classesDt.Rows.Add(dr);
                #endregion
            }

            return classesDt;
        }

        /// <summary>
        /// 通过教师ID取得所教的班级
        /// </summary>
        /// <returns></returns>
        public DataTable getClassesByTeacherId(string teachID)
        {
            //创建一个新的DataTable表
            DataTable teachClassesDt = new DataTable();
            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            teachClassesDt.Columns.Add(colNumber);

            teachClassesDt.Columns.Add("className", Type.GetType("System.String"));
            teachClassesDt.Columns.Add("classID", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            DataTable dt = classBLL.getByTeacherId(teachID).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建新的一行数据
                DataRow dr = teachClassesDt.NewRow();
                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给className赋值
                dr[1] = dt.Rows[i]["name"];

                //给classID赋值            
                dr[2] = dt.Rows[i]["ID"];

                teachClassesDt.Rows.Add(dr);
                #endregion
            }

            return teachClassesDt;
        }

        /// <summary>
        /// 通过教师ID取得教师考勤信息
        /// </summary>
        /// <param name="teachID"></param>
        /// <returns></returns>
        public DataTable getWorkAttendanceByTeachID(string teachID)
        {
            //创建一个新的DataTable表
            DataTable teachCourseDt = new DataTable();
            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("ID");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            teachCourseDt.Columns.Add(colNumber);
            teachCourseDt.Columns.Add("week", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("weekDay", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("className", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("courseName", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("teacherName", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("place", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("courseTime", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("recorderID", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("classID", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("courTableID", Type.GetType("System.String"));

            #endregion

            TeacherBLL teacherBll = new TeacherBLL();

            CourseTableBLL courseTbBll = new CourseTableBLL();


            List<DataRow> list = courseTbBll.getAll().Tables[0].Select("semester='" + GlobalVars.SEMESTER + "' and teachID='" + teachID + "'").ToList();

            CourseBLL courseBll = new CourseBLL();

            ClassBLL classBll = new ClassBLL();

            AttendanceBLL attendanceBll = new AttendanceBLL();


            foreach (DataRow tempDr in list)
            {
                //通过teachID取得teacher信息
                Teacher teacher = teacherBll.get(tempDr["teachID"].ToString());
                //通过classID取得class信息
                Class cla = classBll.get(tempDr["classID"].ToString());
                //通过courId取得course信息
                Course course = courseBll.get(tempDr["courId"].ToString());
                DataTable attendanceDt = attendanceBll.getByCourTableIdAboutTeacher(tempDr["ID"].ToString()).Tables[0];
                //创建新的一行数据
                DataRow dr = teachCourseDt.NewRow();
                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给week赋值
                dr[1] = "第" + tempDr["week"] + "周";
                //给weekDay赋值
                dr[2] = tempDr["weekDay"];
                //给className赋值
                dr[3] = cla.Name;
                //给courseName赋值
                dr[4] = course.Name;
                //给teacherName赋值
                dr[5] = teacher.Name;
                //给place赋值
                dr[6] = tempDr["place"];
                //给courseTime赋值
                dr[7] = tempDr["courseTime"];
                //判断是否登记
                if (attendanceDt.Rows.Count == 0)
                    dr[8] = "未登记";
                else
                    dr[8] = "已登记";

                dr[9] = cla.Id;
                dr[10] = tempDr["ID"];
                teachCourseDt.Rows.Add(dr);
                #endregion
            }
            return teachCourseDt;

        }

        /// <summary>
        /// 通过班级ID取得班长考勤信息
        /// </summary>
        /// <param name="classID"></param>
        /// <returns></returns>
        public DataTable getWorkAttendanceByClassID(string classID)
        {
            //创建一个新的DataTable表
            DataTable teachCourseDt = new DataTable();
            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("ID");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            teachCourseDt.Columns.Add(colNumber);
            teachCourseDt.Columns.Add("week", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("weekDay", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("className", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("courseName", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("teacherName", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("place", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("courseTime", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("recorderID", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("classID", Type.GetType("System.String"));
            teachCourseDt.Columns.Add("courTableID", Type.GetType("System.String"));

            #endregion

            TeacherBLL teacherBll = new TeacherBLL();

            CourseTableBLL courseTbBll = new CourseTableBLL();


            List<DataRow> list = courseTbBll.getAll().Tables[0].Select("semester='" + GlobalVars.SEMESTER + "' and classID='" + classID + "'").ToList();

            CourseBLL courseBll = new CourseBLL();

            ClassBLL classBll = new ClassBLL();

            AttendanceBLL attendanceBll = new AttendanceBLL();


            foreach (DataRow tempDr in list)
            {
                //通过teachID取得teacher信息
                Teacher teacher = teacherBll.get(tempDr["teachID"].ToString());
                //通过classID取得class信息
                Class cla = classBll.get(tempDr["classID"].ToString());
                //通过courId取得course信息
                Course course = courseBll.get(tempDr["courId"].ToString());
                DataTable attendanceDt = attendanceBll.getByCourTableIdAboutMonitor(tempDr["ID"].ToString()).Tables[0];
                //创建新的一行数据
                DataRow dr = teachCourseDt.NewRow();
                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给week赋值
                dr[1] = "第" + tempDr["week"] + "周";
                //给weekDay赋值
                dr[2] = tempDr["weekDay"];
                //给className赋值
                dr[3] = cla.Name;
                //给courseName赋值
                dr[4] = course.Name;
                //给teacherName赋值
                dr[5] = teacher.Name;
                //给place赋值
                dr[6] = tempDr["place"];
                //给courseTime赋值
                dr[7] = tempDr["courseTime"];
                //判断是否登记
                if (attendanceDt.Rows.Count == 0)
                    dr[8] = "未登记";
                else
                    dr[8] = "已登记";

                dr[9] = cla.Id;
                dr[10] = tempDr["ID"];
                teachCourseDt.Rows.Add(dr);
                #endregion
            }
            return teachCourseDt;

        }

        /// <summary>
        /// 通过班级ID得到每周的平均到课率
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="week"></param>
        /// <param name="classID"></param>
        /// <returns></returns>
        public DataTable getWeekAverageAttendaceRateByClassID(string classID, Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendaceDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendaceDt.Columns.Add(colNumber);

            attendaceDt.Columns.Add("week", Type.GetType("System.String"));
            attendaceDt.Columns.Add("AverageAttendaceRate", Type.GetType("System.String"));
            attendaceDt.Columns.Add("classID", Type.GetType("System.String"));
            #endregion

            CourseTableBLL ctBLL = new CourseTableBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();

            DataTable dt = null;
            if (isTeacherRecord)
                dt = attendBLL.getByClassIdAboutTeacher(classID).Tables[0];
            else
                dt = attendBLL.getByClassIdAboutMonitor(classID).Tables[0];

            //根据课程表ID去除重复行
            DataView dv = new DataView(dt);
            dt = dv.ToTable(true, "courTableID");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CourseTable ct = ctBLL.get(dt.Rows[i]["courTableID"].ToString());

                if (attendaceDt.Select("week='第" + ct.Week + "周'").Length == 0)
                {

                    //创建新的一行数据
                    DataRow dr = attendaceDt.NewRow();
                    #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                    //给week赋值
                    dr[1] = "第" + ct.Week + "周";

                    //给AverageAttendaceRate赋值      
                    DataTable attendDt = getWeekDetailAttendaceRate(ct.Week, classID, isTeacherRecord);
                    dr[2] = FormatUtil.doubleToPercent(calculateAverageAttendRate(attendDt, "attendaceRate"));

                    //给classID赋值
                    dr[3] = ct.ClassID;

                    attendaceDt.Rows.Add(dr);
                    #endregion
                }
            }

            return attendaceDt;
        }

        /// <summary>
        /// 得到每周考勤的详细信息
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="week"></param>
        /// <param name="classID"></param>
        /// <returns></returns>
        public DataTable getWeekDetailAttendaceRate(string week, string classID, Boolean isTeacherRecord)
        {

            //创建一个新的DataTable表
            DataTable attendaceDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendaceDt.Columns.Add(colNumber);

            attendaceDt.Columns.Add("className", Type.GetType("System.String"));
            attendaceDt.Columns.Add("week", Type.GetType("System.String"));
            attendaceDt.Columns.Add("weekDay", Type.GetType("System.String"));
            attendaceDt.Columns.Add("courseTime", Type.GetType("System.String"));
            attendaceDt.Columns.Add("attendaceRate", Type.GetType("System.String"));
            attendaceDt.Columns.Add("courTableID", Type.GetType("System.String"));
            #endregion

            CourseTableBLL ctBLL = new CourseTableBLL();
            ClassBLL classBLL = new ClassBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();

            DataTable dt = null;
            if (isTeacherRecord)
                dt = attendBLL.getByClassIdAboutTeacher(classID).Tables[0];
            else
                dt = attendBLL.getByClassIdAboutMonitor(classID).Tables[0];

            //根据课程表ID去除重复行
            DataView dv = new DataView(dt);
            dt = dv.ToTable(true, "courTableID");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                CourseTable ct = ctBLL.get(dt.Rows[i]["courTableID"].ToString());

                if (ct.Week.Equals(week))
                {
                    //创建新的一行数据
                    DataRow dr = attendaceDt.NewRow();

                    #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                    //给className赋值
                    dr[1] = classBLL.get(ct.ClassID).Name;

                    //给week赋值            
                    dr[2] = "第" + ct.Week + "周";

                    //给weekDay赋值            
                    dr[3] = ct.WeekDay;

                    //给courseTime赋值            
                    dr[4] = ct.CourseTime;

                    //给attendaceRate赋值            
                    dr[5] = FormatUtil.doubleToPercent(calculateAttendRate(dt.Rows[i]["courTableID"].ToString(), isTeacherRecord));

                    //给courTableID赋值            
                    dr[6] = ct.Id;

                    attendaceDt.Rows.Add(dr);
                    #endregion
                }
            }

            return attendaceDt;
        }
        public DataTable getCourseDetailAttendaceRate(string teachID, string classID, string courId, Boolean isTeacherRecord)
        {

            //创建一个新的DataTable表
            DataTable attendaceDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendaceDt.Columns.Add(colNumber);

            attendaceDt.Columns.Add("className", Type.GetType("System.String"));
            attendaceDt.Columns.Add("week", Type.GetType("System.String"));
            attendaceDt.Columns.Add("weekDay", Type.GetType("System.String"));
            attendaceDt.Columns.Add("courseTime", Type.GetType("System.String"));
            attendaceDt.Columns.Add("place", Type.GetType("System.String"));
            attendaceDt.Columns.Add("attendanceRate", Type.GetType("System.String"));
            attendaceDt.Columns.Add("courTableID", Type.GetType("System.String"));
            #endregion

            CourseTableBLL ctBLL = new CourseTableBLL();
            ClassBLL classBLL = new ClassBLL();
            AttendanceBLL attendBll = new AttendanceBLL();

            DataTable dt = null;
            if (isTeacherRecord)
                dt = attendBll.getByClassIdAboutTeacher(classID).Tables[0];
            else
                dt = attendBll.getByClassIdAboutMonitor(classID).Tables[0];

            //根据courTableID去除重复行
            DataView dv = dt.DefaultView;
            dt = dv.ToTable(true, "courTableID");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                CourseTable ct = ctBLL.get(dt.Rows[i]["courTableID"].ToString());

                if (ct.ClassID.Equals(classID) && ct.CourId.Equals(courId) & ct.TeachID.Equals(teachID))
                {
                    //创建新的一行数据
                    DataRow dr = attendaceDt.NewRow();

                    #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                    //给className赋值
                    dr[1] = classBLL.get(ct.ClassID).Name;

                    //给week赋值            
                    dr[2] = "第" + ct.Week + "周";

                    //给weekDay赋值            
                    dr[3] = ct.WeekDay;

                    //给courseTime赋值            
                    dr[4] = ct.CourseTime;

                    //给place赋值
                    dr[5] = ct.Place;

                    //给attendaceRate赋值            
                    dr[6] = FormatUtil.doubleToPercent(calculateAttendRate(dt.Rows[i]["courTableID"].ToString(), isTeacherRecord));

                    //给courTableID赋值            
                    dr[7] = ct.Id;

                    attendaceDt.Rows.Add(dr);
                    #endregion
                }
            }

            return attendaceDt;
        }

        /// <summary>
        /// 得到缺勤学生信息
        /// </summary>
        /// <param name="courTableID"></param>
        /// <returns></returns>
        public DataTable getAbsentStudent(string courTableID, Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable absentDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            absentDt.Columns.Add(colNumber);

            absentDt.Columns.Add("name", Type.GetType("System.String"));
            absentDt.Columns.Add("status", Type.GetType("System.String"));
            #endregion

            StudentBLL stuBLL = new StudentBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();
            DataTable dt = null;
            if (isTeacherRecord)
                dt = attendBLL.getByCourTableIdAboutTeacher(courTableID).Tables[0];
            else
                dt = attendBLL.getByCourTableIdAboutMonitor(courTableID).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!dt.Rows[i]["status"].Equals("正常"))
                {
                    //创建新的一行数据
                    DataRow dr = absentDt.NewRow();

                    #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                    //给name赋值
                    dr[1] = stuBLL.get(dt.Rows[i]["studID"].ToString()).Name;

                    //给status赋值            
                    dr[2] = dt.Rows[i]["status"];

                    absentDt.Rows.Add(dr);

                    #endregion
                }

            }

            return absentDt;
        }

        /// <summary>
        /// 得到班级学生出勤统计
        /// </summary>
        /// <param name="classID"></param>
        /// <returns></returns>
        public DataTable getClassStudentAttendStatistics(string classID, string recorderID, Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendStatistDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendStatistDt.Columns.Add(colNumber);

            attendStatistDt.Columns.Add("name", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("truancy", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("late", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("leaveEarly", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("thingLeave", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("sickleave", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("studID", Type.GetType("System.String"));
            #endregion

            AttendanceBLL attendBLL = new AttendanceBLL();
            StudentBLL studBLL = new StudentBLL();
            DataTable dt = studBLL.getByClassId(classID).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataTable attendDt = null;
                if (isTeacherRecord)
                    attendDt = attendBLL.getByStudIdAboutTeacher(dt.Rows[i]["ID"].ToString()).Tables[0];
                else
                    attendDt = attendBLL.getByStudIdAboutMonitor(dt.Rows[i]["ID"].ToString()).Tables[0];

                List<DataRow> attendList = null;
                if (!string.IsNullOrEmpty(recorderID))
                {
                    attendList = attendDt.Select("recorderID='" + recorderID + "'").ToList();
                }
                else
                    attendList = attendDt.Select().ToList();


                //创建新的一行数据
                DataRow dr = attendStatistDt.NewRow();

                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给name赋值
                dr[1] = dt.Rows[i]["name"];

                //给truancy赋值            
                dr[2] = attendList.Count(tempDr => tempDr["status"].ToString().Equals("旷课"));

                //给late赋值            
                dr[3] = attendList.Count(tempDr => tempDr["status"].ToString().Equals("迟到"));

                //给leaveEarly赋值            
                dr[4] = attendList.Count(tempDr => tempDr["status"].ToString().Equals("早退"));

                //给thingLeave赋值            
                dr[5] = attendList.Count(tempDr => tempDr["status"].ToString().Equals("事假"));

                //给sickleave赋值            
                dr[6] = attendList.Count(tempDr => tempDr["status"].ToString().Equals("病假"));

                //给studID赋值            
                dr[7] = dt.Rows[i]["ID"];

                attendStatistDt.Rows.Add(dr);

                #endregion
            }

            return attendStatistDt;
        }

        /// <summary>
        /// 得到每周次学生出勤统计
        /// </summary>
        /// <param name="classID"></param>
        /// <returns></returns>
        public DataTable getWeekStudentAttendStatistics(Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendStatistDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendStatistDt.Columns.Add(colNumber);

            attendStatistDt.Columns.Add("name", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("className", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("week", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("truancy", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("late", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("leaveEarly", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("thingLeave", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("sickleave", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("studID", Type.GetType("System.String"));
            #endregion

            CourseTableBLL ctBLL = new CourseTableBLL();
            ClassBLL classBLL = new ClassBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();
            StudentBLL studBLL = new StudentBLL();
            DataTable dt = studBLL.getAll().Tables[0];


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataTable tempDt = null;
                if (isTeacherRecord)
                    tempDt = attendBLL.getByStudIdAboutTeacher(dt.Rows[i]["ID"].ToString()).Tables[0];
                else
                    tempDt = attendBLL.getByStudIdAboutMonitor(dt.Rows[i]["ID"].ToString()).Tables[0];


                DataView dv = new DataView(tempDt);
                tempDt = dv.ToTable(true, "courTableID");

                foreach (DataRow tempDr in tempDt.Rows)
                {
                    CourseTable ct = ctBLL.get(tempDr["courTableID"].ToString());
                    string filter = "studID='" + dt.Rows[i]["ID"].ToString() + "' and week='第" + ct.Week + "周'";
                    if (attendStatistDt.Select(filter).Length == 0)
                    {

                        DataTable attendDt = null;
                        if (isTeacherRecord)
                            attendDt = attendBLL.getByParasAboutTeacher(dt.Rows[i]["ID"].ToString(), ct.Week).Tables[0];
                        else
                            attendDt = attendBLL.getByParasAboutMonitor(dt.Rows[i]["ID"].ToString(), ct.Week).Tables[0];

                        //创建新的一行数据
                        DataRow dr = attendStatistDt.NewRow();

                        #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                        //给name赋值
                        dr[1] = dt.Rows[i]["name"];

                        //给className赋值
                        dr[2] = classBLL.get(ct.ClassID).Name; ;

                        //给week赋值
                        dr[3] = "第" + ct.Week + "周";

                        //给truancy赋值            
                        dr[4] = attendDt.Select("status='旷课'").Length;

                        //给late赋值            
                        dr[5] = attendDt.Select("status='迟到'").Length;

                        //给leaveEarly赋值            
                        dr[6] = attendDt.Select("status='早退'").Length;

                        //给thingLeave赋值            
                        dr[7] = attendDt.Select("status='事假'").Length;

                        //给sickleave赋值            
                        dr[8] = attendDt.Select("status='病假'").Length;

                        //给studID赋值            
                        dr[9] = dt.Rows[i]["ID"];

                        attendStatistDt.Rows.Add(dr);

                        #endregion
                    }
                }
            }

            return attendStatistDt;
        }

        /// <summary>
        /// 比较教师和班长登记的学生出勤统计
        /// </summary>
        /// <returns></returns>
        public DataTable getComparedAttendStatistics()
        {
            //创建一个新的DataTable表
            DataTable comparedDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            comparedDt.Columns.Add(colNumber);

            comparedDt.Columns.Add("name", Type.GetType("System.String"));
            comparedDt.Columns.Add("className", Type.GetType("System.String"));
            comparedDt.Columns.Add("t_truancy", Type.GetType("System.String"));
            comparedDt.Columns.Add("t_late", Type.GetType("System.String"));
            comparedDt.Columns.Add("t_leaveEarly", Type.GetType("System.String"));
            comparedDt.Columns.Add("t_thingLeave", Type.GetType("System.String"));
            comparedDt.Columns.Add("t_sickleave", Type.GetType("System.String"));
            comparedDt.Columns.Add("m_truancy", Type.GetType("System.String"));
            comparedDt.Columns.Add("m_late", Type.GetType("System.String"));
            comparedDt.Columns.Add("m_leaveEarly", Type.GetType("System.String"));
            comparedDt.Columns.Add("m_thingLeave", Type.GetType("System.String"));
            comparedDt.Columns.Add("m_sickleave", Type.GetType("System.String"));
            comparedDt.Columns.Add("studID", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();
            StudentBLL studBLL = new StudentBLL();
            DataTable dt = studBLL.getAll().Tables[0];


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable t_attendDt = attendBLL.getByStudIdAboutTeacher(dt.Rows[i]["ID"].ToString()).Tables[0];

                DataTable m_attendDt = attendBLL.getByStudIdAboutMonitor(dt.Rows[i]["ID"].ToString()).Tables[0];

                //创建新的一行数据
                DataRow dr = comparedDt.NewRow();

                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给name赋值
                dr[1] = dt.Rows[i]["name"];

                //给className赋值
                dr[2] = classBLL.get(studBLL.get(dt.Rows[i]["ID"].ToString()).ClassID).Name; ;

                //给t_truancy赋值            
                dr[3] = t_attendDt.Select("status='旷课'").Length;

                //给t_late赋值            
                dr[4] = t_attendDt.Select("status='迟到'").Length;

                //给t_leaveEarly赋值            
                dr[5] = t_attendDt.Select("status='早退'").Length;

                //给t_thingLeave赋值            
                dr[6] = t_attendDt.Select("status='事假'").Length;

                //给t_sickleave赋值            
                dr[7] = t_attendDt.Select("status='病假'").Length;

                //给m_truancy赋值            
                dr[8] = m_attendDt.Select("status='旷课'").Length;

                //给m_late赋值            
                dr[9] = m_attendDt.Select("status='迟到'").Length;

                //给m_leaveEarly赋值            
                dr[10] = m_attendDt.Select("status='早退'").Length;

                //给m_thingLeave赋值            
                dr[11] = m_attendDt.Select("status='事假'").Length;

                //给m_sickleave赋值            
                dr[12] = m_attendDt.Select("status='病假'").Length;

                //给studID赋值            
                dr[13] = dt.Rows[i]["ID"];

                comparedDt.Rows.Add(dr);

                #endregion
            }

            return comparedDt;
        }

        /// <summary>
        /// 得到全院学生出勤统计
        /// </summary>
        /// <returns></returns>
        public DataTable getStudentAttendStatistics(Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendStatistDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendStatistDt.Columns.Add(colNumber);

            attendStatistDt.Columns.Add("name", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("className", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("truancy", Type.GetType("System.Int32"));
            attendStatistDt.Columns.Add("late", Type.GetType("System.Int32"));
            attendStatistDt.Columns.Add("leaveEarly", Type.GetType("System.Int32"));
            attendStatistDt.Columns.Add("thingLeave", Type.GetType("System.Int32"));
            attendStatistDt.Columns.Add("sickLeave", Type.GetType("System.Int32"));
            attendStatistDt.Columns.Add("studID", Type.GetType("System.Int32"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();
            StudentBLL studBLL = new StudentBLL();
            DataTable dt = studBLL.getAll().Tables[0];


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataTable attendDt = null;
                if (isTeacherRecord)
                    attendDt = attendBLL.getByStudIdAboutTeacher(dt.Rows[i]["ID"].ToString()).Tables[0];
                else
                    attendDt = attendBLL.getByStudIdAboutMonitor(dt.Rows[i]["ID"].ToString()).Tables[0];

                //创建新的一行数据
                DataRow dr = attendStatistDt.NewRow();

                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给name赋值
                dr[1] = dt.Rows[i]["name"];

                //给className赋值
                dr[2] = classBLL.get(dt.Rows[i]["classID"].ToString()).Name;

                //给truancy赋值            
                dr[3] = attendDt.Select("status='旷课'").Length;

                //给late赋值            
                dr[4] = attendDt.Select("status='迟到'").Length;

                //给leaveEarly赋值            
                dr[5] = attendDt.Select("status='早退'").Length;

                //给thingLeave赋值            
                dr[6] = attendDt.Select("status='事假'").Length;

                //给sickleave赋值            
                dr[7] = attendDt.Select("status='病假'").Length;

                //给studID赋值            
                dr[8] = dt.Rows[i]["ID"];

                attendStatistDt.Rows.Add(dr);

                #endregion
            }

            return attendStatistDt;
        }

        /// <summary>
        /// 根据学生ID得到个人考勤统计
        /// </summary>
        /// <param name="studID"></param>
        /// <returns></returns>
        public DataTable getSingleStudentAttendStatistics(string studID, Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendStatistDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendStatistDt.Columns.Add(colNumber);

            attendStatistDt.Columns.Add("name", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("className", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("truancy", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("late", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("leaveEarly", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("thingLeave", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("sickleave", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("studID", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();
            StudentBLL studBLL = new StudentBLL();
            Student student = studBLL.get(studID);

            Class clazz = classBLL.get(student.ClassID);

            DataTable attendDt = null;
            if (isTeacherRecord)
                attendDt = attendBLL.getByStudIdAboutTeacher(student.Id).Tables[0];
            else
                attendDt = attendBLL.getByStudIdAboutMonitor(student.Id).Tables[0];

            //创建新的一行数据
            DataRow dr = attendStatistDt.NewRow();

            #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

            //给name赋值
            dr[1] = student.Name;

            //给className赋值
            dr[2] = clazz.Name;

            //给truancy赋值            
            dr[3] = attendDt.Select("status='旷课'").Length;

            //给late赋值            
            dr[4] = attendDt.Select("status='迟到'").Length;

            //给leaveEarly赋值            
            dr[5] = attendDt.Select("status='早退'").Length;

            //给thingLeave赋值            
            dr[6] = attendDt.Select("status='事假'").Length;

            //给sickleave赋值            
            dr[7] = attendDt.Select("status='病假'").Length;

            //给studID赋值            
            dr[8] = student.Id;

            attendStatistDt.Rows.Add(dr);

            #endregion


            return attendStatistDt;
        }

        /// <summary>
        /// 根据学生ID得到详细的考勤统计
        /// </summary>
        /// <param name="studID"></param>
        /// <returns></returns>
        public DataTable getDetailStudentAttendStatistics(string studID, Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendStatistDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendStatistDt.Columns.Add(colNumber);

            attendStatistDt.Columns.Add("name", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("className", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("status", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("course", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("teacher", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("week", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("weekDay", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("courseTime", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("remark", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("ID", Type.GetType("System.String"));
            attendStatistDt.Columns.Add("teacherID", Type.GetType("System.String"));
            #endregion

            TeacherBLL teachBLL = new TeacherBLL();
            CourseBLL courBLL = new CourseBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();
            ClassBLL classBLL = new ClassBLL();
            StudentBLL studBLL = new StudentBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();

            DataTable dt = null;
            if (isTeacherRecord)
                dt = attendBLL.getByStudIdAboutTeacher(studID).Tables[0];
            else
                dt = attendBLL.getByStudIdAboutMonitor(studID).Tables[0];

            Student stud = studBLL.get(studID);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CourseTable ct = ctBLL.get(dt.Rows[i]["courTableID"].ToString());

                //创建新的一行数据
                DataRow dr = attendStatistDt.NewRow();

                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给name赋值
                dr[1] = stud.Name;

                //给className赋值            
                dr[2] = classBLL.get(stud.ClassID).Name;

                //给status赋值            
                dr[3] = dt.Rows[i]["status"];

                //给course赋值            
                dr[4] = courBLL.get(ct.CourId).Name;

                //给teacher赋值            
                dr[5] = teachBLL.get(ct.TeachID).Name;

                //给week赋值            
                dr[6] = "第" + ct.Week + "周";

                //给weekDay赋值            
                dr[7] = ct.WeekDay;

                //给courseTime赋值            
                dr[8] = ct.CourseTime;

                //给remark赋值            
                dr[9] = dt.Rows[i]["remark"];

                //给ID赋值            
                dr[10] = dt.Rows[i]["ID"];

                //给teacherID赋值            
                dr[11] = ct.TeachID;

                attendStatistDt.Rows.Add(dr);

                #endregion
            }

            return attendStatistDt;
        }
        /// <summary>
        /// 得到教师或者班长考勤的班级的周的平均到课率
        /// </summary>
        /// <param name="week"></param>
        /// <param name="isTeacherRecord"></param>
        /// <returns></returns>
        public DataTable getWeekAverageAttendaceRate(string week, Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendaceDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendaceDt.Columns.Add(colNumber);

            attendaceDt.Columns.Add("week", Type.GetType("System.String"));
            attendaceDt.Columns.Add("class", Type.GetType("System.String"));
            attendaceDt.Columns.Add("AverageAttendaceRate", Type.GetType("System.String"));
            attendaceDt.Columns.Add("classID", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();

            DataTable dt = null;
            if (week.Equals("全部周次"))
            {
                if (isTeacherRecord)
                    dt = attendBLL.getAboutTeacher().Tables[0];
                else
                    dt = attendBLL.getAboutMonitor().Tables[0];
            }
            else
            {
                if (isTeacherRecord)
                    dt = attendBLL.getAboutTeacher(week).Tables[0];
                else
                    dt = attendBLL.getAboutMonitor(week).Tables[0];
            }
            //根据课程表ID去除重复行
            DataView dv = new DataView(dt);
            dt = dv.ToTable(true, "courTableID");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                CourseTable ct = ctBLL.get(dt.Rows[i]["courTableID"].ToString());

                if (attendaceDt.Select("week='第" + ct.Week + "周' and classID='" + ct.ClassID + "'").Length == 0)
                {
                    //创建新的一行数据
                    DataRow dr = attendaceDt.NewRow();

                    #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                    //给week赋值            
                    dr[1] = "第" + ct.Week + "周";

                    //给class赋值            
                    dr[2] = classBLL.get(ct.ClassID).Name;

                    //给AverageAttendaceRate赋值            
                    DataTable attendDt = getWeekDetailAttendaceRate(ct.Week, ct.ClassID, isTeacherRecord);
                    dr[3] = FormatUtil.doubleToPercent(calculateAverageAttendRate(attendDt, "attendaceRate"));

                    //给classID赋值            
                    dr[4] = ct.ClassID;

                    attendaceDt.Rows.Add(dr);
                    #endregion
                }
            }

            return attendaceDt;
        }

        /// <summary>
        /// 取得这个学期至今的教师或者班长登记的考勤信息
        /// </summary>
        /// <param name="isTeacherRecord"></param>
        /// <returns></returns>
        public DataTable getSemesterAttendaceRate(Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendaceDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendaceDt.Columns.Add(colNumber);

            attendaceDt.Columns.Add("class", Type.GetType("System.String"));
            attendaceDt.Columns.Add("semesterAttendaceRate", Type.GetType("System.String"));
            attendaceDt.Columns.Add("classID", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();

            DataTable dt = null;
            if (isTeacherRecord)
                dt = attendBLL.getAboutTeacher().Tables[0];
            else
                dt = attendBLL.getAboutMonitor().Tables[0];

            //根据课程表ID去除重复行
            DataView dv = new DataView(dt);
            dt = dv.ToTable(true, "courTableID");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                CourseTable ct = ctBLL.get(dt.Rows[i]["courTableID"].ToString());

                if (attendaceDt.Select("classID=" + ct.ClassID).Length == 0)
                {
                    //创建新的一行数据
                    DataRow dr = attendaceDt.NewRow();

                    #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                    //给class赋值            
                    dr[1] = classBLL.get(ct.ClassID).Name;

                    //给semesterAttendaceRate赋值            
                    DataTable attendDt = getWeekAverageAttendaceRateByClassID(ct.ClassID, isTeacherRecord);
                    dr[2] = FormatUtil.doubleToPercent(calculateAverageAttendRate(attendDt, "AverageAttendaceRate"));

                    //给classID赋值            
                    dr[3] = ct.ClassID;

                    attendaceDt.Rows.Add(dr);

                    #endregion
                }
            }

            return attendaceDt;
        }

        /// <summary>
        /// 取得教师或者班长登记的考勤率
        /// </summary>
        /// <param name="isTeacherRecord">表示是否是教师登记</param>
        /// <returns></returns>
        public DataTable getAttendaceRate(Boolean isTeacherRecord)
        {
            //创建一个新的DataTable表
            DataTable attendaceDt = new DataTable();

            #region 为DataTable创建列

            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            attendaceDt.Columns.Add(colNumber);

            attendaceDt.Columns.Add("week", Type.GetType("System.String"));
            attendaceDt.Columns.Add("weekDay", Type.GetType("System.String"));
            attendaceDt.Columns.Add("className", Type.GetType("System.String"));
            attendaceDt.Columns.Add("courseName", Type.GetType("System.String"));
            attendaceDt.Columns.Add("teacherName", Type.GetType("System.String"));
            attendaceDt.Columns.Add("courseTime", Type.GetType("System.String"));
            attendaceDt.Columns.Add("attendaceRate", Type.GetType("System.Int32"));

            #endregion

            ClassBLL classBLL = new ClassBLL();
            TeacherBLL teachBLL = new TeacherBLL();
            CourseBLL courBLL = new CourseBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();

            DataTable dt = null;
            if (isTeacherRecord)
                dt = attendBLL.getAboutTeacher().Tables[0];
            else
                dt = attendBLL.getAboutMonitor().Tables[0];

            //根据课程表ID去除重复行
            DataView dv = new DataView(dt);
            dt = dv.ToTable(true, "courTableID");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                CourseTable ct = ctBLL.get(dt.Rows[i]["courTableID"].ToString());


                //创建新的一行数据
                DataRow dr = attendaceDt.NewRow();

                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给week赋值            
                dr[1] = "第" + ct.Week + "周";

                //给weekDay赋值            
                dr[2] = ct.WeekDay;

                //给className赋值
                dr[3] = classBLL.get(ct.ClassID).Name;

                //给courseName赋值
                dr[4] = courBLL.get(ct.CourId).Name;

                //给teacherName赋值
                dr[5] = teachBLL.get(ct.TeachID).Name;

                //给courseTime赋值            
                dr[6] = ct.CourseTime;

                //给attendaceRate赋值            
                dr[7] = Math.Round(calculateAttendRate(ct.Id, isTeacherRecord) * 100);

                attendaceDt.Rows.Add(dr);
                #endregion

            }

            return attendaceDt;
        }

        /// <summary>
        /// 根据课程表ID计算考勤率
        /// </summary>
        /// <param name="courTableID"></param>
        /// <param name="isTeacherRecord"></param>
        /// <returns></returns>
        private double calculateAttendRate(string courTableID, Boolean isTeacherRecord)
        {

            AttendanceBLL attendBLL = new AttendanceBLL();

            //根据课程表ID取得考勤表中对应学生的考勤信息集
            DataTable dt = null;

            if (isTeacherRecord)
                dt = attendBLL.getByCourTableIdAboutTeacher(courTableID).Tables[0];
            else
                dt = attendBLL.getByCourTableIdAboutMonitor(courTableID).Tables[0];

            //考勤总共的学生数
            double totalStud = dt.Rows.Count;

            //出勤的学生数
            double attendStud = 0;

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["status"].Equals("正常"))
                {
                    attendStud += 1;
                }
            }

            return attendStud / totalStud;
        }

        public static double calculateAverageAttendRate(DataTable attendDt, string fieldName)
        {
            //周考勤的课程的总数量
            int attendCount = attendDt.Rows.Count;

            //周考勤率的总和
            double attendSum = 0;

            foreach (DataRow dr in attendDt.Rows)
            {
                attendSum += FormatUtil.percentToDobule(dr[fieldName].ToString());
            }

            return attendSum / attendCount;
        }

        public DataTable getAllRecordByRecordId(string recordId)
        {
            //创建一个新的DataTable表
            DataTable teachRecord = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            teachRecord.Columns.Add(colNumber);
            teachRecord.Columns.Add("className", Type.GetType("System.String"));
            teachRecord.Columns.Add("courseName", Type.GetType("System.String"));
            teachRecord.Columns.Add("teachID", Type.GetType("System.String"));
            teachRecord.Columns.Add("classID", Type.GetType("System.String"));
            teachRecord.Columns.Add("courId", Type.GetType("System.String"));
            #endregion
            AttendanceBLL attendanceBll = new AttendanceBLL();

            DataTable dt = attendanceBll.getByRecordId(recordId).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StudentBLL stuBLL = new StudentBLL();
                Student stu = stuBLL.get(dt.Rows[i]["studID"].ToString());
                ClassBLL claBll = new ClassBLL();
                Class cla = claBll.get(stu.ClassID);
                CourseTableBLL courTbBll = new CourseTableBLL();
                CourseTable courTb = courTbBll.get(dt.Rows[i]["courTableID"].ToString());
                CourseBLL courBll = new CourseBLL();
                Course course = courBll.get(courTb.CourId);

                if (teachRecord.Select("className='" + cla.Name + "' and courseName='" + course.Name + "'").Length == 0)
                {
                    //创建新的一行数据
                    DataRow dr = teachRecord.NewRow();

                    #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                    dr[1] = cla.Name;

                    dr[2] = course.Name;

                    dr[3] = courTb.TeachID;

                    dr[4] = courTb.ClassID;

                    dr[5] = courTb.CourId;

                    teachRecord.Rows.Add(dr);

                    #endregion
                }


            }
            return teachRecord;
        }

        public DataTable getComparedAttendance()
        {
            //创建一个新的DataTable表
            DataTable comparedDt = new DataTable();
            #region 为DataTable创建列
            //设置自增长列
            DataColumn colNumber = new DataColumn("colNumber");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            comparedDt.Columns.Add(colNumber);

            comparedDt.Columns.Add("week", Type.GetType("System.String"));
            comparedDt.Columns.Add("weekDay", Type.GetType("System.String"));
            comparedDt.Columns.Add("className", Type.GetType("System.String"));
            comparedDt.Columns.Add("courseName", Type.GetType("System.String"));
            comparedDt.Columns.Add("teacherName", Type.GetType("System.String"));
            comparedDt.Columns.Add("place", Type.GetType("System.String"));
            comparedDt.Columns.Add("courseTime", Type.GetType("System.String"));
            comparedDt.Columns.Add("teacherRecord", Type.GetType("System.String"));
            comparedDt.Columns.Add("monitorRecord", Type.GetType("System.String"));
            #endregion

            ClassBLL classBLL = new ClassBLL();
            TeacherBLL teachBLL = new TeacherBLL();
            CourseBLL courBLL = new CourseBLL();
            AttendanceBLL attendBLL = new AttendanceBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();

            List<DataRow> ctList = ctBLL.getAll().Tables[0].Select("semester='" + GlobalVars.SEMESTER + "'").ToList();

            foreach (DataRow tempDr in ctList)
            {
                CourseTable ct = ctBLL.get(tempDr["ID"].ToString());

                //创建新的一行数据
                DataRow dr = comparedDt.NewRow();

                #region 用数据库中取得的班级信息依次对应给新的数据表行赋值

                //给week赋值            
                dr[1] = "第" + ct.Week + "周";

                //给weekDay赋值            
                dr[2] = ct.WeekDay;

                //给className赋值
                dr[3] = classBLL.get(ct.ClassID).Name;

                //给courseName赋值
                dr[4] = courBLL.get(ct.CourId).Name;

                //给teacherName赋值
                dr[5] = teachBLL.get(ct.TeachID).Name;

                //给place赋值
                dr[6] = ct.Place;

                //给courseTime赋值            
                dr[7] = ct.CourseTime;

                //给teacherRecord赋值            
                dr[8] = attendBLL.getAll().Tables[0].Select("recorder='教师' and courTableID='" + ct.Id + "'").Length != 0 ? "已登记" : "未登记";

                //给monitorRecord赋值            
                dr[9] = attendBLL.getAll().Tables[0].Select("recorder='班长' and courTableID='" + ct.Id + "'").Length != 0 ? "已登记" : "未登记"; ;

                comparedDt.Rows.Add(dr);

                #endregion
            }

            return comparedDt;
        }


    }
}
