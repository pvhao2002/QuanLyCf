
namespace CAFE_SHOP_MANAGEMENT
{
    partial class frmTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtxtSearch = new System.Windows.Forms.RichTextBox();
            this.grboxTableFood = new System.Windows.Forms.Panel();
            this.cboTableStatus = new System.Windows.Forms.ComboBox();
            this.rtxtTableName = new System.Windows.Forms.RichTextBox();
            this.rtxtTableID = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTableFood = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.grboxTableFood.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(454, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "TABLE FOOD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.rtxtSearch);
            this.panel4.Location = new System.Drawing.Point(638, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 74);
            this.panel4.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(404, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(189, 67);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtxtSearch
            // 
            this.rtxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSearch.Location = new System.Drawing.Point(3, 16);
            this.rtxtSearch.Multiline = false;
            this.rtxtSearch.Name = "rtxtSearch";
            this.rtxtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtxtSearch.Size = new System.Drawing.Size(380, 44);
            this.rtxtSearch.TabIndex = 1;
            this.rtxtSearch.Text = "";
            // 
            // grboxTableFood
            // 
            this.grboxTableFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grboxTableFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grboxTableFood.BackgroundImage")));
            this.grboxTableFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grboxTableFood.Controls.Add(this.cboTableStatus);
            this.grboxTableFood.Controls.Add(this.rtxtTableName);
            this.grboxTableFood.Controls.Add(this.rtxtTableID);
            this.grboxTableFood.Controls.Add(this.label5);
            this.grboxTableFood.Controls.Add(this.label3);
            this.grboxTableFood.Controls.Add(this.label2);
            this.grboxTableFood.Location = new System.Drawing.Point(638, 126);
            this.grboxTableFood.Name = "grboxTableFood";
            this.grboxTableFood.Size = new System.Drawing.Size(599, 457);
            this.grboxTableFood.TabIndex = 12;
            // 
            // cboTableStatus
            // 
            this.cboTableStatus.BackColor = System.Drawing.Color.White;
            this.cboTableStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cboTableStatus.FormattingEnabled = true;
            this.cboTableStatus.Items.AddRange(new object[] {
            "Đã có người",
            "Trống"});
            this.cboTableStatus.Location = new System.Drawing.Point(200, 282);
            this.cboTableStatus.Name = "cboTableStatus";
            this.cboTableStatus.Size = new System.Drawing.Size(328, 37);
            this.cboTableStatus.TabIndex = 3;
            // 
            // rtxtTableName
            // 
            this.rtxtTableName.BackColor = System.Drawing.Color.White;
            this.rtxtTableName.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTableName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtxtTableName.Location = new System.Drawing.Point(200, 175);
            this.rtxtTableName.Multiline = false;
            this.rtxtTableName.Name = "rtxtTableName";
            this.rtxtTableName.Size = new System.Drawing.Size(328, 50);
            this.rtxtTableName.TabIndex = 1;
            this.rtxtTableName.Text = "";
            // 
            // rtxtTableID
            // 
            this.rtxtTableID.BackColor = System.Drawing.Color.White;
            this.rtxtTableID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtTableID.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTableID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtxtTableID.Location = new System.Drawing.Point(200, 65);
            this.rtxtTableID.Multiline = false;
            this.rtxtTableID.Name = "rtxtTableID";
            this.rtxtTableID.Size = new System.Drawing.Size(328, 50);
            this.rtxtTableID.TabIndex = 0;
            this.rtxtTableID.Text = "";
            this.rtxtTableID.Leave += new System.EventHandler(this.rtxtTableID_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(58, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(58, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên bàn ăn:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(12, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 74);
            this.panel2.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(487, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 67);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(371, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 67);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(255, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 67);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(139, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 67);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(23, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTableFood
            // 
            this.dgvTableFood.AllowUserToResizeColumns = false;
            this.dgvTableFood.AllowUserToResizeRows = false;
            this.dgvTableFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTableFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTableFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTableFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableFood.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTableFood.Location = new System.Drawing.Point(3, 3);
            this.dgvTableFood.Name = "dgvTableFood";
            this.dgvTableFood.ReadOnly = true;
            this.dgvTableFood.RowHeadersWidth = 51;
            this.dgvTableFood.RowTemplate.Height = 24;
            this.dgvTableFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableFood.Size = new System.Drawing.Size(614, 451);
            this.dgvTableFood.TabIndex = 0;
            this.dgvTableFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableFood_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTableFood);
            this.panel1.Location = new System.Drawing.Point(12, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 457);
            this.panel1.TabIndex = 10;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.grboxTableFood);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.panel4.ResumeLayout(false);
            this.grboxTableFood.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtxtSearch;
        private System.Windows.Forms.Panel grboxTableFood;
        private System.Windows.Forms.ComboBox cboTableStatus;
        private System.Windows.Forms.RichTextBox rtxtTableName;
        private System.Windows.Forms.RichTextBox rtxtTableID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTableFood;
        private System.Windows.Forms.Panel panel1;
    }
}