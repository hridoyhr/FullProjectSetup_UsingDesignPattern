using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AttendanceSystem.Models
{
    public class TestModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public TestModel()
        {
            Func<int, int, int> aMethod = (a, b) => a + b;

            PrintResult((a, b) => a + b, 2, 2);
        }

        public void PrintResult(Expression<Func<int, int, int>> expression, int a, int b)
        {
            var method = expression.Compile();
            var result = method(a, b);
            Console.WriteLine(result);
        }
    }
}
