
namespace SMOA.UI.Forms
{
    partial class frmMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoriesPNL = new System.Windows.Forms.Panel();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnLO = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCm = new System.Windows.Forms.Button();
            this.btnBev = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.HeaderPNL = new System.Windows.Forms.Panel();
            this.lbCategory = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuFooterPnl = new System.Windows.Forms.Panel();
            this.lbDescVal = new System.Windows.Forms.Label();
            this.lbNameVal = new System.Windows.Forms.Label();
            this.lbProductDesc = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.btnATC = new System.Windows.Forms.Button();
            this.lbPriceVal = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.ItemsPnl = new System.Windows.Forms.Panel();
            this.CartListPanel = new System.Windows.Forms.Panel();
            this.lbTaxVal = new System.Windows.Forms.Label();
            this.lbDiscountVal = new System.Windows.Forms.Label();
            this.lbSubTotalVal = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbCoupon = new System.Windows.Forms.Label();
            this.tbCouponCode = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbTotalVal = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.cartListDGV = new System.Windows.Forms.DataGridView();
            this.CartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLOOheader = new System.Windows.Forms.Panel();
            this.lbLlistOfOrders = new System.Windows.Forms.Label();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.categoriesPNL.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.HeaderPNL.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.MenuFooterPnl.SuspendLayout();
            this.CartListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartListDGV)).BeginInit();
            this.pnlLOOheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesPNL
            // 
            this.categoriesPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(234)))));
            this.categoriesPNL.Controls.Add(this.btnViewOrders);
            this.categoriesPNL.Controls.Add(this.btnTax);
            this.categoriesPNL.Controls.Add(this.btnLO);
            this.categoriesPNL.Controls.Add(this.tableLayoutPanel1);
            this.categoriesPNL.Controls.Add(this.HeaderPNL);
            this.categoriesPNL.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoriesPNL.Location = new System.Drawing.Point(0, 0);
            this.categoriesPNL.Name = "categoriesPNL";
            this.categoriesPNL.Size = new System.Drawing.Size(229, 743);
            this.categoriesPNL.TabIndex = 0;
            // 
            // btnTax
            // 
            this.btnTax.BackColor = System.Drawing.Color.Transparent;
            this.btnTax.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTax.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTax.Location = new System.Drawing.Point(0, 681);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(229, 31);
            this.btnTax.TabIndex = 7;
            this.btnTax.Text = "Configure Tax (%)";
            this.btnTax.UseVisualStyleBackColor = false;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnLO
            // 
            this.btnLO.BackColor = System.Drawing.Color.Transparent;
            this.btnLO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLO.Location = new System.Drawing.Point(0, 712);
            this.btnLO.Name = "btnLO";
            this.btnLO.Size = new System.Drawing.Size(229, 31);
            this.btnLO.TabIndex = 6;
            this.btnLO.Text = "Log Out";
            this.btnLO.UseVisualStyleBackColor = false;
            this.btnLO.Click += new System.EventHandler(this.btnLO_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBev, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBurger, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 221);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnCm
            // 
            this.btnCm.BackColor = System.Drawing.Color.Transparent;
            this.btnCm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCm.FlatAppearance.BorderSize = 0;
            this.btnCm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCm.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCm.Location = new System.Drawing.Point(3, 149);
            this.btnCm.Name = "btnCm";
            this.btnCm.Size = new System.Drawing.Size(223, 69);
            this.btnCm.TabIndex = 5;
            this.btnCm.Text = "Combo Meals";
            this.btnCm.UseVisualStyleBackColor = false;
            this.btnCm.Click += new System.EventHandler(this.btnCm_Click);
            // 
            // btnBev
            // 
            this.btnBev.BackColor = System.Drawing.Color.Transparent;
            this.btnBev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBev.FlatAppearance.BorderSize = 0;
            this.btnBev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBev.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBev.Location = new System.Drawing.Point(3, 76);
            this.btnBev.Name = "btnBev";
            this.btnBev.Size = new System.Drawing.Size(223, 67);
            this.btnBev.TabIndex = 4;
            this.btnBev.Text = "Beverages";
            this.btnBev.UseVisualStyleBackColor = false;
            this.btnBev.Click += new System.EventHandler(this.btnBev_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.BackColor = System.Drawing.Color.Transparent;
            this.btnBurger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBurger.FlatAppearance.BorderSize = 0;
            this.btnBurger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBurger.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBurger.Location = new System.Drawing.Point(3, 3);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(223, 67);
            this.btnBurger.TabIndex = 3;
            this.btnBurger.Text = "Burgers";
            this.btnBurger.UseVisualStyleBackColor = false;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // HeaderPNL
            // 
            this.HeaderPNL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderPNL.Controls.Add(this.lbCategory);
            this.HeaderPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPNL.Location = new System.Drawing.Point(0, 0);
            this.HeaderPNL.Name = "HeaderPNL";
            this.HeaderPNL.Size = new System.Drawing.Size(229, 90);
            this.HeaderPNL.TabIndex = 1;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCategory.Location = new System.Drawing.Point(56, 32);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(124, 30);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "Categories";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(202)))), ((int)(((byte)(157)))));
            this.MenuPanel.Controls.Add(this.MenuFooterPnl);
            this.MenuPanel.Controls.Add(this.ItemsPnl);
            this.MenuPanel.Controls.Add(this.CartListPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(229, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(982, 743);
            this.MenuPanel.TabIndex = 1;
            // 
            // MenuFooterPnl
            // 
            this.MenuFooterPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(141)))), ((int)(((byte)(83)))));
            this.MenuFooterPnl.Controls.Add(this.lbDescVal);
            this.MenuFooterPnl.Controls.Add(this.lbNameVal);
            this.MenuFooterPnl.Controls.Add(this.lbProductDesc);
            this.MenuFooterPnl.Controls.Add(this.lbProductName);
            this.MenuFooterPnl.Controls.Add(this.btnATC);
            this.MenuFooterPnl.Controls.Add(this.lbPriceVal);
            this.MenuFooterPnl.Controls.Add(this.lbPrice);
            this.MenuFooterPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuFooterPnl.Location = new System.Drawing.Point(0, 622);
            this.MenuFooterPnl.Name = "MenuFooterPnl";
            this.MenuFooterPnl.Size = new System.Drawing.Size(692, 121);
            this.MenuFooterPnl.TabIndex = 0;
            // 
            // lbDescVal
            // 
            this.lbDescVal.AutoSize = true;
            this.lbDescVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescVal.Location = new System.Drawing.Point(119, 34);
            this.lbDescVal.Name = "lbDescVal";
            this.lbDescVal.Size = new System.Drawing.Size(0, 19);
            this.lbDescVal.TabIndex = 11;
            // 
            // lbNameVal
            // 
            this.lbNameVal.AutoSize = true;
            this.lbNameVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNameVal.Location = new System.Drawing.Point(119, 11);
            this.lbNameVal.Name = "lbNameVal";
            this.lbNameVal.Size = new System.Drawing.Size(0, 19);
            this.lbNameVal.TabIndex = 10;
            // 
            // lbProductDesc
            // 
            this.lbProductDesc.AutoSize = true;
            this.lbProductDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductDesc.Location = new System.Drawing.Point(19, 36);
            this.lbProductDesc.Name = "lbProductDesc";
            this.lbProductDesc.Size = new System.Drawing.Size(84, 19);
            this.lbProductDesc.TabIndex = 9;
            this.lbProductDesc.Text = "Description:";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(19, 13);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(49, 19);
            this.lbProductName.TabIndex = 8;
            this.lbProductName.Text = "Name:";
            // 
            // btnATC
            // 
            this.btnATC.BackColor = System.Drawing.Color.Transparent;
            this.btnATC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnATC.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnATC.Location = new System.Drawing.Point(483, 34);
            this.btnATC.Name = "btnATC";
            this.btnATC.Size = new System.Drawing.Size(184, 75);
            this.btnATC.TabIndex = 7;
            this.btnATC.Text = "Add To Cart";
            this.btnATC.UseVisualStyleBackColor = false;
            this.btnATC.Click += new System.EventHandler(this.btnATC_Click);
            // 
            // lbPriceVal
            // 
            this.lbPriceVal.AutoSize = true;
            this.lbPriceVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPriceVal.Location = new System.Drawing.Point(119, 78);
            this.lbPriceVal.Name = "lbPriceVal";
            this.lbPriceVal.Size = new System.Drawing.Size(84, 30);
            this.lbPriceVal.TabIndex = 2;
            this.lbPriceVal.Text = "10,000";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(19, 79);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(71, 30);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Price:";
            // 
            // ItemsPnl
            // 
            this.ItemsPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsPnl.Location = new System.Drawing.Point(0, 0);
            this.ItemsPnl.Name = "ItemsPnl";
            this.ItemsPnl.Size = new System.Drawing.Size(692, 743);
            this.ItemsPnl.TabIndex = 1;
            // 
            // CartListPanel
            // 
            this.CartListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(234)))));
            this.CartListPanel.Controls.Add(this.lbTaxVal);
            this.CartListPanel.Controls.Add(this.lbDiscountVal);
            this.CartListPanel.Controls.Add(this.lbSubTotalVal);
            this.CartListPanel.Controls.Add(this.lbTax);
            this.CartListPanel.Controls.Add(this.lbSubTotal);
            this.CartListPanel.Controls.Add(this.lbDiscount);
            this.CartListPanel.Controls.Add(this.lbCoupon);
            this.CartListPanel.Controls.Add(this.tbCouponCode);
            this.CartListPanel.Controls.Add(this.btnCheckOut);
            this.CartListPanel.Controls.Add(this.btnAddDiscount);
            this.CartListPanel.Controls.Add(this.btnRemove);
            this.CartListPanel.Controls.Add(this.lbTotalVal);
            this.CartListPanel.Controls.Add(this.lbTotal);
            this.CartListPanel.Controls.Add(this.cartListDGV);
            this.CartListPanel.Controls.Add(this.pnlLOOheader);
            this.CartListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartListPanel.Location = new System.Drawing.Point(692, 0);
            this.CartListPanel.Name = "CartListPanel";
            this.CartListPanel.Size = new System.Drawing.Size(290, 743);
            this.CartListPanel.TabIndex = 0;
            // 
            // lbTaxVal
            // 
            this.lbTaxVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaxVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTaxVal.Location = new System.Drawing.Point(147, 496);
            this.lbTaxVal.Name = "lbTaxVal";
            this.lbTaxVal.Size = new System.Drawing.Size(131, 19);
            this.lbTaxVal.TabIndex = 18;
            this.lbTaxVal.Text = "0";
            this.lbTaxVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTaxVal.TextChanged += new System.EventHandler(this.lbTaxVal_TextChanged);
            // 
            // lbDiscountVal
            // 
            this.lbDiscountVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiscountVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDiscountVal.Location = new System.Drawing.Point(147, 473);
            this.lbDiscountVal.Name = "lbDiscountVal";
            this.lbDiscountVal.Size = new System.Drawing.Size(131, 19);
            this.lbDiscountVal.TabIndex = 17;
            this.lbDiscountVal.Text = "0";
            this.lbDiscountVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDiscountVal.TextChanged += new System.EventHandler(this.lbDiscountVal_TextChanged);
            // 
            // lbSubTotalVal
            // 
            this.lbSubTotalVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubTotalVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubTotalVal.Location = new System.Drawing.Point(147, 450);
            this.lbSubTotalVal.Name = "lbSubTotalVal";
            this.lbSubTotalVal.Size = new System.Drawing.Size(131, 19);
            this.lbSubTotalVal.TabIndex = 16;
            this.lbSubTotalVal.Text = "0";
            this.lbSubTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSubTotalVal.TextChanged += new System.EventHandler(this.lbSubTotalVal_TextChanged);
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTax.Location = new System.Drawing.Point(6, 497);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(59, 19);
            this.lbTax.TabIndex = 15;
            this.lbTax.Text = "Tax (%):";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubTotal.Location = new System.Drawing.Point(6, 451);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(67, 19);
            this.lbSubTotal.TabIndex = 14;
            this.lbSubTotal.Text = "SubTotal:";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDiscount.Location = new System.Drawing.Point(6, 474);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(68, 19);
            this.lbDiscount.TabIndex = 13;
            this.lbDiscount.Text = "Discount:";
            // 
            // lbCoupon
            // 
            this.lbCoupon.AutoSize = true;
            this.lbCoupon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCoupon.Location = new System.Drawing.Point(6, 584);
            this.lbCoupon.Name = "lbCoupon";
            this.lbCoupon.Size = new System.Drawing.Size(97, 19);
            this.lbCoupon.TabIndex = 12;
            this.lbCoupon.Text = "Coupon Code:";
            // 
            // tbCouponCode
            // 
            this.tbCouponCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCouponCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCouponCode.Location = new System.Drawing.Point(147, 583);
            this.tbCouponCode.MaxLength = 10;
            this.tbCouponCode.Name = "tbCouponCode";
            this.tbCouponCode.Size = new System.Drawing.Size(136, 25);
            this.tbCouponCode.TabIndex = 11;
            this.tbCouponCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.Location = new System.Drawing.Point(6, 671);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(277, 60);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDiscount.Location = new System.Drawing.Point(147, 622);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(136, 43);
            this.btnAddDiscount.TabIndex = 9;
            this.btnAddDiscount.Text = "Add Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = false;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(6, 622);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 43);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove From Cart";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbTotalVal
            // 
            this.lbTotalVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalVal.Location = new System.Drawing.Point(147, 528);
            this.lbTotalVal.Name = "lbTotalVal";
            this.lbTotalVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTotalVal.Size = new System.Drawing.Size(136, 30);
            this.lbTotalVal.TabIndex = 5;
            this.lbTotalVal.Text = "0";
            this.lbTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(6, 528);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(70, 30);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total:";
            // 
            // cartListDGV
            // 
            this.cartListDGV.AllowUserToAddRows = false;
            this.cartListDGV.AllowUserToDeleteRows = false;
            this.cartListDGV.AllowUserToResizeColumns = false;
            this.cartListDGV.AllowUserToResizeRows = false;
            this.cartListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartListDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cartListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartId,
            this.ProductName,
            this.Qty,
            this.SubTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartListDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.cartListDGV.Location = new System.Drawing.Point(6, 99);
            this.cartListDGV.MultiSelect = false;
            this.cartListDGV.Name = "cartListDGV";
            this.cartListDGV.ReadOnly = true;
            this.cartListDGV.RowHeadersVisible = false;
            this.cartListDGV.RowTemplate.Height = 25;
            this.cartListDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cartListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartListDGV.Size = new System.Drawing.Size(277, 331);
            this.cartListDGV.TabIndex = 3;
            this.cartListDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartListDGV_CellClick);
            this.cartListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartListDGV_CellContentClick);
            // 
            // CartId
            // 
            this.CartId.DataPropertyName = "CartId";
            this.CartId.HeaderText = "CartIdCartId";
            this.CartId.Name = "CartId";
            this.CartId.ReadOnly = true;
            this.CartId.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle7;
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.FillWeight = 50F;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pnlLOOheader
            // 
            this.pnlLOOheader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLOOheader.Controls.Add(this.lbLlistOfOrders);
            this.pnlLOOheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLOOheader.Location = new System.Drawing.Point(0, 0);
            this.pnlLOOheader.Name = "pnlLOOheader";
            this.pnlLOOheader.Size = new System.Drawing.Size(290, 90);
            this.pnlLOOheader.TabIndex = 2;
            // 
            // lbLlistOfOrders
            // 
            this.lbLlistOfOrders.AutoSize = true;
            this.lbLlistOfOrders.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLlistOfOrders.Location = new System.Drawing.Point(60, 32);
            this.lbLlistOfOrders.Name = "lbLlistOfOrders";
            this.lbLlistOfOrders.Size = new System.Drawing.Size(153, 30);
            this.lbLlistOfOrders.TabIndex = 0;
            this.lbLlistOfOrders.Text = "List of Orders";
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnViewOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewOrders.Location = new System.Drawing.Point(0, 650);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(229, 31);
            this.btnViewOrders.TabIndex = 8;
            this.btnViewOrders.Text = "View Previous Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 743);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.categoriesPNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.categoriesPNL.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.HeaderPNL.ResumeLayout(false);
            this.HeaderPNL.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuFooterPnl.ResumeLayout(false);
            this.MenuFooterPnl.PerformLayout();
            this.CartListPanel.ResumeLayout(false);
            this.CartListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartListDGV)).EndInit();
            this.pnlLOOheader.ResumeLayout(false);
            this.pnlLOOheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Panel categoriesPNL;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Panel HeaderPNL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnCm;
        private System.Windows.Forms.Button btnBev;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLO;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel MenuFooterPnl;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label lbTotalValue;
        private System.Windows.Forms.Button btnATC;
        private System.Windows.Forms.Panel PanelBurgers;
        private System.Windows.Forms.Panel BurgersPnl;
        private System.Windows.Forms.Panel CmPanel;
        private System.Windows.Forms.Panel ItemsPnl;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.Panel CartListPanel;
        private System.Windows.Forms.Panel pnlLOOheader;
        private System.Windows.Forms.Label lbLlistOfOrders;
        private System.Windows.Forms.Label lbLOO;
        private System.Windows.Forms.Panel pnlLBOOheader;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.DataGridView cartListDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDiscountVal;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPriceVal;
        private System.Windows.Forms.Label lbTotalVal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductDesc;
        private System.Windows.Forms.Label lbNameVal;
        private System.Windows.Forms.Label lbDescVal;
        private System.Windows.Forms.Button btnCheckOutCart;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddDisc;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label lbCoupon;
        private System.Windows.Forms.TextBox tbCouponCode;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSubTotalVal;
        private System.Windows.Forms.Label lbTaxVal;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Button btnViewOrders;
    }
}