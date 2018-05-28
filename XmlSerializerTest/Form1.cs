using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XmlSerializerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Age = 5;
            student.FirstName = string.Empty;
            student.LastName = "";
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            StringWriter sw = new StringWriter();
            xs.Serialize(sw, student);
            textBox1.Text = sw.ToString();
        }
    }

    public class Student
    {
       
        public string FirstName { get; set; }

       // [XmlElement, DefaultValue("")]
        public string LastName { get; set; }
        public int Age { get; set; }

        public DateTime RegistrationDate { get; set; }

        public decimal Salary { get; set; }
    }

}
