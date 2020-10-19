namespace SingleProject_BBC
{
    partial class CustomRecord
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
            this.lblNewMemberHeadLine = new System.Windows.Forms.Label();
            this.gbxBuyList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBuyList = new System.Windows.Forms.DataGridView();
            this.dgvRepairList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.tbxNewCID = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxBuyList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewMemberHeadLine
            // 
            this.lblNewMemberHeadLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewMemberHeadLine.AutoSize = true;
            this.lblNewMemberHeadLine.Font = new System.Drawing.Font("HY헤드라인M", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNewMemberHeadLine.Location = new System.Drawing.Point(695, 70);
            this.lblNewMemberHeadLine.Name = "lblNewMemberHeadLine";
            this.lblNewMemberHeadLine.Size = new System.Drawing.Size(212, 48);
            this.lblNewMemberHeadLine.TabIndex = 2;
            this.lblNewMemberHeadLine.Text = "방문내역";
            // 
            // gbxBuyList
            // 
            this.gbxBuyList.Controls.Add(this.dgvBuyList);
            this.gbxBuyList.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxBuyList.Location = new System.Drawing.Point(449, 156);
            this.gbxBuyList.Name = "gbxBuyList";
            this.gbxBuyList.Size = new System.Drawing.Size(536, 627);
            this.gbxBuyList.TabIndex = 3;
            this.gbxBuyList.TabStop = false;
            this.gbxBuyList.Text = "구매내역";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRepairList);
            this.groupBox1.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(1035, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 627);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "수리내역";
            // 
            // dgvBuyList
            // 
            this.dgvBuyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyList.Location = new System.Drawing.Point(13, 42);
            this.dgvBuyList.Name = "dgvBuyList";
            this.dgvBuyList.RowTemplate.Height = 23;
            this.dgvBuyList.Size = new System.Drawing.Size(507, 571);
            this.dgvBuyList.TabIndex = 0;
            // 
            // dgvRepairList
            // 
            this.dgvRepairList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepairList.Location = new System.Drawing.Point(15, 42);
            this.dgvRepairList.Name = "dgvRepairList";
            this.dgvRepairList.RowTemplate.Height = 23;
            this.dgvRepairList.Size = new System.Drawing.Size(507, 571);
            this.dgvRepairList.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblItemName);
            this.groupBox2.Controls.Add(this.tbxNewCID);
            this.groupBox2.Controls.Add(this.lblItemID);
            this.groupBox2.Font = new System.Drawing.Font("HY견고딕", 20F);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 613);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회원정보";
            // 
            // lblItemID
            // 
            this.lblItemID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemID.Location = new System.Drawing.Point(6, 42);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(93, 27);
            this.lblItemID.TabIndex = 19;
            this.lblItemID.Text = "아이디";
            // 
            // tbxNewCID
            // 
            this.tbxNewCID.Enabled = false;
            this.tbxNewCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxNewCID.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbxNewCID.Location = new System.Drawing.Point(11, 72);
            this.tbxNewCID.Name = "tbxNewCID";
            this.tbxNewCID.Size = new System.Drawing.Size(370, 38);
            this.tbxNewCID.TabIndex = 20;
            this.tbxNewCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemName.Location = new System.Drawing.Point(6, 135);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(93, 27);
            this.lblItemName.TabIndex = 21;
            this.lblItemName.Text = "성   함";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.textBox1.Location = new System.Drawing.Point(11, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 38);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "연락처";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.textBox2.Location = new System.Drawing.Point(6, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(370, 38);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1422, 800);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "취  소";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CustomRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBuyList);
            this.Controls.Add(this.lblNewMemberHeadLine);
            this.Name = "CustomRecord";
            this.Text = "CustomRecord";
            this.gbxBuyList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewMemberHeadLine;
        private System.Windows.Forms.GroupBox gbxBuyList;
        private System.Windows.Forms.DataGridView dgvBuyList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRepairList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox tbxNewCID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button button1;
    }
}