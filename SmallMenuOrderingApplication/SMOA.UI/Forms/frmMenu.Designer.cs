
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbPriceVal = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.ItemsPnl = new System.Windows.Forms.Panel();
            this.CartListPanel = new System.Windows.Forms.Panel();
            this.lbTotalVal = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLOOheader = new System.Windows.Forms.Panel();
            this.lbLlistOfOrders = new System.Windows.Forms.Label();
            this.categoriesPNL.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.HeaderPNL.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.MenuFooterPnl.SuspendLayout();
            this.CartListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlLOOheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesPNL
            // 
            this.categoriesPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(234)))));
            this.categoriesPNL.Controls.Add(this.btnLO);
            this.categoriesPNL.Controls.Add(this.tableLayoutPanel1);
            this.categoriesPNL.Controls.Add(this.HeaderPNL);
            this.categoriesPNL.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoriesPNL.Location = new System.Drawing.Point(0, 0);
            this.categoriesPNL.Name = "categoriesPNL";
            this.categoriesPNL.Size = new System.Drawing.Size(229, 650);
            this.categoriesPNL.TabIndex = 0;
            // 
            // btnLO
            // 
            this.btnLO.BackColor = System.Drawing.Color.Transparent;
            this.btnLO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLO.Location = new System.Drawing.Point(0, 619);
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
            this.MenuPanel.Size = new System.Drawing.Size(939, 650);
            this.MenuPanel.TabIndex = 1;
            // 
            // MenuFooterPnl
            // 
            this.MenuFooterPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(141)))), ((int)(((byte)(83)))));
            this.MenuFooterPnl.Controls.Add(this.lbDescVal);
            this.MenuFooterPnl.Controls.Add(this.lbNameVal);
            this.MenuFooterPnl.Controls.Add(this.lbProductDesc);
            this.MenuFooterPnl.Controls.Add(this.lbProductName);
            this.MenuFooterPnl.Controls.Add(this.button1);
            this.MenuFooterPnl.Controls.Add(this.lbPriceVal);
            this.MenuFooterPnl.Controls.Add(this.lbPrice);
            this.MenuFooterPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuFooterPnl.Location = new System.Drawing.Point(0, 542);
            this.MenuFooterPnl.Name = "MenuFooterPnl";
            this.MenuFooterPnl.Size = new System.Drawing.Size(679, 108);
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
            this.lbProductDesc.Location = new System.Drawing.Point(19, 34);
            this.lbProductDesc.Name = "lbProductDesc";
            this.lbProductDesc.Size = new System.Drawing.Size(84, 19);
            this.lbProductDesc.TabIndex = 9;
            this.lbProductDesc.Text = "Description:";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(19, 11);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(49, 19);
            this.lbProductName.TabIndex = 8;
            this.lbProductName.Text = "Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(489, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbPriceVal
            // 
            this.lbPriceVal.AutoSize = true;
            this.lbPriceVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPriceVal.Location = new System.Drawing.Point(119, 69);
            this.lbPriceVal.Name = "lbPriceVal";
            this.lbPriceVal.Size = new System.Drawing.Size(84, 30);
            this.lbPriceVal.TabIndex = 2;
            this.lbPriceVal.Text = "10,000";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(19, 70);
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
            this.ItemsPnl.Size = new System.Drawing.Size(679, 650);
            this.ItemsPnl.TabIndex = 1;
            // 
            // CartListPanel
            // 
            this.CartListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(234)))));
            this.CartListPanel.Controls.Add(this.lbTotalVal);
            this.CartListPanel.Controls.Add(this.lbTotal);
            this.CartListPanel.Controls.Add(this.dataGridView1);
            this.CartListPanel.Controls.Add(this.pnlLOOheader);
            this.CartListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartListPanel.Location = new System.Drawing.Point(679, 0);
            this.CartListPanel.Name = "CartListPanel";
            this.CartListPanel.Size = new System.Drawing.Size(260, 650);
            this.CartListPanel.TabIndex = 0;
            // 
            // lbTotalVal
            // 
            this.lbTotalVal.AutoSize = true;
            this.lbTotalVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalVal.Location = new System.Drawing.Point(164, 448);
            this.lbTotalVal.Name = "lbTotalVal";
            this.lbTotalVal.Size = new System.Drawing.Size(84, 30);
            this.lbTotalVal.TabIndex = 5;
            this.lbTotalVal.Text = "10,000";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(6, 448);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(70, 30);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Qty,
            this.SubTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(6, 99);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(248, 331);
            this.dataGridView1.TabIndex = 3;
            // 
            // Product
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle6;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Qty
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle7;
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SubTotal
            // 
            this.SubTotal.FillWeight = 50F;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pnlLOOheader
            // 
            this.pnlLOOheader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLOOheader.Controls.Add(this.lbLlistOfOrders);
            this.pnlLOOheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLOOheader.Location = new System.Drawing.Point(0, 0);
            this.pnlLOOheader.Name = "pnlLOOheader";
            this.pnlLOOheader.Size = new System.Drawing.Size(260, 90);
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 650);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.categoriesPNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.categoriesPNL.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.HeaderPNL.ResumeLayout(false);
            this.HeaderPNL.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuFooterPnl.ResumeLayout(false);
            this.MenuFooterPnl.PerformLayout();
            this.CartListPanel.ResumeLayout(false);
            this.CartListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
    }
}