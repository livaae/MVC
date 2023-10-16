using YetGenAkbankJump.OOPConsole.Common;
using YetGenAkbankJump.OOPConsole.Enums;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class AccessControlLog : EntityBase<Guid>
    {

        public long PersonId { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string DeviceSerialNo { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public AccessType AccessType { get; set; }
        public DateTime LogTime { get; set; }


        public static AccessType ConvertStringToAccessType(string accessType)
        {
            switch (accessType)
            {
                case "FP":
                    return AccessType.FingerPrint;

                case "FACE":
                    return AccessType.Face;

                case "CARD":
                    return AccessType.Card;

                default:
                    throw new Exception("CiYuAydi");
            }
        }
    }
}