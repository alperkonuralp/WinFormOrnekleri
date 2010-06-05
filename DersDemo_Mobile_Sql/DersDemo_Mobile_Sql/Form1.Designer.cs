namespace DersDemo_Mobile_Sql
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
            System.Windows.Forms.DataGridTextBoxColumn adDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn soyadDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn adresDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn telefonDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label adLabel;
            System.Windows.Forms.Label soyadLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label telefonLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.adresDefteriDataSet = new DersDemo_Mobile_Sql.AdresDefteriDataSet();
            this.adresDefteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresDefteriTableAdapter = new DersDemo_Mobile_Sql.AdresDefteriDataSetTableAdapters.AdresDefteriTableAdapter();
            this.adresDefteriDataGrid = new System.Windows.Forms.DataGrid();
            this.adresDefteriTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iDDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            adDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            soyadDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            adresDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            telefonDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            adLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adresDefteriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresDefteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDataGridColumnStyleDataGridTextBoxColumn
            // 
            iDDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            iDDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            iDDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "ID";
            iDDataGridColumnStyleDataGridTextBoxColumn.MappingName = "ID";
            iDDataGridColumnStyleDataGridTextBoxColumn.Width = 0;
            // 
            // adDataGridColumnStyleDataGridTextBoxColumn
            // 
            adDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            adDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            adDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Ad";
            adDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Ad";
            // 
            // soyadDataGridColumnStyleDataGridTextBoxColumn
            // 
            soyadDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            soyadDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            soyadDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Soyad";
            soyadDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Soyad";
            // 
            // adresDataGridColumnStyleDataGridTextBoxColumn
            // 
            adresDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            adresDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            adresDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Adres";
            adresDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Adres";
            // 
            // telefonDataGridColumnStyleDataGridTextBoxColumn
            // 
            telefonDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            telefonDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            telefonDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Telefon";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
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
            // adresDefteriDataSet
            // 
            this.adresDefteriDataSet.DataSetName = "AdresDefteriDataSet";
            this.adresDefteriDataSet.Prefix = "";
            this.adresDefteriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adresDefteriBindingSource
            // 
            this.adresDefteriBindingSource.DataMember = "AdresDefteri";
            this.adresDefteriBindingSource.DataSource = this.adresDefteriDataSet;
            // 
            // adresDefteriTableAdapter
            // 
            this.adresDefteriTableAdapter.ClearBeforeFill = true;
            // 
            // adresDefteriDataGrid
            // 
            this.adresDefteriDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adresDefteriDataGrid.DataSource = this.adresDefteriBindingSource;
            this.adresDefteriDataGrid.Location = new System.Drawing.Point(3, 3);
            this.adresDefteriDataGrid.Name = "adresDefteriDataGrid";
            this.adresDefteriDataGrid.Size = new System.Drawing.Size(222, 169);
            this.adresDefteriDataGrid.TabIndex = 0;
            this.adresDefteriDataGrid.TableStyles.Add(this.adresDefteriTableStyleDataGridTableStyle);
            // 
            // adresDefteriTableStyleDataGridTableStyle
            // 
            this.adresDefteriTableStyleDataGridTableStyle.GridColumnStyles.Add(iDDataGridColumnStyleDataGridTextBoxColumn);
            this.adresDefteriTableStyleDataGridTableStyle.GridColumnStyles.Add(adDataGridColumnStyleDataGridTextBoxColumn);
            this.adresDefteriTableStyleDataGridTableStyle.GridColumnStyles.Add(soyadDataGridColumnStyleDataGridTextBoxColumn);
            this.adresDefteriTableStyleDataGridTableStyle.GridColumnStyles.Add(adresDataGridColumnStyleDataGridTextBoxColumn);
            this.adresDefteriTableStyleDataGridTableStyle.GridColumnStyles.Add(telefonDataGridColumnStyleDataGridTextBoxColumn);
            this.adresDefteriTableStyleDataGridTableStyle.MappingName = "AdresDefteri";
            // 
            // iDLabel
            // 
            iDLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            iDLabel.Location = new System.Drawing.Point(6, 190);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(32, 14);
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresDefteriBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(69, 187);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(130, 21);
            this.iDTextBox.TabIndex = 2;
            // 
            // adLabel
            // 
            adLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            adLabel.Location = new System.Drawing.Point(6, 218);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(35, 14);
            adLabel.Text = "Ad:";
            // 
            // adTextBox
            // 
            this.adTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresDefteriBindingSource, "Ad", true));
            this.adTextBox.Location = new System.Drawing.Point(69, 215);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(130, 21);
            this.adTextBox.TabIndex = 4;
            // 
            // soyadLabel
            // 
            soyadLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            soyadLabel.Location = new System.Drawing.Point(6, 246);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(56, 14);
            soyadLabel.Text = "Soyad:";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresDefteriBindingSource, "Soyad", true));
            this.soyadTextBox.Location = new System.Drawing.Point(69, 243);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(130, 21);
            this.soyadTextBox.TabIndex = 6;
            // 
            // adresLabel
            // 
            adresLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            adresLabel.Location = new System.Drawing.Point(6, 274);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(53, 14);
            adresLabel.Text = "Adres:";
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresDefteriBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(69, 271);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(130, 38);
            this.adresTextBox.TabIndex = 8;
            // 
            // telefonLabel
            // 
            telefonLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            telefonLabel.Location = new System.Drawing.Point(6, 318);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(63, 14);
            telefonLabel.Text = "Telefon:";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresDefteriBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(69, 315);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(130, 21);
            this.telefonTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(adLabel);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(soyadLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.adresDefteriDataGrid);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Adres Defteri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adresDefteriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresDefteriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private AdresDefteriDataSet adresDefteriDataSet;
        private System.Windows.Forms.BindingSource adresDefteriBindingSource;
        private DersDemo_Mobile_Sql.AdresDefteriDataSetTableAdapters.AdresDefteriTableAdapter adresDefteriTableAdapter;
        private System.Windows.Forms.DataGrid adresDefteriDataGrid;
        private System.Windows.Forms.DataGridTableStyle adresDefteriTableStyleDataGridTableStyle;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Button button1;
    }
}

