﻿namespace NTFSSecurity
{
    partial class ShowSimpleAccessForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSimpleAccessForm));
            this.trvDirectories = new System.Windows.Forms.TreeView();
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.lstPermissions = new System.Windows.Forms.ListView();
            this.chdIdentity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdRights = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdAccessControlType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkRemoveFoldersWithoutAccess = new System.Windows.Forms.CheckBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.grpSearchForIdentity = new System.Windows.Forms.GroupBox();
            this.btnSearchForIdentityNext = new System.Windows.Forms.Button();
            this.btnSearchForIdentityPrev = new System.Windows.Forms.Button();
            this.txtSearchForIdentity = new System.Windows.Forms.TextBox();
            this.btnSearchForIdentity = new System.Windows.Forms.Button();
            this.grpSearchForFolder = new System.Windows.Forms.GroupBox();
            this.btnSearchForFolderPrev = new System.Windows.Forms.Button();
            this.btnSearchForFolderNext = new System.Windows.Forms.Button();
            this.btnSearchForFolder = new System.Windows.Forms.Button();
            this.txtSearchForFolder = new System.Windows.Forms.TextBox();
            this.labDirectoryTreeView = new System.Windows.Forms.Label();
            this.labAccessView = new System.Windows.Forms.Label();
            this.ttSearchForFolder = new System.Windows.Forms.ToolTip(this.components);
            this.grpFilter.SuspendLayout();
            this.grpSearchForIdentity.SuspendLayout();
            this.grpSearchForFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDirectories
            // 
            this.trvDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvDirectories.ImageIndex = 0;
            this.trvDirectories.ImageList = this.imlIcons;
            this.trvDirectories.Location = new System.Drawing.Point(12, 29);
            this.trvDirectories.Name = "trvDirectories";
            this.trvDirectories.SelectedImageIndex = 0;
            this.trvDirectories.Size = new System.Drawing.Size(320, 574);
            this.trvDirectories.TabIndex = 0;
            this.trvDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDirectories_AfterSelect);
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "container.jpg");
            // 
            // lstPermissions
            // 
            this.lstPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPermissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIdentity,
            this.chdRights,
            this.chdAccessControlType});
            this.lstPermissions.Location = new System.Drawing.Point(338, 29);
            this.lstPermissions.Name = "lstPermissions";
            this.lstPermissions.Size = new System.Drawing.Size(480, 342);
            this.lstPermissions.SmallImageList = this.imlIcons;
            this.lstPermissions.TabIndex = 1;
            this.lstPermissions.UseCompatibleStateImageBehavior = false;
            this.lstPermissions.View = System.Windows.Forms.View.Details;
            // 
            // chdIdentity
            // 
            this.chdIdentity.Text = "Identity";
            // 
            // chdRights
            // 
            this.chdRights.Text = "Rights";
            // 
            // chdAccessControlType
            // 
            this.chdAccessControlType.Text = "AccessControlType";
            // 
            // chkRemoveFoldersWithoutAccess
            // 
            this.chkRemoveFoldersWithoutAccess.AutoSize = true;
            this.chkRemoveFoldersWithoutAccess.Location = new System.Drawing.Point(6, 19);
            this.chkRemoveFoldersWithoutAccess.Name = "chkRemoveFoldersWithoutAccess";
            this.chkRemoveFoldersWithoutAccess.Size = new System.Drawing.Size(347, 17);
            this.chkRemoveFoldersWithoutAccess.TabIndex = 2;
            this.chkRemoveFoldersWithoutAccess.Text = "Remove Folders that do not have different access than their parents";
            this.chkRemoveFoldersWithoutAccess.UseVisualStyleBackColor = true;
            this.chkRemoveFoldersWithoutAccess.CheckedChanged += new System.EventHandler(this.chkRemoveFoldersWithoutAccess_CheckedChanged);
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.grpSearchForIdentity);
            this.grpFilter.Controls.Add(this.grpSearchForFolder);
            this.grpFilter.Controls.Add(this.chkRemoveFoldersWithoutAccess);
            this.grpFilter.Location = new System.Drawing.Point(338, 377);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(480, 226);
            this.grpFilter.TabIndex = 3;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // grpSearchForIdentity
            // 
            this.grpSearchForIdentity.Controls.Add(this.btnSearchForIdentityNext);
            this.grpSearchForIdentity.Controls.Add(this.btnSearchForIdentityPrev);
            this.grpSearchForIdentity.Controls.Add(this.txtSearchForIdentity);
            this.grpSearchForIdentity.Controls.Add(this.btnSearchForIdentity);
            this.grpSearchForIdentity.Location = new System.Drawing.Point(9, 125);
            this.grpSearchForIdentity.Name = "grpSearchForIdentity";
            this.grpSearchForIdentity.Size = new System.Drawing.Size(384, 95);
            this.grpSearchForIdentity.TabIndex = 4;
            this.grpSearchForIdentity.TabStop = false;
            this.grpSearchForIdentity.Text = "Search for Identity";
            // 
            // btnSearchForIdentityNext
            // 
            this.btnSearchForIdentityNext.Enabled = false;
            this.btnSearchForIdentityNext.Location = new System.Drawing.Point(222, 45);
            this.btnSearchForIdentityNext.Name = "btnSearchForIdentityNext";
            this.btnSearchForIdentityNext.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForIdentityNext.TabIndex = 7;
            this.btnSearchForIdentityNext.Text = "Prev";
            this.btnSearchForIdentityNext.UseVisualStyleBackColor = true;
            this.btnSearchForIdentityNext.Click += new System.EventHandler(this.btnSearchForIdentityNext_Click);
            // 
            // btnSearchForIdentityPrev
            // 
            this.btnSearchForIdentityPrev.Enabled = false;
            this.btnSearchForIdentityPrev.Location = new System.Drawing.Point(303, 45);
            this.btnSearchForIdentityPrev.Name = "btnSearchForIdentityPrev";
            this.btnSearchForIdentityPrev.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForIdentityPrev.TabIndex = 6;
            this.btnSearchForIdentityPrev.Text = "Next";
            this.btnSearchForIdentityPrev.UseVisualStyleBackColor = true;
            this.btnSearchForIdentityPrev.Click += new System.EventHandler(this.btnSearchForIdentityPrev_Click);
            // 
            // txtSearchForIdentity
            // 
            this.txtSearchForIdentity.Location = new System.Drawing.Point(3, 19);
            this.txtSearchForIdentity.Name = "txtSearchForIdentity";
            this.txtSearchForIdentity.Size = new System.Drawing.Size(341, 20);
            this.txtSearchForIdentity.TabIndex = 4;
            // 
            // btnSearchForIdentity
            // 
            this.btnSearchForIdentity.Location = new System.Drawing.Point(350, 17);
            this.btnSearchForIdentity.Name = "btnSearchForIdentity";
            this.btnSearchForIdentity.Size = new System.Drawing.Size(28, 23);
            this.btnSearchForIdentity.TabIndex = 5;
            this.btnSearchForIdentity.Text = "Go";
            this.btnSearchForIdentity.UseVisualStyleBackColor = true;
            this.btnSearchForIdentity.Click += new System.EventHandler(this.btnSearchForIdentity_Click);
            // 
            // grpSearchForFolder
            // 
            this.grpSearchForFolder.Controls.Add(this.btnSearchForFolderPrev);
            this.grpSearchForFolder.Controls.Add(this.btnSearchForFolderNext);
            this.grpSearchForFolder.Controls.Add(this.btnSearchForFolder);
            this.grpSearchForFolder.Controls.Add(this.txtSearchForFolder);
            this.grpSearchForFolder.Location = new System.Drawing.Point(6, 42);
            this.grpSearchForFolder.Name = "grpSearchForFolder";
            this.grpSearchForFolder.Size = new System.Drawing.Size(387, 77);
            this.grpSearchForFolder.TabIndex = 3;
            this.grpSearchForFolder.TabStop = false;
            this.grpSearchForFolder.Text = "Search for Folder";
            this.ttSearchForFolder.SetToolTip(this.grpSearchForFolder, "\"Search for folder\" lets you search in the tree view for the");
            // 
            // btnSearchForFolderPrev
            // 
            this.btnSearchForFolderPrev.Enabled = false;
            this.btnSearchForFolderPrev.Location = new System.Drawing.Point(225, 45);
            this.btnSearchForFolderPrev.Name = "btnSearchForFolderPrev";
            this.btnSearchForFolderPrev.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForFolderPrev.TabIndex = 3;
            this.btnSearchForFolderPrev.Text = "Prev";
            this.btnSearchForFolderPrev.UseVisualStyleBackColor = true;
            this.btnSearchForFolderPrev.Click += new System.EventHandler(this.btnSearchForFolderPrev_Click);
            // 
            // btnSearchForFolderNext
            // 
            this.btnSearchForFolderNext.Enabled = false;
            this.btnSearchForFolderNext.Location = new System.Drawing.Point(306, 45);
            this.btnSearchForFolderNext.Name = "btnSearchForFolderNext";
            this.btnSearchForFolderNext.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForFolderNext.TabIndex = 2;
            this.btnSearchForFolderNext.Text = "Next";
            this.btnSearchForFolderNext.UseVisualStyleBackColor = true;
            this.btnSearchForFolderNext.Click += new System.EventHandler(this.btnSearchForFolderNext_Click);
            // 
            // btnSearchForFolder
            // 
            this.btnSearchForFolder.Location = new System.Drawing.Point(353, 17);
            this.btnSearchForFolder.Name = "btnSearchForFolder";
            this.btnSearchForFolder.Size = new System.Drawing.Size(28, 23);
            this.btnSearchForFolder.TabIndex = 1;
            this.btnSearchForFolder.Text = "Go";
            this.btnSearchForFolder.UseVisualStyleBackColor = true;
            this.btnSearchForFolder.Click += new System.EventHandler(this.btnSearchForFolder_Click);
            // 
            // txtSearchForFolder
            // 
            this.txtSearchForFolder.Location = new System.Drawing.Point(6, 19);
            this.txtSearchForFolder.Name = "txtSearchForFolder";
            this.txtSearchForFolder.Size = new System.Drawing.Size(341, 20);
            this.txtSearchForFolder.TabIndex = 0;
            this.ttSearchForFolder.SetToolTip(this.txtSearchForFolder, "\"Search for folder\" lets you search in the tree view for the");
            // 
            // labDirectoryTreeView
            // 
            this.labDirectoryTreeView.AutoSize = true;
            this.labDirectoryTreeView.Location = new System.Drawing.Point(13, 13);
            this.labDirectoryTreeView.Name = "labDirectoryTreeView";
            this.labDirectoryTreeView.Size = new System.Drawing.Size(57, 13);
            this.labDirectoryTreeView.TabIndex = 4;
            this.labDirectoryTreeView.Text = "Directories";
            // 
            // labAccessView
            // 
            this.labAccessView.AutoSize = true;
            this.labAccessView.Location = new System.Drawing.Point(344, 12);
            this.labAccessView.Name = "labAccessView";
            this.labAccessView.Size = new System.Drawing.Size(202, 13);
            this.labAccessView.TabIndex = 5;
            this.labAccessView.Text = "Permissions given on the seletcted object";
            // 
            // ttSearchForFolder
            // 
            this.ttSearchForFolder.IsBalloon = true;
            this.ttSearchForFolder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ShowSimpleAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 615);
            this.Controls.Add(this.labAccessView);
            this.Controls.Add(this.labDirectoryTreeView);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lstPermissions);
            this.Controls.Add(this.trvDirectories);
            this.Name = "ShowSimpleAccessForm";
            this.Text = "ShowAccess";
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpSearchForIdentity.ResumeLayout(false);
            this.grpSearchForIdentity.PerformLayout();
            this.grpSearchForFolder.ResumeLayout(false);
            this.grpSearchForFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvDirectories;
        private System.Windows.Forms.ListView lstPermissions;
        private System.Windows.Forms.ColumnHeader chdIdentity;
        private System.Windows.Forms.ColumnHeader chdRights;
        private System.Windows.Forms.ColumnHeader chdAccessControlType;
        private System.Windows.Forms.ImageList imlIcons;
        private System.Windows.Forms.CheckBox chkRemoveFoldersWithoutAccess;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label labDirectoryTreeView;
        private System.Windows.Forms.Label labAccessView;
        private System.Windows.Forms.GroupBox grpSearchForFolder;
        private System.Windows.Forms.Button btnSearchForFolder;
        private System.Windows.Forms.TextBox txtSearchForFolder;
        private System.Windows.Forms.Button btnSearchForFolderNext;
        private System.Windows.Forms.Button btnSearchForFolderPrev;
        private System.Windows.Forms.GroupBox grpSearchForIdentity;
        private System.Windows.Forms.Button btnSearchForIdentityNext;
        private System.Windows.Forms.Button btnSearchForIdentityPrev;
        private System.Windows.Forms.TextBox txtSearchForIdentity;
        private System.Windows.Forms.Button btnSearchForIdentity;
        private System.Windows.Forms.ToolTip ttSearchForFolder;

    }
}