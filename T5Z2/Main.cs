using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace T5Z2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SetEmployeeGrupsComboBox();
            SetColumnHeaders();
            RefreshMain();
        }

        private void SetColumnHeaders()
        {
            dgvEmployees.Columns[nameof(Employee.Id)].HeaderText = "ID";
            dgvEmployees.Columns[nameof(Employee.FirstName)].HeaderText = "Imię";
            dgvEmployees.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
            dgvEmployees.Columns[nameof(Employee.EmploymentDate)].HeaderText = "Data zatrudnienia";
            dgvEmployees.Columns[nameof(Employee.DismissalDate)].HeaderText = "Data zwolnienia";
            dgvEmployees.Columns[nameof(Employee.Salary)].HeaderText = "Wynagrodzenie";
            dgvEmployees.Columns[nameof(Employee.Feedback)].HeaderText = "Uwagi";
        }

        private void SetEmployeeGrupsComboBox()
        {
            var employeeGroups = new List<EmployeeGroup>
            {
                new EmployeeGroup { Id = 0, Name = "Wszyscy" },
                new EmployeeGroup { Id = 1, Name = "Pracujący"},
                new EmployeeGroup { Id = 2, Name = "Zwolnieni"}
            };

            cmbEmployeeGroups.DataSource = employeeGroups;
            cmbEmployeeGroups.DisplayMember = "Name";
            cmbEmployeeGroups.ValueMember = "Id";
        }

        private void RefreshMain()
        {
            var employeesList = JsonHelper<List<Employee>>.DeserializeFromJson(Program.JsonPath);
            var employeeGroup = ((EmployeeGroup)(cmbEmployeeGroups.SelectedItem)).Id;

            switch (employeeGroup)
            {
                case 1:
                    employeesList = (from emp in employeesList
                                     where emp.DismissalDate == null
                                     orderby emp.Id
                                     select emp).ToList();
                    break;
                case 2:
                    employeesList = (from emp in employeesList
                                     where emp.DismissalDate != null
                                     orderby emp.Id
                                     select emp).ToList();
                    break;
                default:
                    employeesList = (from emp in employeesList
                                     orderby emp.Id
                                     select emp).ToList();
                    break;
            }

            dgvEmployees.DataSource = employeesList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployees = new AddEditEmployee();
            addEditEmployees.Text = "Dodaj";
            addEditEmployees.FormClosing += AddEditEmployees_FormClosing;
            addEditEmployees.ShowDialog();
            addEditEmployees.FormClosing -= AddEditEmployees_FormClosing;

        }

        private void AddEditEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshMain();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.Rows.Count == 0)
            {
                MessageBox.Show($"Proszę wybrać pracownika", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var employeeId = (int)dgvEmployees.SelectedRows[0].Cells[nameof(Employee.Id)].Value;
            var addEditEmployees = new AddEditEmployee(employeeId);
            addEditEmployees.Text = "Edytuj";
            addEditEmployees.FormClosing += AddEditEmployees_FormClosing;
            addEditEmployees.ShowDialog();
            addEditEmployees.FormClosing -= AddEditEmployees_FormClosing;
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.Rows.Count == 0)
            {
                MessageBox.Show($"Proszę wybrać pracownika", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show($"Czy chcesz zwolnić pracownika {dgvEmployees.SelectedRows[0].Cells[nameof(Employee.FirstName)].Value} {dgvEmployees.SelectedRows[0].Cells[nameof(Employee.LastName)].Value}?", "Zwolnienie pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                DismissEmployee();
                RefreshMain();
            }
        }

        private void DismissEmployee()
        {
            var employees = JsonHelper<List<Employee>>.DeserializeFromJson(Program.JsonPath);
            var empId = (int)dgvEmployees.SelectedRows[0].Cells[nameof(Employee.Id)].Value;
            var empFirstName = (string)dgvEmployees.SelectedRows[0].Cells[nameof(Employee.FirstName)].Value;
            var empLastName = (string)dgvEmployees.SelectedRows[0].Cells[nameof(Employee.LastName)].Value;
            var empEmploymentDate = (DateTime)dgvEmployees.SelectedRows[0].Cells[nameof(Employee.EmploymentDate)].Value;
            var empSalary = (decimal)dgvEmployees.SelectedRows[0].Cells[nameof(Employee.Salary)].Value;
            var empComments = (string)dgvEmployees.SelectedRows[0].Cells[nameof(Employee.Feedback)].Value;

            employees.RemoveAll(emp => emp.Id == empId);

            var newEmployee = new Employee
            {
                Id = empId,
                FirstName = empFirstName,
                LastName = empLastName,
                EmploymentDate = empEmploymentDate,
                DismissalDate = DateTime.Today,
                Salary = empSalary,
                Feedback = empComments
            };

            employees.Add(newEmployee);

            JsonHelper<List<Employee>>.SerializeToJson(employees, Program.JsonPath);
        }

        private void cmbEmployeeGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMain();
        }
    }
}
