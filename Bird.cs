using System;

namespace base_c_sharp_interface_implementation
{
    public class Bird : IPet
    {
        private string m_name = "";
        private int m_age = 0;

        public Bird(int age = 0, string name = "") {
            this.m_age = age;
            this.m_name = name;
        }

        public string getName() { return m_name; }
        public int getAge() { return m_age; }
        public void SoundOff() {
            Console.WriteLine(string.Format("My Name Is {0}, and I Am {1} Years Old...SQUAWK", this.getName(), this.getAge()));
        }
    }
}