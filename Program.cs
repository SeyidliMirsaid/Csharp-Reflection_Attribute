using Reflection_Attribute_06_16_25.AttributeWrapper;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Reflection_Attribute_06_16_25
{
    internal class Program
    {
        // Attribute
        static void Main(string[] args)
        {
            var stu = new Students();
            stu.age_ = 22;
            stu.name_ = "David";

            // Reflection
            
            Type type = typeof(Students);

            #region
            /* EventInfo eventInfo = type.GetEvent("");
            MethodInfo method = type.GetMethod("CalculateArea");
            FieldInfo field = type.GetField("privateInt", BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(stu, new object[] { "World" }); */
            #endregion

            var allProperties = type.GetProperties();

            foreach (var property in allProperties)
            {
                var customRequiredProp = property.GetCustomAttribute<CustomRequired>();
                if (customRequiredProp != null)
                {
                    var value = property.GetValue(stu);
                    if (value == null || property.PropertyType == typeof(int) && (int)value == 0)
                    {
                        Console.WriteLine($"{property.Name} value as not valid");
                    }
                }
            }

            /*
            //Assembly assembly = typeof(Students).Assembly;
            Assembly assembly = Assembly.GetExecutingAssembly();
            var stMethods = typeOfStudents.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var privatePorperty = 
                typeOfStudents.GetProperty("privateInt", 
                BindingFlags.NonPublic | // private propertini gotur
                BindingFlags.Instance // intansin icindeki
                );
            privatePorperty.SetValue(student, 32, null);
            Console.WriteLine(privatePorperty.GetValue(student)); */
        }
    }
    public class Students
    {
        private int privateInt { get; set; }

        [Range(18, 95)]
        //[CustomRequired]
        public int age_ { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Couldn't litte from three letters")]
        //[CustomRequired]
        public string name_ { get; set; }
        public bool isActive_ { get; set; }

        [Obsolete("This method already is not active")]
        public void CalculateGrad(){}

        //[CustomRequired]
        public void CalculateArea() {}
    }
}
