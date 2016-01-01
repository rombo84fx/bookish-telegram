using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        int index = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student1 = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            students.Add(student1);
            index = students.Count - 1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            MessageBox.Show("Student created");
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (students.Count != 0)
            {
                if (index == 0)
                {
                    index = students.Count - 1;
                }
                else
                {
                    index--;
                }
                populateTextBoxes(index);
            }
            else
            {
                MessageBox.Show("There are no students in the collection.");
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (students.Count != 0)
            {
                if (index == (students.Count - 1))
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
                populateTextBoxes(index);
            }
            else
            {
                MessageBox.Show("There are no students in the collection.");
            }
        }

        private void populateTextBoxes(int index)
        {
            txtFirstName.Text = students[index].FirstName;
            txtLastName.Text = students[index].LastName;
            txtCity.Text = students[index].City;
        }
    }
}
