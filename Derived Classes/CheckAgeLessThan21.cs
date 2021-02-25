using ClsWrkDelegate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkDelegate.Derived_Classes
{
    public class CheckAgeLessThan21 : IStudent
    {
        public bool CheckCriteria(Student s)
        {
            return s.Age < 21;
        }
    }
}
