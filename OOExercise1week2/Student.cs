using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercise1week2_101644658
{
    class Student:Person
    {
        private int studentID;
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public Student(string pFName, string pLName, string pGender, int pStudentID): base(pFName,pLName,pGender)
        {
            studentID = pStudentID;
        }
        public override string Work()
        {
            return "Study, Drink coffee, Party, Sleep, Repeat";
        }
    }
}
