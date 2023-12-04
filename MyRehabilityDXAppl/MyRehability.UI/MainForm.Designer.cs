namespace MyRehability.UI
{
	partial class MainForm
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
			components = new System.ComponentModel.Container();
			RC = new DevExpress.XtraBars.Ribbon.RibbonControl();
			skins = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
			Palettes = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
			pageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
			GroupDataBase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			pageSourceData = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			pageDocuments = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			RSB = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			DLAF = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
			((System.ComponentModel.ISupportInitialize)RC).BeginInit();
			SuspendLayout();
			// 
			// RC
			// 
			RC.ExpandCollapseItem.Id = 0;
			RC.Items.AddRange(new DevExpress.XtraBars.BarItem[] { RC.ExpandCollapseItem, RC.SearchEditItem, skins, Palettes });
			RC.Location = new System.Drawing.Point(0, 0);
			RC.MaxItemId = 7;
			RC.Name = "RC";
			RC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { pageMain, pageSourceData, pageDocuments });
			RC.QuickToolbarItemLinks.Add(skins);
			RC.QuickToolbarItemLinks.Add(Palettes);
			RC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
			RC.ShowQatLocationSelector = false;
			RC.ShowToolbarCustomizeItem = false;
			RC.Size = new System.Drawing.Size(624, 158);
			RC.StatusBar = RSB;
			RC.Toolbar.ShowCustomizeItem = false;
			RC.SelectedPageChanged += RC_SelectedPageChanged;
			// 
			// skins
			// 
			skins.Caption = "Обложки";
			skins.Id = 5;
			skins.Name = "skins";
			// 
			// Palettes
			// 
			Palettes.Caption = "Цвет";
			Palettes.Id = 6;
			Palettes.Name = "Palettes";
			// 
			// pageMain
			// 
			pageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { GroupDataBase });
			pageMain.Name = "pageMain";
			pageMain.Text = "Главная";
			// 
			// GroupDataBase
			// 
			GroupDataBase.Name = "GroupDataBase";
			GroupDataBase.Text = "База данных";
			// 
			// pageSourceData
			// 
			pageSourceData.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
			pageSourceData.Name = "pageSourceData";
			pageSourceData.Text = "Входные данные";
			// 
			// ribbonPageGroup1
			// 
			ribbonPageGroup1.Name = "ribbonPageGroup1";
			ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// pageDocuments
			// 
			pageDocuments.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
			pageDocuments.Name = "pageDocuments";
			pageDocuments.Text = "Документы";
			// 
			// ribbonPageGroup2
			// 
			ribbonPageGroup2.Name = "ribbonPageGroup2";
			ribbonPageGroup2.Text = "ribbonPageGroup2";
			// 
			// RSB
			// 
			RSB.Location = new System.Drawing.Point(0, 528);
			RSB.Name = "RSB";
			RSB.Ribbon = RC;
			RSB.Size = new System.Drawing.Size(624, 24);
			// 
			// MainForm
			// 
			AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(624, 552);
			Controls.Add(RSB);
			Controls.Add(RC);
			Name = "MainForm";
			Ribbon = RC;
			StatusBar = RSB;
			Text = "Учет средств реабилитации";
			((System.ComponentModel.ISupportInitialize)RC).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl RC;
		private DevExpress.XtraBars.Ribbon.RibbonPage pageMain;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup GroupDataBase;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar RSB;
		private DevExpress.XtraBars.SkinRibbonGalleryBarItem skins;
		private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem Palettes;
		private DevExpress.XtraBars.Ribbon.RibbonPage pageSourceData;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonPage pageDocuments;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.LookAndFeel.DefaultLookAndFeel DLAF;
	}
}