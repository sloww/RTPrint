﻿namespace KPrint
{
    partial class FPrintLIst
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgcSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbbRemark = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpProdurceDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPartNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1003, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(159, 17);
            this.toolStripStatusLabel1.Text = "数据库地址：192.168.1.100";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "打印记录总计：12000 ";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 12F);
            this.button6.Location = new System.Drawing.Point(148, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "导出 (&O)";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(530, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(573, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 23);
            this.label19.TabIndex = 12;
            this.label19.Text = "8";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 482);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSelect,
            this.partNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.createtimeDataGridViewTextBoxColumn,
            this.productiondateDataGridViewTextBoxColumn,
            this.containerNoDataGridViewTextBoxColumn,
            this.serialnumberDataGridViewTextBoxColumn,
            this.qrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgcSelect
            // 
            this.dgcSelect.HeaderText = "序";
            this.dgcSelect.Name = "dgcSelect";
            this.dgcSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcSelect.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 150);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 150);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbbRemark);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtpProdurceDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txbModel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txbName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txbPartNo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(995, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbbRemark
            // 
            this.cbbRemark.FormattingEnabled = true;
            this.cbbRemark.Location = new System.Drawing.Point(849, 26);
            this.cbbRemark.Name = "cbbRemark";
            this.cbbRemark.Size = new System.Drawing.Size(121, 20);
            this.cbbRemark.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(803, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "备注";
            // 
            // dtpProdurceDate
            // 
            this.dtpProdurceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProdurceDate.Location = new System.Drawing.Point(695, 26);
            this.dtpProdurceDate.Name = "dtpProdurceDate";
            this.dtpProdurceDate.Size = new System.Drawing.Size(102, 21);
            this.dtpProdurceDate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(617, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "生产日期";
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(539, 26);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(72, 21);
            this.txbModel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(493, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "车型";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(319, 26);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(168, 21);
            this.txbName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(241, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "产品名称";
            // 
            // txbPartNo
            // 
            this.txbPartNo.Location = new System.Drawing.Point(86, 26);
            this.txbPartNo.Name = "txbPartNo";
            this.txbPartNo.Size = new System.Drawing.Size(149, 21);
            this.txbPartNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "零件编号";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 49);
            this.panel3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSearch.Location = new System.Drawing.Point(6, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "检索 (&Q)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "part_No";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "零件编号";
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "产品名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // 
            // createtimeDataGridViewTextBoxColumn
            // 
            this.createtimeDataGridViewTextBoxColumn.DataPropertyName = "create_time";
            this.createtimeDataGridViewTextBoxColumn.HeaderText = "打印时间";
            this.createtimeDataGridViewTextBoxColumn.Name = "createtimeDataGridViewTextBoxColumn";
            // 
            // productiondateDataGridViewTextBoxColumn
            // 
            this.productiondateDataGridViewTextBoxColumn.DataPropertyName = "production_date";
            this.productiondateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productiondateDataGridViewTextBoxColumn.Name = "productiondateDataGridViewTextBoxColumn";
            // 
            // containerNoDataGridViewTextBoxColumn
            // 
            this.containerNoDataGridViewTextBoxColumn.DataPropertyName = "container_No";
            this.containerNoDataGridViewTextBoxColumn.HeaderText = "容器编号";
            this.containerNoDataGridViewTextBoxColumn.Name = "containerNoDataGridViewTextBoxColumn";
            // 
            // serialnumberDataGridViewTextBoxColumn
            // 
            this.serialnumberDataGridViewTextBoxColumn.DataPropertyName = "serial_number";
            this.serialnumberDataGridViewTextBoxColumn.HeaderText = "序列号";
            this.serialnumberDataGridViewTextBoxColumn.Name = "serialnumberDataGridViewTextBoxColumn";
            // 
            // qrDataGridViewTextBoxColumn
            // 
            this.qrDataGridViewTextBoxColumn.DataPropertyName = "qr";
            this.qrDataGridViewTextBoxColumn.HeaderText = "二维码";
            this.qrDataGridViewTextBoxColumn.Name = "qrDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(KPrint.rt_print_log);
            // 
            // FPrintLIst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FPrintLIst";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "打印记录查询界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FPrintLIst_FormClosing);
            this.Load += new System.EventHandler(this.PrintLIst_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPartNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpProdurceDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qrDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;

    }
}