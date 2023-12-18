namespace DXAppInstallerCollectionImgPrice
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(components);
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			bar1 = new DevExpress.XtraBars.Bar();
			dockManager1 = new DevExpress.XtraBars.Docking.DockManager(components);
			dpList = new DevExpress.XtraBars.Docking.DockPanel();
			dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			dpImage = new DevExpress.XtraBars.Docking.DockPanel();
			formContainer = new DevExpress.XtraBars.Docking.ControlContainer();
			tlItems = new DevExpress.XtraTreeList.TreeList();
			behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(components);
			pePicture = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)applicationMenu1).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dockManager1).BeginInit();
			dpList.SuspendLayout();
			dockPanel1_Container.SuspendLayout();
			dpImage.SuspendLayout();
			formContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tlItems).BeginInit();
			((System.ComponentModel.ISupportInitialize)behaviorManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pePicture.Properties).BeginInit();
			SuspendLayout();
			// 
			// applicationMenu1
			// 
			applicationMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem2), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem3), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem4), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem5) });
			applicationMenu1.Name = "applicationMenu1";
			// 
			// barManager1
			// 
			barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1 });
			barManager1.DockControls.Add(barDockControlTop);
			barManager1.DockControls.Add(barDockControlBottom);
			barManager1.DockControls.Add(barDockControlLeft);
			barManager1.DockControls.Add(barDockControlRight);
			barManager1.DockManager = dockManager1;
			barManager1.Form = this;
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5 });
			barManager1.MaxItemId = 5;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			barDockControlTop.Location = new System.Drawing.Point(0, 0);
			barDockControlTop.Manager = barManager1;
			barDockControlTop.Size = new System.Drawing.Size(642, 24);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 456);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new System.Drawing.Size(642, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new System.Drawing.Size(0, 432);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(642, 24);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new System.Drawing.Size(0, 432);
			// 
			// barButtonItem1
			// 
			barButtonItem1.Caption = "barButtonItem1";
			barButtonItem1.Id = 0;
			barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem2
			// 
			barButtonItem2.Caption = "btnAdd";
			barButtonItem2.Id = 1;
			barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
			barButtonItem2.Name = "barButtonItem2";
			// 
			// barButtonItem3
			// 
			barButtonItem3.Caption = "btnDelete";
			barButtonItem3.Id = 2;
			barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem3.ImageOptions.SvgImage");
			barButtonItem3.Name = "barButtonItem3";
			// 
			// barButtonItem4
			// 
			barButtonItem4.Caption = "btnSave";
			barButtonItem4.Id = 3;
			barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
			barButtonItem4.Name = "barButtonItem4";
			// 
			// barButtonItem5
			// 
			barButtonItem5.Caption = "btnOpenFolder";
			barButtonItem5.Id = 4;
			barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem5.ImageOptions.SvgImage");
			barButtonItem5.Name = "barButtonItem5";
			// 
			// bar1
			// 
			bar1.BarName = "Custom 2";
			bar1.DockCol = 0;
			bar1.DockRow = 0;
			bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem2), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem3), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem5), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem4) });
			bar1.Text = "Custom 2";
			// 
			// dockManager1
			// 
			dockManager1.Form = this;
			dockManager1.MenuManager = barManager1;
			dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] { dpList, dpImage });
			dockManager1.TopZIndexControls.AddRange(new string[] { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl" });
			// 
			// dpList
			// 
			dpList.Controls.Add(dockPanel1_Container);
			dpList.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			dpList.ID = new System.Guid("8c16cdd1-773f-4473-9921-a1a3f44fd5f4");
			dpList.Location = new System.Drawing.Point(0, 24);
			dpList.Name = "dpList";
			dpList.OriginalSize = new System.Drawing.Size(200, 200);
			dpList.Size = new System.Drawing.Size(200, 432);
			dpList.Text = "Список";
			// 
			// dockPanel1_Container
			// 
			dockPanel1_Container.Controls.Add(tlItems);
			dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
			dockPanel1_Container.Name = "dockPanel1_Container";
			dockPanel1_Container.Size = new System.Drawing.Size(193, 403);
			dockPanel1_Container.TabIndex = 0;
			// 
			// dpImage
			// 
			dpImage.Controls.Add(formContainer);
			dpImage.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
			dpImage.ID = new System.Guid("7a8c53d0-6865-4fac-847a-4157d53c96c5");
			dpImage.Location = new System.Drawing.Point(200, 24);
			dpImage.Name = "dpImage";
			dpImage.OriginalSize = new System.Drawing.Size(200, 200);
			dpImage.Size = new System.Drawing.Size(442, 432);
			dpImage.Text = "Изображение";
			// 
			// formContainer
			// 
			formContainer.Controls.Add(pePicture);
			formContainer.Location = new System.Drawing.Point(3, 26);
			formContainer.Name = "formContainer";
			formContainer.Size = new System.Drawing.Size(436, 402);
			formContainer.TabIndex = 0;
			// 
			// tlItems
			// 
			tlItems.Dock = System.Windows.Forms.DockStyle.Fill;
			tlItems.Location = new System.Drawing.Point(0, 0);
			tlItems.MenuManager = barManager1;
			tlItems.Name = "tlItems";
			tlItems.Size = new System.Drawing.Size(193, 403);
			tlItems.TabIndex = 0;
			// 
			// pePicture
			// 
			pePicture.Dock = System.Windows.Forms.DockStyle.Fill;
			pePicture.Location = new System.Drawing.Point(0, 0);
			pePicture.MenuManager = barManager1;
			pePicture.Name = "pePicture";
			pePicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			pePicture.Size = new System.Drawing.Size(436, 402);
			pePicture.TabIndex = 0;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(642, 456);
			Controls.Add(dpImage);
			Controls.Add(dpList);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MainForm.IconOptions.SvgImage");
			Name = "MainForm";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)applicationMenu1).EndInit();
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)dockManager1).EndInit();
			dpList.ResumeLayout(false);
			dockPanel1_Container.ResumeLayout(false);
			dpImage.ResumeLayout(false);
			formContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tlItems).EndInit();
			((System.ComponentModel.ISupportInitialize)behaviorManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)pePicture.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Docking.DockManager dockManager1;
		private DevExpress.XtraBars.Docking.DockPanel dpImage;
		private DevExpress.XtraBars.Docking.ControlContainer formContainer;
		private DevExpress.XtraBars.Docking.DockPanel dpList;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
		private DevExpress.XtraEditors.PictureEdit pePicture;
		private DevExpress.XtraTreeList.TreeList tlItems;
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
	}
}

