namespace DatabaseTest
{
    partial class ManagementStudioVeryLight
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
            if(disposing && (components != null))
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
            this.tcQuery = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.tpResult = new System.Windows.Forms.TabPage();
            this.tcResults = new System.Windows.Forms.TabControl();
            this.tpGrid = new System.Windows.Forms.TabPage();
            this.dgvResultGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tpMessages = new System.Windows.Forms.TabPage();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.tpManagement = new System.Windows.Forms.TabPage();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.txtScriptResult = new System.Windows.Forms.TextBox();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.gbExtension = new System.Windows.Forms.GroupBox();
            this.clbExtensions = new System.Windows.Forms.CheckedListBox();
            this.gbScriptPath = new System.Windows.Forms.GroupBox();
            this.btnGetPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.fbdScriptPath = new System.Windows.Forms.FolderBrowserDialog();
            this.tcQuery.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpResult.SuspendLayout();
            this.tcResults.SuspendLayout();
            this.tpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tpMessages.SuspendLayout();
            this.tpManagement.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbExtension.SuspendLayout();
            this.gbScriptPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuery
            // 
            this.tcQuery.Controls.Add(this.tabPage1);
            this.tcQuery.Controls.Add(this.tpResult);
            this.tcQuery.Controls.Add(this.tpManagement);
            this.tcQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuery.Location = new System.Drawing.Point(0, 0);
            this.tcQuery.Name = "tcQuery";
            this.tcQuery.SelectedIndex = 0;
            this.tcQuery.Size = new System.Drawing.Size(585, 378);
            this.tcQuery.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRun);
            this.tabPage1.Controls.Add(this.txtQuery);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRun.Location = new System.Drawing.Point(539, 322);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(35, 27);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuery.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtQuery.Location = new System.Drawing.Point(3, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(571, 319);
            this.txtQuery.TabIndex = 0;
            // 
            // tpResult
            // 
            this.tpResult.Controls.Add(this.tcResults);
            this.tpResult.Location = new System.Drawing.Point(4, 22);
            this.tpResult.Name = "tpResult";
            this.tpResult.Padding = new System.Windows.Forms.Padding(3);
            this.tpResult.Size = new System.Drawing.Size(577, 352);
            this.tpResult.TabIndex = 1;
            this.tpResult.Text = "Result";
            this.tpResult.UseVisualStyleBackColor = true;
            // 
            // tcResults
            // 
            this.tcResults.Controls.Add(this.tpGrid);
            this.tcResults.Controls.Add(this.tabPage3);
            this.tcResults.Controls.Add(this.tpMessages);
            this.tcResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcResults.Location = new System.Drawing.Point(3, 3);
            this.tcResults.Name = "tcResults";
            this.tcResults.SelectedIndex = 0;
            this.tcResults.Size = new System.Drawing.Size(571, 346);
            this.tcResults.TabIndex = 2;
            // 
            // tpGrid
            // 
            this.tpGrid.Controls.Add(this.dgvResultGrid);
            this.tpGrid.Location = new System.Drawing.Point(4, 22);
            this.tpGrid.Name = "tpGrid";
            this.tpGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrid.Size = new System.Drawing.Size(563, 320);
            this.tpGrid.TabIndex = 0;
            this.tpGrid.Text = "Grid";
            this.tpGrid.UseVisualStyleBackColor = true;
            // 
            // dgvResultGrid
            // 
            this.dgvResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultGrid.Location = new System.Drawing.Point(3, 3);
            this.dgvResultGrid.Name = "dgvResultGrid";
            this.dgvResultGrid.Size = new System.Drawing.Size(557, 314);
            this.dgvResultGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtResult);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(563, 320);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Text";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(557, 314);
            this.txtResult.TabIndex = 0;
            // 
            // tpMessages
            // 
            this.tpMessages.Controls.Add(this.txtMessages);
            this.tpMessages.Location = new System.Drawing.Point(4, 22);
            this.tpMessages.Name = "tpMessages";
            this.tpMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tpMessages.Size = new System.Drawing.Size(563, 320);
            this.tpMessages.TabIndex = 2;
            this.tpMessages.Text = "Messages";
            this.tpMessages.UseVisualStyleBackColor = true;
            // 
            // txtMessages
            // 
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(3, 3);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(557, 314);
            this.txtMessages.TabIndex = 1;
            // 
            // tpManagement
            // 
            this.tpManagement.Controls.Add(this.gbResult);
            this.tpManagement.Controls.Add(this.gbExtension);
            this.tpManagement.Controls.Add(this.gbScriptPath);
            this.tpManagement.Location = new System.Drawing.Point(4, 22);
            this.tpManagement.Name = "tpManagement";
            this.tpManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tpManagement.Size = new System.Drawing.Size(577, 352);
            this.tpManagement.TabIndex = 2;
            this.tpManagement.Text = "Management";
            this.tpManagement.UseVisualStyleBackColor = true;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.txtScriptResult);
            this.gbResult.Controls.Add(this.btnRunScript);
            this.gbResult.Enabled = false;
            this.gbResult.Location = new System.Drawing.Point(209, 51);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(362, 296);
            this.gbResult.TabIndex = 4;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // txtScriptResult
            // 
            this.txtScriptResult.Location = new System.Drawing.Point(6, 45);
            this.txtScriptResult.Multiline = true;
            this.txtScriptResult.Name = "txtScriptResult";
            this.txtScriptResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScriptResult.Size = new System.Drawing.Size(350, 248);
            this.txtScriptResult.TabIndex = 4;
            // 
            // btnRunScript
            // 
            this.btnRunScript.Location = new System.Drawing.Point(281, 16);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(75, 23);
            this.btnRunScript.TabIndex = 3;
            this.btnRunScript.Text = "Execute";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // gbExtension
            // 
            this.gbExtension.Controls.Add(this.clbExtensions);
            this.gbExtension.Enabled = false;
            this.gbExtension.Location = new System.Drawing.Point(3, 51);
            this.gbExtension.Name = "gbExtension";
            this.gbExtension.Size = new System.Drawing.Size(200, 296);
            this.gbExtension.TabIndex = 2;
            this.gbExtension.TabStop = false;
            this.gbExtension.Text = "Extensions";
            // 
            // clbExtensions
            // 
            this.clbExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbExtensions.FormattingEnabled = true;
            this.clbExtensions.Location = new System.Drawing.Point(3, 16);
            this.clbExtensions.Name = "clbExtensions";
            this.clbExtensions.Size = new System.Drawing.Size(194, 277);
            this.clbExtensions.TabIndex = 1;
            this.clbExtensions.SelectedValueChanged += new System.EventHandler(this.clbExtensions_SelectedValueChanged);
            // 
            // gbScriptPath
            // 
            this.gbScriptPath.Controls.Add(this.btnGetPath);
            this.gbScriptPath.Controls.Add(this.txtPath);
            this.gbScriptPath.Location = new System.Drawing.Point(3, 3);
            this.gbScriptPath.Name = "gbScriptPath";
            this.gbScriptPath.Size = new System.Drawing.Size(568, 44);
            this.gbScriptPath.TabIndex = 0;
            this.gbScriptPath.TabStop = false;
            this.gbScriptPath.Text = "Script path";
            // 
            // btnGetPath
            // 
            this.btnGetPath.Location = new System.Drawing.Point(512, 15);
            this.btnGetPath.Name = "btnGetPath";
            this.btnGetPath.Size = new System.Drawing.Size(50, 23);
            this.btnGetPath.TabIndex = 1;
            this.btnGetPath.Text = "Path...";
            this.btnGetPath.UseVisualStyleBackColor = true;
            this.btnGetPath.Click += new System.EventHandler(this.btnGetPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(7, 16);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(498, 20);
            this.txtPath.TabIndex = 0;
            // 
            // ManagementStudioVeryLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 378);
            this.Controls.Add(this.tcQuery);
            this.Name = "ManagementStudioVeryLight";
            this.Text = "ManagementStudioVeryLight";
            this.tcQuery.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpResult.ResumeLayout(false);
            this.tcResults.ResumeLayout(false);
            this.tpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tpMessages.ResumeLayout(false);
            this.tpMessages.PerformLayout();
            this.tpManagement.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbExtension.ResumeLayout(false);
            this.gbScriptPath.ResumeLayout(false);
            this.gbScriptPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuery;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TabPage tpResult;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TabControl tcResults;
        private System.Windows.Forms.TabPage tpGrid;
        private System.Windows.Forms.DataGridView dgvResultGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tpMessages;
        private System.Windows.Forms.TabPage tpManagement;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.TextBox txtScriptResult;
        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.GroupBox gbExtension;
        private System.Windows.Forms.CheckedListBox clbExtensions;
        private System.Windows.Forms.GroupBox gbScriptPath;
        private System.Windows.Forms.Button btnGetPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog fbdScriptPath;
    }
}