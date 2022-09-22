
namespace _2022_Inheritance_Example
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSalaraFee = new System.Windows.Forms.Label();
            this.lblCommisionCalculated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(539, 51);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(118, 56);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click_1);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(539, 135);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(118, 57);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click_1);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(36, 51);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(112, 20);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "Student Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(36, 87);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 20);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(36, 121);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(102, 20);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(36, 155);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 20);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id Number";
            // 
            // lblSalaraFee
            // 
            this.lblSalaraFee.AutoSize = true;
            this.lblSalaraFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaraFee.Location = new System.Drawing.Point(35, 199);
            this.lblSalaraFee.Name = "lblSalaraFee";
            this.lblSalaraFee.Size = new System.Drawing.Size(103, 20);
            this.lblSalaraFee.TabIndex = 6;
            this.lblSalaraFee.Text = "Salary or Fee";
            // 
            // lblCommisionCalculated
            // 
            this.lblCommisionCalculated.AutoSize = true;
            this.lblCommisionCalculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommisionCalculated.Location = new System.Drawing.Point(36, 244);
            this.lblCommisionCalculated.Name = "lblCommisionCalculated";
            this.lblCommisionCalculated.Size = new System.Drawing.Size(196, 20);
            this.lblCommisionCalculated.TabIndex = 7;
            this.lblCommisionCalculated.Text = "Commission or Calculated ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.lblCommisionCalculated);
            this.Controls.Add(this.lblSalaraFee);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSalaraFee;
        private System.Windows.Forms.Label lblCommisionCalculated;
    }
}

