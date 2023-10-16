using YetGenAkbankJump.OOPConsole.Enums;

namespace YetGenAkbankJump.OOPConsole.Common
{
    public class PersonBase
    {
        public Guid Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string FirstName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string LastName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Gender Gender { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public void SayMyName() => Console.WriteLine($"{FirstName} {LastName}");
        public int Addition(int number1, int number2) => number1 * number2;
    }
}