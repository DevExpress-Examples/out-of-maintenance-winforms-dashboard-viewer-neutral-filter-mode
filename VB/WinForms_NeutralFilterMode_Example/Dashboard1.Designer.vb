Namespace WinForms_NeutralFilterMode_Example
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.listBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.dashboardExtractDataSource2 = New DevExpress.DashboardCommon.DashboardExtractDataSource()
            Me.listBoxDashboardItem2 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            CType(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardExtractDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.listBoxDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' listBoxDashboardItem1
            ' 
            Me.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1"
            dimension1.DataMember = "OrderDate"
            Me.listBoxDashboardItem1.DataItemRepository.Clear()
            Me.listBoxDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.listBoxDashboardItem1.DataSource = Me.dashboardExtractDataSource2
            Me.listBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.listBoxDashboardItem1.Name = "List Box 1"
            Me.listBoxDashboardItem1.ShowAllValue = False
            Me.listBoxDashboardItem1.ShowCaption = True
            ' 
            ' dashboardExtractDataSource2
            ' 
            Me.dashboardExtractDataSource2.ComponentName = "dashboardExtractDataSource2"
            Me.dashboardExtractDataSource2.FileName = "Orders.dat"
            Me.dashboardExtractDataSource2.Name = "Extract Data Source 1"
            ' 
            ' listBoxDashboardItem2
            ' 
            Me.listBoxDashboardItem2.ComponentName = "listBoxDashboardItem2"
            dimension2.DataMember = "OrderDate"
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.listBoxDashboardItem2.DataItemRepository.Clear()
            Me.listBoxDashboardItem2.DataItemRepository.Add(dimension2, "DataItem0")
            Me.listBoxDashboardItem2.DataSource = Me.dashboardExtractDataSource2
            Me.listBoxDashboardItem2.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
            Me.listBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.listBoxDashboardItem2.Name = "List Box 2"
            Me.listBoxDashboardItem2.ShowAllValue = False
            Me.listBoxDashboardItem2.ShowCaption = True
            ' 
            ' chartDashboardItem1
            ' 
            dimension3.DataMember = "OrderDate"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            measure1.DataMember = "Quantity"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1")
            Me.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem0")
            Me.chartDashboardItem1.DataSource = Me.dashboardExtractDataSource2
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.Name = "Chart 1"
            chartPane1.Name = "Pane 1"
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.PrimaryAxisY.ShowGridLines = True
            chartPane1.PrimaryAxisY.TitleVisible = True
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.SecondaryAxisY.ShowGridLines = False
            chartPane1.SecondaryAxisY.TitleVisible = True
            simpleSeries1.AddDataItem("Value", measure1)
            chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
            Me.chartDashboardItem1.ShowCaption = True
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExtractDataSource2})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.chartDashboardItem1, Me.listBoxDashboardItem1, Me.listBoxDashboardItem2})
            dashboardLayoutItem1.DashboardItem = Me.listBoxDashboardItem1
            dashboardLayoutItem1.Weight = 49.949545913218969R
            dashboardLayoutItem2.DashboardItem = Me.listBoxDashboardItem2
            dashboardLayoutItem2.Weight = 50.050454086781031R
            dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup2.DashboardItem = Nothing
            dashboardLayoutGroup2.Weight = 42.366863905325445R
            dashboardLayoutItem3.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem3.Weight = 57.633136094674555R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            dashboardLayoutGroup1.Weight = 100R
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardExtractDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.listBoxDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region
        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Private listBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Private listBoxDashboardItem2 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Private dashboardExtractDataSource2 As DevExpress.DashboardCommon.DashboardExtractDataSource
    End Class
End Namespace
