Imports DevExpress.DashboardWin
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WinForms_NeutralFilterMode_Example
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            dashboardViewer1.UseNeutralFilterMode = True
            AddHandler dashboardViewer1.CustomizeDashboardTitle, AddressOf DashboardViewer1_CustomizeDashboardTitle
            dashboardViewer1.UpdateDashboardTitle()
        End Sub

        Private Sub DashboardViewer1_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.CustomizeDashboardTitleEventArgs)
            Dim dashboardViewer As DashboardViewer = DirectCast(sender, DashboardViewer)

            Dim commandButton As DashboardToolbarItem = New DashboardToolbarItem(dashboardViewer.UseNeutralFilterMode, "NEUTRAL FILTER MODE", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
                dashboardViewer.UseNeutralFilterMode = Not dashboardViewer.UseNeutralFilterMode
                dashboardViewer1.DashboardSource = GetType(Dashboard1)
            End Sub))
            commandButton.Caption = "NEUTRAL FILTER MODE"
            e.Items.Add(commandButton)
        End Sub
    End Class
End Namespace
