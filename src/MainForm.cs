using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO; // for Directory


// EPT, a tool to quickly save (bitmap) tracks exported from Ethovision
// Copyright (C) 2006 Jean-Etienne Poirrier
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// 
// For any further information, please contact me at jepoirrier@gmail.com
// Latest version of this software is at: http://www.poirrier.be/~jean-etienne/software/ept

namespace EthovisionPasteTracks
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu MainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItemPaste;
		private System.Windows.Forms.Label lblDirectory;
		private System.Windows.Forms.TextBox tbDirectory;
		private System.Windows.Forms.Label lblSubjectNumber;
		private System.Windows.Forms.TextBox tbSubjectNumber;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.PictureBox pbPreview;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItemAbout;
		private System.Windows.Forms.MenuItem menuItemSave;
		private System.Windows.Forms.MenuItem menuItemSaveAs;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.Label lblStartNumber;
		private System.Windows.Forms.NumericUpDown StartNumber;
		private System.Windows.Forms.Button btStartSerie;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
		private System.Windows.Forms.Button btChooseDir;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.MenuItem menuItemNew;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.GroupBox groupBoxSouth;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.ComponentModel.IContainer components;

		/* It's not good to have private variables in the main but it's quickly written */
		private string directory = "";
		private string fileprefix = "";

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.MainMenu = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItemNew = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItemSave = new System.Windows.Forms.MenuItem();
			this.menuItemSaveAs = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItemPaste = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItemHelp = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItemAbout = new System.Windows.Forms.MenuItem();
			this.lblDirectory = new System.Windows.Forms.Label();
			this.tbDirectory = new System.Windows.Forms.TextBox();
			this.lblSubjectNumber = new System.Windows.Forms.Label();
			this.tbSubjectNumber = new System.Windows.Forms.TextBox();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.pbPreview = new System.Windows.Forms.PictureBox();
			this.panelTop = new System.Windows.Forms.Panel();
			this.btChooseDir = new System.Windows.Forms.Button();
			this.btStartSerie = new System.Windows.Forms.Button();
			this.StartNumber = new System.Windows.Forms.NumericUpDown();
			this.lblStartNumber = new System.Windows.Forms.Label();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBoxSouth = new System.Windows.Forms.GroupBox();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StartNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1,
																					 this.menuItem2,
																					 this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemNew,
																					  this.menuItem5,
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItemSave,
																					  this.menuItemSaveAs,
																					  this.menuItem6,
																					  this.menuItemExit});
			this.menuItem1.Text = "&File";
			// 
			// menuItemNew
			// 
			this.menuItemNew.Index = 0;
			this.menuItemNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuItemNew.Text = "&New Serie (reset)";
			this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 2;
			this.menuItem7.Text = "&Choose base directory...";
			this.menuItem7.Click += new System.EventHandler(this.btChooseDir_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 3;
			this.menuItem8.Text = "-";
			// 
			// menuItemSave
			// 
			this.menuItemSave.Enabled = false;
			this.menuItemSave.Index = 4;
			this.menuItemSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuItemSave.Text = "&Save";
			// 
			// menuItemSaveAs
			// 
			this.menuItemSaveAs.Enabled = false;
			this.menuItemSaveAs.Index = 5;
			this.menuItemSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
			this.menuItemSaveAs.Text = "Save &As...";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 6;
			this.menuItem6.Text = "-";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Index = 7;
			this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.menuItemExit.Text = "E&xit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemPaste});
			this.menuItem2.Text = "&Edit";
			// 
			// menuItemPaste
			// 
			this.menuItemPaste.Enabled = false;
			this.menuItemPaste.Index = 0;
			this.menuItemPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.menuItemPaste.Text = "&Paste";
			this.menuItemPaste.Click += new System.EventHandler(this.menuItemPaste_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemHelp,
																					  this.menuItem4,
																					  this.menuItemAbout});
			this.menuItem3.Text = "&Help";
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.Enabled = false;
			this.menuItemHelp.Index = 0;
			this.menuItemHelp.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.menuItemHelp.Text = "&Help";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// menuItemAbout
			// 
			this.menuItemAbout.Index = 2;
			this.menuItemAbout.Text = "&About Ethovision Paste Tracks...";
			this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
			// 
			// lblDirectory
			// 
			this.lblDirectory.Location = new System.Drawing.Point(16, 24);
			this.lblDirectory.Name = "lblDirectory";
			this.lblDirectory.Size = new System.Drawing.Size(88, 23);
			this.lblDirectory.TabIndex = 0;
			this.lblDirectory.Text = "Base directory: ";
			this.lblDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbDirectory
			// 
			this.tbDirectory.Location = new System.Drawing.Point(112, 24);
			this.tbDirectory.Name = "tbDirectory";
			this.tbDirectory.Size = new System.Drawing.Size(152, 20);
			this.tbDirectory.TabIndex = 0;
			this.tbDirectory.Text = "";
			this.toolTip.SetToolTip(this.tbDirectory, "Enter here the directory where you want your images to be saved");
			// 
			// lblSubjectNumber
			// 
			this.lblSubjectNumber.Location = new System.Drawing.Point(16, 48);
			this.lblSubjectNumber.Name = "lblSubjectNumber";
			this.lblSubjectNumber.Size = new System.Drawing.Size(88, 23);
			this.lblSubjectNumber.TabIndex = 2;
			this.lblSubjectNumber.Text = "Subject number: ";
			this.lblSubjectNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbSubjectNumber
			// 
			this.tbSubjectNumber.Location = new System.Drawing.Point(112, 48);
			this.tbSubjectNumber.Name = "tbSubjectNumber";
			this.tbSubjectNumber.Size = new System.Drawing.Size(152, 20);
			this.tbSubjectNumber.TabIndex = 1;
			this.tbSubjectNumber.Text = "mwmxxx-";
			this.toolTip.SetToolTip(this.tbSubjectNumber, "Enter here the subject number (or file prefix)");
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 277);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(472, 22);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 4;
			this.statusBar.Text = "Welcome to Ethovision Paste Tracks - (c) Jean-Etienne Poirrier, 2006";
			// 
			// pbPreview
			// 
			this.pbPreview.Location = new System.Drawing.Point(16, 104);
			this.pbPreview.Name = "pbPreview";
			this.pbPreview.Size = new System.Drawing.Size(440, 160);
			this.pbPreview.TabIndex = 5;
			this.pbPreview.TabStop = false;
			// 
			// panelTop
			// 
			this.panelTop.Controls.Add(this.btChooseDir);
			this.panelTop.Controls.Add(this.btStartSerie);
			this.panelTop.Controls.Add(this.StartNumber);
			this.panelTop.Controls.Add(this.lblStartNumber);
			this.panelTop.Controls.Add(this.groupBox);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(472, 88);
			this.panelTop.TabIndex = 6;
			// 
			// btChooseDir
			// 
			this.btChooseDir.Image = ((System.Drawing.Image)(resources.GetObject("btChooseDir.Image")));
			this.btChooseDir.Location = new System.Drawing.Point(272, 24);
			this.btChooseDir.Name = "btChooseDir";
			this.btChooseDir.Size = new System.Drawing.Size(32, 23);
			this.btChooseDir.TabIndex = 0;
			this.toolTip.SetToolTip(this.btChooseDir, "Choose the base directory");
			this.btChooseDir.Click += new System.EventHandler(this.btChooseDir_Click);
			// 
			// btStartSerie
			// 
			this.btStartSerie.Image = ((System.Drawing.Image)(resources.GetObject("btStartSerie.Image")));
			this.btStartSerie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btStartSerie.Location = new System.Drawing.Point(376, 48);
			this.btStartSerie.Name = "btStartSerie";
			this.btStartSerie.Size = new System.Drawing.Size(80, 23);
			this.btStartSerie.TabIndex = 2;
			this.btStartSerie.Text = "Start Serie";
			this.btStartSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.btStartSerie, "Start Serie with parameters from above");
			this.btStartSerie.Click += new System.EventHandler(this.btStartSerie_Click);
			// 
			// StartNumber
			// 
			this.StartNumber.Location = new System.Drawing.Point(400, 24);
			this.StartNumber.Minimum = new System.Decimal(new int[] {
																		1,
																		0,
																		0,
																		0});
			this.StartNumber.Name = "StartNumber";
			this.StartNumber.Size = new System.Drawing.Size(56, 20);
			this.StartNumber.TabIndex = 1;
			this.toolTip.SetToolTip(this.StartNumber, "Choose the start number");
			this.StartNumber.Value = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  0});
			// 
			// lblStartNumber
			// 
			this.lblStartNumber.Location = new System.Drawing.Point(312, 24);
			this.lblStartNumber.Name = "lblStartNumber";
			this.lblStartNumber.Size = new System.Drawing.Size(80, 23);
			this.lblStartNumber.TabIndex = 0;
			this.lblStartNumber.Text = "Start Number: ";
			this.lblStartNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox
			// 
			this.groupBox.Location = new System.Drawing.Point(8, 8);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(456, 72);
			this.groupBox.TabIndex = 3;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Options";
			// 
			// folderBrowserDlg
			// 
			this.folderBrowserDlg.Description = "Please choose the base directory";
			// 
			// groupBoxSouth
			// 
			this.groupBoxSouth.Location = new System.Drawing.Point(8, 88);
			this.groupBoxSouth.Name = "groupBoxSouth";
			this.groupBoxSouth.Size = new System.Drawing.Size(456, 184);
			this.groupBoxSouth.TabIndex = 7;
			this.groupBoxSouth.TabStop = false;
			this.groupBoxSouth.Text = "Preview";
			// 
			// MainForm
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 299);
			this.Controls.Add(this.pbPreview);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.tbSubjectNumber);
			this.Controls.Add(this.lblSubjectNumber);
			this.Controls.Add(this.tbDirectory);
			this.Controls.Add(this.lblDirectory);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.groupBoxSouth);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.MainMenu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EthoVision Paste Tracks";
			this.panelTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.StartNumber)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			/* Just close the main application */
			Close();
		}

		private void btStartSerie_Click(object sender, System.EventArgs e)
		{
			/* Start a new serie based on values in textboxes, etc. */

			// 1. disable and enable some textboxes and menu items
			tbDirectory.Enabled = false;
			btChooseDir.Enabled = false;
			tbSubjectNumber.Enabled = false;
			StartNumber.Enabled = false;
			btStartSerie.Enabled = false;
			menuItemSave.Enabled = false;
			menuItemSaveAs.Enabled = false;
			menuItemPaste.Enabled = true;
			menuItem7.Enabled = false;

			// 2. Check if directory is properly specified ; if not, give a default one
			if(tbDirectory.Text=="" || !Directory.Exists(tbDirectory.Text))
				directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			else
				directory = tbDirectory.Text;

			directory = directory + "\\";

			// 3. Check if the file prefix is properly specified ; if not, give a default one
			if(tbSubjectNumber.Text=="")
				fileprefix = "mwm";
			else
				fileprefix = tbSubjectNumber.Text;

			statusBar.Text = "Ready to receive a bitmap from clipboard ; just press Ctrl + V";
		}

		private void menuItemPaste_Click(object sender, System.EventArgs e)
		{
			bool res = Clipboard.GetDataObject().GetDataPresent("Bitmap", true);
			string filename = "";
			if(res) // if res is true, we have a bitmap in the clipboard
			{
				Bitmap bmp = new Bitmap((Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap));
				statusBar.Text = "Got a bitmap from clipboard ";
				pbPreview.Image = bmp;
				filename = fileprefix + StartNumber.Value.ToString() + ".png";
				bmp.Save(directory + filename);
				statusBar.Text = statusBar.Text + "and saved file " + filename;
				StartNumber.Value++;
			} 
			else 
			{
				MessageBox.Show("No bitmap present in the clipboard\nPlease copy your track from Ethovision before trying to paste it here", "Error: no bitmap in the clipboard!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btChooseDir_Click(object sender, System.EventArgs e)
		{
			DialogResult result = folderBrowserDlg.ShowDialog();
			if(result == DialogResult.OK) 
			{
				directory = folderBrowserDlg.SelectedPath;
				tbDirectory.Text = directory;
			}
		}

		private void menuItemNew_Click(object sender, System.EventArgs e)
		{
			tbDirectory.Enabled = true;
			btChooseDir.Enabled = true;
			tbSubjectNumber.Enabled = true;
			StartNumber.Enabled = true;
			StartNumber.Value = 1;
			btStartSerie.Enabled = true;
			menuItemSave.Enabled = false;
			menuItemSaveAs.Enabled = false;
			menuItemPaste.Enabled = false;
			menuItem7.Enabled = true;

			statusBar.Text = "Reset values ; please specify new values and start a new serie";
		}

		private void menuItemAbout_Click(object sender, System.EventArgs e)
		{
			AboutForm af = new AboutForm();
			af.ShowDialog();
		}
	}
}
