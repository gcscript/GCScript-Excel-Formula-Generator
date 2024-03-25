namespace GCScript_Excel_Formula_Generator
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txt_SheetName = new TextBox();
            txt_ColumnName = new TextBox();
            txt_Mode01 = new TextBox();
            txt_Mode02 = new TextBox();
            txt_Mode03 = new TextBox();
            btn_CopyMode01 = new Button();
            btn_CopyMode02 = new Button();
            btn_CopyMode03 = new Button();
            lbl_Mode01 = new Label();
            lbl_Mode02 = new Label();
            lbl_Mode03 = new Label();
            lbl_ExampleMode01 = new Label();
            lbl_ExampleMode02 = new Label();
            lbl_ExampleMode03 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 5, 1);
            tableLayoutPanel1.Controls.Add(txt_SheetName, 1, 2);
            tableLayoutPanel1.Controls.Add(txt_ColumnName, 5, 2);
            tableLayoutPanel1.Controls.Add(txt_Mode01, 1, 5);
            tableLayoutPanel1.Controls.Add(txt_Mode02, 1, 7);
            tableLayoutPanel1.Controls.Add(txt_Mode03, 1, 9);
            tableLayoutPanel1.Controls.Add(btn_CopyMode01, 8, 5);
            tableLayoutPanel1.Controls.Add(btn_CopyMode02, 8, 7);
            tableLayoutPanel1.Controls.Add(btn_CopyMode03, 8, 9);
            tableLayoutPanel1.Controls.Add(lbl_Mode01, 1, 4);
            tableLayoutPanel1.Controls.Add(lbl_Mode02, 1, 6);
            tableLayoutPanel1.Controls.Add(lbl_Mode03, 1, 8);
            tableLayoutPanel1.Controls.Add(lbl_ExampleMode01, 7, 4);
            tableLayoutPanel1.Controls.Add(lbl_ExampleMode02, 7, 6);
            tableLayoutPanel1.Controls.Add(lbl_ExampleMode03, 7, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(582, 243);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 4);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Consolas", 9F);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(258, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome da Planilha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 4);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Consolas", 9F);
            label2.Location = new Point(277, 10);
            label2.Name = "label2";
            label2.Size = new Size(292, 18);
            label2.TabIndex = 1;
            label2.Text = "Nome da Coluna";
            // 
            // txt_SheetName
            // 
            txt_SheetName.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(txt_SheetName, 4);
            txt_SheetName.Dock = DockStyle.Fill;
            txt_SheetName.Location = new Point(13, 31);
            txt_SheetName.MaxLength = 30;
            txt_SheetName.Name = "txt_SheetName";
            txt_SheetName.Size = new Size(258, 25);
            txt_SheetName.TabIndex = 0;
            txt_SheetName.TextChanged += txt_SheetName_TextChanged;
            // 
            // txt_ColumnName
            // 
            txt_ColumnName.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(txt_ColumnName, 4);
            txt_ColumnName.Dock = DockStyle.Fill;
            txt_ColumnName.Location = new Point(277, 31);
            txt_ColumnName.MaxLength = 100;
            txt_ColumnName.Name = "txt_ColumnName";
            txt_ColumnName.Size = new Size(292, 25);
            txt_ColumnName.TabIndex = 1;
            txt_ColumnName.TextChanged += txt_ColumnName_TextChanged;
            // 
            // txt_Mode01
            // 
            txt_Mode01.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(txt_Mode01, 7);
            txt_Mode01.Dock = DockStyle.Fill;
            txt_Mode01.Font = new Font("Consolas", 9F, FontStyle.Italic);
            txt_Mode01.Location = new Point(13, 100);
            txt_Mode01.Name = "txt_Mode01";
            txt_Mode01.ReadOnly = true;
            txt_Mode01.Size = new Size(456, 25);
            txt_Mode01.TabIndex = 2;
            // 
            // txt_Mode02
            // 
            txt_Mode02.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(txt_Mode02, 7);
            txt_Mode02.Dock = DockStyle.Fill;
            txt_Mode02.Font = new Font("Consolas", 9F, FontStyle.Italic);
            txt_Mode02.Location = new Point(13, 149);
            txt_Mode02.Name = "txt_Mode02";
            txt_Mode02.ReadOnly = true;
            txt_Mode02.Size = new Size(456, 25);
            txt_Mode02.TabIndex = 4;
            // 
            // txt_Mode03
            // 
            txt_Mode03.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(txt_Mode03, 7);
            txt_Mode03.Dock = DockStyle.Fill;
            txt_Mode03.Font = new Font("Consolas", 9F, FontStyle.Italic);
            txt_Mode03.Location = new Point(13, 198);
            txt_Mode03.Name = "txt_Mode03";
            txt_Mode03.ReadOnly = true;
            txt_Mode03.Size = new Size(456, 25);
            txt_Mode03.TabIndex = 6;
            // 
            // btn_CopyMode01
            // 
            btn_CopyMode01.Dock = DockStyle.Fill;
            btn_CopyMode01.Location = new Point(473, 98);
            btn_CopyMode01.Margin = new Padding(1);
            btn_CopyMode01.Name = "btn_CopyMode01";
            btn_CopyMode01.Size = new Size(98, 29);
            btn_CopyMode01.TabIndex = 3;
            btn_CopyMode01.Text = "Copiar";
            btn_CopyMode01.UseVisualStyleBackColor = true;
            btn_CopyMode01.Click += btn_CopyMode01_Click;
            // 
            // btn_CopyMode02
            // 
            btn_CopyMode02.Dock = DockStyle.Fill;
            btn_CopyMode02.Location = new Point(473, 147);
            btn_CopyMode02.Margin = new Padding(1);
            btn_CopyMode02.Name = "btn_CopyMode02";
            btn_CopyMode02.Size = new Size(98, 29);
            btn_CopyMode02.TabIndex = 5;
            btn_CopyMode02.Text = "Copiar";
            btn_CopyMode02.UseVisualStyleBackColor = true;
            btn_CopyMode02.Click += btn_CopyMode02_Click;
            // 
            // btn_CopyMode03
            // 
            btn_CopyMode03.Dock = DockStyle.Fill;
            btn_CopyMode03.Location = new Point(473, 196);
            btn_CopyMode03.Margin = new Padding(1);
            btn_CopyMode03.Name = "btn_CopyMode03";
            btn_CopyMode03.Size = new Size(98, 29);
            btn_CopyMode03.TabIndex = 7;
            btn_CopyMode03.Text = "Copiar";
            btn_CopyMode03.UseVisualStyleBackColor = true;
            btn_CopyMode03.Click += btn_CopyMode03_Click;
            // 
            // lbl_Mode01
            // 
            lbl_Mode01.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbl_Mode01, 6);
            lbl_Mode01.Dock = DockStyle.Fill;
            lbl_Mode01.Font = new Font("Consolas", 9F);
            lbl_Mode01.Location = new Point(13, 79);
            lbl_Mode01.Name = "lbl_Mode01";
            lbl_Mode01.Size = new Size(390, 18);
            lbl_Mode01.TabIndex = 10;
            lbl_Mode01.Text = "Modo 01";
            // 
            // lbl_Mode02
            // 
            lbl_Mode02.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbl_Mode02, 6);
            lbl_Mode02.Dock = DockStyle.Fill;
            lbl_Mode02.Font = new Font("Consolas", 9F);
            lbl_Mode02.Location = new Point(13, 128);
            lbl_Mode02.Name = "lbl_Mode02";
            lbl_Mode02.Size = new Size(390, 18);
            lbl_Mode02.TabIndex = 11;
            lbl_Mode02.Text = "Modo 02";
            // 
            // lbl_Mode03
            // 
            lbl_Mode03.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbl_Mode03, 6);
            lbl_Mode03.Dock = DockStyle.Fill;
            lbl_Mode03.Font = new Font("Consolas", 9F);
            lbl_Mode03.Location = new Point(13, 177);
            lbl_Mode03.Name = "lbl_Mode03";
            lbl_Mode03.Size = new Size(390, 18);
            lbl_Mode03.TabIndex = 12;
            lbl_Mode03.Text = "Modo 03";
            // 
            // lbl_ExampleMode01
            // 
            lbl_ExampleMode01.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbl_ExampleMode01, 2);
            lbl_ExampleMode01.Dock = DockStyle.Fill;
            lbl_ExampleMode01.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbl_ExampleMode01.ForeColor = Color.Green;
            lbl_ExampleMode01.Location = new Point(409, 79);
            lbl_ExampleMode01.Name = "lbl_ExampleMode01";
            lbl_ExampleMode01.Size = new Size(160, 18);
            lbl_ExampleMode01.TabIndex = 13;
            lbl_ExampleMode01.Text = "Exemplo";
            // 
            // lbl_ExampleMode02
            // 
            lbl_ExampleMode02.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbl_ExampleMode02, 2);
            lbl_ExampleMode02.Dock = DockStyle.Fill;
            lbl_ExampleMode02.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbl_ExampleMode02.ForeColor = Color.Green;
            lbl_ExampleMode02.Location = new Point(409, 128);
            lbl_ExampleMode02.Name = "lbl_ExampleMode02";
            lbl_ExampleMode02.Size = new Size(160, 18);
            lbl_ExampleMode02.TabIndex = 14;
            lbl_ExampleMode02.Text = "Exemplo";
            // 
            // lbl_ExampleMode03
            // 
            lbl_ExampleMode03.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbl_ExampleMode03, 2);
            lbl_ExampleMode03.Dock = DockStyle.Fill;
            lbl_ExampleMode03.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbl_ExampleMode03.ForeColor = Color.Green;
            lbl_ExampleMode03.Location = new Point(409, 177);
            lbl_ExampleMode03.Name = "lbl_ExampleMode03";
            lbl_ExampleMode03.Size = new Size(160, 18);
            lbl_ExampleMode03.TabIndex = 15;
            lbl_ExampleMode03.Text = "Exemplo";
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 243);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 290);
            Name = "frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCScript Excel Formula Generator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox txt_SheetName;
        private TextBox txt_ColumnName;
        private TextBox txt_Mode01;
        private TextBox txt_Mode02;
        private TextBox txt_Mode03;
        private Button btn_CopyMode01;
        private Button btn_CopyMode02;
        private Button btn_CopyMode03;
        private Label lbl_Mode01;
        private Label lbl_Mode02;
        private Label lbl_Mode03;
        private Label lbl_ExampleMode01;
        private Label lbl_ExampleMode02;
        private Label lbl_ExampleMode03;
    }
}
