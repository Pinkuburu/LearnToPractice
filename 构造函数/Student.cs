using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class Student
    {
        string _name;
        public string Name
        {
            get {return _name; }
            set { _name = value; }
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public Student(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;


        }
        public Student(string name)
        {
            this.Name = name;
            


        }
        public void SayHello()
        {
            Console.WriteLine("大家好，我是{0}，今年{1},我是{2}", this.Name, this.Age, this.Gender);
        }
    }
}
