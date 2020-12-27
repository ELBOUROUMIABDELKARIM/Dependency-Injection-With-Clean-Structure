
namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.GetAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.personFnameText = new System.Windows.Forms.TextBox();
            this.personLnameText = new System.Windows.Forms.TextBox();
            this.personEmailText = new System.Windows.Forms.TextBox();
            this.personPhone = new System.Windows.Forms.TextBox();
            this.addPerson = new System.Windows.Forms.Button();
            this.errorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.peopleFoundListbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peopleFoundListbox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 17;
            this.peopleFoundListbox.Location = new System.Drawing.Point(25, 87);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(274, 259);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Font = new System.Drawing.Font("Microsoft JhengHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.Location = new System.Drawing.Point(149, 52);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(150, 23);
            this.LastNameText.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(33, 54);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(88, 16);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name :";
            this.LastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(196, 352);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // GetAll
            // 
            this.GetAll.Location = new System.Drawing.Point(46, 352);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(75, 23);
            this.GetAll.TabIndex = 4;
            this.GetAll.Text = "Get All";
            this.GetAll.UseVisualStyleBackColor = true;
            this.GetAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(368, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 323);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number :";
            // 
            // personFnameText
            // 
            this.personFnameText.Location = new System.Drawing.Point(504, 84);
            this.personFnameText.Name = "personFnameText";
            this.personFnameText.Size = new System.Drawing.Size(159, 20);
            this.personFnameText.TabIndex = 10;
            // 
            // personLnameText
            // 
            this.personLnameText.Location = new System.Drawing.Point(504, 135);
            this.personLnameText.Name = "personLnameText";
            this.personLnameText.Size = new System.Drawing.Size(159, 20);
            this.personLnameText.TabIndex = 11;
            // 
            // personEmailText
            // 
            this.personEmailText.Location = new System.Drawing.Point(504, 192);
            this.personEmailText.Name = "personEmailText";
            this.personEmailText.Size = new System.Drawing.Size(159, 20);
            this.personEmailText.TabIndex = 12;
            // 
            // personPhone
            // 
            this.personPhone.Location = new System.Drawing.Point(504, 250);
            this.personPhone.Name = "personPhone";
            this.personPhone.Size = new System.Drawing.Size(159, 20);
            this.personPhone.TabIndex = 13;
            this.personPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personPhone_KeyPress);
            // 
            // addPerson
            // 
            this.addPerson.Location = new System.Drawing.Point(504, 292);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(75, 23);
            this.addPerson.TabIndex = 14;
            this.addPerson.Text = "Add Person";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // errorListBox
            // 
            this.errorListBox.ForeColor = System.Drawing.Color.DarkRed;
            this.errorListBox.FormattingEnabled = true;
            this.errorListBox.Location = new System.Drawing.Point(395, 333);
            this.errorListBox.Name = "errorListBox";
            this.errorListBox.Size = new System.Drawing.Size(336, 95);
            this.errorListBox.TabIndex = 15;
            this.errorListBox.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.errorListBox);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.personPhone);
            this.Controls.Add(this.personEmailText);
            this.Controls.Add(this.personLnameText);
            this.Controls.Add(this.personFnameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetAll);
            this.Controls.Add(this.search);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button GetAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personFnameText;
        private System.Windows.Forms.TextBox personLnameText;
        private System.Windows.Forms.TextBox personEmailText;
        private System.Windows.Forms.TextBox personPhone;
        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.ListBox errorListBox;
    }
}

