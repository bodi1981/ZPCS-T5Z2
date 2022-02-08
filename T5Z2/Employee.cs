using System;

namespace T5Z2
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public int Salary { get; set; }
        public string Feedback { get; set; }
    }
}
