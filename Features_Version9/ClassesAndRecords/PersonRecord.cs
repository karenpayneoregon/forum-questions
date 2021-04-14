using System.ComponentModel;

namespace Features_Version9.ClassesAndRecords
{
    public record PersonRecord(
        [Description("First Name")] string FirstName, 
        [Description("First Name")] string LastName);
}
