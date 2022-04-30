
namespace AircraftPlantView
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
            this.buttonOrderReady = new System.Windows.Forms.Button();
            this.buttonIssuedOrder = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCompWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentPlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarhousesComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 39);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(755, 359);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(794, 67);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(195, 40);
            this.buttonCreateOrder.TabIndex = 1;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonTakeOrderInWork
            // 
            this.buttonTakeOrderInWork.Location = new System.Drawing.Point(794, 136);
            this.buttonTakeOrderInWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
            this.buttonTakeOrderInWork.Size = new System.Drawing.Size(195, 40);
            this.buttonTakeOrderInWork.TabIndex = 2;
            this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
            this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
            // 
            // buttonOrderReady
            // 
            this.buttonOrderReady.Location = new System.Drawing.Point(794, 203);
            this.buttonOrderReady.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOrderReady.Name = "buttonOrderReady";
            this.buttonOrderReady.Size = new System.Drawing.Size(195, 40);
            this.buttonOrderReady.TabIndex = 3;
            this.buttonOrderReady.Text = "Заказ готов";
            this.buttonOrderReady.UseVisualStyleBackColor = true;
            this.buttonOrderReady.Click += new System.EventHandler(this.buttonOrderReady_Click);
            // 
            // buttonIssuedOrder
            // 
            this.buttonIssuedOrder.Location = new System.Drawing.Point(794, 267);
            this.buttonIssuedOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonIssuedOrder.Name = "buttonIssuedOrder";
            this.buttonIssuedOrder.Size = new System.Drawing.Size(195, 40);
            this.buttonIssuedOrder.TabIndex = 4;
            this.buttonIssuedOrder.Text = "Заказ Выдан";
            this.buttonIssuedOrder.UseVisualStyleBackColor = true;
            this.buttonIssuedOrder.Click += new System.EventHandler(this.buttonIssuedOrder_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(794, 325);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(195, 40);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Обновить список";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.AddCompWarehouseToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1050, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComponentsToolStripMenuItem,
            this.PlaneToolStripMenuItem,
            this.WarehouseToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // ComponentsToolStripMenuItem
            // 
            this.ComponentsToolStripMenuItem.Name = "ComponentsToolStripMenuItem";
            this.ComponentsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.ComponentsToolStripMenuItem.Text = "Компоненты";
            this.ComponentsToolStripMenuItem.Click += new System.EventHandler(this.ComponentsToolStripMenuItem_Click);
            // 
            // PlaneToolStripMenuItem
            // 
            this.PlaneToolStripMenuItem.Name = "PlaneToolStripMenuItem";
            this.PlaneToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.PlaneToolStripMenuItem.Text = "Самолёты";
            this.PlaneToolStripMenuItem.Click += new System.EventHandler(this.PlaneToolStripMenuItem_Click);
            // 
            // WarehouseToolStripMenuItem
            // 
            this.WarehouseToolStripMenuItem.Name = "WarehouseToolStripMenuItem";
            this.WarehouseToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.WarehouseToolStripMenuItem.Text = "Склады";
            this.WarehouseToolStripMenuItem.Click += new System.EventHandler(this.WarehouseToolStripMenuItem_Click);
            // 
            // AddCompWarehouseToolStripMenuItem
            // 
            this.AddCompWarehouseToolStripMenuItem.Name = "AddCompWarehouseToolStripMenuItem";
            this.AddCompWarehouseToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.AddCompWarehouseToolStripMenuItem.Text = "Пополнение склада";
            this.AddCompWarehouseToolStripMenuItem.Click += new System.EventHandler(this.AddCompWarehouseToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlanesToolStripMenuItem,
            this.ComponentPlanesToolStripMenuItem,
            this.OrdersToolStripMenuItem,
            this.WarehousesToolStripMenuItem,
            this.WarhousesComponentsToolStripMenuItem,
            this.OrdersDateToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // PlanesToolStripMenuItem
            // 
            this.PlanesToolStripMenuItem.Name = "PlanesToolStripMenuItem";
            this.PlanesToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.PlanesToolStripMenuItem.Text = "Список самолётов";
            this.PlanesToolStripMenuItem.Click += new System.EventHandler(this.PlanesToolStripMenuItem_Click);
            // 
            // ComponentPlanesToolStripMenuItem
            // 
            this.ComponentPlanesToolStripMenuItem.Name = "ComponentPlanesToolStripMenuItem";
            this.ComponentPlanesToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.ComponentPlanesToolStripMenuItem.Text = "Компоненты по изделиям";
            this.ComponentPlanesToolStripMenuItem.Click += new System.EventHandler(this.ComponentPlanesToolStripMenuItem_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.OrdersToolStripMenuItem.Text = "Список заказов";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // WarehousesToolStripMenuItem
            // 
            this.WarehousesToolStripMenuItem.Name = "WarehousesToolStripMenuItem";
            this.WarehousesToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.WarehousesToolStripMenuItem.Text = "Список складов";
            this.WarehousesToolStripMenuItem.Click += new System.EventHandler(this.WarehousesToolStripMenuItem_Click);
            // 
            // WarhousesComponentsToolStripMenuItem
            // 
            this.WarhousesComponentsToolStripMenuItem.Name = "WarhousesComponentsToolStripMenuItem";
            this.WarhousesComponentsToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.WarhousesComponentsToolStripMenuItem.Text = "Компоненты по складам";
            this.WarhousesComponentsToolStripMenuItem.Click += new System.EventHandler(this.WarhousesComponentsToolStripMenuItem_Click);
            // 
            // OrdersDateToolStripMenuItem
            // 
            this.OrdersDateToolStripMenuItem.Name = "OrdersDateToolStripMenuItem";
            this.OrdersDateToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.OrdersDateToolStripMenuItem.Text = "Список заказов по датам";
            this.OrdersDateToolStripMenuItem.Click += new System.EventHandler(this.OrdersDateToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 413);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonIssuedOrder);
            this.Controls.Add(this.buttonOrderReady);
            this.Controls.Add(this.buttonTakeOrderInWork);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Авиастроительный завод";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonTakeOrderInWork;
        private System.Windows.Forms.Button buttonOrderReady;
        private System.Windows.Forms.Button buttonIssuedOrder;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComponentPlanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCompWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarehousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarhousesComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersDateToolStripMenuItem;
    }
}

