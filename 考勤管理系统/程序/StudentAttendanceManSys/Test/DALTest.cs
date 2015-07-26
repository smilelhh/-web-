using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.IDAL;
using DAL.SQLServerDAL;
using Model;
using System.Data;
using DAL.DALFactory;
using Utility;

namespace Test
{
    [TestClass]
    public class DALTest
    {
        [TestMethod]
        public void TestSave()
        {
            IUserDAL dal = DALFactory.createUserDAL();
            User user = new User();
            user.UserName = "manager";
            user.Password = EncryptUtil.MD5Encrypt("12345678");
            user.Type = "5";
            dal.save(user);
        }

        [TestMethod]
        public void TestGetAll()
        {
            //IUserDAL dal = new UserDAL();
            
            //DataSet ds = dal.getAll();
        }

        [TestMethod]
        public void TestUpdate()
        {
        //    IUserDAL dal = new UserDAL();
        //    User user = new User();
        //    user.Id = "5";
        //    user.UserName = "aa";
        //    user.Password = "123";
        //    user.Type = "2";
        //    dal.update(user);
        //}

        //[TestMethod]
        //public void TestDelete()
        //{
        //    IUserDAL dal = new UserDAL();
        //    User user = new User();
        //    user.Id = "5";           
        //    dal.delete(user);
        }

        [TestMethod]
        public void TestGet()
        {
            //IUserDAL dal = new UserDAL();

            //User user = (User)dal.get("4");
        }
    }
}
