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
                tbEmploymentDate.Text = employee.EmploymentDate == DateTime.MinValue ? "" : employee.EmploymentDate.ToString("yyyy-MM-dd");
                tbDismissalDate.Text = employee.DismissalDate == DateTime.MinValue ? "" : employee.DismissalDate.ToString("yyyy-MM-dd");
                tbSalary.Text = employee.Salary.ToString();
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

            if (!ValidateDate(GetDate(tbEmploymentDate.Text)))
            {
                MessageBox.Show($"Wprowadzona {lblEmploymentDate.Text} jest nieprawidłowa", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateDate(GetDate(tbDismissalDate.Text)))
            {
                MessageBox.Show($"Wprowadzona {lblDismissalDate.Text} jest nieprawidłowa", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                EmploymentDate = GetDate(tbEmploymentDate.Text),
                DismissalDate = GetDate(tbDismissalDate.Text),
                Salary = int.TryParse(tbSalary.Text, out int salary) ? salary : 0,
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

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private DateTime GetDate(string date)
        {
            if (date == "")
                return DateTime.MinValue;
            if (DateTime.TryParse(date, out DateTime validDate))
            {
                return validDate;
            }
            else
                return DateTime.MaxValue;
        }

        private bool ValidateDate(DateTime date)
        {
            if (date == DateTime.MaxValue)
                return false;
            else
                return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
