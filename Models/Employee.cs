namespace Microsoft_Studio.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Employee
    {
        public string EmpId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }

        public string EmpDegree { get; set; }
        public string EmpPhone { get; set; }
    }
}
