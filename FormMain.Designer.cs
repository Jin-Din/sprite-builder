namespace CssSprite
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxImgType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCss = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.chkBoxPhone = new System.Windows.Forms.CheckBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSplitSprite = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSprite = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonVRange = new System.Windows.Forms.Button();
            this.buttonHRange = new System.Windows.Forms.Button();
            this.buttonMakeBigImageCss = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkjson = new System.Windows.Forms.CheckBox();
            this.chkcss_base64 = new System.Windows.Forms.CheckBox();
            this.chksass_base64 = new System.Windows.Forms.CheckBox();
            this.chkcssless = new System.Windows.Forms.CheckBox();
            this.chksass = new System.Windows.Forms.CheckBox();
            this.chkOutListImg = new System.Windows.Forms.CheckBox();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelLess = new System.Windows.Forms.LinkLabel();
            this.linkLabelSass = new System.Windows.Forms.LinkLabel();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBase64Sass = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtBase64Css = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelImages = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Png文件|*.png|Jpeg文件|*.jpeg|Jpg文件|*.jpg";
            this.openFileDialog.Multiselect = true;
            // 
            // comboBoxImgType
            // 
            this.comboBoxImgType.BackColor = System.Drawing.Color.White;
            this.comboBoxImgType.Enabled = false;
            this.comboBoxImgType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxImgType.Items.AddRange(new object[] {
            "Png",
            "Jpg",
            "Jpeg"});
            this.comboBoxImgType.Location = new System.Drawing.Point(689, 64);
            this.comboBoxImgType.Name = "comboBoxImgType";
            this.comboBoxImgType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxImgType.TabIndex = 7;
            this.comboBoxImgType.Text = "Png";
            this.comboBoxImgType.SelectedIndexChanged += new System.EventHandler(this.comboBoxImgType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "雪碧图文件类型：";
            // 
            // txtSass
            // 
            this.txtSass.BackColor = System.Drawing.Color.White;
            this.txtSass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtSass.Location = new System.Drawing.Point(3, 3);
            this.txtSass.Multiline = true;
            this.txtSass.Name = "txtSass";
            this.txtSass.ReadOnly = true;
            this.txtSass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSass.Size = new System.Drawing.Size(955, 90);
            this.txtSass.TabIndex = 11;
            this.txtSass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "css中文件夹路径：";
            // 
            // txtDir
            // 
            this.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDir.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtDir.Location = new System.Drawing.Point(106, 6);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(704, 21);
            this.txtDir.TabIndex = 14;
            this.txtDir.Text = "../images";
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "雪碧图文件名称：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtName.Location = new System.Drawing.Point(106, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(704, 21);
            this.txtName.TabIndex = 16;
            this.txtName.Text = "img";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCss
            // 
            this.txtCss.BackColor = System.Drawing.Color.White;
            this.txtCss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCss.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtCss.Location = new System.Drawing.Point(3, 3);
            this.txtCss.Multiline = true;
            this.txtCss.Name = "txtCss";
            this.txtCss.ReadOnly = true;
            this.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCss.Size = new System.Drawing.Size(955, 90);
            this.txtCss.TabIndex = 19;
            this.txtCss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCss_KeyDown);
            // 
            // chkBoxPhone
            // 
            this.chkBoxPhone.AutoSize = true;
            this.chkBoxPhone.Location = new System.Drawing.Point(6, 68);
            this.chkBoxPhone.Name = "chkBoxPhone";
            this.chkBoxPhone.Size = new System.Drawing.Size(96, 16);
            this.chkBoxPhone.TabIndex = 20;
            this.chkBoxPhone.Text = "是否是手机端";
            this.chkBoxPhone.UseVisualStyleBackColor = true;
            this.chkBoxPhone.CheckedChanged += new System.EventHandler(this.chkBoxPhone_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel3);
            this.panelTop.Controls.Add(this.btnSplitSprite);
            this.panelTop.Controls.Add(this.btnUpdate);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.btnSprite);
            this.panelTop.Controls.Add(this.btn);
            this.panelTop.Controls.Add(this.buttonBrowse);
            this.panelTop.Controls.Add(this.buttonVRange);
            this.panelTop.Controls.Add(this.buttonHRange);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panelTop.Size = new System.Drawing.Size(984, 54);
            this.panelTop.TabIndex = 21;
            // 
            // btnSplitSprite
            // 
            this.btnSplitSprite.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSplitSprite.FlatAppearance.BorderSize = 0;
            this.btnSplitSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitSprite.ForeColor = System.Drawing.Color.White;
            this.btnSplitSprite.Image = global::CssSprite.Properties.Resources.QQ截图201504271504082;
            this.btnSplitSprite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSplitSprite.Location = new System.Drawing.Point(771, 9);
            this.btnSplitSprite.Name = "btnSplitSprite";
            this.btnSplitSprite.Size = new System.Drawing.Size(135, 40);
            this.btnSplitSprite.TabIndex = 26;
            this.btnSplitSprite.Text = "分解sprite";
            this.btnSplitSprite.UseVisualStyleBackColor = false;
            this.btnSplitSprite.Click += new System.EventHandler(this.btnSplitSprite_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::CssSprite.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(375, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::CssSprite.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(329, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::CssSprite.Properties.Resources.add2;
            this.btnAdd.Location = new System.Drawing.Point(283, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSprite
            // 
            this.btnSprite.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSprite.FlatAppearance.BorderSize = 0;
            this.btnSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSprite.ForeColor = System.Drawing.Color.White;
            this.btnSprite.Image = global::CssSprite.Properties.Resources.open;
            this.btnSprite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSprite.Location = new System.Drawing.Point(142, 9);
            this.btnSprite.Name = "btnSprite";
            this.btnSprite.Size = new System.Drawing.Size(135, 40);
            this.btnSprite.TabIndex = 22;
            this.btnSprite.Text = "打开.sprite";
            this.btnSprite.UseVisualStyleBackColor = false;
            this.btnSprite.Click += new System.EventHandler(this.btnSprite_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.White;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Image = global::CssSprite.Properties.Resources.question;
            this.btn.Location = new System.Drawing.Point(912, 9);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(55, 40);
            this.btn.TabIndex = 21;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.Image = global::CssSprite.Properties.Resources.open;
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 9);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(135, 40);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "选择多幅图片";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonVRange
            // 
            this.buttonVRange.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonVRange.FlatAppearance.BorderSize = 0;
            this.buttonVRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVRange.ForeColor = System.Drawing.Color.White;
            this.buttonVRange.Image = global::CssSprite.Properties.Resources.vertical;
            this.buttonVRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVRange.Location = new System.Drawing.Point(470, 9);
            this.buttonVRange.Name = "buttonVRange";
            this.buttonVRange.Size = new System.Drawing.Size(134, 40);
            this.buttonVRange.TabIndex = 4;
            this.buttonVRange.Text = "小图竖排";
            this.buttonVRange.UseVisualStyleBackColor = false;
            this.buttonVRange.Click += new System.EventHandler(this.ButtonVRange_Click);
            // 
            // buttonHRange
            // 
            this.buttonHRange.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHRange.FlatAppearance.BorderSize = 0;
            this.buttonHRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHRange.ForeColor = System.Drawing.Color.White;
            this.buttonHRange.Image = global::CssSprite.Properties.Resources.horizontal;
            this.buttonHRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHRange.Location = new System.Drawing.Point(610, 9);
            this.buttonHRange.Name = "buttonHRange";
            this.buttonHRange.Size = new System.Drawing.Size(115, 40);
            this.buttonHRange.TabIndex = 5;
            this.buttonHRange.Text = "小图横排";
            this.buttonHRange.UseVisualStyleBackColor = false;
            this.buttonHRange.Click += new System.EventHandler(this.buttonHRange_Click);
            // 
            // buttonMakeBigImageCss
            // 
            this.buttonMakeBigImageCss.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMakeBigImageCss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMakeBigImageCss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeBigImageCss.ForeColor = System.Drawing.Color.White;
            this.buttonMakeBigImageCss.Image = global::CssSprite.Properties.Resources.download;
            this.buttonMakeBigImageCss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMakeBigImageCss.Location = new System.Drawing.Point(828, 6);
            this.buttonMakeBigImageCss.Name = "buttonMakeBigImageCss";
            this.buttonMakeBigImageCss.Size = new System.Drawing.Size(139, 60);
            this.buttonMakeBigImageCss.TabIndex = 9;
            this.buttonMakeBigImageCss.Text = "生成雪碧图";
            this.buttonMakeBigImageCss.UseVisualStyleBackColor = false;
            this.buttonMakeBigImageCss.Click += new System.EventHandler(this.ButtonMakeBigImageCss_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.panel2);
            this.panelBottom.Controls.Add(this.chkOutListImg);
            this.panelBottom.Controls.Add(this.panelPhone);
            this.panelBottom.Controls.Add(this.tabControl);
            this.panelBottom.Controls.Add(this.txtDir);
            this.panelBottom.Controls.Add(this.chkBoxPhone);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.comboBoxImgType);
            this.panelBottom.Controls.Add(this.txtName);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.buttonMakeBigImageCss);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(3, 414);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(984, 274);
            this.panelBottom.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "输出：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkjson);
            this.panel2.Controls.Add(this.chkcss_base64);
            this.panel2.Controls.Add(this.chksass_base64);
            this.panel2.Controls.Add(this.chkcssless);
            this.panel2.Controls.Add(this.chksass);
            this.panel2.Location = new System.Drawing.Point(106, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 41);
            this.panel2.TabIndex = 27;
            // 
            // chkjson
            // 
            this.chkjson.AutoSize = true;
            this.chkjson.Checked = true;
            this.chkjson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkjson.Location = new System.Drawing.Point(331, 13);
            this.chkjson.Name = "chkjson";
            this.chkjson.Size = new System.Drawing.Size(48, 16);
            this.chkjson.TabIndex = 4;
            this.chkjson.Text = "json";
            this.chkjson.UseVisualStyleBackColor = true;
            // 
            // chkcss_base64
            // 
            this.chkcss_base64.AutoSize = true;
            this.chkcss_base64.Checked = true;
            this.chkcss_base64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkcss_base64.Location = new System.Drawing.Point(241, 13);
            this.chkcss_base64.Name = "chkcss_base64";
            this.chkcss_base64.Size = new System.Drawing.Size(84, 16);
            this.chkcss_base64.TabIndex = 3;
            this.chkcss_base64.Text = "css base64";
            this.chkcss_base64.UseVisualStyleBackColor = true;
            // 
            // chksass_base64
            // 
            this.chksass_base64.AutoSize = true;
            this.chksass_base64.Checked = true;
            this.chksass_base64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksass_base64.Location = new System.Drawing.Point(145, 13);
            this.chksass_base64.Name = "chksass_base64";
            this.chksass_base64.Size = new System.Drawing.Size(90, 16);
            this.chksass_base64.TabIndex = 2;
            this.chksass_base64.Text = "sass base64";
            this.chksass_base64.UseVisualStyleBackColor = true;
            // 
            // chkcssless
            // 
            this.chkcssless.AutoSize = true;
            this.chkcssless.Checked = true;
            this.chkcssless.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkcssless.Location = new System.Drawing.Point(58, 13);
            this.chkcssless.Name = "chkcssless";
            this.chkcssless.Size = new System.Drawing.Size(72, 16);
            this.chkcssless.TabIndex = 1;
            this.chkcssless.Text = "css/less";
            this.chkcssless.UseVisualStyleBackColor = true;
            // 
            // chksass
            // 
            this.chksass.AutoSize = true;
            this.chksass.Checked = true;
            this.chksass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksass.Location = new System.Drawing.Point(4, 13);
            this.chksass.Name = "chksass";
            this.chksass.Size = new System.Drawing.Size(48, 16);
            this.chksass.TabIndex = 0;
            this.chksass.Text = "sass";
            this.chksass.UseVisualStyleBackColor = true;
            // 
            // chkOutListImg
            // 
            this.chkOutListImg.AutoSize = true;
            this.chkOutListImg.Checked = true;
            this.chkOutListImg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutListImg.Location = new System.Drawing.Point(828, 74);
            this.chkOutListImg.Name = "chkOutListImg";
            this.chkOutListImg.Size = new System.Drawing.Size(96, 16);
            this.chkOutListImg.TabIndex = 26;
            this.chkOutListImg.Text = "是否输出原图";
            this.chkOutListImg.UseVisualStyleBackColor = true;
            // 
            // panelPhone
            // 
            this.panelPhone.Controls.Add(this.label3);
            this.panelPhone.Controls.Add(this.linkLabelLess);
            this.panelPhone.Controls.Add(this.linkLabelSass);
            this.panelPhone.Controls.Add(this.linkLabelHelp);
            this.panelPhone.Location = new System.Drawing.Point(106, 60);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(435, 28);
            this.panelPhone.TabIndex = 22;
            this.panelPhone.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "帮助：";
            // 
            // linkLabelLess
            // 
            this.linkLabelLess.AutoSize = true;
            this.linkLabelLess.Location = new System.Drawing.Point(303, 9);
            this.linkLabelLess.Name = "linkLabelLess";
            this.linkLabelLess.Size = new System.Drawing.Size(77, 12);
            this.linkLabelLess.TabIndex = 0;
            this.linkLabelLess.TabStop = true;
            this.linkLabelLess.Text = "Less变量合集";
            this.linkLabelLess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLess_LinkClicked);
            // 
            // linkLabelSass
            // 
            this.linkLabelSass.AutoSize = true;
            this.linkLabelSass.Location = new System.Drawing.Point(208, 9);
            this.linkLabelSass.Name = "linkLabelSass";
            this.linkLabelSass.Size = new System.Drawing.Size(77, 12);
            this.linkLabelSass.TabIndex = 0;
            this.linkLabelSass.TabStop = true;
            this.linkLabelSass.Text = "Sass变量合集";
            this.linkLabelSass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSass_LinkClicked);
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Location = new System.Drawing.Point(50, 9);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(143, 12);
            this.linkLabelHelp.TabIndex = 0;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "手机端页面rem自适应脚本";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(6, 143);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(969, 122);
            this.tabControl.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSass);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sass代码";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCss);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 96);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "css/less代码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBase64Sass);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(961, 96);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "sass Base64代码";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBase64Sass
            // 
            this.txtBase64Sass.BackColor = System.Drawing.Color.White;
            this.txtBase64Sass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBase64Sass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase64Sass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBase64Sass.Location = new System.Drawing.Point(3, 3);
            this.txtBase64Sass.Multiline = true;
            this.txtBase64Sass.Name = "txtBase64Sass";
            this.txtBase64Sass.ReadOnly = true;
            this.txtBase64Sass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBase64Sass.Size = new System.Drawing.Size(955, 90);
            this.txtBase64Sass.TabIndex = 12;
            this.txtBase64Sass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBase64Sass_KeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtBase64Css);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(961, 96);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "css Base64代码";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtBase64Css
            // 
            this.txtBase64Css.BackColor = System.Drawing.Color.White;
            this.txtBase64Css.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBase64Css.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase64Css.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBase64Css.Location = new System.Drawing.Point(3, 3);
            this.txtBase64Css.Multiline = true;
            this.txtBase64Css.Name = "txtBase64Css";
            this.txtBase64Css.ReadOnly = true;
            this.txtBase64Css.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBase64Css.Size = new System.Drawing.Size(955, 90);
            this.txtBase64Css.TabIndex = 12;
            this.txtBase64Css.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBase64Css_KeyDown);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtJson);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(961, 96);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "json配置";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtJson
            // 
            this.txtJson.BackColor = System.Drawing.Color.White;
            this.txtJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtJson.Location = new System.Drawing.Point(3, 3);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ReadOnly = true;
            this.txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJson.Size = new System.Drawing.Size(955, 90);
            this.txtJson.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 691);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CssSprite.Properties.Resources.QQ截图201504271504082;
            this.panel1.Controls.Add(this.panelImages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 345);
            this.panel1.TabIndex = 0;
            // 
            // panelImages
            // 
            this.panelImages.AutoScroll = true;
            this.panelImages.BackColor = System.Drawing.Color.Transparent;
            this.panelImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImages.Location = new System.Drawing.Point(0, 0);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(984, 345);
            this.panelImages.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(750, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 26);
            this.panel3.TabIndex = 27;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Css背景图(sprite)合并/分解工具";
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonMakeBigImageCss;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonHRange;
        private System.Windows.Forms.Button buttonVRange;
        private System.Windows.Forms.ComboBox comboBoxImgType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCss;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox chkBoxPhone;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnSprite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtBase64Sass;
        private System.Windows.Forms.TextBox txtBase64Css;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
        private System.Windows.Forms.LinkLabel linkLabelLess;
        private System.Windows.Forms.LinkLabel linkLabelSass;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.CheckBox chkOutListImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkjson;
        private System.Windows.Forms.CheckBox chkcss_base64;
        private System.Windows.Forms.CheckBox chksass_base64;
        private System.Windows.Forms.CheckBox chkcssless;
        private System.Windows.Forms.CheckBox chksass;
        private System.Windows.Forms.Button btnSplitSprite;
        private System.Windows.Forms.Panel panel3;
    }
}

