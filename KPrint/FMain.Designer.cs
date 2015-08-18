namespace KPrint
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txbModelForSearch = new System.Windows.Forms.TextBox();
            this.txbNameForSearch = new System.Windows.Forms.TextBox();
            this.txbPartNoForSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrintList = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbCapacity = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPart_No = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 150);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 150);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbModelForSearch);
            this.tabPage1.Controls.Add(this.txbNameForSearch);
            this.tabPage1.Controls.Add(this.txbPartNoForSearch);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询打印";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txbModelForSearch
            // 
            this.txbModelForSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbModelForSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.txbModelForSearch.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbModelForSearch.Location = new System.Drawing.Point(600, 20);
            this.txbModelForSearch.MaxLength = 10;
            this.txbModelForSearch.Name = "txbModelForSearch";
            this.txbModelForSearch.Size = new System.Drawing.Size(100, 26);
            this.txbModelForSearch.TabIndex = 2;
            this.txbModelForSearch.TextChanged += new System.EventHandler(this.txbModelForSearch_TextChanged);
            this.txbModelForSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbModelForSearch_KeyPress);
            // 
            // txbNameForSearch
            // 
            this.txbNameForSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.txbNameForSearch.Location = new System.Drawing.Point(355, 20);
            this.txbNameForSearch.MaxLength = 30;
            this.txbNameForSearch.Name = "txbNameForSearch";
            this.txbNameForSearch.Size = new System.Drawing.Size(200, 26);
            this.txbNameForSearch.TabIndex = 1;
            // 
            // txbPartNoForSearch
            // 
            this.txbPartNoForSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPartNoForSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.txbPartNoForSearch.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbPartNoForSearch.Location = new System.Drawing.Point(80, 20);
            this.txbPartNoForSearch.MaxLength = 20;
            this.txbPartNoForSearch.Name = "txbPartNoForSearch";
            this.txbPartNoForSearch.Size = new System.Drawing.Size(200, 26);
            this.txbPartNoForSearch.TabIndex = 0;
            this.txbPartNoForSearch.TextChanged += new System.EventHandler(this.txbPartNoForSearch_TextChanged);
            this.txbPartNoForSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPartNoForSearch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(560, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "车型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(280, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "产品名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "零件编号";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnPrintList);
            this.panel3.Controls.Add(this.btnImport);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 49);
            this.panel3.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExport.Location = new System.Drawing.Point(375, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 30);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrintList
            // 
            this.btnPrintList.Font = new System.Drawing.Font("宋体", 12F);
            this.btnPrintList.Location = new System.Drawing.Point(498, 12);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(152, 30);
            this.btnPrintList.TabIndex = 4;
            this.btnPrintList.Text = "查看打印记录";
            this.btnPrintList.UseVisualStyleBackColor = true;
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // btnImport
            // 
            this.btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btnImport.Font = new System.Drawing.Font("宋体", 12F);
            this.btnImport.Location = new System.Drawing.Point(252, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(105, 30);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("宋体", 12F);
            this.btnPrint.Location = new System.Drawing.Point(129, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 30);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "打印 ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSearch.Location = new System.Drawing.Point(6, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.txbCapacity);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.txbModel);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txbName);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txbPart_No);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 124);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "编辑";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(876, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // txbCapacity
            // 
            this.txbCapacity.BackColor = System.Drawing.SystemColors.Window;
            this.txbCapacity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbCapacity.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbCapacity.Location = new System.Drawing.Point(765, 20);
            this.txbCapacity.MaxLength = 3;
            this.txbCapacity.Name = "txbCapacity";
            this.txbCapacity.Size = new System.Drawing.Size(37, 26);
            this.txbCapacity.TabIndex = 7;
            this.txbCapacity.Text = "60";
            this.txbCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCapacity_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 12F);
            this.label23.Location = new System.Drawing.Point(705, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 28;
            this.label23.Text = "收容数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(853, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnADD);
            this.panel4.Controls.Add(this.btnUploadImg);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(990, 49);
            this.panel4.TabIndex = 25;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F);
            this.btnClear.Location = new System.Drawing.Point(6, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空 ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnEdit.Location = new System.Drawing.Point(250, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSave.Location = new System.Drawing.Point(494, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDelete.Location = new System.Drawing.Point(372, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("宋体", 12F);
            this.btnADD.Location = new System.Drawing.Point(128, 12);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(105, 30);
            this.btnADD.TabIndex = 2;
            this.btnADD.Text = "新增";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadImg.Font = new System.Drawing.Font("宋体", 12F);
            this.btnUploadImg.Location = new System.Drawing.Point(877, 12);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(105, 30);
            this.btnUploadImg.TabIndex = 0;
            this.btnUploadImg.Text = "选择图片";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // txbModel
            // 
            this.txbModel.BackColor = System.Drawing.SystemColors.Window;
            this.txbModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbModel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbModel.Location = new System.Drawing.Point(600, 20);
            this.txbModel.MaxLength = 10;
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(100, 26);
            this.txbModel.TabIndex = 8;
            this.txbModel.Text = "2CE";
            this.txbModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbModelForSearch_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(560, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "车型";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Window;
            this.txbName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbName.Location = new System.Drawing.Point(355, 20);
            this.txbName.MaxLength = 30;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(200, 26);
            this.txbName.TabIndex = 6;
            this.txbName.Text = "COVER L,FR FLOOR UNDER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(280, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "产品名称";
            // 
            // txbPart_No
            // 
            this.txbPart_No.BackColor = System.Drawing.SystemColors.Window;
            this.txbPart_No.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPart_No.Enabled = false;
            this.txbPart_No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbPart_No.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbPart_No.Location = new System.Drawing.Point(80, 20);
            this.txbPart_No.MaxLength = 20;
            this.txbPart_No.Name = "txbPart_No";
            this.txbPart_No.Size = new System.Drawing.Size(200, 26);
            this.txbPart_No.TabIndex = 5;
            this.txbPart_No.Text = "74561-T6L-H010-M1";
            this.txbPart_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPart_No_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(5, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "零件编号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 531);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.partNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.img});
            this.dataGridView1.DataSource = this.bdsProduct;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 509);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // img
            // 
            this.img.DataPropertyName = "img";
            this.img.HeaderText = "图片";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelDB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelDB
            // 
            this.LabelDB.Name = "LabelDB";
            this.LabelDB.Size = new System.Drawing.Size(164, 17);
            this.LabelDB.Text = "数据库地址：远程测试数据库";
            this.LabelDB.Click += new System.EventHandler(this.LabelDB_Click);
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "part_No";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "零件编号";
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "产品名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "车型";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "收容数";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Visible = false;
            // 
            // bdsProduct
            // 
            this.bdsProduct.DataSource = typeof(KPrint.rt_product);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社内标签打印系统 v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbModelForSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNameForSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPartNoForSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPart_No;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnPrintList;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelDB;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbCapacity;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdsProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn img;
    }
}