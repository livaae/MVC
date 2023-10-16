// See https://aka.ms/new-console-template for more information

//using System.Linq.Expressions;
//using System.Text.Json;
//using System.Threading.Channels;
//using YetGenAkbankJump.OOPConsole.Entities;
//using YetGenAkbankJump.OOPConsole.Enums;
//using YetGenAkbankJump.OOPConsole.Services;
/*
var student = new Student()
{
Id = Guid.NewGuid(),
FirstName = "Alper",
LastName = "Tunga",
Gender = Gender.Unknown,
No = 1,
CreatedOn = DateTimeOffset.Now,
RegistrationDate = DateTimeOffset.Now.AddHours(-1),
};

var secondStudent = new Student()
{
Id = Guid.NewGuid(),
FirstName = "Yakup",
LastName = "Sıtacı",
Gender = Gender.Male,
No = 2,
CreatedOn = DateTimeOffset.Now,
RegistrationDate = DateTimeOffset.Now.AddHours(-1),
};

List<Student> students = new List<Student>();

students.Add(student);
students.Add(secondStudent);

students.ForEach(x => Console.WriteLine($"Student Information: No- {x.No} - {x.FirstName} {x.LastName} {x.Gender}"));

Console.ReadLine();*/
/*var consoleLogger = new ConsoleLogger("Alper Hoca's Logger");

try
{
    var filePath = "C:\\Users\\livan\\OneDrive\\Masaüstü\\AccessControlLogs.txt";

    var textFile = File.ReadAllText(filePath);

    var splittedLines = textFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

    Console.WriteLine("Lines are splitted.");
    List<AccessControlLog> logs = new();

    foreach (var splittedLine in splittedLines)
    {
        var values = splittedLine.Split("---", StringSplitOptions.RemoveEmptyEntries); //valyus

        var accessControlLog = new AccessControlLog()
        {
            Id = Guid.NewGuid(),
            CreatedOn = DateTimeOffset.Now,
            PersonId = Convert.ToInt64(values[0]),
            DeviceSerialNo = values[1],
            AccessType = AccessControlLog.ConvertStringToAccessType(values[2]),
            LogTime = Convert.ToDateTime(values[3]),

        };
        logs.Add(accessControlLog);
    }
    consoleLogger.Log("All lines are converted to objects.");

    //Console.WriteLine(JsonSerializer.Serialize(logs));

    File.WriteAllText("C:\\Users\\livan\\OneDrive\\Masaüstü\\AccessControlLogsJson.txt", JsonSerializer.Serialize(logs));
    consoleLogger.Log("The JSON file was successfully created.");

    consoleLogger.Log("The operation was successfully completed.");
    Console.WriteLine(consoleLogger.Name);
    Console.ReadLine();

}
catch (Exception ex)
{
    consoleLogger.Log(ex.Message);
    FileLogger.Log(ex.Message);
}

List<object> myObjects = new List<object>();
myObjects.Add(consoleLogger);
myObjects.Add(FileLogger);

logs.ForEach(x => myObjects.Add(x));

foreach (var myObject in myObjects)
{
    if (myObject is LoggerBase)

        if (myObject is ICreatedByEntity)
        {
            var entity = myObject as ICrearedByEntity;
            entity.CreatedOn = DateTimeOffset.Now;
        }

    if (myObject is IDeletedByEntity)
    {
        var entity = myObject as IDeletedByEntity;
        entity.CreatedOn = DateTimeOffset.Now;

    }


}*/


//Alper hocanin notlari: 5.10.2023
/*
using YetGenAkbankJump.OOPConsole.Utilities;

var passwordGenerator = new PasswordGenerator();

Console.WriteLine("Lütfen şifreniz için istediğiniz karakter sayısını giriniz.");

var passwordLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Şifreniz sayıları içersin mi?");

var includeNumbers = Console.ReadLine() == "evet";

Console.WriteLine("Şifreniz küçük karakterleri içersin mi?");

var includeLowerCase = Console.ReadLine() == "evet";

Console.WriteLine("Şifreniz büyük karakterleri içersin mi?");

var includeUpperCase = Console.ReadLine() == "evet";

Console.WriteLine("Şifreniz özel karakterleri içersin mi?");

var includeSpecialChars = Console.ReadLine() == "evet";

var password = passwordGenerator.Generate(passwordLength, includeNumbers, includeLowerCase, includeUpperCase, includeSpecialChars);

Console.WriteLine($"Şifreniz:{password}");

Console.ReadLine();

return 1;

//explicit değer veri kaybi olan
//new oldugu zaman yeni referans
*/


using YetGenAkbankJump.OOPConsole.Utilities;

var passwordGenerator = new PasswordGenerator();

Console.WriteLine("Lütfen şifreniz için istediğiniz karakter sayısını giriniz.");

var passwordLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Şifreniz sayıları içersin mi?");

var includeNumbers = Console.ReadLine() == "evet";

Console.WriteLine("Şifreniz küçük karakterleri içersin mi?");

var includeLowerCase = Console.ReadLine() == "evet";

Console.WriteLine("Şifreniz büyük karakterleri içersin mi?");

var includeUpperCase = Console.ReadLine() == "evet";

Console.WriteLine("Şifreniz özel karakterleri içersin mi?");

var includeSpecialChars = Console.ReadLine() == "evet";

var password = passwordGenerator.Generate(passwordLength, includeNumbers, includeLowerCase, includeUpperCase, includeSpecialChars);

Console.WriteLine($"Şifreniz:{password}");

Console.ReadLine();

return 1;


