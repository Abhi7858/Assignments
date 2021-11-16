using System;

namespace studentlist
{
    public class student
    {
        public string Name;
        public int age;
        public string gender;
        public int standard;
        public student(string Name, int age, string gender, int standard)
        {
            this.Name = Name;
            this.age = age;
            this.gender = gender;
            this.standard = standard;
        }
    }
}
