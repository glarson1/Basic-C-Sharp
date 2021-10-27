using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    //making class public so main() can have access
    public class MathOperations
    {
        public static int firstMethod (int i, int j = 1)
        {
            int theAnswer = i + j;
            return theAnswer;
            
        }
    }
}
