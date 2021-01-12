using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pringles.BLL;
using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.EE;

namespace Pringles.Tests
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void AutoresTest()
        {
            IRepository<Autor> repository = new Repository<Autor>();
            AutorBLL autorBLL = new AutorBLL(repository);

            var result = autorBLL.ListarAutores();
        }
    }
}
