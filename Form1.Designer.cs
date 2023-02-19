namespace Xichun_City_Train
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.IDC_TEXTBOXTRAIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDC_COMBOBOXKIND = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDC_TEXTBOXLOCOMOTIVE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDC_TEXTBOXMAXSPEED = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDC_RICHTEXTBOXSTATION = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存FToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 保存FToolStripMenuItem
            // 
            this.保存FToolStripMenuItem.Name = "保存FToolStripMenuItem";
            this.保存FToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存FToolStripMenuItem.Text = "保存(&F)";
            this.保存FToolStripMenuItem.Click += new System.EventHandler(this.保存FToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "车次";
            // 
            // IDC_TEXTBOXTRAIN
            // 
            this.IDC_TEXTBOXTRAIN.Location = new System.Drawing.Point(8, 51);
            this.IDC_TEXTBOXTRAIN.Name = "IDC_TEXTBOXTRAIN";
            this.IDC_TEXTBOXTRAIN.Size = new System.Drawing.Size(100, 23);
            this.IDC_TEXTBOXTRAIN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "类型";
            // 
            // IDC_COMBOBOXKIND
            // 
            this.IDC_COMBOBOXKIND.FormattingEnabled = true;
            this.IDC_COMBOBOXKIND.Items.AddRange(new object[] {
            "客运",
            "货运"});
            this.IDC_COMBOBOXKIND.Location = new System.Drawing.Point(8, 97);
            this.IDC_COMBOBOXKIND.Name = "IDC_COMBOBOXKIND";
            this.IDC_COMBOBOXKIND.Size = new System.Drawing.Size(121, 25);
            this.IDC_COMBOBOXKIND.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "列车";
            // 
            // IDC_TEXTBOXLOCOMOTIVE
            // 
            this.IDC_TEXTBOXLOCOMOTIVE.Location = new System.Drawing.Point(8, 145);
            this.IDC_TEXTBOXLOCOMOTIVE.Name = "IDC_TEXTBOXLOCOMOTIVE";
            this.IDC_TEXTBOXLOCOMOTIVE.Size = new System.Drawing.Size(242, 23);
            this.IDC_TEXTBOXLOCOMOTIVE.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "最大速度";
            // 
            // IDC_TEXTBOXMAXSPEED
            // 
            this.IDC_TEXTBOXMAXSPEED.Location = new System.Drawing.Point(8, 191);
            this.IDC_TEXTBOXMAXSPEED.Name = "IDC_TEXTBOXMAXSPEED";
            this.IDC_TEXTBOXMAXSPEED.Size = new System.Drawing.Size(100, 23);
            this.IDC_TEXTBOXMAXSPEED.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "所经站点";
            // 
            // IDC_RICHTEXTBOXSTATION
            // 
            this.IDC_RICHTEXTBOXSTATION.Location = new System.Drawing.Point(8, 237);
            this.IDC_RICHTEXTBOXSTATION.Name = "IDC_RICHTEXTBOXSTATION";
            this.IDC_RICHTEXTBOXSTATION.Size = new System.Drawing.Size(100, 96);
            this.IDC_RICHTEXTBOXSTATION.TabIndex = 10;
            this.IDC_RICHTEXTBOXSTATION.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDC_RICHTEXTBOXSTATION);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDC_TEXTBOXMAXSPEED);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDC_TEXTBOXLOCOMOTIVE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDC_COMBOBOXKIND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDC_TEXTBOXTRAIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Xichun City-Train";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件FToolStripMenuItem;
        private ToolStripMenuItem 保存FToolStripMenuItem;
        private Label label1;
        private TextBox IDC_TEXTBOXTRAIN;
        private Label label2;
        private ComboBox IDC_COMBOBOXKIND;
        private Label label3;
        private TextBox IDC_TEXTBOXLOCOMOTIVE;
        private Label label4;
        private TextBox IDC_TEXTBOXMAXSPEED;
        private Label label5;
        private RichTextBox IDC_RICHTEXTBOXSTATION;
    }
}