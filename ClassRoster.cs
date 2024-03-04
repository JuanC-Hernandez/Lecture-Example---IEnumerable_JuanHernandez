using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Interface_and_IEnumerable_JuanHernandez
{
    // Inherit the IEnumerable
    internal class ClassRoster : IEnumerable
    {
        // Field
        List<Student> _students = new List<Student>();

        // Methods
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddStudent(string firstName,  string lastName)
        {
            _students.Add(new Student(firstName, lastName));
        }

        // Generate our IEnumerable Method
        public IEnumerator GetEnumerator()
        {
            return new ClassRosterEnumerator(ref _students);
        }

        // Internal class
        private class ClassRosterEnumerator : IEnumerator
        {

            // Fields
            int index = -1; // Indicates its at the start of our collection
            List<Student> Students;

            // Constructor 
            // Make sure to pass your argument as a ref
            // place ref in front of your parameter
            public ClassRosterEnumerator(ref List<Student> students)
            {
                Students = students;
            }


            // Property
            public object Current => Students[index];

            // Is called to iterate to the next index
            public bool MoveNext()
            {
                // Increments to nex index
                index++;

                // indicates if at the end of the collection
                if (index >= Students.Count)
                {
                    return false;
                }
                else { return true; }   
            }

            // Reset sets the index back to before the first element
            public void Reset()
            {
                index = -1;
            }
        }

    }
}
