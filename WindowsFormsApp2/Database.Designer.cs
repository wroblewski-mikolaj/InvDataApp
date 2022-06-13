
namespace WindowsFormsApp2
{
    partial class InvDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvDatabase));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.NameYourTableBox = new System.Windows.Forms.TextBox();
            this.FirstNameInsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameInsTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailInsTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TelNumberInsTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCreateInsertProcedure = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            this.comboSearchBox = new System.Windows.Forms.ComboBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(244, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Location = new System.Drawing.Point(12, 384);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(197, 54);
            this.btnCreateDatabase.TabIndex = 2;
            this.btnCreateDatabase.Text = "Create new Database";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(244, 406);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(234, 38);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 20;
            this.peopleFoundListbox.Location = new System.Drawing.Point(32, 119);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(446, 224);
            this.peopleFoundListbox.TabIndex = 4;
            this.peopleFoundListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(219, 49);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(190, 26);
            this.LastNameText.TabIndex = 5;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // NameYourTableBox
            // 
            this.NameYourTableBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameYourTableBox.Location = new System.Drawing.Point(244, 384);
            this.NameYourTableBox.Name = "NameYourTableBox";
            this.NameYourTableBox.Size = new System.Drawing.Size(234, 26);
            this.NameYourTableBox.TabIndex = 6;
            this.NameYourTableBox.Tag = "";
            this.NameYourTableBox.TextChanged += new System.EventHandler(this.NameYourTableBox_TextChanged);
            // 
            // FirstNameInsTxt
            // 
            this.FirstNameInsTxt.Location = new System.Drawing.Point(586, 119);
            this.FirstNameInsTxt.Name = "FirstNameInsTxt";
            this.FirstNameInsTxt.Size = new System.Drawing.Size(190, 26);
            this.FirstNameInsTxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // LastNameInsTxt
            // 
            this.LastNameInsTxt.Location = new System.Drawing.Point(586, 166);
            this.LastNameInsTxt.Name = "LastNameInsTxt";
            this.LastNameInsTxt.Size = new System.Drawing.Size(190, 26);
            this.LastNameInsTxt.TabIndex = 10;
            this.LastNameInsTxt.TextChanged += new System.EventHandler(this.LastNameInsTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // EmailInsTxt
            // 
            this.EmailInsTxt.Location = new System.Drawing.Point(586, 214);
            this.EmailInsTxt.Name = "EmailInsTxt";
            this.EmailInsTxt.Size = new System.Drawing.Size(190, 26);
            this.EmailInsTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // TelNumberInsTxt
            // 
            this.TelNumberInsTxt.Location = new System.Drawing.Point(586, 261);
            this.TelNumberInsTxt.Name = "TelNumberInsTxt";
            this.TelNumberInsTxt.Size = new System.Drawing.Size(190, 26);
            this.TelNumberInsTxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tel.";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(623, 311);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(114, 48);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCreateInsertProcedure
            // 
            this.btnCreateInsertProcedure.Location = new System.Drawing.Point(572, 406);
            this.btnCreateInsertProcedure.Name = "btnCreateInsertProcedure";
            this.btnCreateInsertProcedure.Size = new System.Drawing.Size(204, 32);
            this.btnCreateInsertProcedure.TabIndex = 16;
            this.btnCreateInsertProcedure.Text = "Create Insert Procedure";
            this.btnCreateInsertProcedure.UseVisualStyleBackColor = true;
            this.btnCreateInsertProcedure.Click += new System.EventHandler(this.btnCreateInsertProcedure_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(240, 361);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(170, 20);
            this.TableLabel.TabIndex = 17;
            this.TableLabel.Text = "Insert new Table name";
            // 
            // comboSearchBox
            // 
            this.comboSearchBox.FormattingEnabled = true;
            this.comboSearchBox.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Email",
            "Phone Number"});
            this.comboSearchBox.Location = new System.Drawing.Point(92, 47);
            this.comboSearchBox.Name = "comboSearchBox";
            this.comboSearchBox.Size = new System.Drawing.Size(121, 28);
            this.comboSearchBox.TabIndex = 18;
            this.comboSearchBox.SelectedIndexChanged += new System.EventHandler(this.comboSearchBox_SelectedIndexChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(55, 24);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(154, 20);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Select search option";
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.Location = new System.Drawing.Point(475, 409);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(44, 33);
            this.btnInfo.TabIndex = 19;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.comboSearchBox);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.btnCreateInsertProcedure);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.TelNumberInsTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailInsTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameInsTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameInsTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameYourTableBox);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.LastNameLabel);
            this.Name = "InvDatabase";
            this.Text = "InvDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox NameYourTableBox;
        private System.Windows.Forms.TextBox FirstNameInsTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameInsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailInsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelNumberInsTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCreateInsertProcedure;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.ComboBox comboSearchBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button btnInfo;
    }
}

