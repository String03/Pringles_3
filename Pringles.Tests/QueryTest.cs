using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pringles.EE;
using Pringles.DAL;

namespace Pringles.Tests
{
    [TestClass]
    public class QueryTest
    {
        [TestMethod]
        public void DeleteQueryTest()
        {
            var autor = new Autor
            {
                Id = 1,
                Nombres = "Ayy",
                Apellido = "No se"
            };
            new Repository<Autor>().Delete(autor);

        }

        [TestMethod]
        public void InsertQueryTest()
        {
            var autor = new Autor
            {
                Nombres = "Ayy",
                Apellido = "No se"
            };
            new Repository<Autor>().Save(autor);
        }

        [TestMethod]
        public void UpdateQueryTest() 
        {
            var autor = new Autor
            {
                Id = 1,
                Nombres = "me la quiero coger",
                Apellido = "a laura"
            };
            new Repository<Autor>().Update(autor);
        }
    }
}
