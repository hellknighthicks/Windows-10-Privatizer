﻿using System.ComponentModel;
using System.Windows.Forms;

namespace PSS_Windows_10_Privatizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.tabPageUtilites = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDisableOfficeUpdate = new System.Windows.Forms.Button();
            this.btnDeleteOneDrive = new System.Windows.Forms.Button();
            this.btnDeleteMetroAppsInfo = new System.Windows.Forms.Button();
            this.groupBoxWindowsUpdate = new System.Windows.Forms.GroupBox();
            this.btnEnableWindowsUpdate = new System.Windows.Forms.Button();
            this.btnDisableWindowsUpdate = new System.Windows.Forms.Button();
            this.groupBoxUACEdit = new System.Windows.Forms.GroupBox();
            this.btnEnableUac = new System.Windows.Forms.Button();
            this.btnDisableUac = new System.Windows.Forms.Button();
            this.btnOpenAndEditHosts = new System.Windows.Forms.Button();
            this.btnRestoreSystem = new System.Windows.Forms.Button();
            this.btnDeleteAllWindows10Apps = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBox_Disable_ActionCenter = new System.Windows.Forms.CheckBox();
            this.checkBox_SetDarkTheme = new System.Windows.Forms.CheckBox();
            this.checkBox_StickyKeys = new System.Windows.Forms.CheckBox();
            this.checkBox_ActionCenterActions = new System.Windows.Forms.CheckBox();
            this.checkBox_SecurityCenter = new System.Windows.Forms.CheckBox();
            this.checkBox_LockScreen = new System.Windows.Forms.CheckBox();
            this.CheckboxUAC_Silent = new System.Windows.Forms.CheckBox();
            this.checkBoxOneDrive = new System.Windows.Forms.CheckBox();
            this.checkBoxP2PWinUpdate = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableServices = new System.Windows.Forms.CheckBox();
            this.checkBoxSPYTasks = new System.Windows.Forms.CheckBox();
            this.checkBoxSetDefaultPhoto = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableWindowsDefender = new System.Windows.Forms.CheckBox();
            this.checkBoxDisablePrivateSettings = new System.Windows.Forms.CheckBox();
            this.checkBoxAddToHosts = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyLoggerAndTelemetry = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateSystemRestorePoint = new System.Windows.Forms.CheckBox();
            this.ProgressBarStatus = new System.Windows.Forms.ProgressBar();
            this.Button_Execite_Checked = new System.Windows.Forms.Button();
            this.LogOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.FormTabsControl = new System.Windows.Forms.TabControl();
            this.tabPageMETRO = new System.Windows.Forms.TabPage();
            this.labelInfoDeleteMetroApps = new System.Windows.Forms.Label();
            this.checkBoxDeleteAppXBOX = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppVoice = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppSolit = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppPhotos = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppPhone = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppPeopleOneNote = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppZune = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppBing = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteMailCalendarMaps = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppCamera = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteApp3d = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteWindows10Apps = new System.Windows.Forms.CheckBox();
            this.lable_Title_Bar = new System.Windows.Forms.Label();
            this.checkBox_FixAdminAccount = new System.Windows.Forms.CheckBox();
            this.checkBox_DisableGameDVR = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            this.tabPageUtilites.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxWindowsUpdate.SuspendLayout();
            this.groupBoxUACEdit.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.FormTabsControl.SuspendLayout();
            this.tabPageMETRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = global::PSS_Windows_10_Privatizer.Properties.Resources.close;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(826, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 16);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImage = global::PSS_Windows_10_Privatizer.Properties.Resources.minimize;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Location = new System.Drawing.Point(802, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(18, 16);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // tabPageUtilites
            // 
            this.tabPageUtilites.BackColor = System.Drawing.Color.White;
            this.tabPageUtilites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageUtilites.Controls.Add(this.groupBox1);
            this.tabPageUtilites.Controls.Add(this.btnDisableOfficeUpdate);
            this.tabPageUtilites.Controls.Add(this.btnDeleteOneDrive);
            this.tabPageUtilites.Controls.Add(this.btnDeleteMetroAppsInfo);
            this.tabPageUtilites.Controls.Add(this.groupBoxWindowsUpdate);
            this.tabPageUtilites.Controls.Add(this.groupBoxUACEdit);
            this.tabPageUtilites.Controls.Add(this.btnOpenAndEditHosts);
            this.tabPageUtilites.Controls.Add(this.btnRestoreSystem);
            this.tabPageUtilites.Controls.Add(this.btnDeleteAllWindows10Apps);
            this.tabPageUtilites.Location = new System.Drawing.Point(4, 22);
            this.tabPageUtilites.Name = "tabPageUtilites";
            this.tabPageUtilites.Size = new System.Drawing.Size(261, 438);
            this.tabPageUtilites.TabIndex = 2;
            this.tabPageUtilites.Text = "Utilites";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Settings";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnDisableOfficeUpdate
            // 
            this.btnDisableOfficeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnDisableOfficeUpdate.BackgroundImage = global::PSS_Windows_10_Privatizer.Properties.Resources.warning;
            this.btnDisableOfficeUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDisableOfficeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableOfficeUpdate.Location = new System.Drawing.Point(14, 119);
            this.btnDisableOfficeUpdate.Name = "btnDisableOfficeUpdate";
            this.btnDisableOfficeUpdate.Size = new System.Drawing.Size(230, 23);
            this.btnDisableOfficeUpdate.TabIndex = 6;
            this.btnDisableOfficeUpdate.Text = "Disable Office 2016 Telemetry";
            this.btnDisableOfficeUpdate.UseVisualStyleBackColor = false;
            this.btnDisableOfficeUpdate.Click += new System.EventHandler(this.btnDisableOfficeUpdate_Click);
            // 
            // btnDeleteOneDrive
            // 
            this.btnDeleteOneDrive.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOneDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOneDrive.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteOneDrive.Location = new System.Drawing.Point(14, 90);
            this.btnDeleteOneDrive.Name = "btnDeleteOneDrive";
            this.btnDeleteOneDrive.Size = new System.Drawing.Size(230, 23);
            this.btnDeleteOneDrive.TabIndex = 10;
            this.btnDeleteOneDrive.Text = "Delete One Drive";
            this.btnDeleteOneDrive.UseVisualStyleBackColor = false;
            this.btnDeleteOneDrive.Click += new System.EventHandler(this.UnInsall_OneDrive);
            // 
            // btnDeleteMetroAppsInfo
            // 
            this.btnDeleteMetroAppsInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMetroAppsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMetroAppsInfo.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMetroAppsInfo.Location = new System.Drawing.Point(199, 32);
            this.btnDeleteMetroAppsInfo.Name = "btnDeleteMetroAppsInfo";
            this.btnDeleteMetroAppsInfo.Size = new System.Drawing.Size(45, 23);
            this.btnDeleteMetroAppsInfo.TabIndex = 9;
            this.btnDeleteMetroAppsInfo.Text = "?";
            this.btnDeleteMetroAppsInfo.UseVisualStyleBackColor = false;
            this.btnDeleteMetroAppsInfo.Click += new System.EventHandler(this.btnDeleteMetroAppsInfo_Click);
            // 
            // groupBoxWindowsUpdate
            // 
            this.groupBoxWindowsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxWindowsUpdate.Controls.Add(this.btnEnableWindowsUpdate);
            this.groupBoxWindowsUpdate.Controls.Add(this.btnDisableWindowsUpdate);
            this.groupBoxWindowsUpdate.Location = new System.Drawing.Point(8, 234);
            this.groupBoxWindowsUpdate.Name = "groupBoxWindowsUpdate";
            this.groupBoxWindowsUpdate.Size = new System.Drawing.Size(242, 80);
            this.groupBoxWindowsUpdate.TabIndex = 8;
            this.groupBoxWindowsUpdate.TabStop = false;
            this.groupBoxWindowsUpdate.Text = "Windows Update";
            // 
            // btnEnableWindowsUpdate
            // 
            this.btnEnableWindowsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnEnableWindowsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableWindowsUpdate.Location = new System.Drawing.Point(6, 20);
            this.btnEnableWindowsUpdate.Name = "btnEnableWindowsUpdate";
            this.btnEnableWindowsUpdate.Size = new System.Drawing.Size(230, 23);
            this.btnEnableWindowsUpdate.TabIndex = 4;
            this.btnEnableWindowsUpdate.Text = "Enable Windows Update";
            this.btnEnableWindowsUpdate.UseVisualStyleBackColor = false;
            this.btnEnableWindowsUpdate.Click += new System.EventHandler(this.btnEnableWindowsUpdate_Click);
            // 
            // btnDisableWindowsUpdate
            // 
            this.btnDisableWindowsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnDisableWindowsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableWindowsUpdate.Location = new System.Drawing.Point(6, 49);
            this.btnDisableWindowsUpdate.Name = "btnDisableWindowsUpdate";
            this.btnDisableWindowsUpdate.Size = new System.Drawing.Size(230, 23);
            this.btnDisableWindowsUpdate.TabIndex = 5;
            this.btnDisableWindowsUpdate.Text = "Disable Windows Update";
            this.btnDisableWindowsUpdate.UseVisualStyleBackColor = false;
            this.btnDisableWindowsUpdate.Click += new System.EventHandler(this.btnDisableWindowsUpdate_Click);
            // 
            // groupBoxUACEdit
            // 
            this.groupBoxUACEdit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxUACEdit.Controls.Add(this.btnEnableUac);
            this.groupBoxUACEdit.Controls.Add(this.btnDisableUac);
            this.groupBoxUACEdit.Location = new System.Drawing.Point(8, 148);
            this.groupBoxUACEdit.Name = "groupBoxUACEdit";
            this.groupBoxUACEdit.Size = new System.Drawing.Size(242, 80);
            this.groupBoxUACEdit.TabIndex = 7;
            this.groupBoxUACEdit.TabStop = false;
            this.groupBoxUACEdit.Text = "UAC";
            // 
            // btnEnableUac
            // 
            this.btnEnableUac.BackColor = System.Drawing.Color.Transparent;
            this.btnEnableUac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableUac.Location = new System.Drawing.Point(6, 20);
            this.btnEnableUac.Name = "btnEnableUac";
            this.btnEnableUac.Size = new System.Drawing.Size(230, 23);
            this.btnEnableUac.TabIndex = 2;
            this.btnEnableUac.Text = "Enable UAC";
            this.btnEnableUac.UseVisualStyleBackColor = false;
            this.btnEnableUac.Click += new System.EventHandler(this.btnEnableUac_Click);
            // 
            // btnDisableUac
            // 
            this.btnDisableUac.BackColor = System.Drawing.Color.Transparent;
            this.btnDisableUac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableUac.Location = new System.Drawing.Point(6, 49);
            this.btnDisableUac.Name = "btnDisableUac";
            this.btnDisableUac.Size = new System.Drawing.Size(230, 23);
            this.btnDisableUac.TabIndex = 3;
            this.btnDisableUac.Text = "Disable UAC";
            this.btnDisableUac.UseVisualStyleBackColor = false;
            this.btnDisableUac.Click += new System.EventHandler(this.btnDisableUac_Click);
            // 
            // btnOpenAndEditHosts
            // 
            this.btnOpenAndEditHosts.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenAndEditHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAndEditHosts.Location = new System.Drawing.Point(14, 3);
            this.btnOpenAndEditHosts.Name = "btnOpenAndEditHosts";
            this.btnOpenAndEditHosts.Size = new System.Drawing.Size(230, 23);
            this.btnOpenAndEditHosts.TabIndex = 6;
            this.btnOpenAndEditHosts.Text = "Open and edit HOSTS file";
            this.btnOpenAndEditHosts.UseVisualStyleBackColor = false;
            this.btnOpenAndEditHosts.Click += new System.EventHandler(this.btnOpenAndEditHosts_Click);
            // 
            // btnRestoreSystem
            // 
            this.btnRestoreSystem.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreSystem.Location = new System.Drawing.Point(14, 61);
            this.btnRestoreSystem.Name = "btnRestoreSystem";
            this.btnRestoreSystem.Size = new System.Drawing.Size(230, 23);
            this.btnRestoreSystem.TabIndex = 1;
            this.btnRestoreSystem.Text = "Restore System";
            this.btnRestoreSystem.UseVisualStyleBackColor = false;
            this.btnRestoreSystem.Click += new System.EventHandler(this.btnRestoreSystem_Click);
            // 
            // btnDeleteAllWindows10Apps
            // 
            this.btnDeleteAllWindows10Apps.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAllWindows10Apps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllWindows10Apps.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllWindows10Apps.Location = new System.Drawing.Point(14, 32);
            this.btnDeleteAllWindows10Apps.Name = "btnDeleteAllWindows10Apps";
            this.btnDeleteAllWindows10Apps.Size = new System.Drawing.Size(213, 23);
            this.btnDeleteAllWindows10Apps.TabIndex = 0;
            this.btnDeleteAllWindows10Apps.Text = "Delete all windows 10 metro apps";
            this.btnDeleteAllWindows10Apps.UseVisualStyleBackColor = false;
            this.btnDeleteAllWindows10Apps.Click += new System.EventHandler(this.btnDeleteAllWindows10Apps_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageSettings.Controls.Add(this.checkBox_DisableGameDVR);
            this.tabPageSettings.Controls.Add(this.checkBox_FixAdminAccount);
            this.tabPageSettings.Controls.Add(this.checkBox_Disable_ActionCenter);
            this.tabPageSettings.Controls.Add(this.checkBox_SetDarkTheme);
            this.tabPageSettings.Controls.Add(this.checkBox_StickyKeys);
            this.tabPageSettings.Controls.Add(this.checkBox_ActionCenterActions);
            this.tabPageSettings.Controls.Add(this.checkBox_SecurityCenter);
            this.tabPageSettings.Controls.Add(this.checkBox_LockScreen);
            this.tabPageSettings.Controls.Add(this.CheckboxUAC_Silent);
            this.tabPageSettings.Controls.Add(this.checkBoxOneDrive);
            this.tabPageSettings.Controls.Add(this.checkBoxP2PWinUpdate);
            this.tabPageSettings.Controls.Add(this.checkBoxDisableServices);
            this.tabPageSettings.Controls.Add(this.checkBoxSPYTasks);
            this.tabPageSettings.Controls.Add(this.checkBoxSetDefaultPhoto);
            this.tabPageSettings.Controls.Add(this.checkBoxDisableWindowsDefender);
            this.tabPageSettings.Controls.Add(this.checkBoxDisablePrivateSettings);
            this.tabPageSettings.Controls.Add(this.checkBoxAddToHosts);
            this.tabPageSettings.Controls.Add(this.checkBoxKeyLoggerAndTelemetry);
            this.tabPageSettings.Controls.Add(this.checkBoxCreateSystemRestorePoint);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(261, 438);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Options";
            // 
            // checkBox_Disable_ActionCenter
            // 
            this.checkBox_Disable_ActionCenter.AutoSize = true;
            this.checkBox_Disable_ActionCenter.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Disable_ActionCenter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_Disable_ActionCenter.Location = new System.Drawing.Point(6, 207);
            this.checkBox_Disable_ActionCenter.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_Disable_ActionCenter.Name = "checkBox_Disable_ActionCenter";
            this.checkBox_Disable_ActionCenter.Size = new System.Drawing.Size(260, 17);
            this.checkBox_Disable_ActionCenter.TabIndex = 32;
            this.checkBox_Disable_ActionCenter.Text = "Disable Action Center Service (Will Cause Popup)";
            this.checkBox_Disable_ActionCenter.UseVisualStyleBackColor = false;
            // 
            // checkBox_SetDarkTheme
            // 
            this.checkBox_SetDarkTheme.AutoSize = true;
            this.checkBox_SetDarkTheme.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_SetDarkTheme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_SetDarkTheme.Location = new System.Drawing.Point(6, 401);
            this.checkBox_SetDarkTheme.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_SetDarkTheme.Name = "checkBox_SetDarkTheme";
            this.checkBox_SetDarkTheme.Size = new System.Drawing.Size(102, 17);
            this.checkBox_SetDarkTheme.TabIndex = 31;
            this.checkBox_SetDarkTheme.Text = "Set Dark Theme";
            this.checkBox_SetDarkTheme.UseVisualStyleBackColor = false;
            // 
            // checkBox_StickyKeys
            // 
            this.checkBox_StickyKeys.AutoSize = true;
            this.checkBox_StickyKeys.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_StickyKeys.Checked = true;
            this.checkBox_StickyKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_StickyKeys.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_StickyKeys.Location = new System.Drawing.Point(6, 224);
            this.checkBox_StickyKeys.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_StickyKeys.Name = "checkBox_StickyKeys";
            this.checkBox_StickyKeys.Size = new System.Drawing.Size(117, 17);
            this.checkBox_StickyKeys.TabIndex = 29;
            this.checkBox_StickyKeys.Text = "Disable Sticky Keys";
            this.checkBox_StickyKeys.UseVisualStyleBackColor = false;
            // 
            // checkBox_ActionCenterActions
            // 
            this.checkBox_ActionCenterActions.AutoSize = true;
            this.checkBox_ActionCenterActions.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ActionCenterActions.Checked = true;
            this.checkBox_ActionCenterActions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ActionCenterActions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_ActionCenterActions.Location = new System.Drawing.Point(6, 190);
            this.checkBox_ActionCenterActions.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_ActionCenterActions.Name = "checkBox_ActionCenterActions";
            this.checkBox_ActionCenterActions.Size = new System.Drawing.Size(167, 17);
            this.checkBox_ActionCenterActions.TabIndex = 28;
            this.checkBox_ActionCenterActions.Text = "Disable Action Center Actions";
            this.checkBox_ActionCenterActions.UseVisualStyleBackColor = false;
            // 
            // checkBox_SecurityCenter
            // 
            this.checkBox_SecurityCenter.AutoSize = true;
            this.checkBox_SecurityCenter.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_SecurityCenter.Checked = true;
            this.checkBox_SecurityCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SecurityCenter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_SecurityCenter.Location = new System.Drawing.Point(6, 173);
            this.checkBox_SecurityCenter.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_SecurityCenter.Name = "checkBox_SecurityCenter";
            this.checkBox_SecurityCenter.Size = new System.Drawing.Size(203, 17);
            this.checkBox_SecurityCenter.TabIndex = 27;
            this.checkBox_SecurityCenter.Text = "Disable Security Center & Notifications";
            this.checkBox_SecurityCenter.UseVisualStyleBackColor = false;
            // 
            // checkBox_LockScreen
            // 
            this.checkBox_LockScreen.AutoSize = true;
            this.checkBox_LockScreen.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_LockScreen.Checked = true;
            this.checkBox_LockScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LockScreen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_LockScreen.Location = new System.Drawing.Point(6, 156);
            this.checkBox_LockScreen.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_LockScreen.Name = "checkBox_LockScreen";
            this.checkBox_LockScreen.Size = new System.Drawing.Size(154, 17);
            this.checkBox_LockScreen.TabIndex = 26;
            this.checkBox_LockScreen.Text = "Disable Sliding-Lock Screen";
            this.checkBox_LockScreen.UseVisualStyleBackColor = false;
            // 
            // CheckboxUAC_Silent
            // 
            this.CheckboxUAC_Silent.AutoSize = true;
            this.CheckboxUAC_Silent.BackColor = System.Drawing.Color.Transparent;
            this.CheckboxUAC_Silent.Checked = true;
            this.CheckboxUAC_Silent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxUAC_Silent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckboxUAC_Silent.Location = new System.Drawing.Point(6, 282);
            this.CheckboxUAC_Silent.Margin = new System.Windows.Forms.Padding(0);
            this.CheckboxUAC_Silent.Name = "CheckboxUAC_Silent";
            this.CheckboxUAC_Silent.Size = new System.Drawing.Size(137, 17);
            this.CheckboxUAC_Silent.TabIndex = 25;
            this.CheckboxUAC_Silent.Text = "Set UAC to Silent mode";
            this.CheckboxUAC_Silent.UseVisualStyleBackColor = false;
            // 
            // checkBoxOneDrive
            // 
            this.checkBoxOneDrive.AutoSize = true;
            this.checkBoxOneDrive.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOneDrive.Checked = true;
            this.checkBoxOneDrive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOneDrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxOneDrive.Location = new System.Drawing.Point(6, 139);
            this.checkBoxOneDrive.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxOneDrive.Name = "checkBoxOneDrive";
            this.checkBoxOneDrive.Size = new System.Drawing.Size(158, 17);
            this.checkBoxOneDrive.TabIndex = 24;
            this.checkBoxOneDrive.Text = "Disable Microsoft One Drive";
            this.checkBoxOneDrive.UseVisualStyleBackColor = false;
            // 
            // checkBoxP2PWinUpdate
            // 
            this.checkBoxP2PWinUpdate.AutoSize = true;
            this.checkBoxP2PWinUpdate.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxP2PWinUpdate.Checked = true;
            this.checkBoxP2PWinUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxP2PWinUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxP2PWinUpdate.Location = new System.Drawing.Point(6, 122);
            this.checkBoxP2PWinUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxP2PWinUpdate.Name = "checkBoxP2PWinUpdate";
            this.checkBoxP2PWinUpdate.Size = new System.Drawing.Size(258, 17);
            this.checkBoxP2PWinUpdate.TabIndex = 23;
            this.checkBoxP2PWinUpdate.Text = "Disable Internet P2P Distribution of Win Updates";
            this.checkBoxP2PWinUpdate.UseVisualStyleBackColor = false;
            // 
            // checkBoxDisableServices
            // 
            this.checkBoxDisableServices.AutoSize = true;
            this.checkBoxDisableServices.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDisableServices.Checked = true;
            this.checkBoxDisableServices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisableServices.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxDisableServices.Location = new System.Drawing.Point(6, 105);
            this.checkBoxDisableServices.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDisableServices.Name = "checkBoxDisableServices";
            this.checkBoxDisableServices.Size = new System.Drawing.Size(160, 17);
            this.checkBoxDisableServices.TabIndex = 22;
            this.checkBoxDisableServices.Text = "Disable Un-Needed Services";
            this.checkBoxDisableServices.UseVisualStyleBackColor = false;
            // 
            // checkBoxSPYTasks
            // 
            this.checkBoxSPYTasks.AutoSize = true;
            this.checkBoxSPYTasks.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSPYTasks.Checked = true;
            this.checkBoxSPYTasks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSPYTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxSPYTasks.Location = new System.Drawing.Point(6, 88);
            this.checkBoxSPYTasks.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSPYTasks.Name = "checkBoxSPYTasks";
            this.checkBoxSPYTasks.Size = new System.Drawing.Size(250, 17);
            this.checkBoxSPYTasks.TabIndex = 6;
            this.checkBoxSPYTasks.Text = "Disable Scheduled sending of data to Microsoft";
            this.checkBoxSPYTasks.UseVisualStyleBackColor = false;
            // 
            // checkBoxSetDefaultPhoto
            // 
            this.checkBoxSetDefaultPhoto.AutoSize = true;
            this.checkBoxSetDefaultPhoto.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSetDefaultPhoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxSetDefaultPhoto.Location = new System.Drawing.Point(6, 418);
            this.checkBoxSetDefaultPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSetDefaultPhoto.Name = "checkBoxSetDefaultPhoto";
            this.checkBoxSetDefaultPhoto.Size = new System.Drawing.Size(189, 17);
            this.checkBoxSetDefaultPhoto.TabIndex = 5;
            this.checkBoxSetDefaultPhoto.Text = "Set default windows photo viewer";
            this.checkBoxSetDefaultPhoto.UseVisualStyleBackColor = false;
            this.checkBoxSetDefaultPhoto.CheckedChanged += new System.EventHandler(this.checkBoxSetDefaultPhoto_CheckedChanged);
            // 
            // checkBoxDisableWindowsDefender
            // 
            this.checkBoxDisableWindowsDefender.AutoSize = true;
            this.checkBoxDisableWindowsDefender.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDisableWindowsDefender.Checked = true;
            this.checkBoxDisableWindowsDefender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisableWindowsDefender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxDisableWindowsDefender.Location = new System.Drawing.Point(6, 71);
            this.checkBoxDisableWindowsDefender.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDisableWindowsDefender.Name = "checkBoxDisableWindowsDefender";
            this.checkBoxDisableWindowsDefender.Size = new System.Drawing.Size(154, 17);
            this.checkBoxDisableWindowsDefender.TabIndex = 4;
            this.checkBoxDisableWindowsDefender.Text = "Disable Windows Defender";
            this.checkBoxDisableWindowsDefender.UseVisualStyleBackColor = false;
            // 
            // checkBoxDisablePrivateSettings
            // 
            this.checkBoxDisablePrivateSettings.AutoSize = true;
            this.checkBoxDisablePrivateSettings.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDisablePrivateSettings.Checked = true;
            this.checkBoxDisablePrivateSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisablePrivateSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxDisablePrivateSettings.Location = new System.Drawing.Point(6, 54);
            this.checkBoxDisablePrivateSettings.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDisablePrivateSettings.Name = "checkBoxDisablePrivateSettings";
            this.checkBoxDisablePrivateSettings.Size = new System.Drawing.Size(210, 17);
            this.checkBoxDisablePrivateSettings.TabIndex = 3;
            this.checkBoxDisablePrivateSettings.Text = "Disable Sending of Windows Searches ";
            this.checkBoxDisablePrivateSettings.UseVisualStyleBackColor = false;
            // 
            // checkBoxAddToHosts
            // 
            this.checkBoxAddToHosts.AutoSize = true;
            this.checkBoxAddToHosts.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAddToHosts.Checked = true;
            this.checkBoxAddToHosts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddToHosts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxAddToHosts.Location = new System.Drawing.Point(6, 37);
            this.checkBoxAddToHosts.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAddToHosts.Name = "checkBoxAddToHosts";
            this.checkBoxAddToHosts.Size = new System.Drawing.Size(247, 17);
            this.checkBoxAddToHosts.TabIndex = 2;
            this.checkBoxAddToHosts.Text = "Block Spying wiht Hosts file / Windows Firewall\r\n";
            this.checkBoxAddToHosts.UseVisualStyleBackColor = false;
            // 
            // checkBoxKeyLoggerAndTelemetry
            // 
            this.checkBoxKeyLoggerAndTelemetry.AutoSize = true;
            this.checkBoxKeyLoggerAndTelemetry.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxKeyLoggerAndTelemetry.Checked = true;
            this.checkBoxKeyLoggerAndTelemetry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKeyLoggerAndTelemetry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxKeyLoggerAndTelemetry.Location = new System.Drawing.Point(6, 20);
            this.checkBoxKeyLoggerAndTelemetry.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxKeyLoggerAndTelemetry.Name = "checkBoxKeyLoggerAndTelemetry";
            this.checkBoxKeyLoggerAndTelemetry.Size = new System.Drawing.Size(219, 17);
            this.checkBoxKeyLoggerAndTelemetry.TabIndex = 1;
            this.checkBoxKeyLoggerAndTelemetry.Text = "Disable Keyloggers/Telemetry/MetaData";
            this.checkBoxKeyLoggerAndTelemetry.UseVisualStyleBackColor = false;
            // 
            // checkBoxCreateSystemRestorePoint
            // 
            this.checkBoxCreateSystemRestorePoint.AutoSize = true;
            this.checkBoxCreateSystemRestorePoint.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCreateSystemRestorePoint.Checked = true;
            this.checkBoxCreateSystemRestorePoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateSystemRestorePoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxCreateSystemRestorePoint.Location = new System.Drawing.Point(6, 3);
            this.checkBoxCreateSystemRestorePoint.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxCreateSystemRestorePoint.Name = "checkBoxCreateSystemRestorePoint";
            this.checkBoxCreateSystemRestorePoint.Size = new System.Drawing.Size(161, 17);
            this.checkBoxCreateSystemRestorePoint.TabIndex = 0;
            this.checkBoxCreateSystemRestorePoint.Text = "Create system restore point";
            this.checkBoxCreateSystemRestorePoint.UseVisualStyleBackColor = false;
            // 
            // ProgressBarStatus
            // 
            this.ProgressBarStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ProgressBarStatus.Location = new System.Drawing.Point(12, 506);
            this.ProgressBarStatus.Name = "ProgressBarStatus";
            this.ProgressBarStatus.Size = new System.Drawing.Size(548, 23);
            this.ProgressBarStatus.TabIndex = 1;
            // 
            // Button_Execite_Checked
            // 
            this.Button_Execite_Checked.BackColor = System.Drawing.Color.White;
            this.Button_Execite_Checked.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Button_Execite_Checked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Execite_Checked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Execite_Checked.Location = new System.Drawing.Point(570, 499);
            this.Button_Execite_Checked.Name = "Button_Execite_Checked";
            this.Button_Execite_Checked.Size = new System.Drawing.Size(261, 30);
            this.Button_Execite_Checked.TabIndex = 0;
            this.Button_Execite_Checked.Text = "Execute";
            this.Button_Execite_Checked.UseVisualStyleBackColor = false;
            this.Button_Execite_Checked.Click += new System.EventHandler(this.btnDestroyWindowsSpying_Click);
            // 
            // LogOutputTextBox
            // 
            this.LogOutputTextBox.BackColor = System.Drawing.Color.Black;
            this.LogOutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogOutputTextBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutputTextBox.ForeColor = System.Drawing.Color.Cyan;
            this.LogOutputTextBox.Location = new System.Drawing.Point(12, 29);
            this.LogOutputTextBox.Name = "LogOutputTextBox";
            this.LogOutputTextBox.ReadOnly = true;
            this.LogOutputTextBox.Size = new System.Drawing.Size(548, 464);
            this.LogOutputTextBox.TabIndex = 3;
            this.LogOutputTextBox.Text = "";
            this.LogOutputTextBox.TextChanged += new System.EventHandler(this.LogOutputTextBox_TextChanged);
            // 
            // FormTabsControl
            // 
            this.FormTabsControl.Controls.Add(this.tabPageSettings);
            this.FormTabsControl.Controls.Add(this.tabPageMETRO);
            this.FormTabsControl.Controls.Add(this.tabPageUtilites);
            this.FormTabsControl.Location = new System.Drawing.Point(566, 29);
            this.FormTabsControl.Name = "FormTabsControl";
            this.FormTabsControl.SelectedIndex = 0;
            this.FormTabsControl.Size = new System.Drawing.Size(269, 464);
            this.FormTabsControl.TabIndex = 0;
            // 
            // tabPageMETRO
            // 
            this.tabPageMETRO.Controls.Add(this.labelInfoDeleteMetroApps);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppXBOX);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppVoice);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppSolit);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppPhotos);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppPhone);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppPeopleOneNote);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppZune);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppBing);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteMailCalendarMaps);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteAppCamera);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteApp3d);
            this.tabPageMETRO.Controls.Add(this.checkBoxDeleteWindows10Apps);
            this.tabPageMETRO.Location = new System.Drawing.Point(4, 22);
            this.tabPageMETRO.Name = "tabPageMETRO";
            this.tabPageMETRO.Size = new System.Drawing.Size(261, 438);
            this.tabPageMETRO.TabIndex = 3;
            this.tabPageMETRO.Text = "Metro Apps";
            this.tabPageMETRO.UseVisualStyleBackColor = true;
            // 
            // labelInfoDeleteMetroApps
            // 
            this.labelInfoDeleteMetroApps.AutoSize = true;
            this.labelInfoDeleteMetroApps.BackColor = System.Drawing.Color.Transparent;
            this.labelInfoDeleteMetroApps.ForeColor = System.Drawing.Color.Red;
            this.labelInfoDeleteMetroApps.Location = new System.Drawing.Point(7, 0);
            this.labelInfoDeleteMetroApps.Name = "labelInfoDeleteMetroApps";
            this.labelInfoDeleteMetroApps.Size = new System.Drawing.Size(251, 13);
            this.labelInfoDeleteMetroApps.TabIndex = 33;
            this.labelInfoDeleteMetroApps.Text = "Be Aware if Metro Apps are deleted its permanent!";
            // 
            // checkBoxDeleteAppXBOX
            // 
            this.checkBoxDeleteAppXBOX.AutoSize = true;
            this.checkBoxDeleteAppXBOX.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppXBOX.Checked = true;
            this.checkBoxDeleteAppXBOX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppXBOX.Enabled = false;
            this.checkBoxDeleteAppXBOX.Location = new System.Drawing.Point(10, 200);
            this.checkBoxDeleteAppXBOX.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppXBOX.Name = "checkBoxDeleteAppXBOX";
            this.checkBoxDeleteAppXBOX.Size = new System.Drawing.Size(84, 17);
            this.checkBoxDeleteAppXBOX.TabIndex = 32;
            this.checkBoxDeleteAppXBOX.Text = "Delete XBoX";
            this.checkBoxDeleteAppXBOX.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppVoice
            // 
            this.checkBoxDeleteAppVoice.AutoSize = true;
            this.checkBoxDeleteAppVoice.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppVoice.Checked = true;
            this.checkBoxDeleteAppVoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppVoice.Enabled = false;
            this.checkBoxDeleteAppVoice.Location = new System.Drawing.Point(10, 183);
            this.checkBoxDeleteAppVoice.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppVoice.Name = "checkBoxDeleteAppVoice";
            this.checkBoxDeleteAppVoice.Size = new System.Drawing.Size(132, 17);
            this.checkBoxDeleteAppVoice.TabIndex = 31;
            this.checkBoxDeleteAppVoice.Text = "Delete Voice Recorder";
            this.checkBoxDeleteAppVoice.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppSolit
            // 
            this.checkBoxDeleteAppSolit.AutoSize = true;
            this.checkBoxDeleteAppSolit.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppSolit.Checked = true;
            this.checkBoxDeleteAppSolit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppSolit.Enabled = false;
            this.checkBoxDeleteAppSolit.Location = new System.Drawing.Point(10, 166);
            this.checkBoxDeleteAppSolit.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppSolit.Name = "checkBoxDeleteAppSolit";
            this.checkBoxDeleteAppSolit.Size = new System.Drawing.Size(147, 17);
            this.checkBoxDeleteAppSolit.TabIndex = 30;
            this.checkBoxDeleteAppSolit.Text = "Delete Solitaire Collection";
            this.checkBoxDeleteAppSolit.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppPhotos
            // 
            this.checkBoxDeleteAppPhotos.AutoSize = true;
            this.checkBoxDeleteAppPhotos.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppPhotos.Checked = true;
            this.checkBoxDeleteAppPhotos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppPhotos.Enabled = false;
            this.checkBoxDeleteAppPhotos.Location = new System.Drawing.Point(10, 149);
            this.checkBoxDeleteAppPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppPhotos.Name = "checkBoxDeleteAppPhotos";
            this.checkBoxDeleteAppPhotos.Size = new System.Drawing.Size(93, 17);
            this.checkBoxDeleteAppPhotos.TabIndex = 29;
            this.checkBoxDeleteAppPhotos.Text = "Delete Photos";
            this.checkBoxDeleteAppPhotos.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppPhone
            // 
            this.checkBoxDeleteAppPhone.AutoSize = true;
            this.checkBoxDeleteAppPhone.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppPhone.Checked = true;
            this.checkBoxDeleteAppPhone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppPhone.Enabled = false;
            this.checkBoxDeleteAppPhone.Location = new System.Drawing.Point(10, 132);
            this.checkBoxDeleteAppPhone.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppPhone.Name = "checkBoxDeleteAppPhone";
            this.checkBoxDeleteAppPhone.Size = new System.Drawing.Size(146, 17);
            this.checkBoxDeleteAppPhone.TabIndex = 28;
            this.checkBoxDeleteAppPhone.Text = "Delete Phone Companion";
            this.checkBoxDeleteAppPhone.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppPeopleOneNote
            // 
            this.checkBoxDeleteAppPeopleOneNote.AutoSize = true;
            this.checkBoxDeleteAppPeopleOneNote.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppPeopleOneNote.Checked = true;
            this.checkBoxDeleteAppPeopleOneNote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppPeopleOneNote.Enabled = false;
            this.checkBoxDeleteAppPeopleOneNote.Location = new System.Drawing.Point(10, 115);
            this.checkBoxDeleteAppPeopleOneNote.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppPeopleOneNote.Name = "checkBoxDeleteAppPeopleOneNote";
            this.checkBoxDeleteAppPeopleOneNote.Size = new System.Drawing.Size(159, 17);
            this.checkBoxDeleteAppPeopleOneNote.TabIndex = 27;
            this.checkBoxDeleteAppPeopleOneNote.Text = "Delete People and OneNote";
            this.checkBoxDeleteAppPeopleOneNote.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppZune
            // 
            this.checkBoxDeleteAppZune.AutoSize = true;
            this.checkBoxDeleteAppZune.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppZune.Checked = true;
            this.checkBoxDeleteAppZune.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppZune.Enabled = false;
            this.checkBoxDeleteAppZune.Location = new System.Drawing.Point(10, 98);
            this.checkBoxDeleteAppZune.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppZune.Name = "checkBoxDeleteAppZune";
            this.checkBoxDeleteAppZune.Size = new System.Drawing.Size(184, 17);
            this.checkBoxDeleteAppZune.TabIndex = 26;
            this.checkBoxDeleteAppZune.Text = "Delete Groove Music and Film TV ";
            this.checkBoxDeleteAppZune.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppBing
            // 
            this.checkBoxDeleteAppBing.AutoSize = true;
            this.checkBoxDeleteAppBing.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppBing.Checked = true;
            this.checkBoxDeleteAppBing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppBing.Enabled = false;
            this.checkBoxDeleteAppBing.Location = new System.Drawing.Point(10, 81);
            this.checkBoxDeleteAppBing.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppBing.Name = "checkBoxDeleteAppBing";
            this.checkBoxDeleteAppBing.Size = new System.Drawing.Size(229, 17);
            this.checkBoxDeleteAppBing.TabIndex = 25;
            this.checkBoxDeleteAppBing.Text = "Delete Money, Sports, News and Weather";
            this.checkBoxDeleteAppBing.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteMailCalendarMaps
            // 
            this.checkBoxDeleteMailCalendarMaps.AutoSize = true;
            this.checkBoxDeleteMailCalendarMaps.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteMailCalendarMaps.Checked = true;
            this.checkBoxDeleteMailCalendarMaps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteMailCalendarMaps.Enabled = false;
            this.checkBoxDeleteMailCalendarMaps.Location = new System.Drawing.Point(10, 64);
            this.checkBoxDeleteMailCalendarMaps.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteMailCalendarMaps.Name = "checkBoxDeleteMailCalendarMaps";
            this.checkBoxDeleteMailCalendarMaps.Size = new System.Drawing.Size(174, 17);
            this.checkBoxDeleteMailCalendarMaps.TabIndex = 24;
            this.checkBoxDeleteMailCalendarMaps.Text = "Delete Mail,Calendar and Maps";
            this.checkBoxDeleteMailCalendarMaps.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppCamera
            // 
            this.checkBoxDeleteAppCamera.AutoSize = true;
            this.checkBoxDeleteAppCamera.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppCamera.Checked = true;
            this.checkBoxDeleteAppCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppCamera.Enabled = false;
            this.checkBoxDeleteAppCamera.Location = new System.Drawing.Point(10, 47);
            this.checkBoxDeleteAppCamera.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppCamera.Name = "checkBoxDeleteAppCamera";
            this.checkBoxDeleteAppCamera.Size = new System.Drawing.Size(97, 17);
            this.checkBoxDeleteAppCamera.TabIndex = 23;
            this.checkBoxDeleteAppCamera.Text = "Delete Camera";
            this.checkBoxDeleteAppCamera.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteApp3d
            // 
            this.checkBoxDeleteApp3d.AutoSize = true;
            this.checkBoxDeleteApp3d.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteApp3d.Checked = true;
            this.checkBoxDeleteApp3d.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteApp3d.Enabled = false;
            this.checkBoxDeleteApp3d.Location = new System.Drawing.Point(10, 30);
            this.checkBoxDeleteApp3d.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteApp3d.Name = "checkBoxDeleteApp3d";
            this.checkBoxDeleteApp3d.Size = new System.Drawing.Size(108, 17);
            this.checkBoxDeleteApp3d.TabIndex = 22;
            this.checkBoxDeleteApp3d.Text = "Delete Builder 3D";
            this.checkBoxDeleteApp3d.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteWindows10Apps
            // 
            this.checkBoxDeleteWindows10Apps.AutoSize = true;
            this.checkBoxDeleteWindows10Apps.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteWindows10Apps.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBoxDeleteWindows10Apps.Location = new System.Drawing.Point(10, 13);
            this.checkBoxDeleteWindows10Apps.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteWindows10Apps.Name = "checkBoxDeleteWindows10Apps";
            this.checkBoxDeleteWindows10Apps.Size = new System.Drawing.Size(173, 17);
            this.checkBoxDeleteWindows10Apps.TabIndex = 21;
            this.checkBoxDeleteWindows10Apps.Text = "Delete windows 10 metro apps";
            this.checkBoxDeleteWindows10Apps.UseVisualStyleBackColor = false;
            this.checkBoxDeleteWindows10Apps.CheckedChanged += new System.EventHandler(this.checkBoxDeleteWindows10Apps_CheckedChanged_1);
            // 
            // lable_Title_Bar
            // 
            this.lable_Title_Bar.AutoSize = true;
            this.lable_Title_Bar.BackColor = System.Drawing.Color.Transparent;
            this.lable_Title_Bar.Enabled = false;
            this.lable_Title_Bar.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable_Title_Bar.ForeColor = System.Drawing.Color.White;
            this.lable_Title_Bar.Location = new System.Drawing.Point(8, 0);
            this.lable_Title_Bar.Name = "lable_Title_Bar";
            this.lable_Title_Bar.Size = new System.Drawing.Size(108, 23);
            this.lable_Title_Bar.TabIndex = 4;
            this.lable_Title_Bar.Text = "App Name";
            // 
            // checkBox_FixAdminAccount
            // 
            this.checkBox_FixAdminAccount.AutoSize = true;
            this.checkBox_FixAdminAccount.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_FixAdminAccount.Checked = true;
            this.checkBox_FixAdminAccount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FixAdminAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_FixAdminAccount.Location = new System.Drawing.Point(6, 384);
            this.checkBox_FixAdminAccount.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_FixAdminAccount.Name = "checkBox_FixAdminAccount";
            this.checkBox_FixAdminAccount.Size = new System.Drawing.Size(147, 17);
            this.checkBox_FixAdminAccount.TabIndex = 33;
            this.checkBox_FixAdminAccount.Text = "Fix Admin Account Rights";
            this.checkBox_FixAdminAccount.UseVisualStyleBackColor = false;
            // 
            // checkBox_DisableGameDVR
            // 
            this.checkBox_DisableGameDVR.AutoSize = true;
            this.checkBox_DisableGameDVR.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_DisableGameDVR.Checked = true;
            this.checkBox_DisableGameDVR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DisableGameDVR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_DisableGameDVR.Location = new System.Drawing.Point(6, 241);
            this.checkBox_DisableGameDVR.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_DisableGameDVR.Name = "checkBox_DisableGameDVR";
            this.checkBox_DisableGameDVR.Size = new System.Drawing.Size(137, 17);
            this.checkBox_DisableGameDVR.TabIndex = 34;
            this.checkBox_DisableGameDVR.Text = "Disable Xbox GameDVR";
            this.checkBox_DisableGameDVR.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::PSS_Windows_10_Privatizer.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(847, 541);
            this.Controls.Add(this.lable_Title_Bar);
            this.Controls.Add(this.ProgressBarStatus);
            this.Controls.Add(this.LogOutputTextBox);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.Button_Execite_Checked);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.FormTabsControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pro Silver Systems - Windows 10 Privatizer";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            this.tabPageUtilites.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxWindowsUpdate.ResumeLayout(false);
            this.groupBoxUACEdit.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.FormTabsControl.ResumeLayout(false);
            this.tabPageMETRO.ResumeLayout(false);
            this.tabPageMETRO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox CloseButton;
        private PictureBox MinimizeButton;
        private TabPage tabPageUtilites;
        private Button btnDisableOfficeUpdate;
        private Button btnDeleteOneDrive;
        private Button btnDeleteMetroAppsInfo;
        private GroupBox groupBoxWindowsUpdate;
        private Button btnEnableWindowsUpdate;
        private Button btnDisableWindowsUpdate;
        private GroupBox groupBoxUACEdit;
        private Button btnEnableUac;
        private Button btnDisableUac;
        private Button btnOpenAndEditHosts;
        private Button btnRestoreSystem;
        private Button btnDeleteAllWindows10Apps;
        private TabPage tabPageSettings;
        private CheckBox checkBoxOneDrive;
        private CheckBox checkBoxP2PWinUpdate;
        private CheckBox checkBoxDisableServices;
        private CheckBox checkBoxSPYTasks;
        private CheckBox checkBoxSetDefaultPhoto;
        private CheckBox checkBoxDisableWindowsDefender;
        private CheckBox checkBoxDisablePrivateSettings;
        private CheckBox checkBoxAddToHosts;
        private CheckBox checkBoxKeyLoggerAndTelemetry;
        private CheckBox checkBoxCreateSystemRestorePoint;
        private ProgressBar ProgressBarStatus;
        private Button Button_Execite_Checked;
        private RichTextBox LogOutputTextBox;
        private TabControl FormTabsControl;
        private CheckBox CheckboxUAC_Silent;
        private CheckBox checkBox_LockScreen;
        private Label lable_Title_Bar;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TabPage tabPageMETRO;
        private Label labelInfoDeleteMetroApps;
        private CheckBox checkBoxDeleteAppXBOX;
        private CheckBox checkBoxDeleteAppVoice;
        private CheckBox checkBoxDeleteAppSolit;
        private CheckBox checkBoxDeleteAppPhotos;
        private CheckBox checkBoxDeleteAppPhone;
        private CheckBox checkBoxDeleteAppPeopleOneNote;
        private CheckBox checkBoxDeleteAppZune;
        private CheckBox checkBoxDeleteAppBing;
        private CheckBox checkBoxDeleteMailCalendarMaps;
        private CheckBox checkBoxDeleteAppCamera;
        private CheckBox checkBoxDeleteApp3d;
        private CheckBox checkBoxDeleteWindows10Apps;
        private CheckBox checkBox_SecurityCenter;
        private CheckBox checkBox_ActionCenterActions;
        private CheckBox checkBox_StickyKeys;
        private CheckBox checkBox_SetDarkTheme;
        private CheckBox checkBox_Disable_ActionCenter;
        private CheckBox checkBox_DisableGameDVR;
        private CheckBox checkBox_FixAdminAccount;
    }
}

