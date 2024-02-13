using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Grade
    {
        public void GradeSystem()
        {
            int marks;
            Console.WriteLine("Enter the Student marks:");
            marks = int.Parse(Console.ReadLine());
            if(marks >=90){
                Console.WriteLine($"Garde obtained for the marks {marks} is : A" );
            }
            else if (marks >=80)
            {
                Console.WriteLine($"Garde obtained for the marks {marks} is : B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine($"Garde obtained for the marks {marks} is : C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine($"Garde obtained for the marks  {marks} is : D");
            }
            else
            {
                Console.WriteLine($"Garde obtained for the marks {marks} is : E");
            }
        }
    }
}
