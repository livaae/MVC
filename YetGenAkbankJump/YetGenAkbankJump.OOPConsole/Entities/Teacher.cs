using YetGenAkbankJump.OOPConsole.Common;
using YetGenAkbankJump.OOPConsole.Utilities;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class Teacher : EntityBase<long>
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string FirstName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string LastName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DateTimeOffset RegistrationDate { get; set; }

        public static implicit operator Teacher(Student student)
        {
            return new Teacher()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                CreatedOn = student.CreatedOn
            };
        }

        //public static explicit operator Teacher(Student student)
        //{
        //    return new Teacher()
        //    {
        //        FirstName = student.FirstName,
        //        LastName = student.LastName,
        //        CreatedOn = student.CreatedOn,
        //    };
        //}

        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

    }
}