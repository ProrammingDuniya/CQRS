namespace Application.Model
{
    /// <summary>
    /// EmployeeCreateModel
    /// </summary>
    public class EmployeeCreateModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }
}
