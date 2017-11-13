using Business;
using Data.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests
{
    [TestClass]
    public class TodoRepositoryTest : BaseIntegrationTest {

        [TestMethod]
        public void Given_TodoRepository_When_AddingATodo_Then_TheTodoShouldBeProperlySaved() {
            RunOnDatabase(ctx => {
                //Arrange
                var repository = new UserRepository(ctx);
                var todo = Organization.Create("descriere originala", false, "titlu original");

                //Act
                repository.Add(todo);
                
                //Assert
                var todos = repository.GetAll();
                Assert.AreEqual(1, todos.Count);
            });
        }
    }
}
