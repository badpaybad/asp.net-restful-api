namespace RestfulSample.DesktopApp
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHttpClient = new System.Windows.Forms.Button();
            this.btnSrGetAll = new System.Windows.Forms.Button();
            this.btnSampleResponse = new System.Windows.Forms.Button();
            this.btnIsValidToken = new System.Windows.Forms.Button();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.txtApiToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnListAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.txtFileToUpload = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.lblMsg);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnInsert);
            this.splitContainer1.Panel2.Controls.Add(this.txtValue);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtId);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 949);
            this.splitContainer1.SplitterDistance = 690;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel2.Controls.Add(this.txtSearch);
            this.splitContainer2.Panel2.Controls.Add(this.btnListAll);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.btnSearchById);
            this.splitContainer2.Size = new System.Drawing.Size(690, 949);
            this.splitContainer2.SplitterDistance = 325;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 28;
            this.dgvList.Size = new System.Drawing.Size(690, 325);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHttpClient);
            this.groupBox1.Controls.Add(this.btnSrGetAll);
            this.groupBox1.Controls.Add(this.btnSampleResponse);
            this.groupBox1.Controls.Add(this.btnIsValidToken);
            this.groupBox1.Controls.Add(this.btnGetToken);
            this.groupBox1.Controls.Add(this.txtApiToken);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApiKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 401);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ApiSession";
            // 
            // btnHttpClient
            // 
            this.btnHttpClient.Location = new System.Drawing.Point(323, 269);
            this.btnHttpClient.Name = "btnHttpClient";
            this.btnHttpClient.Size = new System.Drawing.Size(299, 35);
            this.btnHttpClient.TabIndex = 14;
            this.btnHttpClient.Text = "SampeResponse GetAll HttpClient";
            this.btnHttpClient.UseVisualStyleBackColor = true;
            this.btnHttpClient.Click += new System.EventHandler(this.btnHttpClient_Click);
            // 
            // btnSrGetAll
            // 
            this.btnSrGetAll.Location = new System.Drawing.Point(323, 209);
            this.btnSrGetAll.Name = "btnSrGetAll";
            this.btnSrGetAll.Size = new System.Drawing.Size(299, 35);
            this.btnSrGetAll.TabIndex = 13;
            this.btnSrGetAll.Text = "SampeResponse GetAll";
            this.btnSrGetAll.UseVisualStyleBackColor = true;
            this.btnSrGetAll.Click += new System.EventHandler(this.btnSrGetAll_Click);
            // 
            // btnSampleResponse
            // 
            this.btnSampleResponse.Location = new System.Drawing.Point(323, 154);
            this.btnSampleResponse.Name = "btnSampleResponse";
            this.btnSampleResponse.Size = new System.Drawing.Size(299, 35);
            this.btnSampleResponse.TabIndex = 12;
            this.btnSampleResponse.Text = "SampeResponse GetById=1";
            this.btnSampleResponse.UseVisualStyleBackColor = true;
            this.btnSampleResponse.Click += new System.EventHandler(this.btnSampleResponse_Click);
            // 
            // btnIsValidToken
            // 
            this.btnIsValidToken.Location = new System.Drawing.Point(481, 96);
            this.btnIsValidToken.Name = "btnIsValidToken";
            this.btnIsValidToken.Size = new System.Drawing.Size(141, 35);
            this.btnIsValidToken.TabIndex = 11;
            this.btnIsValidToken.Text = "IsValidToken";
            this.btnIsValidToken.UseVisualStyleBackColor = true;
            this.btnIsValidToken.Click += new System.EventHandler(this.btnIsValidToken_Click);
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(481, 41);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(141, 35);
            this.btnGetToken.TabIndex = 10;
            this.btnGetToken.Text = "GetToken";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // txtApiToken
            // 
            this.txtApiToken.Location = new System.Drawing.Point(105, 100);
            this.txtApiToken.Name = "txtApiToken";
            this.txtApiToken.Size = new System.Drawing.Size(360, 26);
            this.txtApiToken.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Token";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(105, 45);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(360, 26);
            this.txtApiKey.TabIndex = 1;
            this.txtApiKey.Text = "4488B32B730142409E73E742F16494B3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ApiKey";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(271, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(428, 24);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(141, 35);
            this.btnListAll.TabIndex = 7;
            this.btnListAll.Text = "List All";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "keywords";
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(271, 24);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(141, 35);
            this.btnSearchById.TabIndex = 5;
            this.btnSearchById.Text = "Search by Id";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUploadFile);
            this.groupBox2.Controls.Add(this.txtFileToUpload);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Location = new System.Drawing.Point(54, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 141);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose file to upload";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(23, 73);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(259, 35);
            this.btnUploadFile.TabIndex = 17;
            this.btnUploadFile.Text = "UploadFileBy64BaseString";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // txtFileToUpload
            // 
            this.txtFileToUpload.Location = new System.Drawing.Point(23, 29);
            this.txtFileToUpload.Name = "txtFileToUpload";
            this.txtFileToUpload.Size = new System.Drawing.Size(209, 26);
            this.txtFileToUpload.TabIndex = 15;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(238, 25);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(44, 33);
            this.btnSelectFile.TabIndex = 16;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(62, 238);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(54, 20);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "lblMsg";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(308, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(308, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(308, 51);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 35);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(55, 182);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(183, 26);
            this.txtValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 95);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(187, 26);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 949);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Sample client to work with restful";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApiToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIsValidToken;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Button btnSampleResponse;
        private System.Windows.Forms.Button btnSrGetAll;
        private System.Windows.Forms.Button btnHttpClient;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileToUpload;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

