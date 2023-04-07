using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class MyClass
    {
        void Method01() // default access modifier is private
        {
            MessageBox.Show("Method01: Default");
        }
        private void Method02()
        {
            MessageBox.Show("Method02: private");
        }
        public void Method03() {
            MessageBox.Show("Method03: public");
        }
       internal void Method04() {
            MessageBox.Show("Method04: internal");
        }
        protected void Method05()
        {
            MessageBox.Show("Method05: protected");
        }
        protected internal void Method06()
        {
            MessageBox.Show("Method06: protected internal");
         }
        public void Method07()
        {
            Method01();
            Method02();
            MessageBox.Show("封裝: 使用公開(public method)呼叫私有(private method)");
        }
    }
    public class Member
    {
        public string Name;
        public int Age;
    }
    public enum UserRole
    {
        Admin = 1,
        User = 2
    }
    public struct Employee
    {
        public string Name { get; set;}
        public int Age { get; set;}

        public Employee(string EmployeeName, int EmployeeAge)
        {
            this.Name = EmployeeName;
            this.Age = EmployeeAge;
        }
        public struct Product
        {
            public string Name;
            public decimal Price;
        }
    }
}
