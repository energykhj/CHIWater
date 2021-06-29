using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHIWater.Models
{
    public enum Gender
    {
        Male = 'M',
        Female = 'F'
    }

    public interface IPet
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime DateOfBirth { get; set; }
        Gender Gender { get; set; }

        string Speak();
    }

    public abstract class PetBase : IPet
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract DateTime DateOfBirth { get; set; }
        public abstract Gender Gender { get; set; }
        public virtual float Wingspan { get; set; }
        public abstract string Speak();

        public virtual bool IsNameAPalindrome
        {
            get
            {
                try
                {
                    System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9-]");

                    string str = rgx.Replace(this.Name, "");
                    char[] ch = str.ToCharArray();
                    Array.Reverse(ch);
                    string rev = new string(ch);

                    return str.Equals(rev, StringComparison.OrdinalIgnoreCase);
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            }
        }

        public virtual int Age
        {
            get
            {
                try
                {
                    var age = DateTime.Today.Year - this.DateOfBirth.Year;
                    if (this.DateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;
                    return age;
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }

    public class Bird : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }
        public override float Wingspan { get; set; }

        public override string Speak()
        {
            return "Chirp!";
        }
    }

    public class Cat : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public override string Speak()
        {
            return "Meow!";
        }

        //public override bool IsNameAPalindrome { get => base.IsNameAPalindrome; }

    }

    public class Dog : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public override string Speak()
        {
            return "Whoof!";
        }
    }

    public class House : List<PetBase>
    {
        public void AddTestData()
        {
            this.Add(new Cat()
            {
                ID = this.Count + 1,
                Name = "Gracie",
                DateOfBirth = new DateTime(2016, 09, 28),
                Gender = Gender.Female
            });

            this.Add(new Cat()
            {
                ID = this.Count + 1,
                Name = "Patches",
                DateOfBirth = new DateTime(2015, 01, 09),
                Gender = Gender.Male
            });

            this.Add(new Bird()
            {
                ID = this.Count + 1,
                Name = "Izzi",
                DateOfBirth = new DateTime(2018, 07, 03),
                Gender = Gender.Female,
                Wingspan = 10.0f,
            });

            this.Add(new Dog()
            {
                ID = this.Count + 1,
                Name = "Missy",
                DateOfBirth = new DateTime(2016, 03, 05),
                Gender = Gender.Female
            });
        }
    }
}
