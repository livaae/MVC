using YetGenAkbankJump.OOPConsole.Common;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class Log : ICreatedByEntity, IDeletedByEntity
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string CreatedByUserId { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DateTimeOffset CreatedOn { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string DeletedByUserId { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DateTimeOffset DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}