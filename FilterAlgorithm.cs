using ClsWrkDelegate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkDelegate
{
    public class FilterAlgorithm
    {
        // return list of those student who are less than 21 
        public static List<Student> FilterStudent(List<Student> students, Func<Student, bool> ageLess21)
        {
            List<Student> filterStudent = new List<Student>();
            foreach (var student in students)
            {
                // change the object behaviour
                // invoking the delegate ageLess21()
                // successfully modified my internal function method
                if (ageLess21(student))
                {
                    filterStudent.Add(student);
                }
            }

            return filterStudent;
        }

        public static List<Student> CheckCriteriaName(List<Student> students, IStudent s)
        {
            List<Student> filterStudent = new List<Student>();
            foreach (var student in students)
            {
                // change the object behaviour
                // invoking the delegate ageLess21()
                // successfully modified my internal function method
                if (s.CheckCriteria(student))
                {
                    filterStudent.Add(student);
                }
            }

            return filterStudent;
        }
    }



 }
