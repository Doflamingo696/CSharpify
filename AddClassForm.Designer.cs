namespace AttendanceSystem
{
    partial class AddClassForm
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
            this.tbAddClassFormAddClass = new MetroFramework.Controls.MetroTextBox();
            this.btnAddClassFormAccept = new MetroFramework.Controls.MetroButton();
            this.lblAddClassFormClassName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tbAddClassFormAddClass
            // 
            this.tbAddClassFormAddClass.Location = new System.Drawing.Point(183, 194);
            this.tbAddClassFormAddClass.Name = "tbAddClassFormAddClass";
            this.tbAddClassFormAddClass.Size = new System.Drawing.Size(446, 23);
            this.tbAddClassFormAddClass.TabIndex = 0;
            this.tbAddClassFormAddClass.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // btnAddClassFormAccept
            // 
            this.btnAddClassFormAccept.Location = new System.Drawing.Point(554, 223);
            this.btnAddClassFormAccept.Name = "btnAddClassFormAccept";
            this.btnAddClassFormAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAddClassFormAccept.TabIndex = 2;
            this.btnAddClassFormAccept.Text = "Accept";
            this.btnAddClassFormAccept.Click += new System.EventHandler(this.btnAddClassFormAccept_Click);
            // 
            // lblAddClassFormClassName
            // 
            this.lblAddClassFormClassName.AutoSize = true;
            this.lblAddClassFormClassName.Location = new System.Drawing.Point(183, 172);
            this.lblAddClassFormClassName.Name = "lblAddClassFormClassName";
            this.lblAddClassFormClassName.Size = new System.Drawing.Size(81, 19);
            this.lblAddClassFormClassName.TabIndex = 3;
            this.lblAddClassFormClassName.Text = "Class Name:";
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAddClassFormClassName);
            this.Controls.Add(this.btnAddClassFormAccept);
            this.Controls.Add(this.tbAddClassFormAddClass);
            this.Name = "AddClassForm";
            this.Text = "Add Class";
            this.Load += new System.EventHandler(this.AddClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbAddClassFormAddClass;
        private MetroFramework.Controls.MetroButton btnAddClassFormAccept;
        private MetroFramework.Controls.MetroLabel lblAddClassFormClassName;
    }
}