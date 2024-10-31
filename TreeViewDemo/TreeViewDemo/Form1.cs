using System.ComponentModel;

namespace TreeViewDemo
{
    public partial class Form1 : Form
    {
        ////data binding manually 
        //private List<Department> departments;
        //private List<Employee> employees;

        // data binding
        private BindingList<Department> departments;
        private BindingList<Employee> employees;
        public Form1()
        {
            InitializeComponent();
            InitializeTreeView();
        }
        private void InitializeTreeView()
        {
            //TreeNode rootNode = new TreeNode("Company Departments");

            //TreeNode hrNode = new TreeNode("Human Resources");
            //hrNode.Nodes.Add("Employee1");
            //hrNode.Nodes.Add("Employee2");

            //TreeNode itNode = new TreeNode("Finance");
            //itNode.Nodes.Add("Employee3");
            //itNode.Nodes.Add("Employee4");

            //TreeNode salesNode = new TreeNode("Technology");
            //salesNode.Nodes.Add("Employee5");
            //salesNode.Nodes.Add("Employee6");

            //rootNode.Nodes.Add(hrNode);
            //rootNode.Nodes.Add(itNode);
            //rootNode.Nodes.Add(salesNode);

            //treeView1.Nodes.Add(rootNode);

            ////////////////////Get data and show ///////////////////
            departments = new BindingList<Department>(Data.GetDepartments());
            employees = new BindingList<Employee>(Data.GetEmployees());

            UpdateTreeView();
            employees.ListChanged += (sender, e) => { UpdateTreeView(); };
            departments.ListChanged += (sender, e) => { UpdateTreeView(); };
        }
        private void UpdateTreeView() 
        {
            // before create a treeview, clear first
            treeView1.Nodes.Clear();
            
            foreach (Department department in departments)
            {
                TreeNode departmentNode = new TreeNode(department.LongName);

                IEnumerable<Employee> departmentEmployees = employees.Where(e => e.DepartmentId == department.Id);

                foreach (Employee employee in departmentEmployees)
                {
                    TreeNode employeeNode = new TreeNode($"{employee.FirstName} {employee.LastName}");
                    departmentNode.Nodes.Add(employeeNode);
                }

                treeView1.Nodes.Add(departmentNode);
            }
            treeView1.ExpandAll();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee
            {
                Id = 5,
                FirstName = "Tom",
                LastName = "Hanks",
                AnnualSalary = 50000.0m,
                IsManager = false,
                DepartmentId = 1
            });


            //departments.Add(new Department
            //{
            //    Id = 4,
            //    ShortName = "IT",
            //    LongName = "IT Service"
            //});

            //// update manually
            //UpdateTreeView();
        }
    }
}
