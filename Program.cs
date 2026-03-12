using Reflection_Attribute_Homework_06_16_25.MyAttributes;
using System;
using System.Reflection;

namespace Reflection_Attribute_Homework_06_16_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir AuthorAttribute adlı öz attribute - bu yaradın.Bu attribute sinif və metodlara tətbiq olunsun 
            və müəllifin adını saxlasın.  Tələb olunanlar:
            --> AuthorAttribute class-ı yaradın.
            --> Book adlı bir sinifə bu attribute-u tətbiq edin.
            --> Reflection istifadə edərək bu attributun məlumatını oxuyun və konsola çıxarın.
            (NUMUNE
            [Author("Ali Vəliyev")]
            public class Book
            {
                [Author("Nigar Məmmədova")]
                public void PrintInfo() { }
            })
            */

            var bookAuthor = new Book();

            Type bookAuthorType = typeof(Book);
            var hasClassAttribute = bookAuthorType.GetCustomAttribute<Authors>();

            Console.WriteLine(hasClassAttribute.text);

            var properties = bookAuthorType.GetProperties();

            foreach (var data in properties)
            {
                var hasPropertiesAttribute = data.GetCustomAttribute<Authors>();
                Console.WriteLine(hasPropertiesAttribute.text);
            }

            /*
            Reflection istifadə edərək istənilən bir sinifdəki bütün method-ların adlarını və 
            onların geri dönüş tiplərini konsola çıxarın.

            Tələb olunanlar:

            Product adlı sinif yaradın və içində bir neçə method əlavə edin.

            Reflection vasitəsilə bu sinifdəki method-ları tapın.

            Method adı və geri dönüş tipi ekrana çıxarılsın.
            */

            var products = new Product()
            {
                ProductNumber = 1,
                Name = "Samsung",
                Price = 473.64
            };

            Type productType = typeof(Product);

            var propertiesNameAndReturnValue = productType.GetProperties();
            var methodNameAndReturnValue = productType.GetMethods();

            Console.WriteLine(propertiesNameAndReturnValue);
            Console.WriteLine(methodNameAndReturnValue);

            foreach (var property in propertiesNameAndReturnValue)
            {
                Console.WriteLine($"Property: {property.Name}  Value: {property.PropertyType.Name}");

                var value = property.GetValue(products);
                Console.WriteLine(value);
            }
            Console.WriteLine();
            foreach (var method in methodNameAndReturnValue)
            {
                Console.WriteLine(method.ReturnParameter.Name);
                Console.WriteLine($"Name: {method.Name}  Return Type: {method.ReturnType.Name}");
            }
        }
    }
    [Authors("Mirsaid Seyidli")]
	class Book
	{
		[Authors("Nigar Məmmədova")]
		public string Name { get; set; }

		[Authors("Seyidli Mirsaid")]
		public string MiddleName { get; set; }

	}

    class Product
    {
        public int ProductNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime ProductionDate(DateTime dt)
        {
            return dt;
        }

        public void ProductName(string name)
        {

        }
    }
}
