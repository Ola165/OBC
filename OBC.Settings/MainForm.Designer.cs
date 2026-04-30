// This file is part of OpenBootCamp.
// Copyright © Sparronator9999 2024-2026.
//
// OpenBootCamp is free software: you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the Free
// Software Foundation, either version 3 of the License, or (at your option)
// any later version.
//
// OpenBootCamp is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
// more details.
//
// You should have received a copy of the GNU General Public License along with
// OpenBootCamp. If not, see <https://www.gnu.org/licenses/>.

namespace OBC.Settings
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
            System.Windows.Forms.ToolStripMenuItem tsiFile;
            System.Windows.Forms.ToolStripMenuItem tsiExit;
            System.Windows.Forms.ToolStripMenuItem tsiHelp;
            System.Windows.Forms.ToolStripMenuItem tsiAbout;
            System.Windows.Forms.ToolStripMenuItem tsiSource;
            System.Windows.Forms.TabControl tcMain;
            System.Windows.Forms.TabPage tabKbd;
            System.Windows.Forms.TableLayoutPanel tblKbdSettings;
            System.Windows.Forms.Label lblFnBehaviour;
            System.Windows.Forms.Label lbKLT;
            System.Windows.Forms.Label lblKLTUnit;
            System.Windows.Forms.Label lblBrightness;
            System.Windows.Forms.TabPage tabFC;
            System.Windows.Forms.TableLayoutPanel tblFCSettings;
            System.Windows.Forms.Label lblFCPR;
            System.Windows.Forms.Label lblFCPRUnit;
            System.Windows.Forms.TableLayoutPanel tblFans;
            System.Windows.Forms.NumericUpDown numericUpDown3;
            System.Windows.Forms.NumericUpDown numericUpDown2;
            System.Windows.Forms.NumericUpDown numericUpDown1;
            System.Windows.Forms.TextBox txtFanKey;
            System.Windows.Forms.CheckBox chkFanEnable;
            System.Windows.Forms.TextBox txtFanName;
            System.Windows.Forms.Label lblFanName;
            System.Windows.Forms.Label lblFanKey;
            System.Windows.Forms.Label lblTmin;
            System.Windows.Forms.Label lblTmax;
            System.Windows.Forms.Label lblTdown;
            System.Windows.Forms.TabPage tabChgLim;
            System.Windows.Forms.TableLayoutPanel tblBattManSettings;
            System.Windows.Forms.Label lblChgLim;
            System.Windows.Forms.Label lblBattUnit;
            System.Windows.Forms.TabPage tabDbg;
            System.Windows.Forms.GroupBox grpKeyDump;
            System.Windows.Forms.TableLayoutPanel tblKeyDump;
            System.Windows.Forms.FlowLayoutPanel flwKeyDumpDelay;
            System.Windows.Forms.Label lblDelay;
            System.Windows.Forms.Label lblDelayUnit;
            System.Windows.Forms.TableLayoutPanel tblDbgOpt;
            System.Windows.Forms.Button btnInstallMgr;
            System.Windows.Forms.Button btnConfDir;
            System.Windows.Forms.TableLayoutPanel tblMain;
            System.Windows.Forms.Button btnRevert;
            System.Windows.Forms.Button btnApply;
            this.tblKeyboard = new System.Windows.Forms.TableLayoutPanel();
            this.grpKeyboardSettings = new System.Windows.Forms.GroupBox();
            this.cboBrightness = new System.Windows.Forms.ComboBox();
            this.cboFnBehaviour = new System.Windows.Forms.ComboBox();
            this.lblFnKeyHint = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkKeyLightTimeout = new System.Windows.Forms.CheckBox();
            this.numKeyLightTimeout = new System.Windows.Forms.NumericUpDown();
            this.chkKbdEventListenerEnable = new System.Windows.Forms.CheckBox();
            this.tblFC = new System.Windows.Forms.TableLayoutPanel();
            this.chkFCEnable = new System.Windows.Forms.CheckBox();
            this.grpFCGlobal = new System.Windows.Forms.GroupBox();
            this.numFCPollRate = new System.Windows.Forms.NumericUpDown();
            this.grpFans = new System.Windows.Forms.GroupBox();
            this.tblBattMan = new System.Windows.Forms.TableLayoutPanel();
            this.grpBattMan = new System.Windows.Forms.GroupBox();
            this.numChgLim = new System.Windows.Forms.NumericUpDown();
            this.chkBattManEnable = new System.Windows.Forms.CheckBox();
            this.tblDbg = new System.Windows.Forms.TableLayoutPanel();
            this.chkWakeDelayed = new System.Windows.Forms.CheckBox();
            this.chkWake = new System.Windows.Forms.CheckBox();
            this.chkSleep = new System.Windows.Forms.CheckBox();
            this.chkSvcStart = new System.Windows.Forms.CheckBox();
            this.chkSvcStop = new System.Windows.Forms.CheckBox();
            this.chkSvcStartDelayed = new System.Windows.Forms.CheckBox();
            this.numKeyDumpDelay = new System.Windows.Forms.NumericUpDown();
            this.grpDbg = new System.Windows.Forms.GroupBox();
            this.btnKeyDump = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            tsiFile = new System.Windows.Forms.ToolStripMenuItem();
            tsiExit = new System.Windows.Forms.ToolStripMenuItem();
            tsiHelp = new System.Windows.Forms.ToolStripMenuItem();
            tsiAbout = new System.Windows.Forms.ToolStripMenuItem();
            tsiSource = new System.Windows.Forms.ToolStripMenuItem();
            tcMain = new System.Windows.Forms.TabControl();
            tabKbd = new System.Windows.Forms.TabPage();
            tblKbdSettings = new System.Windows.Forms.TableLayoutPanel();
            lblFnBehaviour = new System.Windows.Forms.Label();
            lbKLT = new System.Windows.Forms.Label();
            lblKLTUnit = new System.Windows.Forms.Label();
            lblBrightness = new System.Windows.Forms.Label();
            tabFC = new System.Windows.Forms.TabPage();
            tblFCSettings = new System.Windows.Forms.TableLayoutPanel();
            lblFCPR = new System.Windows.Forms.Label();
            lblFCPRUnit = new System.Windows.Forms.Label();
            tblFans = new System.Windows.Forms.TableLayoutPanel();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            txtFanKey = new System.Windows.Forms.TextBox();
            chkFanEnable = new System.Windows.Forms.CheckBox();
            txtFanName = new System.Windows.Forms.TextBox();
            lblFanName = new System.Windows.Forms.Label();
            lblFanKey = new System.Windows.Forms.Label();
            lblTmin = new System.Windows.Forms.Label();
            lblTmax = new System.Windows.Forms.Label();
            lblTdown = new System.Windows.Forms.Label();
            tabChgLim = new System.Windows.Forms.TabPage();
            tblBattManSettings = new System.Windows.Forms.TableLayoutPanel();
            lblChgLim = new System.Windows.Forms.Label();
            lblBattUnit = new System.Windows.Forms.Label();
            tabDbg = new System.Windows.Forms.TabPage();
            grpKeyDump = new System.Windows.Forms.GroupBox();
            tblKeyDump = new System.Windows.Forms.TableLayoutPanel();
            flwKeyDumpDelay = new System.Windows.Forms.FlowLayoutPanel();
            lblDelay = new System.Windows.Forms.Label();
            lblDelayUnit = new System.Windows.Forms.Label();
            tblDbgOpt = new System.Windows.Forms.TableLayoutPanel();
            btnInstallMgr = new System.Windows.Forms.Button();
            btnConfDir = new System.Windows.Forms.Button();
            tblMain = new System.Windows.Forms.TableLayoutPanel();
            btnRevert = new System.Windows.Forms.Button();
            btnApply = new System.Windows.Forms.Button();
            tcMain.SuspendLayout();
            tabKbd.SuspendLayout();
            this.tblKeyboard.SuspendLayout();
            this.grpKeyboardSettings.SuspendLayout();
            tblKbdSettings.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyLightTimeout)).BeginInit();
            tabFC.SuspendLayout();
            this.tblFC.SuspendLayout();
            this.grpFCGlobal.SuspendLayout();
            tblFCSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFCPollRate)).BeginInit();
            this.grpFans.SuspendLayout();
            tblFans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown1)).BeginInit();
            tabChgLim.SuspendLayout();
            this.tblBattMan.SuspendLayout();
            this.grpBattMan.SuspendLayout();
            tblBattManSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChgLim)).BeginInit();
            tabDbg.SuspendLayout();
            this.tblDbg.SuspendLayout();
            grpKeyDump.SuspendLayout();
            tblKeyDump.SuspendLayout();
            flwKeyDumpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyDumpDelay)).BeginInit();
            this.grpDbg.SuspendLayout();
            tblDbgOpt.SuspendLayout();
            tblMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsiFile
            // 
            tsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsiExit});
            tsiFile.Name = "tsiFile";
            tsiFile.Size = new System.Drawing.Size(37, 20);
            tsiFile.Text = "File";
            // 
            // tsiExit
            // 
            tsiExit.Name = "tsiExit";
            tsiExit.Size = new System.Drawing.Size(93, 22);
            tsiExit.Text = "Exit";
            tsiExit.Click += new System.EventHandler(this.tsiExit_Click);
            // 
            // tsiHelp
            // 
            tsiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsiAbout,
            tsiSource});
            tsiHelp.Name = "tsiHelp";
            tsiHelp.Size = new System.Drawing.Size(44, 20);
            tsiHelp.Text = "Help";
            // 
            // tsiAbout
            // 
            tsiAbout.Name = "tsiAbout";
            tsiAbout.Size = new System.Drawing.Size(139, 22);
            tsiAbout.Text = "About";
            tsiAbout.Click += new System.EventHandler(this.tsiAbout_Click);
            // 
            // tsiSource
            // 
            tsiSource.Name = "tsiSource";
            tsiSource.Size = new System.Drawing.Size(139, 22);
            tsiSource.Text = "Source code";
            tsiSource.Click += new System.EventHandler(this.tsiSource_Click);
            // 
            // tcMain
            // 
            tblMain.SetColumnSpan(tcMain, 3);
            tcMain.Controls.Add(tabKbd);
            tcMain.Controls.Add(tabFC);
            tcMain.Controls.Add(tabChgLim);
            tcMain.Controls.Add(tabDbg);
            tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tcMain.Location = new System.Drawing.Point(3, 3);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new System.Drawing.Size(482, 241);
            tcMain.TabIndex = 2;
            // 
            // tabKbd
            // 
            tabKbd.Controls.Add(this.tblKeyboard);
            tabKbd.Location = new System.Drawing.Point(4, 24);
            tabKbd.Name = "tabKbd";
            tabKbd.Padding = new System.Windows.Forms.Padding(3);
            tabKbd.Size = new System.Drawing.Size(474, 213);
            tabKbd.TabIndex = 2;
            tabKbd.Text = "Keyboard";
            tabKbd.UseVisualStyleBackColor = true;
            // 
            // tblKeyboard
            // 
            this.tblKeyboard.ColumnCount = 1;
            this.tblKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKeyboard.Controls.Add(this.grpKeyboardSettings, 0, 1);
            this.tblKeyboard.Controls.Add(this.chkKbdEventListenerEnable, 0, 0);
            this.tblKeyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKeyboard.Location = new System.Drawing.Point(3, 3);
            this.tblKeyboard.Name = "tblKeyboard";
            this.tblKeyboard.RowCount = 2;
            this.tblKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKeyboard.Size = new System.Drawing.Size(468, 207);
            this.tblKeyboard.TabIndex = 3;
            // 
            // grpKeyboardSettings
            // 
            this.grpKeyboardSettings.Controls.Add(tblKbdSettings);
            this.grpKeyboardSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKeyboardSettings.Location = new System.Drawing.Point(3, 28);
            this.grpKeyboardSettings.Name = "grpKeyboardSettings";
            this.grpKeyboardSettings.Size = new System.Drawing.Size(462, 176);
            this.grpKeyboardSettings.TabIndex = 2;
            this.grpKeyboardSettings.TabStop = false;
            this.grpKeyboardSettings.Text = "Keyboard settings";
            // 
            // tblKbdSettings
            // 
            tblKbdSettings.ColumnCount = 2;
            tblKbdSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblKbdSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblKbdSettings.Controls.Add(this.cboBrightness, 1, 2);
            tblKbdSettings.Controls.Add(lblFnBehaviour, 0, 0);
            tblKbdSettings.Controls.Add(this.cboFnBehaviour, 1, 0);
            tblKbdSettings.Controls.Add(this.lblFnKeyHint, 0, 1);
            tblKbdSettings.Controls.Add(lbKLT, 0, 3);
            tblKbdSettings.Controls.Add(this.flowLayoutPanel2, 1, 3);
            tblKbdSettings.Controls.Add(lblBrightness, 0, 2);
            tblKbdSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            tblKbdSettings.Location = new System.Drawing.Point(3, 19);
            tblKbdSettings.Name = "tblKbdSettings";
            tblKbdSettings.RowCount = 5;
            tblKbdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKbdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKbdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKbdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKbdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblKbdSettings.Size = new System.Drawing.Size(456, 154);
            tblKbdSettings.TabIndex = 1;
            // 
            // cboBrightness
            // 
            this.cboBrightness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboBrightness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrightness.FormattingEnabled = true;
            this.cboBrightness.Items.AddRange(new object[] {
            "Standard (Windows/ACPI)",
            "Alternate (OBC, requires service to run)"});
            this.cboBrightness.Location = new System.Drawing.Point(163, 53);
            this.cboBrightness.Name = "cboBrightness";
            this.cboBrightness.Size = new System.Drawing.Size(200, 23);
            this.cboBrightness.TabIndex = 7;
            this.cboBrightness.SelectedIndexChanged += new System.EventHandler(this.cboBrightness_SelectedIndexChanged);
            // 
            // lblFnBehaviour
            // 
            lblFnBehaviour.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblFnBehaviour.AutoSize = true;
            lblFnBehaviour.Location = new System.Drawing.Point(18, 7);
            lblFnBehaviour.Name = "lblFnBehaviour";
            lblFnBehaviour.Size = new System.Drawing.Size(139, 15);
            lblFnBehaviour.TabIndex = 0;
            lblFnBehaviour.Text = "Use all F1, F2, etc. keys as";
            // 
            // cboFnBehaviour
            // 
            this.cboFnBehaviour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFnBehaviour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFnBehaviour.FormattingEnabled = true;
            this.cboFnBehaviour.Items.AddRange(new object[] {
            "standard function keys",
            "special keys (brightness, volume, etc.)"});
            this.cboFnBehaviour.Location = new System.Drawing.Point(163, 3);
            this.cboFnBehaviour.Name = "cboFnBehaviour";
            this.cboFnBehaviour.Size = new System.Drawing.Size(200, 23);
            this.cboFnBehaviour.TabIndex = 1;
            this.cboFnBehaviour.SelectedIndexChanged += new System.EventHandler(this.cboFnBehaviour_SelectedIndexChanged);
            // 
            // lblFnKeyHint
            // 
            this.lblFnKeyHint.AutoSize = true;
            tblKbdSettings.SetColumnSpan(this.lblFnKeyHint, 2);
            this.lblFnKeyHint.Location = new System.Drawing.Point(3, 29);
            this.lblFnKeyHint.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.lblFnKeyHint.Name = "lblFnKeyHint";
            this.lblFnKeyHint.Size = new System.Drawing.Size(0, 15);
            this.lblFnKeyHint.TabIndex = 2;
            // 
            // lbKLT
            // 
            lbKLT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbKLT.AutoSize = true;
            lbKLT.Location = new System.Drawing.Point(3, 89);
            lbKLT.Name = "lbKLT";
            lbKLT.Size = new System.Drawing.Size(154, 15);
            lbKLT.TabIndex = 3;
            lbKLT.Text = "Keyboard backlight timeout";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.chkKeyLightTimeout);
            this.flowLayoutPanel2.Controls.Add(this.numKeyLightTimeout);
            this.flowLayoutPanel2.Controls.Add(lblKLTUnit);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(163, 82);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(290, 29);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // chkKeyLightTimeout
            // 
            this.chkKeyLightTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkKeyLightTimeout.AutoSize = true;
            this.chkKeyLightTimeout.Location = new System.Drawing.Point(3, 4);
            this.chkKeyLightTimeout.Margin = new System.Windows.Forms.Padding(3, 2, 0, 3);
            this.chkKeyLightTimeout.Name = "chkKeyLightTimeout";
            this.chkKeyLightTimeout.Size = new System.Drawing.Size(98, 19);
            this.chkKeyLightTimeout.TabIndex = 4;
            this.chkKeyLightTimeout.Text = "Enabled, after";
            this.chkKeyLightTimeout.UseVisualStyleBackColor = true;
            this.chkKeyLightTimeout.CheckedChanged += new System.EventHandler(this.chkKeyLightTimeout_CheckedChanged);
            // 
            // numKeyLightTimeout
            // 
            this.numKeyLightTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numKeyLightTimeout.Location = new System.Drawing.Point(101, 3);
            this.numKeyLightTimeout.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.numKeyLightTimeout.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numKeyLightTimeout.Name = "numKeyLightTimeout";
            this.numKeyLightTimeout.Size = new System.Drawing.Size(60, 23);
            this.numKeyLightTimeout.TabIndex = 5;
            this.numKeyLightTimeout.ValueChanged += new System.EventHandler(this.numKeyLightTimeout_ValueChanged);
            // 
            // lblKLTUnit
            // 
            lblKLTUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblKLTUnit.AutoSize = true;
            lblKLTUnit.Location = new System.Drawing.Point(164, 5);
            lblKLTUnit.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            lblKLTUnit.Name = "lblKLTUnit";
            lblKLTUnit.Size = new System.Drawing.Size(50, 15);
            lblKLTUnit.TabIndex = 6;
            lblKLTUnit.Text = "seconds";
            // 
            // lblBrightness
            // 
            lblBrightness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblBrightness.AutoSize = true;
            lblBrightness.Location = new System.Drawing.Point(16, 57);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new System.Drawing.Size(141, 15);
            lblBrightness.TabIndex = 6;
            lblBrightness.Text = "Screen brightness control";
            // 
            // chkKbdEventListenerEnable
            // 
            this.chkKbdEventListenerEnable.AutoSize = true;
            this.chkKbdEventListenerEnable.Location = new System.Drawing.Point(3, 3);
            this.chkKbdEventListenerEnable.Name = "chkKbdEventListenerEnable";
            this.chkKbdEventListenerEnable.Size = new System.Drawing.Size(262, 19);
            this.chkKbdEventListenerEnable.TabIndex = 3;
            this.chkKbdEventListenerEnable.Text = "Enable keyboard settings and event handling";
            this.chkKbdEventListenerEnable.UseVisualStyleBackColor = true;
            this.chkKbdEventListenerEnable.CheckedChanged += new System.EventHandler(this.chkKbdEventListenerEnable_CheckedChanged);
            // 
            // tabFC
            // 
            tabFC.Controls.Add(this.tblFC);
            tabFC.Location = new System.Drawing.Point(4, 24);
            tabFC.Name = "tabFC";
            tabFC.Padding = new System.Windows.Forms.Padding(3);
            tabFC.Size = new System.Drawing.Size(474, 213);
            tabFC.TabIndex = 3;
            tabFC.Text = "Fans";
            tabFC.UseVisualStyleBackColor = true;
            // 
            // tblFC
            // 
            this.tblFC.ColumnCount = 1;
            this.tblFC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFC.Controls.Add(this.chkFCEnable, 0, 0);
            this.tblFC.Controls.Add(this.grpFCGlobal, 0, 1);
            this.tblFC.Controls.Add(this.grpFans, 0, 2);
            this.tblFC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFC.Location = new System.Drawing.Point(3, 3);
            this.tblFC.Name = "tblFC";
            this.tblFC.RowCount = 3;
            this.tblFC.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblFC.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblFC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFC.Size = new System.Drawing.Size(468, 207);
            this.tblFC.TabIndex = 0;
            // 
            // chkFCEnable
            // 
            this.chkFCEnable.AutoSize = true;
            this.chkFCEnable.Location = new System.Drawing.Point(3, 3);
            this.chkFCEnable.Name = "chkFCEnable";
            this.chkFCEnable.Size = new System.Drawing.Size(122, 19);
            this.chkFCEnable.TabIndex = 0;
            this.chkFCEnable.Text = "Enable fan control";
            this.chkFCEnable.UseVisualStyleBackColor = true;
            this.chkFCEnable.CheckedChanged += new System.EventHandler(this.chkFCEnable_CheckedChanged);
            // 
            // grpFCGlobal
            // 
            this.grpFCGlobal.AutoSize = true;
            this.grpFCGlobal.Controls.Add(tblFCSettings);
            this.grpFCGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFCGlobal.Location = new System.Drawing.Point(3, 28);
            this.grpFCGlobal.Name = "grpFCGlobal";
            this.grpFCGlobal.Size = new System.Drawing.Size(462, 51);
            this.grpFCGlobal.TabIndex = 1;
            this.grpFCGlobal.TabStop = false;
            this.grpFCGlobal.Text = "Global settings";
            // 
            // tblFCSettings
            // 
            tblFCSettings.AutoSize = true;
            tblFCSettings.ColumnCount = 3;
            tblFCSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblFCSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblFCSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblFCSettings.Controls.Add(lblFCPR, 0, 0);
            tblFCSettings.Controls.Add(this.numFCPollRate, 1, 0);
            tblFCSettings.Controls.Add(lblFCPRUnit, 2, 0);
            tblFCSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            tblFCSettings.Location = new System.Drawing.Point(3, 19);
            tblFCSettings.Name = "tblFCSettings";
            tblFCSettings.RowCount = 2;
            tblFCSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblFCSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblFCSettings.Size = new System.Drawing.Size(456, 29);
            tblFCSettings.TabIndex = 1;
            // 
            // lblFCPR
            // 
            lblFCPR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblFCPR.AutoSize = true;
            lblFCPR.Location = new System.Drawing.Point(3, 7);
            lblFCPR.Name = "lblFCPR";
            lblFCPR.Size = new System.Drawing.Size(70, 15);
            lblFCPR.TabIndex = 0;
            lblFCPR.Text = "Polling rate:";
            // 
            // numFCPollRate
            // 
            this.numFCPollRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numFCPollRate.DecimalPlaces = 3;
            this.numFCPollRate.Location = new System.Drawing.Point(79, 3);
            this.numFCPollRate.Name = "numFCPollRate";
            this.numFCPollRate.Size = new System.Drawing.Size(60, 23);
            this.numFCPollRate.TabIndex = 1;
            this.numFCPollRate.ValueChanged += new System.EventHandler(this.numFCPollRate_ValueChanged);
            // 
            // lblFCPRUnit
            // 
            lblFCPRUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblFCPRUnit.AutoSize = true;
            lblFCPRUnit.Location = new System.Drawing.Point(145, 7);
            lblFCPRUnit.Name = "lblFCPRUnit";
            lblFCPRUnit.Size = new System.Drawing.Size(50, 15);
            lblFCPRUnit.TabIndex = 2;
            lblFCPRUnit.Text = "seconds";
            // 
            // grpFans
            // 
            this.grpFans.Controls.Add(tblFans);
            this.grpFans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFans.Location = new System.Drawing.Point(3, 85);
            this.grpFans.Name = "grpFans";
            this.grpFans.Size = new System.Drawing.Size(462, 119);
            this.grpFans.TabIndex = 2;
            this.grpFans.TabStop = false;
            this.grpFans.Text = "Fans";
            // 
            // tblFans
            // 
            tblFans.ColumnCount = 6;
            tblFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblFans.Controls.Add(numericUpDown3, 5, 1);
            tblFans.Controls.Add(numericUpDown2, 4, 1);
            tblFans.Controls.Add(numericUpDown1, 3, 1);
            tblFans.Controls.Add(txtFanKey, 2, 1);
            tblFans.Controls.Add(chkFanEnable, 0, 1);
            tblFans.Controls.Add(txtFanName, 1, 1);
            tblFans.Controls.Add(lblFanName, 1, 0);
            tblFans.Controls.Add(lblFanKey, 2, 0);
            tblFans.Controls.Add(lblTmin, 3, 0);
            tblFans.Controls.Add(lblTmax, 4, 0);
            tblFans.Controls.Add(lblTdown, 5, 0);
            tblFans.Dock = System.Windows.Forms.DockStyle.Fill;
            tblFans.Enabled = false;
            tblFans.Location = new System.Drawing.Point(3, 19);
            tblFans.Name = "tblFans";
            tblFans.RowCount = 3;
            tblFans.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblFans.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblFans.Size = new System.Drawing.Size(456, 97);
            tblFans.TabIndex = 0;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new System.Drawing.Point(393, 18);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(60, 23);
            numericUpDown3.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(323, 18);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(60, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(255, 18);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(60, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // txtFanKey
            // 
            txtFanKey.Location = new System.Drawing.Point(186, 18);
            txtFanKey.Name = "txtFanKey";
            txtFanKey.Size = new System.Drawing.Size(60, 23);
            txtFanKey.TabIndex = 1;
            txtFanKey.Text = "TKEY";
            // 
            // chkFanEnable
            // 
            chkFanEnable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            chkFanEnable.AutoSize = true;
            chkFanEnable.Location = new System.Drawing.Point(3, 22);
            chkFanEnable.Name = "chkFanEnable";
            chkFanEnable.Size = new System.Drawing.Size(15, 14);
            chkFanEnable.TabIndex = 0;
            chkFanEnable.UseVisualStyleBackColor = true;
            // 
            // txtFanName
            // 
            txtFanName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtFanName.Location = new System.Drawing.Point(24, 18);
            txtFanName.Name = "txtFanName";
            txtFanName.Size = new System.Drawing.Size(156, 23);
            txtFanName.TabIndex = 5;
            txtFanName.Text = "TODO";
            // 
            // lblFanName
            // 
            lblFanName.AutoSize = true;
            lblFanName.Location = new System.Drawing.Point(24, 0);
            lblFanName.Name = "lblFanName";
            lblFanName.Size = new System.Drawing.Size(39, 15);
            lblFanName.TabIndex = 6;
            lblFanName.Text = "Name";
            // 
            // lblFanKey
            // 
            lblFanKey.AutoSize = true;
            lblFanKey.Location = new System.Drawing.Point(186, 0);
            lblFanKey.Name = "lblFanKey";
            lblFanKey.Size = new System.Drawing.Size(63, 15);
            lblFanKey.TabIndex = 7;
            lblFanKey.Text = "Sensor key";
            // 
            // lblTmin
            // 
            lblTmin.AutoSize = true;
            lblTmin.Location = new System.Drawing.Point(255, 0);
            lblTmin.Name = "lblTmin";
            lblTmin.Size = new System.Drawing.Size(62, 15);
            lblTmin.TabIndex = 8;
            lblTmin.Text = "Min. temp";
            // 
            // lblTmax
            // 
            lblTmax.AutoSize = true;
            lblTmax.Location = new System.Drawing.Point(323, 0);
            lblTmax.Name = "lblTmax";
            lblTmax.Size = new System.Drawing.Size(64, 15);
            lblTmax.TabIndex = 9;
            lblTmax.Text = "Max. temp";
            // 
            // lblTdown
            // 
            lblTdown.AutoSize = true;
            lblTdown.Location = new System.Drawing.Point(393, 0);
            lblTdown.Name = "lblTdown";
            lblTdown.Size = new System.Drawing.Size(60, 15);
            lblTdown.TabIndex = 10;
            lblTdown.Text = "Hysteresis";
            // 
            // tabChgLim
            // 
            tabChgLim.Controls.Add(this.tblBattMan);
            tabChgLim.Location = new System.Drawing.Point(4, 24);
            tabChgLim.Name = "tabChgLim";
            tabChgLim.Padding = new System.Windows.Forms.Padding(3);
            tabChgLim.Size = new System.Drawing.Size(474, 213);
            tabChgLim.TabIndex = 4;
            tabChgLim.Text = "Battery";
            tabChgLim.UseVisualStyleBackColor = true;
            // 
            // tblBattMan
            // 
            this.tblBattMan.ColumnCount = 1;
            this.tblBattMan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBattMan.Controls.Add(this.grpBattMan, 0, 1);
            this.tblBattMan.Controls.Add(this.chkBattManEnable, 0, 0);
            this.tblBattMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBattMan.Location = new System.Drawing.Point(3, 3);
            this.tblBattMan.Name = "tblBattMan";
            this.tblBattMan.RowCount = 2;
            this.tblBattMan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBattMan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBattMan.Size = new System.Drawing.Size(468, 207);
            this.tblBattMan.TabIndex = 4;
            // 
            // grpBattMan
            // 
            this.grpBattMan.Controls.Add(tblBattManSettings);
            this.grpBattMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBattMan.Location = new System.Drawing.Point(3, 28);
            this.grpBattMan.Name = "grpBattMan";
            this.grpBattMan.Size = new System.Drawing.Size(462, 176);
            this.grpBattMan.TabIndex = 2;
            this.grpBattMan.TabStop = false;
            this.grpBattMan.Text = "Battery manager settings";
            // 
            // tblBattManSettings
            // 
            tblBattManSettings.ColumnCount = 3;
            tblBattManSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblBattManSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblBattManSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblBattManSettings.Controls.Add(lblChgLim, 0, 0);
            tblBattManSettings.Controls.Add(this.numChgLim, 1, 0);
            tblBattManSettings.Controls.Add(lblBattUnit, 2, 0);
            tblBattManSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            tblBattManSettings.Location = new System.Drawing.Point(3, 19);
            tblBattManSettings.Name = "tblBattManSettings";
            tblBattManSettings.RowCount = 2;
            tblBattManSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblBattManSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblBattManSettings.Size = new System.Drawing.Size(456, 154);
            tblBattManSettings.TabIndex = 1;
            // 
            // lblChgLim
            // 
            lblChgLim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblChgLim.AutoSize = true;
            lblChgLim.Location = new System.Drawing.Point(3, 7);
            lblChgLim.Name = "lblChgLim";
            lblChgLim.Size = new System.Drawing.Size(127, 15);
            lblChgLim.TabIndex = 0;
            lblChgLim.Text = "Limit battery charge to";
            // 
            // numChgLim
            // 
            this.numChgLim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numChgLim.Location = new System.Drawing.Point(136, 3);
            this.numChgLim.Name = "numChgLim";
            this.numChgLim.Size = new System.Drawing.Size(60, 23);
            this.numChgLim.TabIndex = 1;
            this.numChgLim.ValueChanged += new System.EventHandler(this.numChgLim_ValueChanged);
            // 
            // lblBattUnit
            // 
            lblBattUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblBattUnit.AutoSize = true;
            lblBattUnit.Location = new System.Drawing.Point(202, 7);
            lblBattUnit.Name = "lblBattUnit";
            lblBattUnit.Size = new System.Drawing.Size(17, 15);
            lblBattUnit.TabIndex = 2;
            lblBattUnit.Text = "%";
            // 
            // chkBattManEnable
            // 
            this.chkBattManEnable.AutoSize = true;
            this.chkBattManEnable.Location = new System.Drawing.Point(3, 3);
            this.chkBattManEnable.Name = "chkBattManEnable";
            this.chkBattManEnable.Size = new System.Drawing.Size(151, 19);
            this.chkBattManEnable.TabIndex = 3;
            this.chkBattManEnable.Text = "Enable battery manager";
            this.chkBattManEnable.UseVisualStyleBackColor = true;
            this.chkBattManEnable.CheckedChanged += new System.EventHandler(this.chkBattManEnable_CheckedChanged);
            // 
            // tabDbg
            // 
            tabDbg.Controls.Add(this.tblDbg);
            tabDbg.Location = new System.Drawing.Point(4, 24);
            tabDbg.Name = "tabDbg";
            tabDbg.Padding = new System.Windows.Forms.Padding(3);
            tabDbg.Size = new System.Drawing.Size(474, 213);
            tabDbg.TabIndex = 5;
            tabDbg.Text = "Debug";
            tabDbg.UseVisualStyleBackColor = true;
            // 
            // tblDbg
            // 
            this.tblDbg.ColumnCount = 2;
            this.tblDbg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDbg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDbg.Controls.Add(grpKeyDump, 0, 0);
            this.tblDbg.Controls.Add(this.grpDbg, 1, 0);
            this.tblDbg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDbg.Location = new System.Drawing.Point(3, 3);
            this.tblDbg.Name = "tblDbg";
            this.tblDbg.RowCount = 1;
            this.tblDbg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDbg.Size = new System.Drawing.Size(468, 207);
            this.tblDbg.TabIndex = 2;
            // 
            // grpKeyDump
            // 
            grpKeyDump.Controls.Add(tblKeyDump);
            grpKeyDump.Dock = System.Windows.Forms.DockStyle.Fill;
            grpKeyDump.Location = new System.Drawing.Point(3, 3);
            grpKeyDump.Name = "grpKeyDump";
            grpKeyDump.Size = new System.Drawing.Size(344, 201);
            grpKeyDump.TabIndex = 1;
            grpKeyDump.TabStop = false;
            grpKeyDump.Text = "SMC Key Dump";
            // 
            // tblKeyDump
            // 
            tblKeyDump.ColumnCount = 1;
            tblKeyDump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblKeyDump.Controls.Add(this.chkWakeDelayed, 0, 5);
            tblKeyDump.Controls.Add(this.chkWake, 0, 4);
            tblKeyDump.Controls.Add(this.chkSleep, 0, 3);
            tblKeyDump.Controls.Add(this.chkSvcStart, 0, 0);
            tblKeyDump.Controls.Add(this.chkSvcStop, 0, 2);
            tblKeyDump.Controls.Add(this.chkSvcStartDelayed, 0, 1);
            tblKeyDump.Controls.Add(flwKeyDumpDelay, 0, 6);
            tblKeyDump.Dock = System.Windows.Forms.DockStyle.Fill;
            tblKeyDump.Location = new System.Drawing.Point(3, 19);
            tblKeyDump.Name = "tblKeyDump";
            tblKeyDump.RowCount = 7;
            tblKeyDump.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKeyDump.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKeyDump.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKeyDump.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKeyDump.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKeyDump.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblKeyDump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tblKeyDump.Size = new System.Drawing.Size(338, 179);
            tblKeyDump.TabIndex = 2;
            // 
            // chkWakeDelayed
            // 
            this.chkWakeDelayed.AutoSize = true;
            this.chkWakeDelayed.Location = new System.Drawing.Point(3, 128);
            this.chkWakeDelayed.Name = "chkWakeDelayed";
            this.chkWakeDelayed.Size = new System.Drawing.Size(164, 19);
            this.chkWakeDelayed.TabIndex = 5;
            this.chkWakeDelayed.Text = "On system wake (delayed)";
            this.chkWakeDelayed.UseVisualStyleBackColor = true;
            this.chkWakeDelayed.CheckedChanged += new System.EventHandler(this.chkWakeDelayed_CheckedChanged);
            // 
            // chkWake
            // 
            this.chkWake.AutoSize = true;
            this.chkWake.Location = new System.Drawing.Point(3, 103);
            this.chkWake.Name = "chkWake";
            this.chkWake.Size = new System.Drawing.Size(112, 19);
            this.chkWake.TabIndex = 4;
            this.chkWake.Text = "On system wake";
            this.chkWake.UseVisualStyleBackColor = true;
            this.chkWake.CheckedChanged += new System.EventHandler(this.chkWake_CheckedChanged);
            // 
            // chkSleep
            // 
            this.chkSleep.AutoSize = true;
            this.chkSleep.Location = new System.Drawing.Point(3, 78);
            this.chkSleep.Name = "chkSleep";
            this.chkSleep.Size = new System.Drawing.Size(112, 19);
            this.chkSleep.TabIndex = 3;
            this.chkSleep.Text = "On system sleep";
            this.chkSleep.UseVisualStyleBackColor = true;
            this.chkSleep.CheckedChanged += new System.EventHandler(this.chkSleep_CheckedChanged);
            // 
            // chkSvcStart
            // 
            this.chkSvcStart.AutoSize = true;
            this.chkSvcStart.Location = new System.Drawing.Point(3, 3);
            this.chkSvcStart.Name = "chkSvcStart";
            this.chkSvcStart.Size = new System.Drawing.Size(107, 19);
            this.chkSvcStart.TabIndex = 0;
            this.chkSvcStart.Text = "On service start";
            this.chkSvcStart.UseVisualStyleBackColor = true;
            this.chkSvcStart.CheckedChanged += new System.EventHandler(this.chkSvcStart_CheckedChanged);
            // 
            // chkSvcStop
            // 
            this.chkSvcStop.AutoSize = true;
            this.chkSvcStop.Location = new System.Drawing.Point(3, 53);
            this.chkSvcStop.Name = "chkSvcStop";
            this.chkSvcStop.Size = new System.Drawing.Size(107, 19);
            this.chkSvcStop.TabIndex = 2;
            this.chkSvcStop.Text = "On service stop";
            this.chkSvcStop.UseVisualStyleBackColor = true;
            this.chkSvcStop.CheckedChanged += new System.EventHandler(this.chkSvcStop_CheckedChanged);
            // 
            // chkSvcStartDelayed
            // 
            this.chkSvcStartDelayed.AutoSize = true;
            this.chkSvcStartDelayed.Location = new System.Drawing.Point(3, 28);
            this.chkSvcStartDelayed.Name = "chkSvcStartDelayed";
            this.chkSvcStartDelayed.Size = new System.Drawing.Size(159, 19);
            this.chkSvcStartDelayed.TabIndex = 1;
            this.chkSvcStartDelayed.Text = "On service start (delayed)";
            this.chkSvcStartDelayed.UseVisualStyleBackColor = true;
            this.chkSvcStartDelayed.CheckedChanged += new System.EventHandler(this.chkSvcStartDelayed_CheckedChanged);
            // 
            // flwKeyDumpDelay
            // 
            flwKeyDumpDelay.Controls.Add(lblDelay);
            flwKeyDumpDelay.Controls.Add(this.numKeyDumpDelay);
            flwKeyDumpDelay.Controls.Add(lblDelayUnit);
            flwKeyDumpDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            flwKeyDumpDelay.Location = new System.Drawing.Point(0, 150);
            flwKeyDumpDelay.Margin = new System.Windows.Forms.Padding(0);
            flwKeyDumpDelay.Name = "flwKeyDumpDelay";
            flwKeyDumpDelay.Size = new System.Drawing.Size(338, 29);
            flwKeyDumpDelay.TabIndex = 6;
            // 
            // lblDelay
            // 
            lblDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblDelay.AutoSize = true;
            lblDelay.Location = new System.Drawing.Point(3, 5);
            lblDelay.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            lblDelay.Name = "lblDelay";
            lblDelay.Size = new System.Drawing.Size(39, 15);
            lblDelay.TabIndex = 0;
            lblDelay.Text = "Delay:";
            // 
            // numKeyDumpDelay
            // 
            this.numKeyDumpDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numKeyDumpDelay.Location = new System.Drawing.Point(48, 3);
            this.numKeyDumpDelay.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numKeyDumpDelay.Name = "numKeyDumpDelay";
            this.numKeyDumpDelay.Size = new System.Drawing.Size(60, 23);
            this.numKeyDumpDelay.TabIndex = 1;
            this.numKeyDumpDelay.ValueChanged += new System.EventHandler(this.numKeyDumpDelay_ValueChanged);
            // 
            // lblDelayUnit
            // 
            lblDelayUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblDelayUnit.AutoSize = true;
            lblDelayUnit.Location = new System.Drawing.Point(114, 5);
            lblDelayUnit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            lblDelayUnit.Name = "lblDelayUnit";
            lblDelayUnit.Size = new System.Drawing.Size(50, 15);
            lblDelayUnit.TabIndex = 2;
            lblDelayUnit.Text = "seconds";
            // 
            // grpDbg
            // 
            this.grpDbg.AutoSize = true;
            this.grpDbg.Controls.Add(tblDbgOpt);
            this.grpDbg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDbg.Location = new System.Drawing.Point(353, 3);
            this.grpDbg.Name = "grpDbg";
            this.grpDbg.Size = new System.Drawing.Size(112, 201);
            this.grpDbg.TabIndex = 2;
            this.grpDbg.TabStop = false;
            this.grpDbg.Text = "Debug";
            // 
            // tblDbgOpt
            // 
            tblDbgOpt.AutoSize = true;
            tblDbgOpt.ColumnCount = 1;
            tblDbgOpt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblDbgOpt.Controls.Add(btnInstallMgr, 0, 0);
            tblDbgOpt.Controls.Add(btnConfDir, 0, 1);
            tblDbgOpt.Controls.Add(this.btnKeyDump, 0, 2);
            tblDbgOpt.Dock = System.Windows.Forms.DockStyle.Fill;
            tblDbgOpt.Location = new System.Drawing.Point(3, 19);
            tblDbgOpt.Name = "tblDbgOpt";
            tblDbgOpt.RowCount = 4;
            tblDbgOpt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblDbgOpt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblDbgOpt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblDbgOpt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblDbgOpt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tblDbgOpt.Size = new System.Drawing.Size(106, 179);
            tblDbgOpt.TabIndex = 0;
            // 
            // btnInstallMgr
            // 
            btnInstallMgr.Location = new System.Drawing.Point(3, 3);
            btnInstallMgr.Name = "btnInstallMgr";
            btnInstallMgr.Size = new System.Drawing.Size(100, 23);
            btnInstallMgr.TabIndex = 1;
            btnInstallMgr.Text = "Install Manager";
            btnInstallMgr.UseVisualStyleBackColor = true;
            btnInstallMgr.Click += new System.EventHandler(this.btnInstallMgr_Click);
            // 
            // btnConfDir
            // 
            btnConfDir.Location = new System.Drawing.Point(3, 32);
            btnConfDir.Name = "btnConfDir";
            btnConfDir.Size = new System.Drawing.Size(100, 23);
            btnConfDir.TabIndex = 3;
            btnConfDir.Text = "Open data dir";
            btnConfDir.UseVisualStyleBackColor = true;
            btnConfDir.Click += new System.EventHandler(this.btnConfDir_Click);
            // 
            // btnKeyDump
            // 
            this.btnKeyDump.Enabled = false;
            this.btnKeyDump.Location = new System.Drawing.Point(3, 61);
            this.btnKeyDump.Name = "btnKeyDump";
            this.btnKeyDump.Size = new System.Drawing.Size(100, 23);
            this.btnKeyDump.TabIndex = 2;
            this.btnKeyDump.Text = "SMC keydump";
            this.btnKeyDump.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblMain.Controls.Add(tcMain, 0, 0);
            tblMain.Controls.Add(this.lblStatus, 0, 1);
            tblMain.Controls.Add(btnRevert, 1, 1);
            tblMain.Controls.Add(btnApply, 2, 1);
            tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tblMain.Location = new System.Drawing.Point(0, 24);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblMain.Size = new System.Drawing.Size(488, 276);
            tblMain.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 254);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Config GUI is WIP!";
            // 
            // btnRevert
            // 
            btnRevert.Location = new System.Drawing.Point(329, 250);
            btnRevert.Name = "btnRevert";
            btnRevert.Size = new System.Drawing.Size(75, 23);
            btnRevert.TabIndex = 4;
            btnRevert.Text = "Revert";
            btnRevert.UseVisualStyleBackColor = true;
            btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnApply
            // 
            btnApply.Location = new System.Drawing.Point(410, 250);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(75, 23);
            btnApply.TabIndex = 5;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsiFile,
            tsiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(488, 300);
            this.Controls.Add(tblMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenBootCamp Settings";
            tcMain.ResumeLayout(false);
            tabKbd.ResumeLayout(false);
            this.tblKeyboard.ResumeLayout(false);
            this.tblKeyboard.PerformLayout();
            this.grpKeyboardSettings.ResumeLayout(false);
            tblKbdSettings.ResumeLayout(false);
            tblKbdSettings.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyLightTimeout)).EndInit();
            tabFC.ResumeLayout(false);
            this.tblFC.ResumeLayout(false);
            this.tblFC.PerformLayout();
            this.grpFCGlobal.ResumeLayout(false);
            this.grpFCGlobal.PerformLayout();
            tblFCSettings.ResumeLayout(false);
            tblFCSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFCPollRate)).EndInit();
            this.grpFans.ResumeLayout(false);
            tblFans.ResumeLayout(false);
            tblFans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown1)).EndInit();
            tabChgLim.ResumeLayout(false);
            this.tblBattMan.ResumeLayout(false);
            this.tblBattMan.PerformLayout();
            this.grpBattMan.ResumeLayout(false);
            tblBattManSettings.ResumeLayout(false);
            tblBattManSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChgLim)).EndInit();
            tabDbg.ResumeLayout(false);
            this.tblDbg.ResumeLayout(false);
            this.tblDbg.PerformLayout();
            grpKeyDump.ResumeLayout(false);
            tblKeyDump.ResumeLayout(false);
            tblKeyDump.PerformLayout();
            flwKeyDumpDelay.ResumeLayout(false);
            flwKeyDumpDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyDumpDelay)).EndInit();
            this.grpDbg.ResumeLayout(false);
            this.grpDbg.PerformLayout();
            tblDbgOpt.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox chkSvcStart;
        private System.Windows.Forms.CheckBox chkSleep;
        private System.Windows.Forms.CheckBox chkSvcStop;
        private System.Windows.Forms.CheckBox chkSvcStartDelayed;
        private System.Windows.Forms.CheckBox chkWakeDelayed;
        private System.Windows.Forms.CheckBox chkWake;
        private System.Windows.Forms.NumericUpDown numKeyDumpDelay;
        private System.Windows.Forms.ComboBox cboFnBehaviour;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox chkKeyLightTimeout;
        private System.Windows.Forms.NumericUpDown numKeyLightTimeout;
        private System.Windows.Forms.ComboBox cboBrightness;
        private System.Windows.Forms.NumericUpDown numChgLim;
        private System.Windows.Forms.GroupBox grpBattMan;
        private System.Windows.Forms.CheckBox chkBattManEnable;
        private System.Windows.Forms.GroupBox grpKeyboardSettings;
        private System.Windows.Forms.Label lblFnKeyHint;
        private System.Windows.Forms.CheckBox chkKbdEventListenerEnable;
        private System.Windows.Forms.TableLayoutPanel tblKeyboard;
        private System.Windows.Forms.TableLayoutPanel tblBattMan;
        private System.Windows.Forms.TableLayoutPanel tblFC;
        private System.Windows.Forms.TableLayoutPanel tblDbg;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkFCEnable;
        private System.Windows.Forms.GroupBox grpDbg;
        private System.Windows.Forms.Button btnKeyDump;
        private System.Windows.Forms.NumericUpDown numFCPollRate;
        private System.Windows.Forms.GroupBox grpFCGlobal;
        private System.Windows.Forms.GroupBox grpFans;
    }
}

