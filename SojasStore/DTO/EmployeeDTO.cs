using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; init; }
        public int Ssn { get; init; }
        public string Name { get; init; }
        public string PhoneNumber { get; init; }
    }
}
