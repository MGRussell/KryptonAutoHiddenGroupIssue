using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KryptonAutoHiddenGroupIssue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _count = 1;
        private KryptonPage NewPage()
        {
            KryptonPage page = new KryptonPage();
            page.Text = "Page " + (_count++).ToString();
            page.TextTitle = page.Text;
            page.UniqueName = page.Text;

            KryptonRichTextBox rtb = new KryptonRichTextBox();
            rtb.StateCommon.Border.Draw = InheritBool.False;
            rtb.Dock = DockStyle.Fill;
            rtb.Text = "Page Content";
            page.Controls.Add(rtb);

            return page;
        }

        KryptonPage visiblePage, hiddenPage, hiddenPageProxy;

        void TogglePageIcon(KryptonPage page)
        {
            if (page.ImageSmall == null)
                page.ImageSmall = Properties.Resources.SomeIcon;
            else
                page.ImageSmall = null;

            if(forceEventCheckBox.Checked)
                ForceAppearanceChangedEvent(page);
        }

        private void HiddenToggleButton_Click(object sender, EventArgs e)
        {
            TogglePageIcon(hiddenPage);
        }

        private void HiddenProxyToggleButton_Click(object sender, EventArgs e)
        {
            TogglePageIcon(hiddenPageProxy);
        }

        private void RegularToggleButton_Click(object sender, EventArgs e)
        {
            TogglePageIcon(visiblePage);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace("Workspace", kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl("Control", kryptonPanel1, w);

            List<KryptonPage> pages = new List<KryptonPage>();
            for (int i = 0; i < 2; i++)
                pages.Add(NewPage());

            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { pages[0] });

            KryptonDockingAutoHiddenGroup group = kryptonDockingManager1.AddAutoHiddenGroup("Control", DockingEdge.Right, new KryptonPage[] { pages[1] });

            visiblePage = pages[0];
            hiddenPage = pages[1];
            hiddenPageProxy = GetHiddenProxyPages(group)[0];
        }

        private List<KryptonPage> GetHiddenProxyPages(KryptonDockingAutoHiddenGroup group)
        {
            List<KryptonPage> pages = new List<KryptonPage>();

            foreach (KryptonPage page in group.AutoHiddenGroupControl.Pages)
            {
                if ((page is KryptonAutoHiddenProxyPage proxyPage) && page.LastVisibleSet)
                {
                    pages.Add(proxyPage);
                }
            }

            return pages;
        }

        private void ForceAppearanceChangedEvent(KryptonPage page)
        {
            MethodInfo method = typeof(KryptonPage).GetMethod("OnAppearancePropertyChanged", BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(page, new object[] { nameof(KryptonPage.ImageSmall) });
        }
    }
}
