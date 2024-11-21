using EmployeeDB.Data;
using EmployeeDB.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace EmployeeDB
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadData();
        }

        private void LoadData()
        {
            // inner join
            var employees = _context.Employees
                .Join(_context.Departments,
                    e => e.DepartmentId,
                    d => d.Id,
                    (e, d) => new
                    {
                        e.Id,
                        e.FirstName,
                        e.LastName,
                        e.AnnualSalary,
                        e.IsManager,
                        DepartmentName = d.LongName
                    }).ToList();

            dataGridView1.DataSource = employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                FirstName = "New",
                LastName = "Employee",
                AnnualSalary = 50000,
                IsManager = false,
                DepartmentId = 1
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    employee.FirstName = "Updated";
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }
    }
}
