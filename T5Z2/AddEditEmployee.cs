using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace T5Z2
{
    public partial class AddEditEmployee : Form
    {
        private int _employeeId;
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            this._employeeId = id;
            GetEmployeesData();
        }

        private void GetEmployeesData()
        {
            if (_employeeId != 0)
            {
                var employees = JsonHelper<List<Employee>>.DeserializeFromJson(Program.JsonPath);
                var employee = (from emp in employees
                                where emp.Id == _employeeId
                                select emp).FirstOrDefault();

                if (employee == null)
                    throw new Exception($"Pracownik o podanym {_employeeId} nie istnieje.");

                tbId.Text = employee.Id.ToString();
                tbFirstName.Text = employee.FirstName;
                tbLastName.Text = employee.LastName;
                dtpEmploymentDate.Value = employee.EmploymentDate ?? DateTime.Today;
                dtpDismissalDate.Value = employee.DismissalDate ?? DateTime.Today;
                dtpDismissalDate.Checked = employee.DismissalDate.HasValue ? true : false;
                nudSalary.Value = employee.Salary;
                rtbFeedback.Text = employee.Feedback;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = JsonHelper<List<Employee>>.DeserializeFromJson(Program.JsonPath);
            int maxId = AssignMaxEmployeeID(employees);

            if (_employeeId != 0)
            {
                employees.RemoveAll(emp => emp.Id == _employeeId);

            }
            else
            {
                _employeeId = maxId;
            }

            AddNewEmployee(employees);

            JsonHelper<List<Employee>>.SerializeToJson(employees, Program.JsonPath);
            Close();
        }

        private void AddNewEmployee(List<Employee> employees)
        {
            var newEmployee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                EmploymentDate = dtpEmploymentDate.Value.Date,
                DismissalDate = dtpDismissalDate.Checked ? dtpDismissalDate?.Value : null,
                Salary = nudSalary.Value,
                Feedback = rtbFeedback.Text
            };
            employees.Add(newEmployee);
        }

        private static int AssignMaxEmployeeID(List<Employee> employees)
        {
            var maxId = (from emp in employees
                         orderby emp.Id descending
                         select emp.Id).FirstOrDefault();

            maxId++;
            return maxId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
