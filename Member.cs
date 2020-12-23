using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AddressBook
{
    class Member:IComparable<Member>
    {
        public List<Belongings> Belongings = new List<Belongings>();
        public string Name = "";
        public int Age = 0;

        public Member() // constructor 1
        {

        }

        public Member (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Member(string name, int age, Belongings belongings)
            {
                this.Name = name;
                this.Age = age;
                this.Belongings.Add(belongings);
            }

        public void AddToBelongings (Belongings belongings)
        {
            belongings.Owner = this;
            this.Belongings.Add(belongings);
        }
        
        public int BelongingsNumber
        {
            get { return this.Belongings.Count; }
        }
        
        public override string ToString()
        {
            return "Member name:" + this.Name + "\t\tAge: " + this.Age.ToString() + "\tThe number of belongings:" + this.BelongingsNumber.ToString();
        }

        public int CompareTo([AllowNull] Member other)
        {
            throw new NotImplementedException();
        }
    }
}
