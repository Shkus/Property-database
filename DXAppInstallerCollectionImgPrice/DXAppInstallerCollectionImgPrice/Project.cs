using DevExpress.XtraSpreadsheet.Commands;
using RehabilityApplication.CoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXAppInstallerCollectionImgPrice
{
	public class Project
	{
		private static string filter = "Файл проекта (*.ive)|*.ive";

		public static ProjectData DataSource = new ProjectData();

		public static void SaveProject()
		{
			SaveFileDialog sfd = new SaveFileDialog()
			{
				Filter = filter
			};

			if (sfd.ShowDialog() == DialogResult.OK)
			{ 
				BinarySerializer.SaveObject(sfd.FileName, DataSource);
			}
		}

		public static void OpenProject()
		{
			OpenFileDialog ofd = new OpenFileDialog()
			{
				Filter = filter
			};

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				DataSource = (ProjectData)BinarySerializer.OpenObject(ofd.FileName);
			}
		}
	}
}
