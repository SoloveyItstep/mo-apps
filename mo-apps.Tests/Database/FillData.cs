using Microsoft.VisualStudio.TestTools.UnitTesting;
using mo_apps.entity;
using mo_apps.entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo_apps.Tests.Database
{
    [TestClass]
    public class FillData
    {
        public Context _context { get; set; }
        public FillData()
        {
            //this._context = new Context(@"Data Source=DESKTOP-8GG7PPQ\SQLEXPRESS;Initial Catalog=moApps;Integrated Security=True");
            this._context = new Context();
        }

        [TestMethod]
        public void FillUsers()
        {
            List<User> users = new List<User>();

            for(Int32 i = 0; i < 50; ++i)
            {
                DateTime date = new DateTime(DateTime.Now.Year - i, DateTime.Now.Month, DateTime.Now.Day);
                Int32 rank = i % 4;
                _context.User.Add(new User
                {
                    FirstName = "first name " + i.ToString(),
                    LastName = "last name" + i.ToString(),
                    Birthday = date,
                    Nickname = "warior "+i.ToString(),
                    Rank = rank
                });
            }

            //_context.User.AddRange(users);
            Int32 result = _context.SaveChanges();
            Assert.AreEqual(result, 1);
        }

        //public void FixEfProviderServicesProblem()
        //{
        //    //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
        //    //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
        //    //Make sure the provider assembly is available to the running application. 
        //    //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            
        //    var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        //}
    }
}
