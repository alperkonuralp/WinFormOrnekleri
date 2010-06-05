namespace DersDemo_Mobile_Address
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridTextBoxColumn iDDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn firstNameDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn lastNameDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.userDataSet = new DersDemo_Mobile_Address.UserDataSet();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataGrid = new System.Windows.Forms.DataGrid();
            this.contactTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            iDDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            firstNameDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            lastNameDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.Prefix = "";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.userDataSet;
            // 
            // contactDataGrid
            // 
            this.contactDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.contactDataGrid.DataSource = this.contactBindingSource;
            this.contactDataGrid.Location = new System.Drawing.Point(11, 14);
            this.contactDataGrid.Name = "contactDataGrid";
            this.contactDataGrid.Size = new System.Drawing.Size(219, 115);
            this.contactDataGrid.TabIndex = 0;
            this.contactDataGrid.TableStyles.Add(this.contactTableStyleDataGridTableStyle);
            // 
            // contactTableStyleDataGridTableStyle
            // 
            this.contactTableStyleDataGridTableStyle.GridColumnStyles.Add(iDDataGridColumnStyleDataGridTextBoxColumn);
            this.contactTableStyleDataGridTableStyle.GridColumnStyles.Add(firstNameDataGridColumnStyleDataGridTextBoxColumn);
            this.contactTableStyleDataGridTableStyle.GridColumnStyles.Add(lastNameDataGridColumnStyleDataGridTextBoxColumn);
            this.contactTableStyleDataGridTableStyle.MappingName = "Contact";
            // 
            // iDDataGridColumnStyleDataGridTextBoxColumn
            // 
            iDDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            iDDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            iDDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "ID";
            iDDataGridColumnStyleDataGridTextBoxColumn.MappingName = "ID";
            // 
            // firstNameDataGridColumnStyleDataGridTextBoxColumn
            // 
            firstNameDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            firstNameDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            firstNameDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridColumnStyleDataGridTextBoxColumn.MappingName = "FirstName";
            // 
            // lastNameDataGridColumnStyleDataGridTextBoxColumn
            // 
            lastNameDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            lastNameDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            lastNameDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridColumnStyleDataGridTextBoxColumn.MappingName = "LastName";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Ad : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Soyad : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Contact Kaydet";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Dosya";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Çıkış";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sms Gönder";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 242);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 60);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Mesaj : ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 215);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 21);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Alıcı : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactDataGrid);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.DataGrid contactDataGrid;
        private System.Windows.Forms.DataGridTableStyle contactTableStyleDataGridTableStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;

    }
}

