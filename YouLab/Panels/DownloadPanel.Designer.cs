namespace YouLab.Panels
{
    partial class DownloadPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadPanel));
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.totalDownloadLabel = new MetroFramework.Controls.MetroLabel();
            this.closeLinkLabel = new MetroFramework.Controls.MetroLink();
            this.downloadPercentage = new MetroFramework.Controls.MetroLabel();
            this.downloadingStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.titleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qulityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.backLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.statusLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.statusLabel.Location = new System.Drawing.Point(47, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(126, 25);
            this.statusLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Geting Started";
            this.statusLabel.UseStyleColors = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(198, 9);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(38, 34);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressSpinner1.TabIndex = 8;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.UseStyleColors = true;
            this.metroProgressSpinner1.Value = 20;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(47, 383);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(679, 37);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Green;
            this.progressBar.TabIndex = 9;
            // 
            // totalDownloadLabel
            // 
            this.totalDownloadLabel.AutoSize = true;
            this.totalDownloadLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalDownloadLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalDownloadLabel.Location = new System.Drawing.Point(47, 68);
            this.totalDownloadLabel.Name = "totalDownloadLabel";
            this.totalDownloadLabel.Size = new System.Drawing.Size(39, 25);
            this.totalDownloadLabel.TabIndex = 11;
            this.totalDownloadLabel.Text = "0/0";
            // 
            // closeLinkLabel
            // 
            this.closeLinkLabel.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.closeLinkLabel.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.closeLinkLabel.Location = new System.Drawing.Point(549, 423);
            this.closeLinkLabel.Name = "closeLinkLabel";
            this.closeLinkLabel.Size = new System.Drawing.Size(177, 33);
            this.closeLinkLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.closeLinkLabel.TabIndex = 12;
            this.closeLinkLabel.Text = "Cancel Downloading";
            this.closeLinkLabel.UseSelectable = true;
            this.closeLinkLabel.UseStyleColors = true;
            this.closeLinkLabel.Click += new System.EventHandler(this.closeLinkLabel_Click);
            // 
            // downloadPercentage
            // 
            this.downloadPercentage.AutoSize = true;
            this.downloadPercentage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.downloadPercentage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.downloadPercentage.Location = new System.Drawing.Point(47, 423);
            this.downloadPercentage.Name = "downloadPercentage";
            this.downloadPercentage.Size = new System.Drawing.Size(37, 25);
            this.downloadPercentage.TabIndex = 13;
            this.downloadPercentage.Text = "0%";
            // 
            // downloadingStatusLabel
            // 
            this.downloadingStatusLabel.AutoSize = true;
            this.downloadingStatusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.downloadingStatusLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.downloadingStatusLabel.Location = new System.Drawing.Point(47, 355);
            this.downloadingStatusLabel.Name = "downloadingStatusLabel";
            this.downloadingStatusLabel.Size = new System.Drawing.Size(0, 0);
            this.downloadingStatusLabel.TabIndex = 14;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeColumns = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleCol,
            this.qulityCol,
            this.statusCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(47, 96);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.ReadOnly = true;
            this.metroGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(679, 239);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 17;
            this.metroGrid1.TabStop = false;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            // 
            // titleCol
            // 
            this.titleCol.HeaderText = "Title";
            this.titleCol.Name = "titleCol";
            this.titleCol.ReadOnly = true;
            this.titleCol.Width = 415;
            // 
            // qulityCol
            // 
            this.qulityCol.HeaderText = "Qulity";
            this.qulityCol.Name = "qulityCol";
            this.qulityCol.ReadOnly = true;
            this.qulityCol.Width = 110;
            // 
            // statusCol
            // 
            this.statusCol.HeaderText = "Status";
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusCol.Width = 110;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // backLink
            // 
            this.backLink.Enabled = false;
            this.backLink.Image = ((System.Drawing.Image)(resources.GetObject("backLink.Image")));
            this.backLink.ImageSize = 36;
            this.backLink.Location = new System.Drawing.Point(682, 9);
            this.backLink.Name = "backLink";
            this.backLink.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("backLink.NoFocusImage")));
            this.backLink.Size = new System.Drawing.Size(44, 40);
            this.backLink.TabIndex = 18;
            this.backLink.UseSelectable = true;
            this.backLink.Click += new System.EventHandler(this.backLink_Click);
            // 
            // DownloadPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.downloadingStatusLabel);
            this.Controls.Add(this.downloadPercentage);
            this.Controls.Add(this.closeLinkLabel);
            this.Controls.Add(this.totalDownloadLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.statusLabel);
            this.Name = "DownloadPanel";
            this.Size = new System.Drawing.Size(777, 500);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroLabel totalDownloadLabel;
        public MetroFramework.Controls.MetroLink closeLinkLabel;
        private MetroFramework.Controls.MetroLabel downloadPercentage;
        private MetroFramework.Controls.MetroLabel downloadingStatusLabel;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn qulityCol;
        private System.Windows.Forms.DataGridViewImageColumn statusCol;
        public MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink backLink;
    }
}
