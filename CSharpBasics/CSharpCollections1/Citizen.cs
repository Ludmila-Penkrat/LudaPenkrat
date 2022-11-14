using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class Citizen
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public Address CitizenAddress { get; set; }
        public DateTime Birthday { get; set; }

        public Citizen()
        {
        }

        public Citizen(string name, string patronymic, string surname, Address citizenAddress, DateTime birthday)
        {
            Name = name;
            Patronymic = patronymic;
            Surname = surname;
            CitizenAddress = citizenAddress;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                "\nPatronymic: " + Patronymic +
                "\nSurname: " + Surname +
                "\nBirthday: " + Birthday.ToShortDateString() +
                "\nAddress: " + CitizenAddress +
                "\nAge: " + Age(Birthday);
        }

        public void PrintCitizenList(List<Citizen> list)
        {
            foreach (Citizen item in list)
            {
                if (item == null)
                {
                    Console.WriteLine("Value of this element is null.");
                }
                else
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
        }
   
        public int Age (DateTime birthdayDate)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            var timeSpan = (DateTime.Now - birthdayDate).Duration();
            int age = (zeroTime + timeSpan).Year - 1;
            return age;
        }

        
    }
}
/*Дан класс, в котором соджержится информация о каждом жителе города:
а) фамилия, имя, отчество;
б) домашний адрес (улица, дом);
в) дата рождения.
Создать список List<Citizen>, в котором будет содержаться информацию о жителях.
Требуется составить новый списки избирателей, живущих по заданному адресу в алфавитном порядке.
Примечание: Правом участия в выборах обладают люди не моложе 18 лет.
*/