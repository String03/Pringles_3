using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pringles.Contracts.Repositories;
using Pringles.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Tests
{
    [TestClass]
    public class SeguridadTest
    {
        [TestMethod]
        public void CheckUserExistsTest()
        {
            ISeguridadRepository repository = new SeguridadRepository();
            Assert.IsFalse(repository.CheckUserExists());
        }

        [TestMethod]
        public void CreateDefaultUserTest()
        {
            ISeguridadRepository repository = new SeguridadRepository();
            repository.CreateDefaultAdmin();
        }

        [TestMethod]
        public void LoginTest()
        {
            ISeguridadRepository repository = new SeguridadRepository();
            Assert.IsFalse(repository.AuthenticateUser("ADMIN", "ADMIN"));
            Assert.IsTrue(repository.AuthenticateUser("ADMIN", "pindonga"));
        }

        [TestMethod]
        public void ChangePasswordTest()
        {
            ISeguridadRepository repository = new SeguridadRepository();
            repository.UpdateUserPassword("ADMIN", "ADMIN", "pindonga");
        }
    }
}
