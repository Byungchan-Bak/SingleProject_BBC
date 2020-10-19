namespace SingleProject_BBC
{
    partial class SearchMember
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbHobby = new System.Windows.Forms.GroupBox();
            this.gbKey = new System.Windows.Forms.GroupBox();
            this.cbKeyEtc = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbAccordion = new System.Windows.Forms.CheckBox();
            this.cbSynthesizer = new System.Windows.Forms.CheckBox();
            this.gbLine = new System.Windows.Forms.GroupBox();
            this.cbLineEtc = new System.Windows.Forms.CheckBox();
            this.cbAGuitar = new System.Windows.Forms.CheckBox();
            this.cbEGuitar = new System.Windows.Forms.CheckBox();
            this.cbCGuitar = new System.Windows.Forms.CheckBox();
            this.gbHit = new System.Windows.Forms.GroupBox();
            this.cbHitEtc = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbDjembe = new System.Windows.Forms.CheckBox();
            this.cbCajon = new System.Windows.Forms.CheckBox();
            this.gbBlow = new System.Windows.Forms.GroupBox();
            this.cbBlowEtc = new System.Windows.Forms.CheckBox();
            this.cbOcarina = new System.Windows.Forms.CheckBox();
            this.cbHarmonica = new System.Windows.Forms.CheckBox();
            this.cbFlute = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSearchLCNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSearchFCNum = new System.Windows.Forms.ComboBox();
            this.tbxSearchSCNum = new System.Windows.Forms.TextBox();
            this.tbxSearchCName = new System.Windows.Forms.TextBox();
            this.tbxNewCID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.libSMember = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMemberUpdate = new System.Windows.Forms.Button();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.btnMRecorde = new System.Windows.Forms.Button();
            this.gbHobby.SuspendLayout();
            this.gbKey.SuspendLayout();
            this.gbLine.SuspendLayout();
            this.gbHit.SuspendLayout();
            this.gbBlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.lblNewMemberHeadLine.TabIndex = 1;
            this.lblNewMemberHeadLine.Text = "회원조회";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemName.Location = new System.Drawing.Point(1211, 242);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(121, 27);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "성   함 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1036, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "연락처 : ";
            // 
            // gbHobby
            // 
            this.gbHobby.Controls.Add(this.gbKey);
            this.gbHobby.Controls.Add(this.gbLine);
            this.gbHobby.Controls.Add(this.gbHit);
            this.gbHobby.Controls.Add(this.gbBlow);
            this.gbHobby.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbHobby.Location = new System.Drawing.Point(547, 354);
            this.gbHobby.Name = "gbHobby";
            this.gbHobby.Size = new System.Drawing.Size(991, 350);
            this.gbHobby.TabIndex = 9;
            this.gbHobby.TabStop = false;
            this.gbHobby.Text = "관심분야";
            // 
            // gbKey
            // 
            this.gbKey.Controls.Add(this.cbKeyEtc);
            this.gbKey.Controls.Add(this.cbPiano);
            this.gbKey.Controls.Add(this.cbAccordion);
            this.gbKey.Controls.Add(this.cbSynthesizer);
            this.gbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbKey.Location = new System.Drawing.Point(789, 45);
            this.gbKey.Name = "gbKey";
            this.gbKey.Size = new System.Drawing.Size(180, 280);
            this.gbKey.TabIndex = 1;
            this.gbKey.TabStop = false;
            this.gbKey.Text = "건반악기";
            // 
            // cbKeyEtc
            // 
            this.cbKeyEtc.AutoSize = true;
            this.cbKeyEtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbKeyEtc.Location = new System.Drawing.Point(29, 221);
            this.cbKeyEtc.Name = "cbKeyEtc";
            this.cbKeyEtc.Size = new System.Drawing.Size(57, 20);
            this.cbKeyEtc.TabIndex = 15;
            this.cbKeyEtc.Text = "없음";
            this.cbKeyEtc.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbPiano.Location = new System.Drawing.Point(29, 65);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(72, 20);
            this.cbPiano.TabIndex = 12;
            this.cbPiano.Text = "피아노";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbAccordion
            // 
            this.cbAccordion.AutoSize = true;
            this.cbAccordion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAccordion.Location = new System.Drawing.Point(29, 169);
            this.cbAccordion.Name = "cbAccordion";
            this.cbAccordion.Size = new System.Drawing.Size(87, 20);
            this.cbAccordion.TabIndex = 14;
            this.cbAccordion.Text = "아코디언";
            this.cbAccordion.UseVisualStyleBackColor = true;
            // 
            // cbSynthesizer
            // 
            this.cbSynthesizer.AutoSize = true;
            this.cbSynthesizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSynthesizer.Location = new System.Drawing.Point(29, 117);
            this.cbSynthesizer.Name = "cbSynthesizer";
            this.cbSynthesizer.Size = new System.Drawing.Size(102, 20);
            this.cbSynthesizer.TabIndex = 13;
            this.cbSynthesizer.Text = "신시사이저";
            this.cbSynthesizer.UseVisualStyleBackColor = true;
            // 
            // gbLine
            // 
            this.gbLine.Controls.Add(this.cbLineEtc);
            this.gbLine.Controls.Add(this.cbAGuitar);
            this.gbLine.Controls.Add(this.cbEGuitar);
            this.gbLine.Controls.Add(this.cbCGuitar);
            this.gbLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbLine.Location = new System.Drawing.Point(533, 45);
            this.gbLine.Name = "gbLine";
            this.gbLine.Size = new System.Drawing.Size(180, 280);
            this.gbLine.TabIndex = 1;
            this.gbLine.TabStop = false;
            this.gbLine.Text = "현악기";
            // 
            // cbLineEtc
            // 
            this.cbLineEtc.AutoSize = true;
            this.cbLineEtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbLineEtc.Location = new System.Drawing.Point(29, 221);
            this.cbLineEtc.Name = "cbLineEtc";
            this.cbLineEtc.Size = new System.Drawing.Size(57, 20);
            this.cbLineEtc.TabIndex = 11;
            this.cbLineEtc.Text = "없음";
            this.cbLineEtc.UseVisualStyleBackColor = true;
            // 
            // cbAGuitar
            // 
            this.cbAGuitar.AutoSize = true;
            this.cbAGuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAGuitar.Location = new System.Drawing.Point(29, 65);
            this.cbAGuitar.Name = "cbAGuitar";
            this.cbAGuitar.Size = new System.Drawing.Size(72, 20);
            this.cbAGuitar.TabIndex = 8;
            this.cbAGuitar.Text = "통기타";
            this.cbAGuitar.UseVisualStyleBackColor = true;
            // 
            // cbEGuitar
            // 
            this.cbEGuitar.AutoSize = true;
            this.cbEGuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbEGuitar.Location = new System.Drawing.Point(29, 117);
            this.cbEGuitar.Name = "cbEGuitar";
            this.cbEGuitar.Size = new System.Drawing.Size(87, 20);
            this.cbEGuitar.TabIndex = 9;
            this.cbEGuitar.Text = "일렉기타";
            this.cbEGuitar.UseVisualStyleBackColor = true;
            // 
            // cbCGuitar
            // 
            this.cbCGuitar.AutoSize = true;
            this.cbCGuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCGuitar.Location = new System.Drawing.Point(29, 169);
            this.cbCGuitar.Name = "cbCGuitar";
            this.cbCGuitar.Size = new System.Drawing.Size(102, 20);
            this.cbCGuitar.TabIndex = 10;
            this.cbCGuitar.Text = "클래식기타";
            this.cbCGuitar.UseVisualStyleBackColor = true;
            // 
            // gbHit
            // 
            this.gbHit.Controls.Add(this.cbHitEtc);
            this.gbHit.Controls.Add(this.cbDrum);
            this.gbHit.Controls.Add(this.cbDjembe);
            this.gbHit.Controls.Add(this.cbCajon);
            this.gbHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbHit.Location = new System.Drawing.Point(277, 45);
            this.gbHit.Name = "gbHit";
            this.gbHit.Size = new System.Drawing.Size(180, 280);
            this.gbHit.TabIndex = 1;
            this.gbHit.TabStop = false;
            this.gbHit.Text = "타악기";
            // 
            // cbHitEtc
            // 
            this.cbHitEtc.AutoSize = true;
            this.cbHitEtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbHitEtc.Location = new System.Drawing.Point(26, 221);
            this.cbHitEtc.Name = "cbHitEtc";
            this.cbHitEtc.Size = new System.Drawing.Size(57, 20);
            this.cbHitEtc.TabIndex = 7;
            this.cbHitEtc.Text = "없음";
            this.cbHitEtc.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDrum.Location = new System.Drawing.Point(26, 65);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(57, 20);
            this.cbDrum.TabIndex = 4;
            this.cbDrum.Text = "드럼";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbDjembe
            // 
            this.cbDjembe.AutoSize = true;
            this.cbDjembe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDjembe.Location = new System.Drawing.Point(26, 169);
            this.cbDjembe.Name = "cbDjembe";
            this.cbDjembe.Size = new System.Drawing.Size(57, 20);
            this.cbDjembe.TabIndex = 6;
            this.cbDjembe.Text = "젬베";
            this.cbDjembe.UseVisualStyleBackColor = true;
            // 
            // cbCajon
            // 
            this.cbCajon.AutoSize = true;
            this.cbCajon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCajon.Location = new System.Drawing.Point(26, 117);
            this.cbCajon.Name = "cbCajon";
            this.cbCajon.Size = new System.Drawing.Size(57, 20);
            this.cbCajon.TabIndex = 5;
            this.cbCajon.Text = "카혼";
            this.cbCajon.UseVisualStyleBackColor = true;
            // 
            // gbBlow
            // 
            this.gbBlow.Controls.Add(this.cbBlowEtc);
            this.gbBlow.Controls.Add(this.cbOcarina);
            this.gbBlow.Controls.Add(this.cbHarmonica);
            this.gbBlow.Controls.Add(this.cbFlute);
            this.gbBlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBlow.Location = new System.Drawing.Point(21, 45);
            this.gbBlow.Name = "gbBlow";
            this.gbBlow.Size = new System.Drawing.Size(180, 280);
            this.gbBlow.TabIndex = 0;
            this.gbBlow.TabStop = false;
            this.gbBlow.Text = "관악기";
            // 
            // cbBlowEtc
            // 
            this.cbBlowEtc.AutoSize = true;
            this.cbBlowEtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBlowEtc.Location = new System.Drawing.Point(23, 221);
            this.cbBlowEtc.Name = "cbBlowEtc";
            this.cbBlowEtc.Size = new System.Drawing.Size(57, 20);
            this.cbBlowEtc.TabIndex = 3;
            this.cbBlowEtc.Text = "없음";
            this.cbBlowEtc.UseVisualStyleBackColor = true;
            // 
            // cbOcarina
            // 
            this.cbOcarina.AutoSize = true;
            this.cbOcarina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbOcarina.Location = new System.Drawing.Point(23, 169);
            this.cbOcarina.Name = "cbOcarina";
            this.cbOcarina.Size = new System.Drawing.Size(87, 20);
            this.cbOcarina.TabIndex = 2;
            this.cbOcarina.Text = "오카리나";
            this.cbOcarina.UseVisualStyleBackColor = true;
            // 
            // cbHarmonica
            // 
            this.cbHarmonica.AutoSize = true;
            this.cbHarmonica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbHarmonica.Location = new System.Drawing.Point(23, 117);
            this.cbHarmonica.Name = "cbHarmonica";
            this.cbHarmonica.Size = new System.Drawing.Size(87, 20);
            this.cbHarmonica.TabIndex = 1;
            this.cbHarmonica.Text = "하모니카";
            this.cbHarmonica.UseVisualStyleBackColor = true;
            // 
            // cbFlute
            // 
            this.cbFlute.AutoSize = true;
            this.cbFlute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbFlute.Location = new System.Drawing.Point(23, 65);
            this.cbFlute.Name = "cbFlute";
            this.cbFlute.Size = new System.Drawing.Size(72, 20);
            this.cbFlute.TabIndex = 0;
            this.cbFlute.Text = "플루트";
            this.cbFlute.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(1399, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // tbxSearchLCNum
            // 
            this.tbxSearchLCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxSearchLCNum.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbxSearchLCNum.Location = new System.Drawing.Point(1436, 292);
            this.tbxSearchLCNum.Name = "tbxSearchLCNum";
            this.tbxSearchLCNum.Size = new System.Drawing.Size(102, 38);
            this.tbxSearchLCNum.TabIndex = 11;
            this.tbxSearchLCNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1247, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // cbxSearchFCNum
            // 
            this.cbxSearchFCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxSearchFCNum.FormattingEnabled = true;
            this.cbxSearchFCNum.Items.AddRange(new object[] {
            "010",
            "011",
            "016",
            "017",
            "018",
            "019"});
            this.cbxSearchFCNum.Location = new System.Drawing.Point(1163, 292);
            this.cbxSearchFCNum.Name = "cbxSearchFCNum";
            this.cbxSearchFCNum.Size = new System.Drawing.Size(71, 39);
            this.cbxSearchFCNum.TabIndex = 9;
            // 
            // tbxSearchSCNum
            // 
            this.tbxSearchSCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxSearchSCNum.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbxSearchSCNum.Location = new System.Drawing.Point(1284, 292);
            this.tbxSearchSCNum.Name = "tbxSearchSCNum";
            this.tbxSearchSCNum.Size = new System.Drawing.Size(102, 38);
            this.tbxSearchSCNum.TabIndex = 8;
            this.tbxSearchSCNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxSearchCName
            // 
            this.tbxSearchCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxSearchCName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbxSearchCName.Location = new System.Drawing.Point(1338, 236);
            this.tbxSearchCName.Name = "tbxSearchCName";
            this.tbxSearchCName.Size = new System.Drawing.Size(200, 38);
            this.tbxSearchCName.TabIndex = 16;
            this.tbxSearchCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxNewCID
            // 
            this.tbxNewCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxNewCID.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbxNewCID.Location = new System.Drawing.Point(1296, 180);
            this.tbxNewCID.Name = "tbxNewCID";
            this.tbxNewCID.Size = new System.Drawing.Size(242, 38);
            this.tbxNewCID.TabIndex = 17;
            this.tbxNewCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItemID
            // 
            this.lblItemID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemID.Location = new System.Drawing.Point(1169, 186);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(121, 27);
            this.lblItemID.TabIndex = 18;
            this.lblItemID.Text = "아이디 : ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.libSMember);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btnMDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnMemberUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnMRecorde);
            this.splitContainer1.Size = new System.Drawing.Size(1584, 861);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 19;
            // 
            // libSMember
            // 
            this.libSMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libSMember.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.libSMember.FormattingEnabled = true;
            this.libSMember.ItemHeight = 19;
            this.libSMember.Location = new System.Drawing.Point(0, 0);
            this.libSMember.Name = "libSMember";
            this.libSMember.Size = new System.Drawing.Size(288, 861);
            this.libSMember.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1096, 799);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "취  소";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMemberUpdate
            // 
            this.btnMemberUpdate.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMemberUpdate.Location = new System.Drawing.Point(481, 799);
            this.btnMemberUpdate.Name = "btnMemberUpdate";
            this.btnMemberUpdate.Size = new System.Drawing.Size(150, 50);
            this.btnMemberUpdate.TabIndex = 13;
            this.btnMemberUpdate.Text = "수  정";
            this.btnMemberUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMDelete
            // 
            this.btnMDelete.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMDelete.Location = new System.Drawing.Point(686, 799);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(150, 50);
            this.btnMDelete.TabIndex = 14;
            this.btnMDelete.Text = "삭  제";
            this.btnMDelete.UseVisualStyleBackColor = true;
            // 
            // btnMRecorde
            // 
            this.btnMRecorde.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMRecorde.Location = new System.Drawing.Point(891, 799);
            this.btnMRecorde.Name = "btnMRecorde";
            this.btnMRecorde.Size = new System.Drawing.Size(150, 50);
            this.btnMRecorde.TabIndex = 15;
            this.btnMRecorde.Text = "내  역";
            this.btnMRecorde.UseVisualStyleBackColor = true;
            // 
            // SearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tbxNewCID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.tbxSearchCName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbHobby);
            this.Controls.Add(this.tbxSearchLCNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSearchFCNum);
            this.Controls.Add(this.tbxSearchSCNum);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblNewMemberHeadLine);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SearchMember";
            this.Text = "SearchMember";
            this.gbHobby.ResumeLayout(false);
            this.gbKey.ResumeLayout(false);
            this.gbKey.PerformLayout();
            this.gbLine.ResumeLayout(false);
            this.gbLine.PerformLayout();
            this.gbHit.ResumeLayout(false);
            this.gbHit.PerformLayout();
            this.gbBlow.ResumeLayout(false);
            this.gbBlow.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewMemberHeadLine;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbHobby;
        private System.Windows.Forms.GroupBox gbKey;
        private System.Windows.Forms.CheckBox cbKeyEtc;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbAccordion;
        private System.Windows.Forms.CheckBox cbSynthesizer;
        private System.Windows.Forms.GroupBox gbLine;
        private System.Windows.Forms.CheckBox cbLineEtc;
        private System.Windows.Forms.CheckBox cbAGuitar;
        private System.Windows.Forms.CheckBox cbEGuitar;
        private System.Windows.Forms.CheckBox cbCGuitar;
        private System.Windows.Forms.GroupBox gbHit;
        private System.Windows.Forms.CheckBox cbHitEtc;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbDjembe;
        private System.Windows.Forms.CheckBox cbCajon;
        private System.Windows.Forms.GroupBox gbBlow;
        private System.Windows.Forms.CheckBox cbBlowEtc;
        private System.Windows.Forms.CheckBox cbOcarina;
        private System.Windows.Forms.CheckBox cbHarmonica;
        private System.Windows.Forms.CheckBox cbFlute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSearchLCNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSearchFCNum;
        private System.Windows.Forms.TextBox tbxSearchSCNum;
        private System.Windows.Forms.TextBox tbxSearchCName;
        private System.Windows.Forms.TextBox tbxNewCID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox libSMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMDelete;
        private System.Windows.Forms.Button btnMemberUpdate;
        private System.Windows.Forms.Button btnMRecorde;
    }
}