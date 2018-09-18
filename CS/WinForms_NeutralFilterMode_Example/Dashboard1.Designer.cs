namespace WinForms_NeutralFilterMode_Example
{
    partial class Dashboard1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.listBoxDashboardItem1 = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.dashboardExtractDataSource1 = new DevExpress.DashboardCommon.DashboardExtractDataSource();
            this.listBoxDashboardItem2 = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExtractDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // listBoxDashboardItem1
            // 
            this.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1";
            dimension1.DataMember = "OrderDate";
            this.listBoxDashboardItem1.DataItemRepository.Clear();
            this.listBoxDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.listBoxDashboardItem1.DataSource = this.dashboardExtractDataSource1;
            this.listBoxDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.listBoxDashboardItem1.Name = "List Box 1";
            this.listBoxDashboardItem1.ShowAllValue = false;
            this.listBoxDashboardItem1.ShowCaption = true;
            // 
            // dashboardExtractDataSource1
            // 
            this.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1";
            this.dashboardExtractDataSource1.FileName = "C:\\Data\\NWind_SalesPerson.dat";
            this.dashboardExtractDataSource1.Name = "Extract Data Source 1";
            // 
            // listBoxDashboardItem2
            // 
            this.listBoxDashboardItem2.ComponentName = "listBoxDashboardItem2";
            dimension2.DataMember = "OrderDate";
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.listBoxDashboardItem2.DataItemRepository.Clear();
            this.listBoxDashboardItem2.DataItemRepository.Add(dimension2, "DataItem0");
            this.listBoxDashboardItem2.DataSource = this.dashboardExtractDataSource1;
            this.listBoxDashboardItem2.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.listBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = false;
            this.listBoxDashboardItem2.Name = "List Box 2";
            this.listBoxDashboardItem2.ShowAllValue = false;
            this.listBoxDashboardItem2.ShowCaption = true;
            // 
            // chartDashboardItem1
            // 
            dimension3.DataMember = "OrderDate";
            dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            measure1.DataMember = "Quantity";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.chartDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1");
            this.chartDashboardItem1.DataSource = this.dashboardExtractDataSource1;
            this.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "Chart 1";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ShowCaption = true;
            // 
            // Dashboard1
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardExtractDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartDashboardItem1,
            this.listBoxDashboardItem1,
            this.listBoxDashboardItem2});
            dashboardLayoutItem1.DashboardItem = this.listBoxDashboardItem1;
            dashboardLayoutItem1.Weight = 50D;
            dashboardLayoutItem2.DashboardItem = this.listBoxDashboardItem2;
            dashboardLayoutItem2.Weight = 50D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 49.924357034795761D;
            dashboardLayoutItem3.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem3.Weight = 50.075642965204239D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExtractDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardExtractDataSource dashboardExtractDataSource1;
        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.ListBoxDashboardItem listBoxDashboardItem1;
        private DevExpress.DashboardCommon.ListBoxDashboardItem listBoxDashboardItem2;
    }
}
