using DevExpress.XtraRichEdit;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RehabilityApplication.CoreLib
{
	public static class DocGenManagerShkus
	{
		public static void GenerateDocShkus()
		{
			string templatePath = @"C:\Users\Семья\Desktop\template.docx";
			string saveFolder = System.IO.Path.GetDirectoryName(templatePath);
			string targetFolder = $@"{saveFolder}\documents";

			long docCount = GlobalDatabaseManager.clients.Count;
			long currentIndex = 0;


			foreach (var client in GlobalDatabaseManager.clients)
			{
				using (var docServer = new RichEditDocumentServer())
				{
					docServer.LoadDocument(templatePath);
					docServer.Document.ReplaceAll(new Regex("%ID%"), client.Id);
					docServer.Document.ReplaceAll(new Regex("%IsSelected%"), client.IsSelected.ToString());
					docServer.Document.ReplaceAll(new Regex("%Snils%"), client.Snils);
					docServer.SaveDocument($@"{targetFolder}\{client.Id}.doc", DocumentFormat.Doc);
					currentIndex++;
					SplashScreenManager.Default.SetWaitFormDescription($"Документ {currentIndex} из {docCount} сохранен");

				}

			}
		}

		public static string GenerateDocShkusTelegrammBot(string snils)
		{
			string templatePath = @"C:\Users\Семья\Desktop\template.docx";
			string saveFolder = System.IO.Path.GetDirectoryName(templatePath);
			string targetFolder = $@"{saveFolder}\documents";

			var client = GlobalDatabaseManager.clients.Where(t => t.Snils == snils).FirstOrDefault();

			if (client != null)
			{
				return string.Empty;
			}


			using (var docServer = new RichEditDocumentServer())
			{
				docServer.LoadDocument(templatePath);
				docServer.Document.ReplaceAll(new Regex("%ID%"), client.Id);
				docServer.Document.ReplaceAll(new Regex("%IsSelected%"), client.IsSelected.ToString());
				docServer.Document.ReplaceAll(new Regex("%Snils%"), client.Snils);
				string savedFilePath = $@"{targetFolder}\{client.Id}.doc";

				docServer.SaveDocument($@"{targetFolder}\{client.Id}.doc", DocumentFormat.Doc);

				return savedFilePath;

				}


		}
	}
}
