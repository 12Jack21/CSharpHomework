using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStruc
{
    public class Customer
    {
        private string name;
        private string phoneNum;
        public string Name { get => name; set => name = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        public Customer() { }
        public Customer(string name, string phoneNum)
        {
            this.name = name;
            this.phoneNum = phoneNum;
        }

        public void update(string name, string phoneNum)
        {
            this.name = name;
            this.phoneNum = phoneNum;
        }

        public override string ToString()
        {
            string result = "";
            result += ("Name: " + name + "  phoneNum: " + phoneNum);
            return result;
        }
    }
}
