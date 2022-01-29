
namespace Demo
{
    partial class DemoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.moonButton1 = new MoonUI.MoonButton();
            this.moonTextField1 = new MoonUI.MoonTextField();
            this.moonInfoButton1 = new MoonUI.MoonInfoButton();
            this.moonMenu1 = new MoonUI.MoonMenu();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moonSuccessButton1 = new MoonUI.MoonSuccessButton();
            this.moonDangerButton2 = new MoonUI.MoonDangerButton();
            this.moonLabel1 = new MoonUI.MoonLabel();
            this.moonWarnButton1 = new MoonUI.MoonWarnButton();
            this.moonCheckList1 = new MoonUI.MoonCheckList();
            this.moonList1 = new MoonUI.MoonList();
            this.moonGrid1 = new MoonUI.MoonGrid();
            this.moonToggle1 = new MoonUI.MoonToggle();
            this.moonTip1 = new MoonUI.MoonTip();
            this.moonMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moonGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // moonButton1
            // 
            this.moonButton1.BackColor = System.Drawing.Color.MediumOrchid;
            this.moonButton1.FlatAppearance.BorderSize = 0;
            this.moonButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.moonButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.moonButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonButton1.ForeColor = System.Drawing.Color.White;
            this.moonButton1.Location = new System.Drawing.Point(5, 340);
            this.moonButton1.Name = "moonButton1";
            this.moonButton1.Size = new System.Drawing.Size(134, 23);
            this.moonButton1.TabIndex = 1;
            this.moonButton1.Text = "Switch theme";
            this.moonButton1.UseVisualStyleBackColor = false;
            this.moonButton1.Click += new System.EventHandler(this.moonButton1_Click);
            // 
            // moonTextField1
            // 
            this.moonTextField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.moonTextField1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moonTextField1.ForeColor = System.Drawing.Color.White;
            this.moonTextField1.Location = new System.Drawing.Point(35, 392);
            this.moonTextField1.Name = "moonTextField1";
            this.moonTextField1.Size = new System.Drawing.Size(100, 13);
            this.moonTextField1.TabIndex = 3;
            // 
            // moonInfoButton1
            // 
            this.moonInfoButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.moonInfoButton1.FlatAppearance.BorderSize = 0;
            this.moonInfoButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.moonInfoButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.moonInfoButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonInfoButton1.ForeColor = System.Drawing.Color.White;
            this.moonInfoButton1.Location = new System.Drawing.Point(365, 157);
            this.moonInfoButton1.Name = "moonInfoButton1";
            this.moonInfoButton1.Size = new System.Drawing.Size(75, 23);
            this.moonInfoButton1.TabIndex = 6;
            this.moonInfoButton1.Text = "moonInfoButton1";
            this.moonInfoButton1.UseVisualStyleBackColor = false;
            // 
            // moonMenu1
            // 
            this.moonMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.moonMenu1.ForeColor = System.Drawing.Color.White;
            this.moonMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.moonMenu1.Location = new System.Drawing.Point(0, 0);
            this.moonMenu1.Name = "moonMenu1";
            this.moonMenu1.Size = new System.Drawing.Size(705, 24);
            this.moonMenu1.TabIndex = 8;
            this.moonMenu1.Text = "moonMenu1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // moonSuccessButton1
            // 
            this.moonSuccessButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.moonSuccessButton1.FlatAppearance.BorderSize = 0;
            this.moonSuccessButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.moonSuccessButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.moonSuccessButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonSuccessButton1.ForeColor = System.Drawing.Color.White;
            this.moonSuccessButton1.Location = new System.Drawing.Point(35, 201);
            this.moonSuccessButton1.Name = "moonSuccessButton1";
            this.moonSuccessButton1.Size = new System.Drawing.Size(75, 23);
            this.moonSuccessButton1.TabIndex = 9;
            this.moonSuccessButton1.Text = "moonSuccessButton1";
            this.moonSuccessButton1.UseVisualStyleBackColor = false;
            // 
            // moonDangerButton2
            // 
            this.moonDangerButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.moonDangerButton2.FlatAppearance.BorderSize = 0;
            this.moonDangerButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.moonDangerButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.moonDangerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonDangerButton2.ForeColor = System.Drawing.Color.Black;
            this.moonDangerButton2.Location = new System.Drawing.Point(373, 48);
            this.moonDangerButton2.Name = "moonDangerButton2";
            this.moonDangerButton2.Size = new System.Drawing.Size(75, 23);
            this.moonDangerButton2.TabIndex = 10;
            this.moonDangerButton2.Text = "moonDangerButton2";
            this.moonDangerButton2.UseVisualStyleBackColor = false;
            // 
            // moonLabel1
            // 
            this.moonLabel1.AutoSize = true;
            this.moonLabel1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.moonLabel1.Location = new System.Drawing.Point(45, 249);
            this.moonLabel1.Name = "moonLabel1";
            this.moonLabel1.Size = new System.Drawing.Size(65, 13);
            this.moonLabel1.TabIndex = 12;
            this.moonLabel1.Text = "moonLabel1";
            // 
            // moonWarnButton1
            // 
            this.moonWarnButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.moonWarnButton1.FlatAppearance.BorderSize = 0;
            this.moonWarnButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.moonWarnButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.moonWarnButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonWarnButton1.ForeColor = System.Drawing.Color.Black;
            this.moonWarnButton1.Location = new System.Drawing.Point(218, 139);
            this.moonWarnButton1.Name = "moonWarnButton1";
            this.moonWarnButton1.Size = new System.Drawing.Size(75, 23);
            this.moonWarnButton1.TabIndex = 13;
            this.moonWarnButton1.Text = "moonWarnButton1";
            this.moonWarnButton1.UseVisualStyleBackColor = false;
            // 
            // moonCheckList1
            // 
            this.moonCheckList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.moonCheckList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moonCheckList1.ForeColor = System.Drawing.Color.White;
            this.moonCheckList1.FormattingEnabled = true;
            this.moonCheckList1.Items.AddRange(new object[] {
            "aaaa",
            "bbbbbb",
            "ccccccccc",
            "ddddddddddd",
            "eeee",
            "tttt"});
            this.moonCheckList1.Location = new System.Drawing.Point(499, 48);
            this.moonCheckList1.Name = "moonCheckList1";
            this.moonCheckList1.Size = new System.Drawing.Size(174, 120);
            this.moonCheckList1.TabIndex = 14;
            // 
            // moonList1
            // 
            this.moonList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.moonList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moonList1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.moonList1.ForeColor = System.Drawing.Color.White;
            this.moonList1.FormattingEnabled = true;
            this.moonList1.Items.AddRange(new object[] {
            "fbdf",
            "f",
            "b",
            "df",
            "bd",
            "f",
            "bdf"});
            this.moonList1.Location = new System.Drawing.Point(35, 66);
            this.moonList1.Name = "moonList1";
            this.moonList1.Size = new System.Drawing.Size(120, 96);
            this.moonList1.TabIndex = 15;
            // 
            // moonGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.moonGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.moonGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.moonGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moonGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.moonGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moonGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.moonGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.moonGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.moonGrid1.EnableHeadersVisualStyles = false;
            this.moonGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.moonGrid1.Location = new System.Drawing.Point(218, 213);
            this.moonGrid1.Name = "moonGrid1";
            this.moonGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moonGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.moonGrid1.Size = new System.Drawing.Size(345, 192);
            this.moonGrid1.TabIndex = 16;
            // 
            // moonToggle1
            // 
            this.moonToggle1.AutoSize = true;
            this.moonToggle1.ForeColor = System.Drawing.Color.White;
            this.moonToggle1.Location = new System.Drawing.Point(602, 340);
            this.moonToggle1.MinimumSize = new System.Drawing.Size(46, 22);
            this.moonToggle1.Name = "moonToggle1";
            this.moonToggle1.Size = new System.Drawing.Size(46, 22);
            this.moonToggle1.TabIndex = 17;
            this.moonToggle1.UseVisualStyleBackColor = true;
            this.moonToggle1.CheckedChanged += new System.EventHandler(this.moonToggle1_CheckedChanged);
            // 
            // moonTip1
            // 
            this.moonTip1.AutoPopDelay = 99999;
            this.moonTip1.InitialDelay = 0;
            this.moonTip1.OwnerDraw = true;
            this.moonTip1.ReshowDelay = 0;
            this.moonTip1.ShowAlways = true;
            this.moonTip1.UseAnimation = false;
            this.moonTip1.UseFading = false;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 438);
            this.Controls.Add(this.moonToggle1);
            this.Controls.Add(this.moonGrid1);
            this.Controls.Add(this.moonList1);
            this.Controls.Add(this.moonCheckList1);
            this.Controls.Add(this.moonWarnButton1);
            this.Controls.Add(this.moonLabel1);
            this.Controls.Add(this.moonDangerButton2);
            this.Controls.Add(this.moonSuccessButton1);
            this.Controls.Add(this.moonInfoButton1);
            this.Controls.Add(this.moonTextField1);
            this.Controls.Add(this.moonButton1);
            this.Controls.Add(this.moonMenu1);
            this.MainMenuStrip = this.moonMenu1;
            this.Name = "DemoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.moonMenu1.ResumeLayout(false);
            this.moonMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moonGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MoonUI.MoonButton moonButton1;
        private MoonUI.MoonTextField moonTextField1;
        private MoonUI.MoonInfoButton moonInfoButton1;
        private MoonUI.MoonMenu moonMenu1;
        private MoonUI.MoonSuccessButton moonSuccessButton1;
        private MoonUI.MoonDangerButton moonDangerButton2;
        private MoonUI.MoonLabel moonLabel1;
        private MoonUI.MoonWarnButton moonWarnButton1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private MoonUI.MoonCheckList moonCheckList1;
        private MoonUI.MoonList moonList1;
        private MoonUI.MoonGrid moonGrid1;
        private MoonUI.MoonToggle moonToggle1;
        private MoonUI.MoonTip moonTip1;
    }
}

