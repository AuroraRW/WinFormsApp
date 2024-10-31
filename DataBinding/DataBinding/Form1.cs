using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        private Person person;
        //private List<Person> people;
        private BindingList<Person> people;
        public Form1()
        {
            InitializeComponent();

            // bind object
            person = new Person { Name = "Tom", Age = 25 };

            // when UI update, notify data
            //txtName.DataBindings.Add("Text", person, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            //txtAge.DataBindings.Add("Text", person, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            //lblName.DataBindings.Add("Text", person, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            //lblAge.DataBindings.Add("Text", person, "Age", true, DataSourceUpdateMode.OnPropertyChanged);

            // List can not notify property change
            //people = new List<Person>
            //{
            //    new Person { Name = "Alice", Age = 25 },
            //    new Person { Name = "Bob", Age = 30 }
            //};

            people = new BindingList<Person>
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 }
            };
            // bind list to comboBox
            comboBox1.DataSource = people;
            comboBox1.DisplayMember = "Name";

            // bind list to listBox
            listBox1.DataSource = people;
            listBox1.DisplayMember = "Name";

            // bind list to dataGridView 
            dataGridView1.DataSource = people;

            // bind DataTable to dataGridView
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Rows.Add("Lily", 17);
            table.Rows.Add("Mary", 30);

            //dataGridView1.DataSource = table;

            ///////////////when PropertyChanged event trigger, call Person_PropertyChanged function///////////////
            person.PropertyChanged += Person_PropertyChanged;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            person.Name = "Bob";
            person.Age = 20;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            people.Add(new Person { Name = person.Name, Age = person.Age });
        }

        private static void Person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show($"{e.PropertyName} property has changed.");
        }
    }
}
