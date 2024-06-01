using System.Windows.Forms;

namespace FlightTicketBookingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabAircraft = new TabPage();
            btnDeleteAircraft = new Button();
            btnUpdateAircraft = new Button();
            btnSaveAircraft = new Button();
            dataGridViewAircraft = new DataGridView();
            txtAircraftSeatCapacity = new MaskedTextBox();
            txtAircraftSerialNo = new TextBox();
            txtAircraftBrand = new TextBox();
            txtAircraftModel = new TextBox();
            lblAircraftCapacity = new Label();
            lblAircraftSerialNo = new Label();
            lblAircraftBrand = new Label();
            lblAircraftModel = new Label();
            tabLocation = new TabPage();
            btnDeleteLocation = new Button();
            btnUpdateLocation = new Button();
            comboActivePassive = new ComboBox();
            btnSaveLocation = new Button();
            comboAirport = new ComboBox();
            comboCity = new ComboBox();
            comboCountry = new ComboBox();
            dataGridViewLocation = new DataGridView();
            lblActivePassive = new Label();
            lblAirport = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            tabReservation = new TabPage();
            panelSittingRegulation = new Panel();
            dataGridViewReservation = new DataGridView();
            btnDeleteReservation = new Button();
            btnUpdateReservation = new Button();
            btnSaveReservation = new Button();
            comboAircraft = new ComboBox();
            lblAircraft = new Label();
            lblLocation = new Label();
            comboLocation = new ComboBox();
            datePicker = new DateTimePicker();
            lblDate = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            lblSurname = new Label();
            lblGender = new Label();
            comboGender = new ComboBox();
            lblName = new Label();
            lblTCIdentityNumber = new Label();
            txtTCIdentityNumber = new MaskedTextBox();
            tabControl1.SuspendLayout();
            tabAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAircraft).BeginInit();
            tabLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocation).BeginInit();
            tabReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAircraft);
            tabControl1.Controls.Add(tabLocation);
            tabControl1.Controls.Add(tabReservation);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 637);
            tabControl1.TabIndex = 0;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabAircraft
            // 
            tabAircraft.BackColor = SystemColors.ActiveCaptionText;
            tabAircraft.Controls.Add(btnDeleteAircraft);
            tabAircraft.Controls.Add(btnUpdateAircraft);
            tabAircraft.Controls.Add(btnSaveAircraft);
            tabAircraft.Controls.Add(dataGridViewAircraft);
            tabAircraft.Controls.Add(txtAircraftSeatCapacity);
            tabAircraft.Controls.Add(txtAircraftSerialNo);
            tabAircraft.Controls.Add(txtAircraftBrand);
            tabAircraft.Controls.Add(txtAircraftModel);
            tabAircraft.Controls.Add(lblAircraftCapacity);
            tabAircraft.Controls.Add(lblAircraftSerialNo);
            tabAircraft.Controls.Add(lblAircraftBrand);
            tabAircraft.Controls.Add(lblAircraftModel);
            tabAircraft.Location = new Point(4, 24);
            tabAircraft.Name = "tabAircraft";
            tabAircraft.Padding = new Padding(3);
            tabAircraft.Size = new Size(975, 609);
            tabAircraft.TabIndex = 0;
            tabAircraft.Text = "Aircraft";
            // 
            // btnDeleteAircraft
            // 
            btnDeleteAircraft.FlatStyle = FlatStyle.Flat;
            btnDeleteAircraft.Location = new Point(871, 6);
            btnDeleteAircraft.Name = "btnDeleteAircraft";
            btnDeleteAircraft.Size = new Size(100, 52);
            btnDeleteAircraft.TabIndex = 10;
            btnDeleteAircraft.Text = "Delete";
            btnDeleteAircraft.UseVisualStyleBackColor = true;
            btnDeleteAircraft.Click += btnAircraft_Click;
            // 
            // btnUpdateAircraft
            // 
            btnUpdateAircraft.FlatStyle = FlatStyle.Flat;
            btnUpdateAircraft.Location = new Point(765, 6);
            btnUpdateAircraft.Name = "btnUpdateAircraft";
            btnUpdateAircraft.Size = new Size(100, 52);
            btnUpdateAircraft.TabIndex = 9;
            btnUpdateAircraft.Text = "Update";
            btnUpdateAircraft.UseVisualStyleBackColor = true;
            btnUpdateAircraft.Click += btnAircraft_Click;
            // 
            // btnSaveAircraft
            // 
            btnSaveAircraft.FlatStyle = FlatStyle.Flat;
            btnSaveAircraft.Location = new Point(659, 6);
            btnSaveAircraft.Name = "btnSaveAircraft";
            btnSaveAircraft.Size = new Size(100, 52);
            btnSaveAircraft.TabIndex = 8;
            btnSaveAircraft.Text = "Save";
            btnSaveAircraft.UseVisualStyleBackColor = true;
            btnSaveAircraft.Click += btnAircraft_Click;
            // 
            // dataGridViewAircraft
            // 
            dataGridViewAircraft.AllowUserToAddRows = false;
            dataGridViewAircraft.AllowUserToDeleteRows = false;
            dataGridViewAircraft.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAircraft.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAircraft.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAircraft.Location = new Point(5, 64);
            dataGridViewAircraft.Name = "dataGridViewAircraft";
            dataGridViewAircraft.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewAircraft.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAircraft.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAircraft.Size = new Size(964, 539);
            dataGridViewAircraft.TabIndex = 11;
            dataGridViewAircraft.CellClick += dataGridViewAircraft_CellClick;
            // 
            // txtAircraftSeatCapacity
            // 
            txtAircraftSeatCapacity.Location = new Point(443, 35);
            txtAircraftSeatCapacity.Mask = "0000";
            txtAircraftSeatCapacity.Name = "txtAircraftSeatCapacity";
            txtAircraftSeatCapacity.Size = new Size(210, 23);
            txtAircraftSeatCapacity.TabIndex = 7;
            txtAircraftSeatCapacity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAircraftSerialNo
            // 
            txtAircraftSerialNo.Location = new Point(443, 6);
            txtAircraftSerialNo.Name = "txtAircraftSerialNo";
            txtAircraftSerialNo.Size = new Size(210, 23);
            txtAircraftSerialNo.TabIndex = 5;
            // 
            // txtAircraftBrand
            // 
            txtAircraftBrand.Location = new Point(98, 35);
            txtAircraftBrand.Name = "txtAircraftBrand";
            txtAircraftBrand.Size = new Size(210, 23);
            txtAircraftBrand.TabIndex = 6;
            // 
            // txtAircraftModel
            // 
            txtAircraftModel.Location = new Point(98, 6);
            txtAircraftModel.Name = "txtAircraftModel";
            txtAircraftModel.Size = new Size(210, 23);
            txtAircraftModel.TabIndex = 4;
            // 
            // lblAircraftCapacity
            // 
            lblAircraftCapacity.AutoSize = true;
            lblAircraftCapacity.Location = new Point(314, 38);
            lblAircraftCapacity.Name = "lblAircraftCapacity";
            lblAircraftCapacity.Size = new Size(123, 15);
            lblAircraftCapacity.TabIndex = 3;
            lblAircraftCapacity.Text = "Aircraft Seat Capacity:";
            // 
            // lblAircraftSerialNo
            // 
            lblAircraftSerialNo.AutoSize = true;
            lblAircraftSerialNo.Location = new Point(338, 9);
            lblAircraftSerialNo.Name = "lblAircraftSerialNo";
            lblAircraftSerialNo.Size = new Size(99, 15);
            lblAircraftSerialNo.TabIndex = 1;
            lblAircraftSerialNo.Text = "Aircraft Serial No:";
            // 
            // lblAircraftBrand
            // 
            lblAircraftBrand.AutoSize = true;
            lblAircraftBrand.Location = new Point(9, 38);
            lblAircraftBrand.Name = "lblAircraftBrand";
            lblAircraftBrand.Size = new Size(83, 15);
            lblAircraftBrand.TabIndex = 2;
            lblAircraftBrand.Text = "Aircraft Brand:";
            // 
            // lblAircraftModel
            // 
            lblAircraftModel.AutoSize = true;
            lblAircraftModel.Location = new Point(6, 9);
            lblAircraftModel.Name = "lblAircraftModel";
            lblAircraftModel.Size = new Size(86, 15);
            lblAircraftModel.TabIndex = 0;
            lblAircraftModel.Text = "Aircraft Model:";
            // 
            // tabLocation
            // 
            tabLocation.BackColor = SystemColors.ActiveCaptionText;
            tabLocation.Controls.Add(btnDeleteLocation);
            tabLocation.Controls.Add(btnUpdateLocation);
            tabLocation.Controls.Add(comboActivePassive);
            tabLocation.Controls.Add(btnSaveLocation);
            tabLocation.Controls.Add(comboAirport);
            tabLocation.Controls.Add(comboCity);
            tabLocation.Controls.Add(comboCountry);
            tabLocation.Controls.Add(dataGridViewLocation);
            tabLocation.Controls.Add(lblActivePassive);
            tabLocation.Controls.Add(lblAirport);
            tabLocation.Controls.Add(lblCity);
            tabLocation.Controls.Add(lblCountry);
            tabLocation.Location = new Point(4, 24);
            tabLocation.Name = "tabLocation";
            tabLocation.Padding = new Padding(3);
            tabLocation.Size = new Size(975, 609);
            tabLocation.TabIndex = 1;
            tabLocation.Text = "Location";
            // 
            // btnDeleteLocation
            // 
            btnDeleteLocation.FlatStyle = FlatStyle.Flat;
            btnDeleteLocation.Location = new Point(869, 6);
            btnDeleteLocation.Name = "btnDeleteLocation";
            btnDeleteLocation.Size = new Size(100, 52);
            btnDeleteLocation.TabIndex = 10;
            btnDeleteLocation.Text = "Delete";
            btnDeleteLocation.UseVisualStyleBackColor = true;
            btnDeleteLocation.Click += btnLocation_Click;
            // 
            // btnUpdateLocation
            // 
            btnUpdateLocation.FlatStyle = FlatStyle.Flat;
            btnUpdateLocation.Location = new Point(763, 6);
            btnUpdateLocation.Name = "btnUpdateLocation";
            btnUpdateLocation.Size = new Size(100, 52);
            btnUpdateLocation.TabIndex = 9;
            btnUpdateLocation.Text = "Update";
            btnUpdateLocation.UseVisualStyleBackColor = true;
            btnUpdateLocation.Click += btnLocation_Click;
            // 
            // comboActivePassive
            // 
            comboActivePassive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboActivePassive.FormattingEnabled = true;
            comboActivePassive.IntegralHeight = false;
            comboActivePassive.Items.AddRange(new object[] { "", "Active", "Passive" });
            comboActivePassive.Location = new Point(403, 35);
            comboActivePassive.MaxDropDownItems = 4;
            comboActivePassive.Name = "comboActivePassive";
            comboActivePassive.Size = new Size(240, 23);
            comboActivePassive.TabIndex = 7;
            // 
            // btnSaveLocation
            // 
            btnSaveLocation.FlatStyle = FlatStyle.Flat;
            btnSaveLocation.Location = new Point(657, 6);
            btnSaveLocation.Name = "btnSaveLocation";
            btnSaveLocation.Size = new Size(100, 52);
            btnSaveLocation.TabIndex = 8;
            btnSaveLocation.Text = "Save";
            btnSaveLocation.UseVisualStyleBackColor = true;
            btnSaveLocation.Click += btnLocation_Click;
            // 
            // comboAirport
            // 
            comboAirport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAirport.FormattingEnabled = true;
            comboAirport.IntegralHeight = false;
            comboAirport.Location = new Point(65, 35);
            comboAirport.MaxDropDownItems = 4;
            comboAirport.Name = "comboAirport";
            comboAirport.Size = new Size(240, 23);
            comboAirport.TabIndex = 6;
            // 
            // comboCity
            // 
            comboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCity.FormattingEnabled = true;
            comboCity.IntegralHeight = false;
            comboCity.Location = new Point(403, 6);
            comboCity.MaxDropDownItems = 4;
            comboCity.Name = "comboCity";
            comboCity.Size = new Size(240, 23);
            comboCity.TabIndex = 5;
            comboCity.SelectedIndexChanged += comboCity_SelectedIndexChanged;
            // 
            // comboCountry
            // 
            comboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCountry.FormattingEnabled = true;
            comboCountry.IntegralHeight = false;
            comboCountry.Location = new Point(65, 6);
            comboCountry.MaxDropDownItems = 4;
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(240, 23);
            comboCountry.TabIndex = 4;
            comboCountry.SelectedIndexChanged += comboCountry_SelectedIndexChanged;
            // 
            // dataGridViewLocation
            // 
            dataGridViewLocation.AllowUserToAddRows = false;
            dataGridViewLocation.AllowUserToDeleteRows = false;
            dataGridViewLocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLocation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocation.Location = new Point(6, 64);
            dataGridViewLocation.Name = "dataGridViewLocation";
            dataGridViewLocation.ReadOnly = true;
            dataGridViewLocation.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLocation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLocation.Size = new Size(963, 539);
            dataGridViewLocation.TabIndex = 11;
            dataGridViewLocation.CellClick += dataGridViewLocation_CellClick;
            // 
            // lblActivePassive
            // 
            lblActivePassive.AutoSize = true;
            lblActivePassive.Location = new Point(311, 40);
            lblActivePassive.Name = "lblActivePassive";
            lblActivePassive.Size = new Size(86, 15);
            lblActivePassive.TabIndex = 3;
            lblActivePassive.Text = "Active-Passive:";
            // 
            // lblAirport
            // 
            lblAirport.AutoSize = true;
            lblAirport.Location = new Point(12, 38);
            lblAirport.Name = "lblAirport";
            lblAirport.Size = new Size(47, 15);
            lblAirport.TabIndex = 2;
            lblAirport.Text = "Airport:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(366, 9);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 1;
            lblCity.Text = "City:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(6, 11);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(53, 15);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Country:";
            // 
            // tabReservation
            // 
            tabReservation.BackColor = SystemColors.ActiveCaptionText;
            tabReservation.Controls.Add(panelSittingRegulation);
            tabReservation.Controls.Add(dataGridViewReservation);
            tabReservation.Controls.Add(btnDeleteReservation);
            tabReservation.Controls.Add(btnUpdateReservation);
            tabReservation.Controls.Add(btnSaveReservation);
            tabReservation.Controls.Add(comboAircraft);
            tabReservation.Controls.Add(lblAircraft);
            tabReservation.Controls.Add(lblLocation);
            tabReservation.Controls.Add(comboLocation);
            tabReservation.Controls.Add(datePicker);
            tabReservation.Controls.Add(lblDate);
            tabReservation.Controls.Add(txtSurname);
            tabReservation.Controls.Add(txtName);
            tabReservation.Controls.Add(lblSurname);
            tabReservation.Controls.Add(lblGender);
            tabReservation.Controls.Add(comboGender);
            tabReservation.Controls.Add(lblName);
            tabReservation.Controls.Add(lblTCIdentityNumber);
            tabReservation.Controls.Add(txtTCIdentityNumber);
            tabReservation.Location = new Point(4, 24);
            tabReservation.Name = "tabReservation";
            tabReservation.Size = new Size(975, 609);
            tabReservation.TabIndex = 2;
            tabReservation.Text = "Reservation";
            // 
            // panelSittingRegulation
            // 
            panelSittingRegulation.Location = new Point(6, 95);
            panelSittingRegulation.Name = "panelSittingRegulation";
            panelSittingRegulation.Size = new Size(415, 499);
            panelSittingRegulation.TabIndex = 18;
            // 
            // dataGridViewReservation
            // 
            dataGridViewReservation.AllowUserToAddRows = false;
            dataGridViewReservation.AllowUserToDeleteRows = false;
            dataGridViewReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservation.Location = new Point(427, 95);
            dataGridViewReservation.Name = "dataGridViewReservation";
            dataGridViewReservation.ReadOnly = true;
            dataGridViewReservation.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservation.Size = new Size(538, 499);
            dataGridViewReservation.TabIndex = 17;
            dataGridViewReservation.CellClick += dataGridViewReservation_CellClick;
            // 
            // btnDeleteReservation
            // 
            btnDeleteReservation.FlatStyle = FlatStyle.Flat;
            btnDeleteReservation.Location = new Point(865, 37);
            btnDeleteReservation.Name = "btnDeleteReservation";
            btnDeleteReservation.Size = new Size(100, 52);
            btnDeleteReservation.TabIndex = 16;
            btnDeleteReservation.Text = "Delete";
            btnDeleteReservation.UseVisualStyleBackColor = true;
            btnDeleteReservation.Click += btnReservation_Click;
            // 
            // btnUpdateReservation
            // 
            btnUpdateReservation.FlatStyle = FlatStyle.Flat;
            btnUpdateReservation.Location = new Point(759, 37);
            btnUpdateReservation.Name = "btnUpdateReservation";
            btnUpdateReservation.Size = new Size(100, 52);
            btnUpdateReservation.TabIndex = 15;
            btnUpdateReservation.Text = "Update";
            btnUpdateReservation.UseVisualStyleBackColor = true;
            btnUpdateReservation.Click += btnReservation_Click;
            // 
            // btnSaveReservation
            // 
            btnSaveReservation.FlatStyle = FlatStyle.Flat;
            btnSaveReservation.Location = new Point(653, 37);
            btnSaveReservation.Name = "btnSaveReservation";
            btnSaveReservation.Size = new Size(100, 52);
            btnSaveReservation.TabIndex = 14;
            btnSaveReservation.Text = "Save";
            btnSaveReservation.UseVisualStyleBackColor = true;
            btnSaveReservation.Click += btnReservation_Click;
            // 
            // comboAircraft
            // 
            comboAircraft.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAircraft.FormattingEnabled = true;
            comboAircraft.IntegralHeight = false;
            comboAircraft.Location = new Point(61, 8);
            comboAircraft.MaxDropDownItems = 4;
            comboAircraft.Name = "comboAircraft";
            comboAircraft.Size = new Size(220, 23);
            comboAircraft.TabIndex = 7;
            // 
            // lblAircraft
            // 
            lblAircraft.AutoSize = true;
            lblAircraft.Location = new Point(6, 11);
            lblAircraft.Name = "lblAircraft";
            lblAircraft.Size = new Size(49, 15);
            lblAircraft.TabIndex = 0;
            lblAircraft.Text = "Aircraft:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(287, 11);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(56, 15);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location:";
            // 
            // comboLocation
            // 
            comboLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocation.FormattingEnabled = true;
            comboLocation.IntegralHeight = false;
            comboLocation.Location = new Point(349, 8);
            comboLocation.MaxDropDownItems = 4;
            comboLocation.Name = "comboLocation";
            comboLocation.Size = new Size(350, 23);
            comboLocation.TabIndex = 8;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(745, 8);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(220, 23);
            datePicker.TabIndex = 9;
            datePicker.Value = DateTime.Now;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(705, 11);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(427, 37);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(220, 23);
            txtSurname.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 23);
            txtName.TabIndex = 10;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(364, 40);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(57, 15);
            lblSurname.TabIndex = 4;
            lblSurname.Text = "Surname:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(373, 69);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            // 
            // comboGender
            // 
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGender.FormattingEnabled = true;
            comboGender.IntegralHeight = false;
            comboGender.Items.AddRange(new object[] { "", "Female", "Male" });
            comboGender.Location = new Point(427, 66);
            comboGender.MaxDropDownItems = 4;
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(220, 23);
            comboGender.TabIndex = 13;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(90, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblTCIdentityNumber
            // 
            lblTCIdentityNumber.AutoSize = true;
            lblTCIdentityNumber.Location = new Point(12, 69);
            lblTCIdentityNumber.Name = "lblTCIdentityNumber";
            lblTCIdentityNumber.Size = new Size(120, 15);
            lblTCIdentityNumber.TabIndex = 5;
            lblTCIdentityNumber.Text = "T.C. Identity Number:";
            // 
            // txtTCIdentityNumber
            // 
            txtTCIdentityNumber.Location = new Point(138, 66);
            txtTCIdentityNumber.Mask = "00000000000";
            txtTCIdentityNumber.Name = "txtTCIdentityNumber";
            txtTCIdentityNumber.Size = new Size(220, 23);
            txtTCIdentityNumber.TabIndex = 12;
            txtTCIdentityNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1007, 661);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ButtonHighlight;
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flight Ticket Booking App";
            KeyDown += MainForm_KeyDown;
            tabControl1.ResumeLayout(false);
            tabAircraft.ResumeLayout(false);
            tabAircraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAircraft).EndInit();
            tabLocation.ResumeLayout(false);
            tabLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocation).EndInit();
            tabReservation.ResumeLayout(false);
            tabReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAircraft;
        private TabPage tabLocation;
        private TabPage tabReservation;
        private Label lblAircraftModel;
        private Label lblAircraftBrand;
        private Label lblAircraftSerialNo;
        private Label lblAircraftCapacity;
        private Label lblCountry;
        private Label lblCity;
        private Label lblAirport;
        private Label lblActivePassive;
        private Label lblAircraft;
        private Label lblLocation;
        private Label lblDate;
        private Label lblName;
        private Label lblSurname;
        private Label lblTCIdentityNumber;
        private Label lblGender;
        private Button btnSaveAircraft;
        private Button btnUpdateAircraft;
        private Button btnDeleteAircraft;
        private Button btnSaveLocation;
        private Button btnUpdateLocation;
        private Button btnDeleteLocation;
        private Button btnSaveReservation;
        private Button btnUpdateReservation;
        private Button btnDeleteReservation;
        public static Panel panelSittingRegulation;
        public static TextBox txtAircraftModel;
        public static TextBox txtAircraftBrand;
        public static TextBox txtAircraftSerialNo;
        public static TextBox txtName;
        public static TextBox txtSurname;
        public static MaskedTextBox txtAircraftSeatCapacity;
        public static MaskedTextBox txtTCIdentityNumber;
        public static DateTimePicker datePicker;
        public static ComboBox comboCountry;
        public static ComboBox comboCity;
        public static ComboBox comboAirport;
        public static ComboBox comboActivePassive;
        public static ComboBox comboAircraft;
        public static ComboBox comboLocation;
        public static ComboBox comboGender;
        public static DataGridView dataGridViewAircraft;
        public static DataGridView dataGridViewLocation;
        public static DataGridView dataGridViewReservation;
    }
}

/*
        public static Panel panelSittingRegulation;
        public static TextBox txtAircraftModel;
        public static TextBox txtAircraftBrand;
        public static TextBox txtAircraftSerialNo;
        public static TextBox txtName;
        public static TextBox txtSurname;
        public static MaskedTextBox txtAircraftSeatCapacity;
        public static MaskedTextBox txtTCIdentityNumber;
        public static DateTimePicker datePicker;
        public static ComboBox comboCountry;
        public static ComboBox comboCity;
        public static ComboBox comboAirport;
        public static ComboBox comboActivePassive;
        public static ComboBox comboAircraft;
        public static ComboBox comboLocation;
        public static ComboBox comboGender;
        public static DataGridView dataGridViewAircraft;
        public static DataGridView dataGridViewLocation;
        public static DataGridView dataGridViewReservation;
*/