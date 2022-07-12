using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace DemoEmployeeWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Employee_Id.Clear();
            txt_Employee_Name.Clear();
            txt_Employee_Salary.Clear();
        }

        private void btn_Bin_Write_Click(object sender, EventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.Emp_Id = Convert.ToInt32(txt_Employee_Id.Text);
                emp.Emp_Name = txt_Employee_Name.Text;
                emp.Emp_salary = Convert.ToInt32(txt_Employee_Salary.Text);
                FileStream fs = new FileStream("d:\\demoempbinary", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Binary Write Completed!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Bin_Read_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\demoempbinary", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp = (Employee)bf.Deserialize(fs);
            txt_Employee_Id.Text = (emp.Emp_Id).ToString(); ;
            txt_Employee_Name.Text = emp.Emp_Name;
            txt_Employee_Salary.Text = (emp.Emp_salary).ToString();
            MessageBox.Show("Binary Read Completed!!");

        }

        private void btn_Xml_Write_Click(object sender, EventArgs e)
        {

            try
            {

                Employee emp = new Employee();
                emp.Emp_Id = Convert.ToInt32(txt_Employee_Id.Text);
                emp.Emp_Name = txt_Employee_Name.Text;
                emp.Emp_salary = Convert.ToInt32(txt_Employee_Salary.Text);
                FileStream fs = new FileStream("d:\\demoempxml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("XML Write Completed!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xml_Read_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\demoempxml", FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            Employee emp = (Employee)xs.Deserialize(fs);
            txt_Employee_Id.Text = (emp.Emp_Id).ToString(); ;
            txt_Employee_Name.Text = emp.Emp_Name;
            txt_Employee_Salary.Text = (emp.Emp_salary).ToString();
            MessageBox.Show("XML Read Completed!!");
        }

        private void btn_Soap_Write_Click(object sender, EventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.Emp_Id = Convert.ToInt32(txt_Employee_Id.Text);
                emp.Emp_Name = txt_Employee_Name.Text;
                emp.Emp_salary = Convert.ToInt32(txt_Employee_Salary.Text);
                FileStream fs = new FileStream("d:\\demoempsoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("SOAP Write Completed!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Soap_Read_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\demoempsoap", FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            Employee emp = (Employee)sf.Deserialize(fs);
            txt_Employee_Id.Text = (emp.Emp_Id).ToString(); ;
            txt_Employee_Name.Text = emp.Emp_Name;
            txt_Employee_Salary.Text = (emp.Emp_salary).ToString();
            MessageBox.Show("SOAP Read Completed!!");
        }

        private void btn_Json_Write_Click(object sender, EventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.Emp_Id = Convert.ToInt32(txt_Employee_Id.Text);
                emp.Emp_Name = txt_Employee_Name.Text;
                emp.Emp_salary = Convert.ToInt32(txt_Employee_Salary.Text);
                FileStream fs = new FileStream("d:\\demoempjson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, emp);                
                fs.Close();
                MessageBox.Show("JSON Write Completed!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btn_Json_Read_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\demoempjson", FileMode.Open, FileAccess.Read);
            Employee emp=  JsonSerializer.Deserialize<Employee>(fs) ;           
            txt_Employee_Id.Text = (emp.Emp_Id).ToString(); ;
            txt_Employee_Name.Text = emp.Emp_Name;
            txt_Employee_Salary.Text = (emp.Emp_salary).ToString();
            MessageBox.Show("JSON Read Completed!!"); 
        }
    } 
}
