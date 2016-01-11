using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的学习和方法的学习
{
    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value; }
        }
        public char _gender;
        public char Gender
        {
            get {
                if (_gender!='男'&&_gender!='女')
                {
                    _gender = '男';
                }
                return _gender; }
            set { _gender = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("大家好，我是{0}，今年{1},我是{2}", this.Name, this.Age, this.Gender);
        }
    }
}
