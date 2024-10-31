using System.Windows.Forms;
using System.ComponentModel;

namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        private BindingList<Employee> employees;
        private BindingList<Department> departments;
        public Form1()
        {
            InitializeComponent();
            //listView1.Columns.Add("File Name", 150);
            //listView1.Columns.Add("File Type", 100);
            //listView1.Columns.Add("Size(KB)", 80);
            //listView1.Columns.Add("Modified Date", 120);

            //ListViewItem item = new ListViewItem("document1.txt");
            //item.SubItems.Add("Text file");
            //item.SubItems.Add("15");
            //item.SubItems.Add("2024-10-29");
            //listView1.Items.Add(item);

            LoadData(listView1);
        }

        private void LoadData(ListView listView)
        {
            listView.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listView.Columns.Add("First Name", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Annual Salary", 100, HorizontalAlignment.Right);
            listView.Columns.Add("Is Manager", 80, HorizontalAlignment.Center);
            listView.Columns.Add("Department", 120, HorizontalAlignment.Left);

            employees = new BindingList<Employee>(Data.GetEmployees());
            departments = new BindingList<Department>(Data.GetDepartments());

            foreach (Employee employee in employees)
            {
                Department dept = departments.FirstOrDefault(d => d.Id == employee.DepartmentId);
                string departmentName = dept != null ? dept.ShortName : "Unknown";

                ListViewItem item = new ListViewItem(employee.Id.ToString());
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.AnnualSalary.ToString());
                item.SubItems.Add(employee.IsManager ? "Yes" : "No");
                item.SubItems.Add(departmentName);

                listView.Items.Add(item);
            }

            employees.ListChanged += UpdateListView;

        }
        private void UpdateListView(object sender, ListChangedEventArgs e)
        {
            listView1.Items.Clear();
            foreach (Employee employee in employees)
            {
                Department dept = departments.FirstOrDefault(d => d.Id == employee.DepartmentId);
                string departmentName = dept != null ? dept.ShortName : "Unknown";

                ListViewItem item = new ListViewItem(employee.Id.ToString());
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.AnnualSalary.ToString());
                item.SubItems.Add(employee.IsManager ? "Yes" : "No");
                item.SubItems.Add(departmentName);

                listView1.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                employees.Add(new Employee  
                {
                    Id = employees.Count + 1,
                    FirstName = "New",
                    LastName = "Employee",
                    AnnualSalary = 45000m,
                    IsManager = false,
                    DepartmentId = 3
                });
        }
    }
}
