using DevExpress.DashboardWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_NeutralFilterMode_Example
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            dashboardViewer1.NeutralFilterMode = true;
            dashboardViewer1.CustomizeDashboardTitle += DashboardViewer1_CustomizeDashboardTitle;
            dashboardViewer1.UpdateDashboardTitle();
        }

        private void DashboardViewer1_CustomizeDashboardTitle(object sender, DevExpress.DashboardWin.CustomizeDashboardTitleEventArgs e)
        {
            DashboardViewer dashboardViewer = (DashboardViewer)sender;

            DashboardToolbarItem commandButton = new DashboardToolbarItem(dashboardViewer.NeutralFilterMode, "NEUTRAL FILTER MODE",
                new Action<DashboardToolbarItemClickEventArgs>((args) => {
                    dashboardViewer.NeutralFilterMode = !dashboardViewer.NeutralFilterMode;
                    dashboardViewer1.DashboardSource = typeof(Dashboard1);
                }));
            commandButton.Caption = "NEUTRAL FILTER MODE";
            e.Items.Add(commandButton);
        }
    }
}
