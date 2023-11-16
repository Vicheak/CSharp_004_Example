namespace Item_CRUD_practice
{
    partial class ItemFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewShowItemInfo = new System.Windows.Forms.DataGridView();
            this.ColumnItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategroryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBrandId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1182, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewShowItemInfo
            // 
            this.dataGridViewShowItemInfo.AllowUserToAddRows = false;
            this.dataGridViewShowItemInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewShowItemInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewShowItemInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShowItemInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowItemInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewShowItemInfo.ColumnHeadersHeight = 50;
            this.dataGridViewShowItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewShowItemInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemId,
            this.ColumnItemName,
            this.ColumnCategroryId,
            this.ColumnBrandId,
            this.ColumnCategoryName,
            this.ColumnBrandName,
            this.ColumnEmpty});
            this.dataGridViewShowItemInfo.EnableHeadersVisualStyles = false;
            this.dataGridViewShowItemInfo.Location = new System.Drawing.Point(397, 117);
            this.dataGridViewShowItemInfo.Name = "dataGridViewShowItemInfo";
            this.dataGridViewShowItemInfo.ReadOnly = true;
            this.dataGridViewShowItemInfo.RowHeadersWidth = 51;
            this.dataGridViewShowItemInfo.RowTemplate.Height = 40;
            this.dataGridViewShowItemInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewShowItemInfo.Size = new System.Drawing.Size(773, 424);
            this.dataGridViewShowItemInfo.TabIndex = 0;
            // 
            // ColumnItemId
            // 
            this.ColumnItemId.DataPropertyName = "ItemId";
            this.ColumnItemId.HeaderText = "Item ID";
            this.ColumnItemId.MinimumWidth = 6;
            this.ColumnItemId.Name = "ColumnItemId";
            this.ColumnItemId.ReadOnly = true;
            this.ColumnItemId.Width = 125;
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnItemName.DataPropertyName = "ItemName";
            this.ColumnItemName.HeaderText = "Item Name";
            this.ColumnItemName.MinimumWidth = 6;
            this.ColumnItemName.Name = "ColumnItemName";
            this.ColumnItemName.ReadOnly = true;
            // 
            // ColumnCategroryId
            // 
            this.ColumnCategroryId.DataPropertyName = "CategoryId";
            this.ColumnCategroryId.HeaderText = "Category ID";
            this.ColumnCategroryId.MinimumWidth = 6;
            this.ColumnCategroryId.Name = "ColumnCategroryId";
            this.ColumnCategroryId.ReadOnly = true;
            this.ColumnCategroryId.Visible = false;
            this.ColumnCategroryId.Width = 125;
            // 
            // ColumnBrandId
            // 
            this.ColumnBrandId.DataPropertyName = "BrandId";
            this.ColumnBrandId.HeaderText = "Brand ID";
            this.ColumnBrandId.MinimumWidth = 6;
            this.ColumnBrandId.Name = "ColumnBrandId";
            this.ColumnBrandId.ReadOnly = true;
            this.ColumnBrandId.Visible = false;
            this.ColumnBrandId.Width = 125;
            // 
            // ColumnCategoryName
            // 
            this.ColumnCategoryName.DataPropertyName = "CategoryName";
            this.ColumnCategoryName.HeaderText = "Category";
            this.ColumnCategoryName.MinimumWidth = 6;
            this.ColumnCategoryName.Name = "ColumnCategoryName";
            this.ColumnCategoryName.ReadOnly = true;
            this.ColumnCategoryName.Width = 125;
            // 
            // ColumnBrandName
            // 
            this.ColumnBrandName.DataPropertyName = "BrandName";
            this.ColumnBrandName.HeaderText = "Brand";
            this.ColumnBrandName.MinimumWidth = 6;
            this.ColumnBrandName.Name = "ColumnBrandName";
            this.ColumnBrandName.ReadOnly = true;
            this.ColumnBrandName.Width = 125;
            // 
            // ColumnEmpty
            // 
            this.ColumnEmpty.HeaderText = "";
            this.ColumnEmpty.MinimumWidth = 6;
            this.ColumnEmpty.Name = "ColumnEmpty";
            this.ColumnEmpty.ReadOnly = true;
            this.ColumnEmpty.Visible = false;
            this.ColumnEmpty.Width = 266;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Brand :";
            // 
            // txtItemId
            // 
            this.txtItemId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtItemId.Location = new System.Drawing.Point(133, 159);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(234, 40);
            this.txtItemId.TabIndex = 5;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(133, 230);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(234, 40);
            this.txtItemName.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(133, 300);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(234, 41);
            this.cbCategory.TabIndex = 7;
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(133, 371);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(234, 41);
            this.cbBrand.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(19, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 46);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Location = new System.Drawing.Point(254, 79);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 46);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(19, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 46);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(254, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 46);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(803, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 40);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1057, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblValue.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.Red;
            this.lblValue.Location = new System.Drawing.Point(137, 166);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(144, 27);
            this.lblValue.TabIndex = 12;
            this.lblValue.Text = "-- Auto As Identity --";
            // 
            // ItemFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewShowItemInfo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerFrm";
            this.Load += new System.EventHandler(this.ItemFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowItemInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewShowItemInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategroryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrandId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblValue;
    }
}