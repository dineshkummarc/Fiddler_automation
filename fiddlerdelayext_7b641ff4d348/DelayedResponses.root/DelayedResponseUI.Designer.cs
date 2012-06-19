namespace Aetheon.FiddlerExtensions.DelayedResponses
{
    partial class DelayedResponsesUI
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.drConfigurationsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sessionDelayedPic = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.urlRegExFilterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentRegExFilterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delaySecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedRespondesDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drConfigurationsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDelayedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayedRespondesDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 596F));
            this.tableLayoutPanel1.Controls.Add(this.drConfigurationsGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 309);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // drConfigurationsGrid
            // 
            this.drConfigurationsGrid.AutoGenerateColumns = false;
            this.drConfigurationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drConfigurationsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drConfigurationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drConfigurationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.urlRegExFilterDataGridViewTextBoxColumn,
            this.contentRegExFilterDataGridViewTextBoxColumn,
            this.delaySecDataGridViewTextBoxColumn});
            this.drConfigurationsGrid.DataSource = this.delayedRespondesDataBindingSource;
            this.drConfigurationsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drConfigurationsGrid.Location = new System.Drawing.Point(3, 117);
            this.drConfigurationsGrid.Name = "drConfigurationsGrid";
            this.drConfigurationsGrid.Size = new System.Drawing.Size(590, 169);
            this.drConfigurationsGrid.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "Enabled";
            this.Column1.HeaderText = "Rule Enabled";
            this.Column1.IndeterminateValue = "True";
            this.Column1.Name = "Column1";
            this.Column1.Width = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delaying the response only works at fiddler proxy level. Statistical service info" +
                "rmation is not changed.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sessionDelayedPic);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 34);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select a session for Delay rules testing:";
            // 
            // sessionDelayedPic
            // 
            this.sessionDelayedPic.Location = new System.Drawing.Point(204, 3);
            this.sessionDelayedPic.Name = "sessionDelayedPic";
            this.sessionDelayedPic.Size = new System.Drawing.Size(62, 28);
            this.sessionDelayedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sessionDelayedPic.TabIndex = 1;
            this.sessionDelayedPic.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 289);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "about";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // urlRegExFilterDataGridViewTextBoxColumn
            // 
            this.urlRegExFilterDataGridViewTextBoxColumn.DataPropertyName = "UrlRegExFilter";
            this.urlRegExFilterDataGridViewTextBoxColumn.HeaderText = "Url (Regular Expression)";
            this.urlRegExFilterDataGridViewTextBoxColumn.Name = "urlRegExFilterDataGridViewTextBoxColumn";
            // 
            // contentRegExFilterDataGridViewTextBoxColumn
            // 
            this.contentRegExFilterDataGridViewTextBoxColumn.DataPropertyName = "ContentRegExFilter";
            this.contentRegExFilterDataGridViewTextBoxColumn.HeaderText = "Html Content (Regular Expression)";
            this.contentRegExFilterDataGridViewTextBoxColumn.Name = "contentRegExFilterDataGridViewTextBoxColumn";
            // 
            // delaySecDataGridViewTextBoxColumn
            // 
            this.delaySecDataGridViewTextBoxColumn.DataPropertyName = "DelaySec";
            this.delaySecDataGridViewTextBoxColumn.HeaderText = "Delaying Time (Seconds)";
            this.delaySecDataGridViewTextBoxColumn.Name = "delaySecDataGridViewTextBoxColumn";
            // 
            // delayedRespondesDataBindingSource
            // 
            this.delayedRespondesDataBindingSource.DataSource = typeof(Aetheon.FiddlerExtensions.DelayedResponses.DelayedResponsesInformation);
            // 
            // DelayedResponsesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DelayedResponsesUI";
            this.Size = new System.Drawing.Size(596, 309);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drConfigurationsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDelayedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayedRespondesDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource delayedRespondesDataBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView drConfigurationsGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox sessionDelayedPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlRegExFilterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentRegExFilterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delaySecDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}
