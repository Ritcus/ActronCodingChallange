using ActronCodingChallange.Interfaces;
using ActronCodingChallange.Services;

namespace ActronCodingChallangeTests.ServicesTests
{
    [TestFixture]
    public class RepositoryServiceTests
    {
        private IRepository _repository;
        private int[] sampleArray;

        [SetUp]
        public void Setup()
        {
            _repository = new RepositoryService();
            sampleArray = new int[] { 10, 223, 78, 90, 99 };
        }
        [Test]
        public void SelectionSortAlgorithm_ReturnsExpectedResult()
        {
            //Arrange

            //Act
            string result = _repository.SelectionSortAlgorithm(sampleArray);

            //Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.EqualTo("99907822310"));
        }

        [Test]
        public void MergeSortAlgorithm_ReturnsExpectedResult()
        {
            //Arrange

            //Act
            string result = _repository.MergeSortAlgorithm(sampleArray);

            //Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.EqualTo("99907822310"));
        }
    }
}