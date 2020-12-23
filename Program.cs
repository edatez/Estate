using AddressBook;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static List<AddressBook.Member> member = new List<AddressBook.Member>();


        static void Main(string[] args)
        {
            AddressBook.Member kendra = new AddressBook.Member("Kendra Green", 30);
            AddressBook.Member scott = new AddressBook.Member("Scott Brown", 35);


            Car honda = new Car();
            honda.Color = Car.CarColor.Red;
            honda.DoorCount = 4;
            kendra.AddToBelongings(honda);

            Condominium condo  = new Condominium();
            condo.RoomCount= 3;
            RealEstate.Address = "100 St, Seattle";
            scott.AddToBelongings(condo);

            member.Add(kendra);
            member.Add(scott);

            PrintMembers();

            member.Sort();

        }
        static void PrintMembers()
        {
            foreach (var item in member)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
