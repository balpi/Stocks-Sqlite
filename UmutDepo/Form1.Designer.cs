
namespace UmutDepo
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
            this.GrsKaydetBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.girisTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.GrsCombo = new System.Windows.Forms.ComboBox();
            this.GrsTarihtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GrsMiktartxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrsUrunadiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrsIptalbtn = new System.Windows.Forms.Button();
            this.GrsDatagrd = new System.Windows.Forms.DataGridView();
            this.CikisTab = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.Cksteslimalantxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CksCombo = new System.Windows.Forms.ComboBox();
            this.CksTarihtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CksMiktartxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CksUrunaditxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CksIptalbtn = new System.Windows.Forms.Button();
            this.CksDatagrd = new System.Windows.Forms.DataGridView();
            this.CksKaydetbtn = new System.Windows.Forms.Button();
            this.raporTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.rprDatagrd = new System.Windows.Forms.DataGridView();
            this.Getcksbtn = new System.Windows.Forms.Button();
            this.Getgrsbtn = new System.Windows.Forms.Button();
            this.GetStockbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.girisTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrsDatagrd)).BeginInit();
            this.CikisTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CksDatagrd)).BeginInit();
            this.raporTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rprDatagrd)).BeginInit();
            this.SuspendLayout();
            // 
            // GrsKaydetBtn
            // 
            this.GrsKaydetBtn.Location = new System.Drawing.Point(12, 396);
            this.GrsKaydetBtn.Name = "GrsKaydetBtn";
            this.GrsKaydetBtn.Size = new System.Drawing.Size(464, 41);
            this.GrsKaydetBtn.TabIndex = 4;
            this.GrsKaydetBtn.Text = "SAVE";
            this.GrsKaydetBtn.UseVisualStyleBackColor = true;
            this.GrsKaydetBtn.Click += new System.EventHandler(this.GrsKaydetBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.girisTab);
            this.tabControl1.Controls.Add(this.CikisTab);
            this.tabControl1.Controls.Add(this.raporTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1367, 681);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // girisTab
            // 
            this.girisTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.girisTab.Controls.Add(this.label11);
            this.girisTab.Controls.Add(this.GrsCombo);
            this.girisTab.Controls.Add(this.GrsTarihtxt);
            this.girisTab.Controls.Add(this.label5);
            this.girisTab.Controls.Add(this.GrsMiktartxt);
            this.girisTab.Controls.Add(this.label4);
            this.girisTab.Controls.Add(this.label3);
            this.girisTab.Controls.Add(this.GrsUrunadiTxt);
            this.girisTab.Controls.Add(this.label2);
            this.girisTab.Controls.Add(this.GrsIptalbtn);
            this.girisTab.Controls.Add(this.GrsDatagrd);
            this.girisTab.Controls.Add(this.GrsKaydetBtn);
            this.girisTab.Location = new System.Drawing.Point(4, 40);
            this.girisTab.Name = "girisTab";
            this.girisTab.Padding = new System.Windows.Forms.Padding(3);
            this.girisTab.Size = new System.Drawing.Size(1359, 637);
            this.girisTab.TabIndex = 0;
            this.girisTab.Text = "Entrance";
            this.girisTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(873, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "Enterance Log";
            // 
            // GrsCombo
            // 
            this.GrsCombo.FormattingEnabled = true;
            this.GrsCombo.Location = new System.Drawing.Point(172, 84);
            this.GrsCombo.Name = "GrsCombo";
            this.GrsCombo.Size = new System.Drawing.Size(304, 39);
            this.GrsCombo.TabIndex = 1;
            // 
            // GrsTarihtxt
            // 
            this.GrsTarihtxt.Location = new System.Drawing.Point(172, 211);
            this.GrsTarihtxt.Name = "GrsTarihtxt";
            this.GrsTarihtxt.Size = new System.Drawing.Size(304, 38);
            this.GrsTarihtxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enterance Date";
            // 
            // GrsMiktartxt
            // 
            this.GrsMiktartxt.Location = new System.Drawing.Point(172, 148);
            this.GrsMiktartxt.Name = "GrsMiktartxt";
            this.GrsMiktartxt.Size = new System.Drawing.Size(304, 38);
            this.GrsMiktartxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Measurement";
            // 
            // GrsUrunadiTxt
            // 
            this.GrsUrunadiTxt.Location = new System.Drawing.Point(172, 25);
            this.GrsUrunadiTxt.Name = "GrsUrunadiTxt";
            this.GrsUrunadiTxt.Size = new System.Drawing.Size(304, 38);
            this.GrsUrunadiTxt.TabIndex = 0;
            this.GrsUrunadiTxt.TextChanged += new System.EventHandler(this.GrsUrunadiTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GrsIptalbtn
            // 
            this.GrsIptalbtn.Location = new System.Drawing.Point(12, 480);
            this.GrsIptalbtn.Name = "GrsIptalbtn";
            this.GrsIptalbtn.Size = new System.Drawing.Size(464, 41);
            this.GrsIptalbtn.TabIndex = 6;
            this.GrsIptalbtn.Text = "CANCEL";
            this.GrsIptalbtn.UseVisualStyleBackColor = true;
            this.GrsIptalbtn.Click += new System.EventHandler(this.GrsIptalbtn_Click);
            // 
            // GrsDatagrd
            // 
            this.GrsDatagrd.BackgroundColor = System.Drawing.Color.White;
            this.GrsDatagrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrsDatagrd.Location = new System.Drawing.Point(499, 60);
            this.GrsDatagrd.Name = "GrsDatagrd";
            this.GrsDatagrd.RowHeadersWidth = 51;
            this.GrsDatagrd.RowTemplate.Height = 24;
            this.GrsDatagrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrsDatagrd.Size = new System.Drawing.Size(856, 569);
            this.GrsDatagrd.TabIndex = 7;
            this.GrsDatagrd.TabStop = false;
            this.GrsDatagrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrsDatagrd_CellClick);
            // 
            // CikisTab
            // 
            this.CikisTab.Controls.Add(this.label12);
            this.CikisTab.Controls.Add(this.Cksteslimalantxt);
            this.CikisTab.Controls.Add(this.label10);
            this.CikisTab.Controls.Add(this.CksCombo);
            this.CikisTab.Controls.Add(this.CksTarihtxt);
            this.CikisTab.Controls.Add(this.label6);
            this.CikisTab.Controls.Add(this.CksMiktartxt);
            this.CikisTab.Controls.Add(this.label7);
            this.CikisTab.Controls.Add(this.label8);
            this.CikisTab.Controls.Add(this.CksUrunaditxt);
            this.CikisTab.Controls.Add(this.label9);
            this.CikisTab.Controls.Add(this.CksIptalbtn);
            this.CikisTab.Controls.Add(this.CksDatagrd);
            this.CikisTab.Controls.Add(this.CksKaydetbtn);
            this.CikisTab.Location = new System.Drawing.Point(4, 40);
            this.CikisTab.Name = "CikisTab";
            this.CikisTab.Padding = new System.Windows.Forms.Padding(3);
            this.CikisTab.Size = new System.Drawing.Size(1359, 637);
            this.CikisTab.TabIndex = 1;
            this.CikisTab.Text = "Exit";
            this.CikisTab.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(845, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 32);
            this.label12.TabIndex = 26;
            this.label12.Text = "Stock Records";
            // 
            // Cksteslimalantxt
            // 
            this.Cksteslimalantxt.Location = new System.Drawing.Point(172, 273);
            this.Cksteslimalantxt.Name = "Cksteslimalantxt";
            this.Cksteslimalantxt.Size = new System.Drawing.Size(304, 38);
            this.Cksteslimalantxt.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Given To";
            // 
            // CksCombo
            // 
            this.CksCombo.FormattingEnabled = true;
            this.CksCombo.Location = new System.Drawing.Point(171, 81);
            this.CksCombo.Name = "CksCombo";
            this.CksCombo.Size = new System.Drawing.Size(304, 39);
            this.CksCombo.TabIndex = 1;
            // 
            // CksTarihtxt
            // 
            this.CksTarihtxt.Location = new System.Drawing.Point(171, 208);
            this.CksTarihtxt.Name = "CksTarihtxt";
            this.CksTarihtxt.Size = new System.Drawing.Size(304, 38);
            this.CksTarihtxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Exit Date";
            // 
            // CksMiktartxt
            // 
            this.CksMiktartxt.Location = new System.Drawing.Point(171, 145);
            this.CksMiktartxt.Name = "CksMiktartxt";
            this.CksMiktartxt.Size = new System.Drawing.Size(304, 38);
            this.CksMiktartxt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(5, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Measurement";
            // 
            // CksUrunaditxt
            // 
            this.CksUrunaditxt.Location = new System.Drawing.Point(171, 22);
            this.CksUrunaditxt.Name = "CksUrunaditxt";
            this.CksUrunaditxt.Size = new System.Drawing.Size(304, 38);
            this.CksUrunaditxt.TabIndex = 0;
            this.CksUrunaditxt.TextChanged += new System.EventHandler(this.CksUrunaditxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Product Name";
            // 
            // CksIptalbtn
            // 
            this.CksIptalbtn.Location = new System.Drawing.Point(12, 477);
            this.CksIptalbtn.Name = "CksIptalbtn";
            this.CksIptalbtn.Size = new System.Drawing.Size(463, 41);
            this.CksIptalbtn.TabIndex = 7;
            this.CksIptalbtn.Text = "CANCEL";
            this.CksIptalbtn.UseVisualStyleBackColor = true;
            this.CksIptalbtn.Click += new System.EventHandler(this.CksIptalbtn_Click);
            // 
            // CksDatagrd
            // 
            this.CksDatagrd.BackgroundColor = System.Drawing.Color.White;
            this.CksDatagrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CksDatagrd.Location = new System.Drawing.Point(498, 58);
            this.CksDatagrd.Name = "CksDatagrd";
            this.CksDatagrd.RowHeadersWidth = 51;
            this.CksDatagrd.RowTemplate.Height = 24;
            this.CksDatagrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CksDatagrd.Size = new System.Drawing.Size(856, 573);
            this.CksDatagrd.TabIndex = 13;
            this.CksDatagrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CksDatagrd_CellClick);
            // 
            // CksKaydetbtn
            // 
            this.CksKaydetbtn.Location = new System.Drawing.Point(11, 393);
            this.CksKaydetbtn.Name = "CksKaydetbtn";
            this.CksKaydetbtn.Size = new System.Drawing.Size(464, 41);
            this.CksKaydetbtn.TabIndex = 5;
            this.CksKaydetbtn.Text = "SAVE";
            this.CksKaydetbtn.UseVisualStyleBackColor = true;
            this.CksKaydetbtn.Click += new System.EventHandler(this.CksKaydetbtn_Click);
            // 
            // raporTab
            // 
            this.raporTab.Controls.Add(this.label13);
            this.raporTab.Controls.Add(this.rprDatagrd);
            this.raporTab.Controls.Add(this.Getcksbtn);
            this.raporTab.Controls.Add(this.Getgrsbtn);
            this.raporTab.Controls.Add(this.GetStockbtn);
            this.raporTab.Location = new System.Drawing.Point(4, 40);
            this.raporTab.Name = "raporTab";
            this.raporTab.Padding = new System.Windows.Forms.Padding(3);
            this.raporTab.Size = new System.Drawing.Size(1359, 637);
            this.raporTab.TabIndex = 2;
            this.raporTab.Text = "Rapors";
            this.raporTab.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(790, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 32);
            this.label13.TabIndex = 27;
            this.label13.Text = "Stock Records";
            // 
            // rprDatagrd
            // 
            this.rprDatagrd.BackgroundColor = System.Drawing.Color.White;
            this.rprDatagrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rprDatagrd.Location = new System.Drawing.Point(383, 75);
            this.rprDatagrd.Name = "rprDatagrd";
            this.rprDatagrd.RowHeadersWidth = 51;
            this.rprDatagrd.RowTemplate.Height = 24;
            this.rprDatagrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rprDatagrd.Size = new System.Drawing.Size(970, 544);
            this.rprDatagrd.TabIndex = 14;
            this.rprDatagrd.TabStop = false;
            // 
            // Getcksbtn
            // 
            this.Getcksbtn.Location = new System.Drawing.Point(6, 345);
            this.Getcksbtn.Name = "Getcksbtn";
            this.Getcksbtn.Size = new System.Drawing.Size(201, 60);
            this.Getcksbtn.TabIndex = 2;
            this.Getcksbtn.Text = "Exits Rapors";
            this.Getcksbtn.UseVisualStyleBackColor = true;
            this.Getcksbtn.Click += new System.EventHandler(this.Getcksbtn_Click);
            // 
            // Getgrsbtn
            // 
            this.Getgrsbtn.Location = new System.Drawing.Point(6, 191);
            this.Getgrsbtn.Name = "Getgrsbtn";
            this.Getgrsbtn.Size = new System.Drawing.Size(201, 60);
            this.Getgrsbtn.TabIndex = 1;
            this.Getgrsbtn.Text = "Entrance Rapors";
            this.Getgrsbtn.UseVisualStyleBackColor = true;
            this.Getgrsbtn.Click += new System.EventHandler(this.Getgrsbtn_Click);
            // 
            // GetStockbtn
            // 
            this.GetStockbtn.Location = new System.Drawing.Point(-1, 28);
            this.GetStockbtn.Name = "GetStockbtn";
            this.GetStockbtn.Size = new System.Drawing.Size(219, 60);
            this.GetStockbtn.TabIndex = 0;
            this.GetStockbtn.Text = "Stock Rapors";
            this.GetStockbtn.UseVisualStyleBackColor = true;
            this.GetStockbtn.Click += new System.EventHandler(this.GetStockbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(412, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.girisTab.ResumeLayout(false);
            this.girisTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrsDatagrd)).EndInit();
            this.CikisTab.ResumeLayout(false);
            this.CikisTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CksDatagrd)).EndInit();
            this.raporTab.ResumeLayout(false);
            this.raporTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rprDatagrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GrsKaydetBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage girisTab;
        private System.Windows.Forms.TabPage CikisTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GrsIptalbtn;
        private System.Windows.Forms.DataGridView GrsDatagrd;
        private System.Windows.Forms.TabPage raporTab;
        private System.Windows.Forms.TextBox GrsUrunadiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GrsCombo;
        private System.Windows.Forms.TextBox GrsTarihtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GrsMiktartxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CksCombo;
        private System.Windows.Forms.TextBox CksTarihtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CksMiktartxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CksUrunaditxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CksIptalbtn;
        private System.Windows.Forms.DataGridView CksDatagrd;
        private System.Windows.Forms.Button CksKaydetbtn;
        private System.Windows.Forms.TextBox Cksteslimalantxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView rprDatagrd;
        private System.Windows.Forms.Button Getcksbtn;
        private System.Windows.Forms.Button Getgrsbtn;
        private System.Windows.Forms.Button GetStockbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

