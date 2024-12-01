
namespace CAFE_SHOP_MANAGEMENT
{
    partial class frmOrder
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
            this.flpanelCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcontrolOrder = new System.Windows.Forms.TabControl();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.flpanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panelListOrder = new System.Windows.Forms.Panel();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFoodDrinkName = new System.Windows.Forms.ComboBox();
            this.nmrCount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.flpanelCategory.SuspendLayout();
            this.tcontrolOrder.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panelListOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
            this.SuspendLayout();
            // 
            // flpanelCategory
            // 
            this.flpanelCategory.AutoScroll = true;
            this.flpanelCategory.Controls.Add(this.panel1);
            this.flpanelCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpanelCategory.Location = new System.Drawing.Point(0, 0);
            this.flpanelCategory.Name = "flpanelCategory";
            this.flpanelCategory.Size = new System.Drawing.Size(221, 670);
            this.flpanelCategory.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 94);
            this.panel1.TabIndex = 0;
            // 
            // tcontrolOrder
            // 
            this.tcontrolOrder.Controls.Add(this.tpTable);
            this.tcontrolOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.tcontrolOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcontrolOrder.Location = new System.Drawing.Point(221, 0);
            this.tcontrolOrder.Name = "tcontrolOrder";
            this.tcontrolOrder.SelectedIndex = 0;
            this.tcontrolOrder.Size = new System.Drawing.Size(438, 670);
            this.tcontrolOrder.TabIndex = 1;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.flpanelTable);
            this.tpTable.Location = new System.Drawing.Point(4, 29);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(430, 637);
            this.tpTable.TabIndex = 1;
            this.tpTable.Text = "Table";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // flpanelTable
            // 
            this.flpanelTable.AutoScroll = true;
            this.flpanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelTable.Location = new System.Drawing.Point(3, 3);
            this.flpanelTable.Name = "flpanelTable";
            this.flpanelTable.Size = new System.Drawing.Size(424, 631);
            this.flpanelTable.TabIndex = 0;
            // 
            // panelListOrder
            // 
            this.panelListOrder.Controls.Add(this.lvOrder);
            this.panelListOrder.Location = new System.Drawing.Point(661, 29);
            this.panelListOrder.Name = "panelListOrder";
            this.panelListOrder.Size = new System.Drawing.Size(599, 376);
            this.panelListOrder.TabIndex = 2;
            // 
            // lvOrder
            // 
            this.lvOrder.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvOrder.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.lvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrder.FullRowSelect = true;
            this.lvOrder.GridLines = true;
            this.lvOrder.HideSelection = false;
            this.lvOrder.HotTracking = true;
            this.lvOrder.HoverSelection = true;
            this.lvOrder.Location = new System.Drawing.Point(0, 0);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(599, 376);
            this.lvOrder.TabIndex = 0;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "Tên món";
            this.col1.Width = 150;
            // 
            // col2
            // 
            this.col2.Text = "Số lượng";
            this.col2.Width = 91;
            // 
            // col3
            // 
            this.col3.Text = "Đơn giá";
            this.col3.Width = 70;
            // 
            // col4
            // 
            this.col4.Text = "Thành tiền";
            this.col4.Width = 132;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(705, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 65);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(665, 408);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(198, 51);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total price:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(665, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 75);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên món:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboFoodDrinkName
            // 
            this.cboFoodDrinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoodDrinkName.FormattingEnabled = true;
            this.cboFoodDrinkName.Location = new System.Drawing.Point(825, 556);
            this.cboFoodDrinkName.Name = "cboFoodDrinkName";
            this.cboFoodDrinkName.Size = new System.Drawing.Size(431, 28);
            this.cboFoodDrinkName.TabIndex = 7;
            // 
            // nmrCount
            // 
            this.nmrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrCount.Location = new System.Drawing.Point(828, 590);
            this.nmrCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrCount.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Size = new System.Drawing.Size(138, 26);
            this.nmrCount.TabIndex = 8;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCheckout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.Red;
            this.btnCheckout.Location = new System.Drawing.Point(993, 462);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(202, 65);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(869, 419);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(391, 33);
            this.txtTotalPrice.TabIndex = 9;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1268, 670);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.nmrCount);
            this.Controls.Add(this.cboFoodDrinkName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelListOrder);
            this.Controls.Add(this.tcontrolOrder);
            this.Controls.Add(this.flpanelCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.flpanelCategory.ResumeLayout(false);
            this.tcontrolOrder.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.panelListOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpanelCategory;
        private System.Windows.Forms.TabControl tcontrolOrder;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.Panel panelListOrder;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.FlowLayoutPanel flpanelTable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFoodDrinkName;
        private System.Windows.Forms.NumericUpDown nmrCount;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}