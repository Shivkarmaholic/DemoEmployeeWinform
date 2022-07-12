namespace DemoEmployeeWinform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Employee_Id = new System.Windows.Forms.TextBox();
            this.txt_Employee_Name = new System.Windows.Forms.TextBox();
            this.txt_Employee_Salary = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Bin_Read = new System.Windows.Forms.Button();
            this.btn_Xml_Write = new System.Windows.Forms.Button();
            this.btn_Xml_Read = new System.Windows.Forms.Button();
            this.btn_Soap_Write = new System.Windows.Forms.Button();
            this.btn_Soap_Read = new System.Windows.Forms.Button();
            this.btn_Json_Write = new System.Windows.Forms.Button();
            this.btn_Json_Read = new System.Windows.Forms.Button();
            this.btn_Bin_Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Salary";
            // 
            // txt_Employee_Id
            // 
            this.txt_Employee_Id.Location = new System.Drawing.Point(128, 52);
            this.txt_Employee_Id.Name = "txt_Employee_Id";
            this.txt_Employee_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Employee_Id.TabIndex = 3;
            // 
            // txt_Employee_Name
            // 
            this.txt_Employee_Name.Location = new System.Drawing.Point(128, 92);
            this.txt_Employee_Name.Name = "txt_Employee_Name";
            this.txt_Employee_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Employee_Name.TabIndex = 4;
            // 
            // txt_Employee_Salary
            // 
            this.txt_Employee_Salary.Location = new System.Drawing.Point(128, 135);
            this.txt_Employee_Salary.Name = "txt_Employee_Salary";
            this.txt_Employee_Salary.Size = new System.Drawing.Size(100, 20);
            this.txt_Employee_Salary.TabIndex = 5;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(49, 173);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Bin_Read
            // 
            this.btn_Bin_Read.Location = new System.Drawing.Point(346, 50);
            this.btn_Bin_Read.Name = "btn_Bin_Read";
            this.btn_Bin_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Bin_Read.TabIndex = 8;
            this.btn_Bin_Read.Text = "Binary Read";
            this.btn_Bin_Read.UseVisualStyleBackColor = true;
            this.btn_Bin_Read.Click += new System.EventHandler(this.btn_Bin_Read_Click);
            // 
            // btn_Xml_Write
            // 
            this.btn_Xml_Write.Location = new System.Drawing.Point(254, 93);
            this.btn_Xml_Write.Name = "btn_Xml_Write";
            this.btn_Xml_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Xml_Write.TabIndex = 10;
            this.btn_Xml_Write.Text = "XML Write";
            this.btn_Xml_Write.UseVisualStyleBackColor = true;
            this.btn_Xml_Write.Click += new System.EventHandler(this.btn_Xml_Write_Click);
            // 
            // btn_Xml_Read
            // 
            this.btn_Xml_Read.Location = new System.Drawing.Point(346, 93);
            this.btn_Xml_Read.Name = "btn_Xml_Read";
            this.btn_Xml_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Xml_Read.TabIndex = 9;
            this.btn_Xml_Read.Text = "XML Read";
            this.btn_Xml_Read.UseVisualStyleBackColor = true;
            this.btn_Xml_Read.Click += new System.EventHandler(this.btn_Xml_Read_Click);
            // 
            // btn_Soap_Write
            // 
            this.btn_Soap_Write.Location = new System.Drawing.Point(254, 133);
            this.btn_Soap_Write.Name = "btn_Soap_Write";
            this.btn_Soap_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Soap_Write.TabIndex = 12;
            this.btn_Soap_Write.Text = "Soap Write";
            this.btn_Soap_Write.UseVisualStyleBackColor = true;
            this.btn_Soap_Write.Click += new System.EventHandler(this.btn_Soap_Write_Click);
            // 
            // btn_Soap_Read
            // 
            this.btn_Soap_Read.Location = new System.Drawing.Point(346, 133);
            this.btn_Soap_Read.Name = "btn_Soap_Read";
            this.btn_Soap_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Soap_Read.TabIndex = 11;
            this.btn_Soap_Read.Text = "Soap Read";
            this.btn_Soap_Read.UseVisualStyleBackColor = true;
            this.btn_Soap_Read.Click += new System.EventHandler(this.btn_Soap_Read_Click);
            // 
            // btn_Json_Write
            // 
            this.btn_Json_Write.Location = new System.Drawing.Point(254, 173);
            this.btn_Json_Write.Name = "btn_Json_Write";
            this.btn_Json_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Json_Write.TabIndex = 14;
            this.btn_Json_Write.Text = "Json Write";
            this.btn_Json_Write.UseVisualStyleBackColor = true;
            this.btn_Json_Write.Click += new System.EventHandler(this.btn_Json_Write_Click);
            // 
            // btn_Json_Read
            // 
            this.btn_Json_Read.Location = new System.Drawing.Point(346, 173);
            this.btn_Json_Read.Name = "btn_Json_Read";
            this.btn_Json_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Json_Read.TabIndex = 13;
            this.btn_Json_Read.Text = "Json Read";
            this.btn_Json_Read.UseVisualStyleBackColor = true;
            this.btn_Json_Read.Click += new System.EventHandler(this.btn_Json_Read_Click);
            // 
            // btn_Bin_Write
            // 
            this.btn_Bin_Write.Location = new System.Drawing.Point(254, 49);
            this.btn_Bin_Write.Name = "btn_Bin_Write";
            this.btn_Bin_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Bin_Write.TabIndex = 16;
            this.btn_Bin_Write.Text = "Binary Write";
            this.btn_Bin_Write.UseVisualStyleBackColor = true;
            this.btn_Bin_Write.Click += new System.EventHandler(this.btn_Bin_Write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 350);
            this.Controls.Add(this.btn_Bin_Write);
            this.Controls.Add(this.btn_Json_Write);
            this.Controls.Add(this.btn_Json_Read);
            this.Controls.Add(this.btn_Soap_Write);
            this.Controls.Add(this.btn_Soap_Read);
            this.Controls.Add(this.btn_Xml_Write);
            this.Controls.Add(this.btn_Xml_Read);
            this.Controls.Add(this.btn_Bin_Read);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txt_Employee_Salary);
            this.Controls.Add(this.txt_Employee_Name);
            this.Controls.Add(this.txt_Employee_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Employee_Id;
        private System.Windows.Forms.TextBox txt_Employee_Name;
        private System.Windows.Forms.TextBox txt_Employee_Salary;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Bin_Read;
        private System.Windows.Forms.Button btn_Xml_Write;
        private System.Windows.Forms.Button btn_Xml_Read;
        private System.Windows.Forms.Button btn_Soap_Write;
        private System.Windows.Forms.Button btn_Soap_Read;
        private System.Windows.Forms.Button btn_Json_Write;
        private System.Windows.Forms.Button btn_Json_Read;
        private System.Windows.Forms.Button btn_Bin_Write;
    }
}