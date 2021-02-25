using ClsWrkDelegate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkDelegate.Derived_Classes
{
    class CheckAgeGreaterthan30 : IStudent
    {
        public bool CheckCriteria(Student student)
        {
            return student.Age > 30;
        }
    }
}
