using ClsWrkDelegate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkDelegate.Derived_Classes
{
    class CheckNameStartWithP : IStudent
    {
        public bool CheckCriteria(Student s)
        {
            return s.Name.StartsWith("P");
        }
    }
}
