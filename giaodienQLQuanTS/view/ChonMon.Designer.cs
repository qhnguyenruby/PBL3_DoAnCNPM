namespace giaodienQLQuanTS
{
    partial class ChonMon
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
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.nmudDiscount = new System.Windows.Forms.NumericUpDown();
            this.nmudQuantity = new System.Windows.Forms.NumericUpDown();
            this.but_CheckOut = new System.Windows.Forms.Button();
            this.but_SwitchTable = new System.Windows.Forms.Button();
            this.but_ThemMon = new System.Windows.Forms.Button();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbTable = new System.Windows.Forms.Label();
            this.txbTable = new System.Windows.Forms.TextBox();
            this.but_CancelBookTable = new System.Windows.Forms.Button();
            this.but_BookTable = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBill = new System.Windows.Forms.ListView();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbProduct.Location = new System.Drawing.Point(647, 122);
            this.lbProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(69, 20);
            this.lbProduct.TabIndex = 15;
            this.lbProduct.Text = "Món ăn:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCategory.Location = new System.Drawing.Point(647, 81);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(91, 20);
            this.lbCategory.TabIndex = 16;
            this.lbCategory.Text = "Danh mục:";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiscount.Location = new System.Drawing.Point(647, 292);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(81, 20);
            this.lbDiscount.TabIndex = 17;
            this.lbDiscount.Text = "Giảm giá:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQuantity.Location = new System.Drawing.Point(647, 165);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(79, 20);
            this.lbQuantity.TabIndex = 18;
            this.lbQuantity.Text = "Số lượng:";
            // 
            // nmudDiscount
            // 
            this.nmudDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmudDiscount.Location = new System.Drawing.Point(745, 290);
            this.nmudDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.nmudDiscount.Name = "nmudDiscount";
            this.nmudDiscount.Size = new System.Drawing.Size(110, 27);
            this.nmudDiscount.TabIndex = 7;
            // 
            // nmudQuantity
            // 
            this.nmudQuantity.Location = new System.Drawing.Point(745, 162);
            this.nmudQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.nmudQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmudQuantity.Name = "nmudQuantity";
            this.nmudQuantity.Size = new System.Drawing.Size(135, 22);
            this.nmudQuantity.TabIndex = 3;
            this.nmudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // but_CheckOut
            // 
            this.but_CheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_CheckOut.Location = new System.Drawing.Point(487, 408);
            this.but_CheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.but_CheckOut.Name = "but_CheckOut";
            this.but_CheckOut.Size = new System.Drawing.Size(128, 44);
            this.but_CheckOut.TabIndex = 8;
            this.but_CheckOut.Text = "Thanh toán";
            this.but_CheckOut.UseVisualStyleBackColor = true;
            this.but_CheckOut.Click += new System.EventHandler(this.but_CheckOut_Click);
            // 
            // but_SwitchTable
            // 
            this.but_SwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_SwitchTable.Location = new System.Drawing.Point(883, 336);
            this.but_SwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.but_SwitchTable.Name = "but_SwitchTable";
            this.but_SwitchTable.Size = new System.Drawing.Size(133, 44);
            this.but_SwitchTable.TabIndex = 6;
            this.but_SwitchTable.Text = "Chuyển bàn";
            this.but_SwitchTable.UseVisualStyleBackColor = true;
            // 
            // but_ThemMon
            // 
            this.but_ThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_ThemMon.Location = new System.Drawing.Point(651, 203);
            this.but_ThemMon.Margin = new System.Windows.Forms.Padding(4);
            this.but_ThemMon.Name = "but_ThemMon";
            this.but_ThemMon.Size = new System.Drawing.Size(365, 64);
            this.but_ThemMon.TabIndex = 4;
            this.but_ThemMon.Text = "Thêm món";
            this.but_ThemMon.UseVisualStyleBackColor = true;
            this.but_ThemMon.Click += new System.EventHandler(this.but_ThemMon_Click);
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4",
            "Bàn 5"});
            this.cbSwitchTable.Location = new System.Drawing.Point(651, 347);
            this.cbSwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(229, 28);
            this.cbSwitchTable.TabIndex = 5;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(745, 118);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(271, 24);
            this.cbProduct.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(745, 78);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(271, 24);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTable.Location = new System.Drawing.Point(652, 34);
            this.lbTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(44, 20);
            this.lbTable.TabIndex = 16;
            this.lbTable.Text = "Bàn:";
            // 
            // txbTable
            // 
            this.txbTable.Location = new System.Drawing.Point(745, 33);
            this.txbTable.Margin = new System.Windows.Forms.Padding(4);
            this.txbTable.Name = "txbTable";
            this.txbTable.ReadOnly = true;
            this.txbTable.Size = new System.Drawing.Size(271, 22);
            this.txbTable.TabIndex = 19;
            // 
            // but_CancelBookTable
            // 
            this.but_CancelBookTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_CancelBookTable.Location = new System.Drawing.Point(831, 393);
            this.but_CancelBookTable.Margin = new System.Windows.Forms.Padding(4);
            this.but_CancelBookTable.Name = "but_CancelBookTable";
            this.but_CancelBookTable.Size = new System.Drawing.Size(185, 59);
            this.but_CancelBookTable.TabIndex = 8;
            this.but_CancelBookTable.Text = "Hủy đặt bàn";
            this.but_CancelBookTable.UseVisualStyleBackColor = true;
            this.but_CancelBookTable.Click += new System.EventHandler(this.but_CancelBookTable_Click);
            // 
            // but_BookTable
            // 
            this.but_BookTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_BookTable.Location = new System.Drawing.Point(638, 393);
            this.but_BookTable.Margin = new System.Windows.Forms.Padding(4);
            this.but_BookTable.Name = "but_BookTable";
            this.but_BookTable.Size = new System.Drawing.Size(185, 59);
            this.but_BookTable.TabIndex = 8;
            this.but_BookTable.Text = "Đặt bàn";
            this.but_BookTable.UseVisualStyleBackColor = true;
            this.but_BookTable.Click += new System.EventHandler(this.but_BookTable_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(256, 417);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(224, 27);
            this.txtTotalPrice.TabIndex = 21;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 142;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(12, 12);
            this.lvBill.Name = "lvBill";
            this.lvBill.Scrollable = false;
            this.lvBill.Size = new System.Drawing.Size(603, 389);
            this.lvBill.TabIndex = 20;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(131, 420);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(83, 20);
            this.lbTotalPrice.TabIndex = 22;
            this.lbTotalPrice.Text = "Tổng tiền:";
            // 
            // ChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 468);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lvBill);
            this.Controls.Add(this.txbTable);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.lbTable);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.nmudDiscount);
            this.Controls.Add(this.nmudQuantity);
            this.Controls.Add(this.but_BookTable);
            this.Controls.Add(this.but_CancelBookTable);
            this.Controls.Add(this.but_CheckOut);
            this.Controls.Add(this.but_SwitchTable);
            this.Controls.Add(this.but_ThemMon);
            this.Controls.Add(this.cbSwitchTable);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChonMon";
            this.Text = "Chọn món";
            ((System.ComponentModel.ISupportInitialize)(this.nmudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.NumericUpDown nmudDiscount;
        private System.Windows.Forms.NumericUpDown nmudQuantity;
        private System.Windows.Forms.Button but_CheckOut;
        private System.Windows.Forms.Button but_SwitchTable;
        private System.Windows.Forms.Button but_ThemMon;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.TextBox txbTable;
        private System.Windows.Forms.Button but_CancelBookTable;
        private System.Windows.Forms.Button but_BookTable;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.Label lbTotalPrice;
    }
}