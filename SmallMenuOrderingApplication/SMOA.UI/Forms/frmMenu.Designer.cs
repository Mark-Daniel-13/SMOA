
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbTotalValue = new System.Windows.Forms.Label();
            this.lbTotalText = new System.Windows.Forms.Label();
            this.ItemsPnl = new System.Windows.Forms.Panel();
            this.CartListPanel = new System.Windows.Forms.Panel();
            this.pnlLOOheader = new System.Windows.Forms.Panel();
            this.lbLlistOfOrders = new System.Windows.Forms.Label();
            this.categoriesPNL.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.HeaderPNL.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.MenuFooterPnl.SuspendLayout();
            this.CartListPanel.SuspendLayout();
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
            this.MenuFooterPnl.Controls.Add(this.button1);
            this.MenuFooterPnl.Controls.Add(this.lbTotalValue);
            this.MenuFooterPnl.Controls.Add(this.lbTotalText);
            this.MenuFooterPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuFooterPnl.Location = new System.Drawing.Point(0, 592);
            this.MenuFooterPnl.Name = "MenuFooterPnl";
            this.MenuFooterPnl.Size = new System.Drawing.Size(673, 58);
            this.MenuFooterPnl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(477, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Proceed to Check Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbTotalValue
            // 
            this.lbTotalValue.AutoSize = true;
            this.lbTotalValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalValue.Location = new System.Drawing.Point(91, 18);
            this.lbTotalValue.Name = "lbTotalValue";
            this.lbTotalValue.Size = new System.Drawing.Size(84, 30);
            this.lbTotalValue.TabIndex = 2;
            this.lbTotalValue.Text = "10,000";
            // 
            // lbTotalText
            // 
            this.lbTotalText.AutoSize = true;
            this.lbTotalText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalText.Location = new System.Drawing.Point(15, 19);
            this.lbTotalText.Name = "lbTotalText";
            this.lbTotalText.Size = new System.Drawing.Size(70, 30);
            this.lbTotalText.TabIndex = 1;
            this.lbTotalText.Text = "Total:";
            // 
            // ItemsPnl
            // 
            this.ItemsPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsPnl.Location = new System.Drawing.Point(0, 0);
            this.ItemsPnl.Name = "ItemsPnl";
            this.ItemsPnl.Size = new System.Drawing.Size(673, 650);
            this.ItemsPnl.TabIndex = 1;
            // 
            // CartListPanel
            // 
            this.CartListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(234)))));
            this.CartListPanel.Controls.Add(this.pnlLOOheader);
            this.CartListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartListPanel.Location = new System.Drawing.Point(673, 0);
            this.CartListPanel.Name = "CartListPanel";
            this.CartListPanel.Size = new System.Drawing.Size(266, 650);
            this.CartListPanel.TabIndex = 0;
            // 
            // pnlLOOheader
            // 
            this.pnlLOOheader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLOOheader.Controls.Add(this.lbLlistOfOrders);
            this.pnlLOOheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLOOheader.Location = new System.Drawing.Point(0, 0);
            this.pnlLOOheader.Name = "pnlLOOheader";
            this.pnlLOOheader.Size = new System.Drawing.Size(266, 90);
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
        private System.Windows.Forms.Label lbTotalText;
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
    }
}