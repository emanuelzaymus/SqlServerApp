
namespace SqlServerApp
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.tablesListBox = new System.Windows.Forms.ListBox();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.messageLabel = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.databasesListBox = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dataTabPage = new System.Windows.Forms.TabPage();
            this.rollbackButton = new System.Windows.Forms.Button();
            this.createSavepointButton = new System.Windows.Forms.Button();
            this.filterColumnsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.structureTabPage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.indexComboBox = new System.Windows.Forms.ComboBox();
            this.dropForeignKeyButton = new System.Windows.Forms.Button();
            this.addForeignKeyButton = new System.Windows.Forms.Button();
            this.foreignColumnComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.foreignTableComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.columnComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.changePkButton = new System.Windows.Forms.Button();
            this.pkCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.columnTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fksListBox = new System.Windows.Forms.ListBox();
            this.autoIncrementCheckBox = new System.Windows.Forms.CheckBox();
            this.nullableCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addColumnButton = new System.Windows.Forms.Button();
            this.dropColumnButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.columnNameTextBox = new System.Windows.Forms.TextBox();
            this.alterColumnButton = new System.Windows.Forms.Button();
            this.columnsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.renameTableButton = new System.Windows.Forms.Button();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createDbButton = new System.Windows.Forms.Button();
            this.dropDbButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.dropTableButton = new System.Windows.Forms.Button();
            this.importTabPage = new System.Windows.Forms.TabPage();
            this.exportTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.dataTabPage.SuspendLayout();
            this.structureTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablesListBox
            // 
            this.tablesListBox.FormattingEnabled = true;
            this.tablesListBox.Location = new System.Drawing.Point(176, 33);
            this.tablesListBox.Name = "tablesListBox";
            this.tablesListBox.Size = new System.Drawing.Size(160, 485);
            this.tablesListBox.TabIndex = 0;
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToOrderColumns = true;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(3, 31);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(727, 483);
            this.mainDataGridView.TabIndex = 1;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(71, 589);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(10, 13);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "-";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(636, 5);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(94, 23);
            this.saveChangesButton.TabIndex = 3;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator.TabIndex = 4;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // databasesListBox
            // 
            this.databasesListBox.FormattingEnabled = true;
            this.databasesListBox.Location = new System.Drawing.Point(10, 33);
            this.databasesListBox.Name = "databasesListBox";
            this.databasesListBox.Size = new System.Drawing.Size(160, 485);
            this.databasesListBox.TabIndex = 6;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.dataTabPage);
            this.tabControl.Controls.Add(this.structureTabPage);
            this.tabControl.Controls.Add(this.reportTabPage);
            this.tabControl.Controls.Add(this.importTabPage);
            this.tabControl.Controls.Add(this.exportTabPage);
            this.tabControl.Location = new System.Drawing.Point(342, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(741, 571);
            this.tabControl.TabIndex = 7;
            // 
            // dataTabPage
            // 
            this.dataTabPage.Controls.Add(this.rollbackButton);
            this.dataTabPage.Controls.Add(this.createSavepointButton);
            this.dataTabPage.Controls.Add(this.filterColumnsButton);
            this.dataTabPage.Controls.Add(this.label1);
            this.dataTabPage.Controls.Add(this.filterButton);
            this.dataTabPage.Controls.Add(this.filterTextBox);
            this.dataTabPage.Controls.Add(this.mainDataGridView);
            this.dataTabPage.Controls.Add(this.bindingNavigator);
            this.dataTabPage.Controls.Add(this.saveChangesButton);
            this.dataTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataTabPage.Size = new System.Drawing.Size(733, 545);
            this.dataTabPage.TabIndex = 0;
            this.dataTabPage.Text = "Table Data";
            this.dataTabPage.UseVisualStyleBackColor = true;
            // 
            // rollbackButton
            // 
            this.rollbackButton.Enabled = false;
            this.rollbackButton.Location = new System.Drawing.Point(529, 5);
            this.rollbackButton.Name = "rollbackButton";
            this.rollbackButton.Size = new System.Drawing.Size(83, 23);
            this.rollbackButton.TabIndex = 10;
            this.rollbackButton.Text = "Rollback";
            this.rollbackButton.UseVisualStyleBackColor = true;
            this.rollbackButton.Click += new System.EventHandler(this.RollbackButton_Click);
            // 
            // createSavepointButton
            // 
            this.createSavepointButton.Location = new System.Drawing.Point(440, 5);
            this.createSavepointButton.Name = "createSavepointButton";
            this.createSavepointButton.Size = new System.Drawing.Size(83, 23);
            this.createSavepointButton.TabIndex = 9;
            this.createSavepointButton.Text = "Savepoint";
            this.createSavepointButton.UseVisualStyleBackColor = true;
            this.createSavepointButton.Click += new System.EventHandler(this.CreateSavepointButton_Click);
            // 
            // filterColumnsButton
            // 
            this.filterColumnsButton.Location = new System.Drawing.Point(261, 5);
            this.filterColumnsButton.Name = "filterColumnsButton";
            this.filterColumnsButton.Size = new System.Drawing.Size(94, 23);
            this.filterColumnsButton.TabIndex = 8;
            this.filterColumnsButton.Text = "Filter Columns";
            this.filterColumnsButton.UseVisualStyleBackColor = true;
            this.filterColumnsButton.Click += new System.EventHandler(this.FilterColumnsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter Conditions:";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(633, 518);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(97, 23);
            this.filterButton.TabIndex = 6;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(93, 520);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(537, 20);
            this.filterTextBox.TabIndex = 5;
            // 
            // structureTabPage
            // 
            this.structureTabPage.Controls.Add(this.label14);
            this.structureTabPage.Controls.Add(this.indexComboBox);
            this.structureTabPage.Controls.Add(this.dropForeignKeyButton);
            this.structureTabPage.Controls.Add(this.addForeignKeyButton);
            this.structureTabPage.Controls.Add(this.foreignColumnComboBox);
            this.structureTabPage.Controls.Add(this.label13);
            this.structureTabPage.Controls.Add(this.foreignTableComboBox);
            this.structureTabPage.Controls.Add(this.label12);
            this.structureTabPage.Controls.Add(this.columnComboBox);
            this.structureTabPage.Controls.Add(this.label11);
            this.structureTabPage.Controls.Add(this.changePkButton);
            this.structureTabPage.Controls.Add(this.pkCheckedListBox);
            this.structureTabPage.Controls.Add(this.label10);
            this.structureTabPage.Controls.Add(this.columnTypeComboBox);
            this.structureTabPage.Controls.Add(this.label9);
            this.structureTabPage.Controls.Add(this.fksListBox);
            this.structureTabPage.Controls.Add(this.autoIncrementCheckBox);
            this.structureTabPage.Controls.Add(this.nullableCheckBox);
            this.structureTabPage.Controls.Add(this.label8);
            this.structureTabPage.Controls.Add(this.addColumnButton);
            this.structureTabPage.Controls.Add(this.dropColumnButton);
            this.structureTabPage.Controls.Add(this.label7);
            this.structureTabPage.Controls.Add(this.columnNameTextBox);
            this.structureTabPage.Controls.Add(this.alterColumnButton);
            this.structureTabPage.Controls.Add(this.columnsListBox);
            this.structureTabPage.Controls.Add(this.label6);
            this.structureTabPage.Controls.Add(this.renameTableButton);
            this.structureTabPage.Controls.Add(this.tableNameTextBox);
            this.structureTabPage.Controls.Add(this.label5);
            this.structureTabPage.Location = new System.Drawing.Point(4, 22);
            this.structureTabPage.Name = "structureTabPage";
            this.structureTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.structureTabPage.Size = new System.Drawing.Size(733, 545);
            this.structureTabPage.TabIndex = 1;
            this.structureTabPage.Text = "Table Stucture";
            this.structureTabPage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Index";
            // 
            // indexComboBox
            // 
            this.indexComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.indexComboBox.FormattingEnabled = true;
            this.indexComboBox.Location = new System.Drawing.Point(10, 451);
            this.indexComboBox.Name = "indexComboBox";
            this.indexComboBox.Size = new System.Drawing.Size(217, 21);
            this.indexComboBox.TabIndex = 31;
            // 
            // dropForeignKeyButton
            // 
            this.dropForeignKeyButton.Location = new System.Drawing.Point(456, 357);
            this.dropForeignKeyButton.Name = "dropForeignKeyButton";
            this.dropForeignKeyButton.Size = new System.Drawing.Size(271, 23);
            this.dropForeignKeyButton.TabIndex = 30;
            this.dropForeignKeyButton.Text = "Drop Foreign Key";
            this.dropForeignKeyButton.UseVisualStyleBackColor = true;
            this.dropForeignKeyButton.Click += new System.EventHandler(this.DropForeignKeyButton_Click);
            // 
            // addForeignKeyButton
            // 
            this.addForeignKeyButton.Location = new System.Drawing.Point(456, 516);
            this.addForeignKeyButton.Name = "addForeignKeyButton";
            this.addForeignKeyButton.Size = new System.Drawing.Size(271, 23);
            this.addForeignKeyButton.TabIndex = 29;
            this.addForeignKeyButton.Text = "Add Foreign Key";
            this.addForeignKeyButton.UseVisualStyleBackColor = true;
            this.addForeignKeyButton.Click += new System.EventHandler(this.AddForeignKeyButton_Click);
            // 
            // foreignColumnComboBox
            // 
            this.foreignColumnComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.foreignColumnComboBox.FormattingEnabled = true;
            this.foreignColumnComboBox.Location = new System.Drawing.Point(456, 487);
            this.foreignColumnComboBox.Name = "foreignColumnComboBox";
            this.foreignColumnComboBox.Size = new System.Drawing.Size(271, 21);
            this.foreignColumnComboBox.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(456, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Foreign Column";
            // 
            // foreignTableComboBox
            // 
            this.foreignTableComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.foreignTableComboBox.FormattingEnabled = true;
            this.foreignTableComboBox.Location = new System.Drawing.Point(456, 447);
            this.foreignTableComboBox.Name = "foreignTableComboBox";
            this.foreignTableComboBox.Size = new System.Drawing.Size(271, 21);
            this.foreignTableComboBox.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Foreign Table";
            // 
            // columnComboBox
            // 
            this.columnComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.columnComboBox.FormattingEnabled = true;
            this.columnComboBox.Location = new System.Drawing.Point(456, 407);
            this.columnComboBox.Name = "columnComboBox";
            this.columnComboBox.Size = new System.Drawing.Size(271, 21);
            this.columnComboBox.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Column Name";
            // 
            // changePkButton
            // 
            this.changePkButton.Location = new System.Drawing.Point(233, 357);
            this.changePkButton.Name = "changePkButton";
            this.changePkButton.Size = new System.Drawing.Size(217, 23);
            this.changePkButton.TabIndex = 21;
            this.changePkButton.Text = "Change Primary Key";
            this.changePkButton.UseVisualStyleBackColor = true;
            this.changePkButton.Click += new System.EventHandler(this.ChangePkButton_Click);
            // 
            // pkCheckedListBox
            // 
            this.pkCheckedListBox.FormattingEnabled = true;
            this.pkCheckedListBox.Location = new System.Drawing.Point(233, 62);
            this.pkCheckedListBox.Name = "pkCheckedListBox";
            this.pkCheckedListBox.Size = new System.Drawing.Size(217, 289);
            this.pkCheckedListBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Primary Key";
            // 
            // columnTypeComboBox
            // 
            this.columnTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.columnTypeComboBox.FormattingEnabled = true;
            this.columnTypeComboBox.Location = new System.Drawing.Point(10, 411);
            this.columnTypeComboBox.Name = "columnTypeComboBox";
            this.columnTypeComboBox.Size = new System.Drawing.Size(217, 21);
            this.columnTypeComboBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Foreign Keys";
            // 
            // fksListBox
            // 
            this.fksListBox.FormattingEnabled = true;
            this.fksListBox.Location = new System.Drawing.Point(456, 62);
            this.fksListBox.Name = "fksListBox";
            this.fksListBox.Size = new System.Drawing.Size(271, 290);
            this.fksListBox.TabIndex = 15;
            // 
            // autoIncrementCheckBox
            // 
            this.autoIncrementCheckBox.AutoSize = true;
            this.autoIncrementCheckBox.Location = new System.Drawing.Point(82, 478);
            this.autoIncrementCheckBox.Name = "autoIncrementCheckBox";
            this.autoIncrementCheckBox.Size = new System.Drawing.Size(98, 17);
            this.autoIncrementCheckBox.TabIndex = 14;
            this.autoIncrementCheckBox.Text = "Auto-Increment";
            this.autoIncrementCheckBox.UseVisualStyleBackColor = true;
            // 
            // nullableCheckBox
            // 
            this.nullableCheckBox.AutoSize = true;
            this.nullableCheckBox.Location = new System.Drawing.Point(12, 478);
            this.nullableCheckBox.Name = "nullableCheckBox";
            this.nullableCheckBox.Size = new System.Drawing.Size(64, 17);
            this.nullableCheckBox.TabIndex = 12;
            this.nullableCheckBox.Text = "Nullable";
            this.nullableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Column Type";
            // 
            // addColumnButton
            // 
            this.addColumnButton.Location = new System.Drawing.Point(10, 516);
            this.addColumnButton.Name = "addColumnButton";
            this.addColumnButton.Size = new System.Drawing.Size(68, 23);
            this.addColumnButton.TabIndex = 9;
            this.addColumnButton.Text = "Add";
            this.addColumnButton.UseVisualStyleBackColor = true;
            this.addColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // dropColumnButton
            // 
            this.dropColumnButton.Location = new System.Drawing.Point(158, 516);
            this.dropColumnButton.Name = "dropColumnButton";
            this.dropColumnButton.Size = new System.Drawing.Size(69, 23);
            this.dropColumnButton.TabIndex = 8;
            this.dropColumnButton.Text = "Drop";
            this.dropColumnButton.UseVisualStyleBackColor = true;
            this.dropColumnButton.Click += new System.EventHandler(this.DropColumnButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Column Name";
            // 
            // columnNameTextBox
            // 
            this.columnNameTextBox.Location = new System.Drawing.Point(10, 372);
            this.columnNameTextBox.Name = "columnNameTextBox";
            this.columnNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.columnNameTextBox.TabIndex = 6;
            // 
            // alterColumnButton
            // 
            this.alterColumnButton.Location = new System.Drawing.Point(84, 516);
            this.alterColumnButton.Name = "alterColumnButton";
            this.alterColumnButton.Size = new System.Drawing.Size(68, 23);
            this.alterColumnButton.TabIndex = 5;
            this.alterColumnButton.Text = "Alter";
            this.alterColumnButton.UseVisualStyleBackColor = true;
            this.alterColumnButton.Click += new System.EventHandler(this.AlterColumnButton_Click);
            // 
            // columnsListBox
            // 
            this.columnsListBox.FormattingEnabled = true;
            this.columnsListBox.Location = new System.Drawing.Point(10, 62);
            this.columnsListBox.Name = "columnsListBox";
            this.columnsListBox.Size = new System.Drawing.Size(217, 290);
            this.columnsListBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Table Columns";
            // 
            // renameTableButton
            // 
            this.renameTableButton.Location = new System.Drawing.Point(233, 21);
            this.renameTableButton.Name = "renameTableButton";
            this.renameTableButton.Size = new System.Drawing.Size(126, 23);
            this.renameTableButton.TabIndex = 2;
            this.renameTableButton.Text = "Rename Table";
            this.renameTableButton.UseVisualStyleBackColor = true;
            this.renameTableButton.Click += new System.EventHandler(this.RenameTableButton_Click);
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(10, 23);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.tableNameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Table Name";
            // 
            // reportTabPage
            // 
            this.reportTabPage.Location = new System.Drawing.Point(4, 22);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Size = new System.Drawing.Size(733, 545);
            this.reportTabPage.TabIndex = 2;
            this.reportTabPage.Text = "Table Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Databases";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tables";
            // 
            // createDbButton
            // 
            this.createDbButton.Location = new System.Drawing.Point(10, 531);
            this.createDbButton.Name = "createDbButton";
            this.createDbButton.Size = new System.Drawing.Size(160, 23);
            this.createDbButton.TabIndex = 12;
            this.createDbButton.Text = "Create Database";
            this.createDbButton.UseVisualStyleBackColor = true;
            this.createDbButton.Click += new System.EventHandler(this.CreateDbButton_Click);
            // 
            // dropDbButton
            // 
            this.dropDbButton.Location = new System.Drawing.Point(10, 560);
            this.dropDbButton.Name = "dropDbButton";
            this.dropDbButton.Size = new System.Drawing.Size(160, 23);
            this.dropDbButton.TabIndex = 13;
            this.dropDbButton.Text = "Drop Database";
            this.dropDbButton.UseVisualStyleBackColor = true;
            this.dropDbButton.Click += new System.EventHandler(this.DropDbButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(176, 531);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(160, 23);
            this.createTableButton.TabIndex = 14;
            this.createTableButton.Text = "Create Table";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // dropTableButton
            // 
            this.dropTableButton.Location = new System.Drawing.Point(176, 560);
            this.dropTableButton.Name = "dropTableButton";
            this.dropTableButton.Size = new System.Drawing.Size(160, 23);
            this.dropTableButton.TabIndex = 15;
            this.dropTableButton.Text = "Drop Table";
            this.dropTableButton.UseVisualStyleBackColor = true;
            this.dropTableButton.Click += new System.EventHandler(this.DropTableButton_Click);
            // 
            // importTabPage
            // 
            this.importTabPage.Location = new System.Drawing.Point(4, 22);
            this.importTabPage.Name = "importTabPage";
            this.importTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.importTabPage.Size = new System.Drawing.Size(733, 545);
            this.importTabPage.TabIndex = 3;
            this.importTabPage.Text = "Import Table";
            this.importTabPage.UseVisualStyleBackColor = true;
            // 
            // exportTabPage
            // 
            this.exportTabPage.Location = new System.Drawing.Point(4, 22);
            this.exportTabPage.Name = "exportTabPage";
            this.exportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.exportTabPage.Size = new System.Drawing.Size(733, 545);
            this.exportTabPage.TabIndex = 4;
            this.exportTabPage.Text = "Export Table";
            this.exportTabPage.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 611);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.dropDbButton);
            this.Controls.Add(this.dropTableButton);
            this.Controls.Add(this.createDbButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.databasesListBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tablesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Server App";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.dataTabPage.ResumeLayout(false);
            this.dataTabPage.PerformLayout();
            this.structureTabPage.ResumeLayout(false);
            this.structureTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tablesListBox;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
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
        private System.Windows.Forms.ListBox databasesListBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage dataTabPage;
        private System.Windows.Forms.TabPage structureTabPage;
        private System.Windows.Forms.TabPage reportTabPage;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createDbButton;
        private System.Windows.Forms.Button dropDbButton;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button dropTableButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button renameTableButton;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox fksListBox;
        private System.Windows.Forms.CheckBox autoIncrementCheckBox;
        private System.Windows.Forms.CheckBox nullableCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addColumnButton;
        private System.Windows.Forms.Button dropColumnButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox columnNameTextBox;
        private System.Windows.Forms.Button alterColumnButton;
        private System.Windows.Forms.ListBox columnsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox columnTypeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button filterColumnsButton;
        private System.Windows.Forms.Button changePkButton;
        private System.Windows.Forms.CheckedListBox pkCheckedListBox;
        private System.Windows.Forms.Button dropForeignKeyButton;
        private System.Windows.Forms.Button addForeignKeyButton;
        private System.Windows.Forms.ComboBox foreignColumnComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox foreignTableComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox columnComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox indexComboBox;
        private System.Windows.Forms.Button rollbackButton;
        private System.Windows.Forms.Button createSavepointButton;
        private System.Windows.Forms.TabPage importTabPage;
        private System.Windows.Forms.TabPage exportTabPage;
    }
}

