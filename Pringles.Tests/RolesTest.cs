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
    public class RolesTest
    {
        [TestMethod]
        public void RolesExistTest()
        {
            IRolesRepository rolesRepository = new RolesRepository();
            Assert.IsFalse(rolesRepository.CheckRolesExists());
        }

        [TestMethod]
        public void CreateDefaultRoleTest()
        {
            IRolesRepository rolesRepository = new RolesRepository();
            rolesRepository.CreateDefaultRole();
        }
    }
}
