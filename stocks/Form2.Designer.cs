namespace stocks
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_histo = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.numericUp_qtt = new System.Windows.Forms.NumericUpDown();
            this.tb_pn = new System.Windows.Forms.TextBox();
            this.tb_machine = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.bt_insert = new System.Windows.Forms.Button();
            this.lb_username = new System.Windows.Forms.Label();
            this.bt_check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_histo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp_qtt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(299, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Machine :";
            // 
            // dg_histo
            // 
            this.dg_histo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_histo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_histo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_histo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_histo.Enabled = false;
            this.dg_histo.Location = new System.Drawing.Point(-1, 254);
            this.dg_histo.Name = "dg_histo";
            this.dg_histo.RowTemplate.Height = 25;
            this.dg_histo.Size = new System.Drawing.Size(523, 150);
            this.dg_histo.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::stocks.Properties.Resources.LOGO_ES;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(299, 146);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(51, 24);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "QTT :";
            // 
            // numericUp_qtt
            // 
            this.numericUp_qtt.Enabled = false;
            this.numericUp_qtt.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUp_qtt.Location = new System.Drawing.Point(368, 144);
            this.numericUp_qtt.Name = "numericUp_qtt";
            this.numericUp_qtt.Size = new System.Drawing.Size(100, 31);
            this.numericUp_qtt.TabIndex = 6;
            this.numericUp_qtt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_pn
            // 
            this.tb_pn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pn.Location = new System.Drawing.Point(133, 69);
            this.tb_pn.Name = "tb_pn";
            this.tb_pn.Size = new System.Drawing.Size(100, 31);
            this.tb_pn.TabIndex = 7;
            // 
            // tb_machine
            // 
            this.tb_machine.Enabled = false;
            this.tb_machine.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_machine.Location = new System.Drawing.Point(133, 143);
            this.tb_machine.Name = "tb_machine";
            this.tb_machine.Size = new System.Drawing.Size(100, 31);
            this.tb_machine.TabIndex = 8;
            // 
            // tb_stock
            // 
            this.tb_stock.Enabled = false;
            this.tb_stock.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_stock.Location = new System.Drawing.Point(368, 67);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(100, 31);
            this.tb_stock.TabIndex = 9;
            // 
            // bt_insert
            // 
            this.bt_insert.Enabled = false;
            this.bt_insert.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_insert.Location = new System.Drawing.Point(368, 202);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(100, 37);
            this.bt_insert.TabIndex = 10;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(430, 9);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(59, 15);
            this.lb_username.TabIndex = 11;
            this.lb_username.Text = "username";
            // 
            // bt_check
            // 
            this.bt_check.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_check.Location = new System.Drawing.Point(239, 69);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(31, 31);
            this.bt_check.TabIndex = 12;
            this.bt_check.Text = "✔️";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 403);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.tb_machine);
            this.Controls.Add(this.tb_pn);
            this.Controls.Add(this.numericUp_qtt);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dg_histo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_histo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp_qtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dg_histo;
        private DataGridView dataGridView2;
        private Label lb_username;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Label label7;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox2;
        private Label lbl;
        private NumericUpDown numericUp_qtt;
        private TextBox tb_pn;
        private TextBox tb_machine;
        private TextBox tb_stock;
        private Button bt_insert;
        private Button bt_check;
    }
}