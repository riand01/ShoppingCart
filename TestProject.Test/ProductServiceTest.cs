using ClassLibrary;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

namespace TestProject.Test
{
    [TestClass]
    public class ProductServiceTest
    {
        private ProductService sut;
        public ProductServiceTest()
        {
                sut = new ProductService();
        }
        [TestMethod]
        public void TestMethod1()
        {
            // ARRANGE
            sut.Products.Add(new Product{Count=12, Id=1, Name="Mjölk", Price=8});

            // ACT
            var Id = 1;
            var result = sut.DoesProductExist(Id);
            

            // ASSERT
            Assert.AreEqual(true, result );
        }


        [TestMethod]
        public void When_adding_existing_product_antal_should_be_added()
        {
            // ARRANGE
            var p = new Product { Count = 0, Id = 2, Name = "Mjölk", Price = 8 };
            sut.AddToList(p,10);
            sut.AddToList(p,12);
            
            // ACT
            
            var result = sut.Products.First(e => e.Id == 2);


            // ASSERT
            Assert.AreEqual(22, result.Count);
        }


    }
}