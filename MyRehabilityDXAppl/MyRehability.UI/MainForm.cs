using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRehability.UI
{
	public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{

		ucDataBaseView ucDataBaseView = new ucDataBaseView();
		ucDocumentsView ucDocumentsView = new ucDocumentsView();
		ucSourceDataView ucSourceDataView = new ucSourceDataView();
		public MainForm()
		{
			InitializeComponent();

			ucDataBaseView.Dock = DockStyle.Fill;
			ucDocumentsView.Dock = DockStyle.Fill;
			ucSourceDataView.Dock = DockStyle.Fill;

			Controls.Add(ucDocumentsView);
			Controls.Add(ucSourceDataView);
			Controls.Add(ucDataBaseView);
		}

		private void RC_SelectedPageChanged(object sender, EventArgs e)
		{
			if (RC.SelectedPage.Name == nameof(pageMain))
			{ 
				ucDataBaseView.BringToFront();
			}

			if (RC.SelectedPage.Name == nameof(pageDocuments))
			{
				ucDocumentsView.BringToFront();
			}

			if (RC.SelectedPage.Name == nameof(pageSourceData))
			{
				ucSourceDataView.BringToFront();
			}

		}
	}
}