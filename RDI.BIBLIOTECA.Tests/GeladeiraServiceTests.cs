using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RDI.BIBLIOTECA.Domain;
using RDI.BIBLIOTECA.Repository;
using RDI.BIBLIOTECA.Service;
using System;
using System.Collections.Generic;

namespace RDI.BIBLIOTECA.Tests
{
    [TestClass] // Indica que esta classe contém métodos de teste
    public class GeladeiraServiceTests
    {
        private Mock<IGeladeiraRepository> _mockRepository; // Mock do repositório
        private GeladeiraService _geladeiraService; // Instância do serviço

        // Este método é executado antes de cada teste
        [TestInitialize]
        public void Setup()
        {
            _mockRepository = new Mock<IGeladeiraRepository>(); // Inicializa o mock
            _geladeiraService = new GeladeiraService(_mockRepository.Object); // Cria a instância do serviço com o mock
        }

        [TestMethod]
        public void Insert_ValidItem_ReturnsInsertedItem()
        {
            // Arrange
            var item = new Item { Id = 1, Nome = "Leite", Andar = 1, Container = 1, Posicao = 1 };
            _mockRepository.Setup(r => r.Insert(item)).Returns(item); // Configura o mock para retornar o item inserido

            // Act
            var result = _geladeiraService.Insert(item); // Chama o método Insert

            // Assert
            Assert.IsNotNull(result); // Verifica se o resultado não é nulo
            Assert.AreEqual(item, result); // Verifica se o resultado é igual ao item esperado
            _mockRepository.Verify(r => r.Insert(item), Times.Once); // Verifica se o método Insert do repositório foi chamado uma vez
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] // Espera que uma exceção seja lançada
        public void Insert_ItemWithInvalidAndar_ThrowsArgumentException()
        {
            // Arrange
            var item = new Item { Id = 2, Nome = "Queijo", Andar = 5, Container = 1, Posicao = 2 }; // Item com andar inválido

            // Act
            _geladeiraService.Insert(item); // Chama o método Insert
        }

        [TestMethod]
        public void Update_ValidItem_ReturnsUpdatedItem()
        {
            // Arrange
            var item = new Item { Id = 1, Nome = "Leite", Andar = 1, Container = 1, Posicao = 1 };
            _mockRepository.Setup(r => r.Update(item)).Returns(item); // Configura o mock

            // Act
            var result = _geladeiraService.Update(item); // Chama o método Update

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(item, result);
            _mockRepository.Verify(r => r.Update(item), Times.Once); // Verifica a chamada
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Update_ItemWithInvalidAndar_ThrowsArgumentException()
        {
            // Arrange
            var item = new Item { Id = 2, Nome = "Queijo", Andar = 5, Container = 1, Posicao = 2 };

            // Act
            _geladeiraService.Update(item); // Chama o método Update
        }

        [TestMethod]
        public void Remove_ValidItem_ReturnsRemovedItem()
        {
            // Arrange
            var item = new Item { Id = 1, Nome = "Leite", Andar = 1, Container = 1, Posicao = 1 };
            _mockRepository.Setup(r => r.Remove(item)).Returns(item); // Configura o mock

            // Act
            var result = _geladeiraService.Remove(item); // Chama o método Remove

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(item, result);
            _mockRepository.Verify(r => r.Remove(item), Times.Once); // Verifica a chamada
        }
    }
}
