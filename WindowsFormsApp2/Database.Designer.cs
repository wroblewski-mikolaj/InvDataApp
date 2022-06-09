
namespace WindowsFormsApp2
{
    partial class Database
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
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(118, 52);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Location = new System.Drawing.Point(501, 119);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(197, 54);
            this.btnCreateDatabase.TabIndex = 2;
            this.btnCreateDatabase.Text = "Create new Database";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(501, 214);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(197, 42);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Add Persons Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 20;
            this.peopleFoundListbox.Location = new System.Drawing.Point(32, 119);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(287, 284);
            this.peopleFoundListbox.TabIndex = 4;
            this.peopleFoundListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(219, 49);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(190, 26);
            this.LastNameText.TabIndex = 5;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastNameLabel);
            this.Name = "Database";
            this.Text = "Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox LastNameText;
    }
}

