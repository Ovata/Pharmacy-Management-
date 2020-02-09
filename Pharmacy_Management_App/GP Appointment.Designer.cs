namespace Pharmacy_Management_App
{
    partial class GP_Appointment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gP_Appointment_RefLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label gP_AppointmentLabel;
            System.Windows.Forms.Label patient_Full_NameLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label medical_Centre_NameLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GP_Appointment));
            this.pharmacyDataSet = new Pharmacy_Management_App.PharmacyDataSet();
            this.gP_AppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gP_AppointmentTableAdapter = new Pharmacy_Management_App.PharmacyDataSetTableAdapters.GP_AppointmentTableAdapter();
            this.tableAdapterManager = new Pharmacy_Management_App.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.gP_AppointmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gP_AppointmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_AppointmentTextBox = new System.Windows.Forms.TextBox();
            this.patient_Full_NameTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_NameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gP_AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntExitDr = new System.Windows.Forms.Button();
            this.bntCloseDr = new System.Windows.Forms.Button();
            this.bntSaveDr = new System.Windows.Forms.Button();
            this.bntPreviousDr = new System.Windows.Forms.Button();
            this.bntNextDr = new System.Windows.Forms.Button();
            this.bntDeleteDr = new System.Windows.Forms.Button();
            this.bntAddDr = new System.Windows.Forms.Button();
            gP_Appointment_RefLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            gP_AppointmentLabel = new System.Windows.Forms.Label();
            patient_Full_NameLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            medical_Centre_NameLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingNavigator)).BeginInit();
            this.gP_AppointmentBindingNavigator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gP_Appointment_RefLabel
            // 
            gP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_RefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_RefLabel.Location = new System.Drawing.Point(41, 83);
            gP_Appointment_RefLabel.Name = "gP_Appointment_RefLabel";
            gP_Appointment_RefLabel.Size = new System.Drawing.Size(302, 32);
            gP_Appointment_RefLabel.TabIndex = 1;
            gP_Appointment_RefLabel.Text = "GP Appointment Ref:";
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(41, 150);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(305, 32);
            patient_NHS_NumberLabel.TabIndex = 3;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMIS_NumberLabel.Location = new System.Drawing.Point(41, 216);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(210, 32);
            eMIS_NumberLabel.TabIndex = 5;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // gP_AppointmentLabel
            // 
            gP_AppointmentLabel.AutoSize = true;
            gP_AppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_AppointmentLabel.Location = new System.Drawing.Point(41, 283);
            gP_AppointmentLabel.Name = "gP_AppointmentLabel";
            gP_AppointmentLabel.Size = new System.Drawing.Size(247, 32);
            gP_AppointmentLabel.TabIndex = 7;
            gP_AppointmentLabel.Text = "GP Appointment:";
            // 
            // patient_Full_NameLabel
            // 
            patient_Full_NameLabel.AutoSize = true;
            patient_Full_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_Full_NameLabel.Location = new System.Drawing.Point(41, 356);
            patient_Full_NameLabel.Name = "patient_Full_NameLabel";
            patient_Full_NameLabel.Size = new System.Drawing.Size(267, 32);
            patient_Full_NameLabel.TabIndex = 9;
            patient_Full_NameLabel.Text = "Patient Full Name:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(41, 426);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(158, 32);
            patient_IDLabel.TabIndex = 11;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // medical_Centre_NameLabel
            // 
            medical_Centre_NameLabel.AutoSize = true;
            medical_Centre_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medical_Centre_NameLabel.Location = new System.Drawing.Point(41, 495);
            medical_Centre_NameLabel.Name = "medical_Centre_NameLabel";
            medical_Centre_NameLabel.Size = new System.Drawing.Size(316, 32);
            medical_Centre_NameLabel.TabIndex = 13;
            medical_Centre_NameLabel.Text = "Medical Centre Name:";
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(41, 561);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(250, 32);
            doctor_s_NHS_NoLabel.TabIndex = 15;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gP_AppointmentBindingSource
            // 
            this.gP_AppointmentBindingSource.DataMember = "GP Appointment";
            this.gP_AppointmentBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // gP_AppointmentTableAdapter
            // 
            this.gP_AppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = this.gP_AppointmentTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pharmacy_Management_App.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gP_AppointmentBindingNavigator
            // 
            this.gP_AppointmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gP_AppointmentBindingNavigator.BindingSource = this.gP_AppointmentBindingSource;
            this.gP_AppointmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gP_AppointmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gP_AppointmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gP_AppointmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.gP_AppointmentBindingNavigatorSaveItem});
            this.gP_AppointmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gP_AppointmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gP_AppointmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gP_AppointmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gP_AppointmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gP_AppointmentBindingNavigator.Name = "gP_AppointmentBindingNavigator";
            this.gP_AppointmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gP_AppointmentBindingNavigator.Size = new System.Drawing.Size(1641, 33);
            this.gP_AppointmentBindingNavigator.TabIndex = 0;
            this.gP_AppointmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // gP_AppointmentBindingNavigatorSaveItem
            // 
            this.gP_AppointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gP_AppointmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gP_AppointmentBindingNavigatorSaveItem.Image")));
            this.gP_AppointmentBindingNavigatorSaveItem.Name = "gP_AppointmentBindingNavigatorSaveItem";
            this.gP_AppointmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.gP_AppointmentBindingNavigatorSaveItem.Text = "Save Data";
            this.gP_AppointmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.gP_AppointmentBindingNavigatorSaveItem_Click_1);
            // 
            // gP_Appointment_RefTextBox
            // 
            this.gP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "GP Appointment Ref", true));
            this.gP_Appointment_RefTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gP_Appointment_RefTextBox.Location = new System.Drawing.Point(372, 80);
            this.gP_Appointment_RefTextBox.Name = "gP_Appointment_RefTextBox";
            this.gP_Appointment_RefTextBox.Size = new System.Drawing.Size(296, 39);
            this.gP_Appointment_RefTextBox.TabIndex = 2;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(372, 147);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(296, 39);
            this.patient_NHS_NumberTextBox.TabIndex = 4;
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(372, 213);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(296, 39);
            this.eMIS_NumberTextBox.TabIndex = 6;
            // 
            // gP_AppointmentTextBox
            // 
            this.gP_AppointmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "GP Appointment", true));
            this.gP_AppointmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gP_AppointmentTextBox.Location = new System.Drawing.Point(372, 280);
            this.gP_AppointmentTextBox.Name = "gP_AppointmentTextBox";
            this.gP_AppointmentTextBox.Size = new System.Drawing.Size(296, 39);
            this.gP_AppointmentTextBox.TabIndex = 8;
            // 
            // patient_Full_NameTextBox
            // 
            this.patient_Full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient Full Name", true));
            this.patient_Full_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_Full_NameTextBox.Location = new System.Drawing.Point(372, 349);
            this.patient_Full_NameTextBox.Name = "patient_Full_NameTextBox";
            this.patient_Full_NameTextBox.Size = new System.Drawing.Size(296, 39);
            this.patient_Full_NameTextBox.TabIndex = 10;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_IDTextBox.Location = new System.Drawing.Point(372, 423);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(296, 39);
            this.patient_IDTextBox.TabIndex = 12;
            // 
            // medical_Centre_NameTextBox
            // 
            this.medical_Centre_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Medical Centre Name", true));
            this.medical_Centre_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medical_Centre_NameTextBox.Location = new System.Drawing.Point(372, 492);
            this.medical_Centre_NameTextBox.Name = "medical_Centre_NameTextBox";
            this.medical_Centre_NameTextBox.Size = new System.Drawing.Size(296, 39);
            this.medical_Centre_NameTextBox.TabIndex = 14;
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(372, 558);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(296, 39);
            this.doctor_s_NHS_NoTextBox.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(727, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 513);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gP_AppointmentDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gP_AppointmentDataGridView
            // 
            this.gP_AppointmentDataGridView.AutoGenerateColumns = false;
            this.gP_AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gP_AppointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gP_AppointmentDataGridView.DataSource = this.gP_AppointmentBindingSource;
            this.gP_AppointmentDataGridView.Location = new System.Drawing.Point(19, 6);
            this.gP_AppointmentDataGridView.Name = "gP_AppointmentDataGridView";
            this.gP_AppointmentDataGridView.RowHeadersWidth = 62;
            this.gP_AppointmentDataGridView.RowTemplate.Height = 28;
            this.gP_AppointmentDataGridView.Size = new System.Drawing.Size(823, 468);
            this.gP_AppointmentDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn1.HeaderText = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patient NHS Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient NHS Number";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMIS Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "EMIS Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GP Appointment";
            this.dataGridViewTextBoxColumn4.HeaderText = "GP Appointment";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Patient Full Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Patient Full Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Medical Centre Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Medical Centre Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn8.HeaderText = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(863, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bntExitDr);
            this.panel1.Controls.Add(this.bntCloseDr);
            this.panel1.Controls.Add(this.bntSaveDr);
            this.panel1.Controls.Add(this.bntPreviousDr);
            this.panel1.Controls.Add(this.bntNextDr);
            this.panel1.Controls.Add(this.bntDeleteDr);
            this.panel1.Controls.Add(this.bntAddDr);
            this.panel1.Location = new System.Drawing.Point(181, 638);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 100);
            this.panel1.TabIndex = 35;
            // 
            // bntExitDr
            // 
            this.bntExitDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExitDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExitDr.Location = new System.Drawing.Point(1150, 15);
            this.bntExitDr.Name = "bntExitDr";
            this.bntExitDr.Size = new System.Drawing.Size(161, 66);
            this.bntExitDr.TabIndex = 13;
            this.bntExitDr.Text = "Exit";
            this.bntExitDr.UseVisualStyleBackColor = true;
            this.bntExitDr.Click += new System.EventHandler(this.bntExitDr_Click);
            // 
            // bntCloseDr
            // 
            this.bntCloseDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCloseDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCloseDr.Location = new System.Drawing.Point(966, 15);
            this.bntCloseDr.Name = "bntCloseDr";
            this.bntCloseDr.Size = new System.Drawing.Size(161, 66);
            this.bntCloseDr.TabIndex = 12;
            this.bntCloseDr.Text = "Close";
            this.bntCloseDr.UseVisualStyleBackColor = true;
            this.bntCloseDr.Click += new System.EventHandler(this.bntCloseDr_Click);
            // 
            // bntSaveDr
            // 
            this.bntSaveDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSaveDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSaveDr.Location = new System.Drawing.Point(780, 15);
            this.bntSaveDr.Name = "bntSaveDr";
            this.bntSaveDr.Size = new System.Drawing.Size(161, 66);
            this.bntSaveDr.TabIndex = 12;
            this.bntSaveDr.Text = "Save";
            this.bntSaveDr.UseVisualStyleBackColor = true;
            this.bntSaveDr.Click += new System.EventHandler(this.bntSaveDr_Click);
            // 
            // bntPreviousDr
            // 
            this.bntPreviousDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPreviousDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPreviousDr.Location = new System.Drawing.Point(588, 15);
            this.bntPreviousDr.Name = "bntPreviousDr";
            this.bntPreviousDr.Size = new System.Drawing.Size(161, 66);
            this.bntPreviousDr.TabIndex = 12;
            this.bntPreviousDr.Text = "Previous";
            this.bntPreviousDr.UseVisualStyleBackColor = true;
            this.bntPreviousDr.Click += new System.EventHandler(this.bntPreviousDr_Click);
            // 
            // bntNextDr
            // 
            this.bntNextDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNextDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNextDr.Location = new System.Drawing.Point(398, 15);
            this.bntNextDr.Name = "bntNextDr";
            this.bntNextDr.Size = new System.Drawing.Size(161, 66);
            this.bntNextDr.TabIndex = 12;
            this.bntNextDr.Text = "Next";
            this.bntNextDr.UseVisualStyleBackColor = true;
            this.bntNextDr.Click += new System.EventHandler(this.bntNextDr_Click);
            // 
            // bntDeleteDr
            // 
            this.bntDeleteDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDeleteDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDeleteDr.Location = new System.Drawing.Point(209, 15);
            this.bntDeleteDr.Name = "bntDeleteDr";
            this.bntDeleteDr.Size = new System.Drawing.Size(161, 66);
            this.bntDeleteDr.TabIndex = 12;
            this.bntDeleteDr.Text = "Delete";
            this.bntDeleteDr.UseVisualStyleBackColor = true;
            this.bntDeleteDr.Click += new System.EventHandler(this.bntDeleteDr_Click);
            // 
            // bntAddDr
            // 
            this.bntAddDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAddDr.Location = new System.Drawing.Point(21, 15);
            this.bntAddDr.Name = "bntAddDr";
            this.bntAddDr.Size = new System.Drawing.Size(161, 66);
            this.bntAddDr.TabIndex = 12;
            this.bntAddDr.Text = "Add";
            this.bntAddDr.UseVisualStyleBackColor = true;
            this.bntAddDr.Click += new System.EventHandler(this.bntAddDr_Click);
            // 
            // GP_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 764);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(gP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_RefTextBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(gP_AppointmentLabel);
            this.Controls.Add(this.gP_AppointmentTextBox);
            this.Controls.Add(patient_Full_NameLabel);
            this.Controls.Add(this.patient_Full_NameTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(medical_Centre_NameLabel);
            this.Controls.Add(this.medical_Centre_NameTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(this.gP_AppointmentBindingNavigator);
            this.Name = "GP_Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GP_Appointment";
            this.Load += new System.EventHandler(this.GP_Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingNavigator)).EndInit();
            this.gP_AppointmentBindingNavigator.ResumeLayout(false);
            this.gP_AppointmentBindingNavigator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource gP_AppointmentBindingSource;
        private PharmacyDataSetTableAdapters.GP_AppointmentTableAdapter gP_AppointmentTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gP_AppointmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton gP_AppointmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_AppointmentTextBox;
        private System.Windows.Forms.TextBox patient_Full_NameTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox medical_Centre_NameTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gP_AppointmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntExitDr;
        private System.Windows.Forms.Button bntCloseDr;
        private System.Windows.Forms.Button bntSaveDr;
        private System.Windows.Forms.Button bntPreviousDr;
        private System.Windows.Forms.Button bntNextDr;
        private System.Windows.Forms.Button bntDeleteDr;
        private System.Windows.Forms.Button bntAddDr;
    }
}