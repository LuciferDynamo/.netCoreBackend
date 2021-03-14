//using Business.Concrete;
//using DataAccess.Abstract;
//using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
//using System;

//namespace ConsoleUI
//{
//    class Program
//    {
//        /*
//        Open Closed Principle
//        SOLID

//        static void Main(string[] args)
//        {
//            DTO - Data Transformation Objects
//            ProductTest();
//            CategoryTest();



//        }

//        private static void CategoryTest()
//        {
//            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

//            foreach (var category in categoryManager.GetAll())
//            {
//                Console.WriteLine(category.CategoryName);
//            }
//        }




//        private static void ProductTest()
//        {
//            ProductManager productManager = new ProductManager(new EfProductDal());

//            var result = productManager.GetProductDetail();


//            if (result.Succes)
//            {
//                foreach (var product in result.Data)
//                {
//                    Console.WriteLine(product.ProductName + " - " + product.CategoryName);
//                }

//            }
//            else
//            {
//                Console.WriteLine(result.Message);
//            }
//        */
//    }
//}