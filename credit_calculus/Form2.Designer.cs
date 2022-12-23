namespace credit_calculus
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(570, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Месяц";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 85;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "(нет)";
            this.Column1.HeaderText = "Платёж";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 85;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Платёж по кредиту";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Платёж по процентам";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Остаток";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown4.Location = new System.Drawing.Point(574, 111);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(57, 27);
            this.numericUpDown4.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(730, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Месяцев";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown5.Location = new System.Drawing.Point(676, 111);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(48, 27);
            this.numericUpDown5.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(637, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Лет";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(574, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Сократить";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(574, 203);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 24);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Платёж";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(574, 173);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 24);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Срок";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 31;
            this.button2.Text = "Расчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(574, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(574, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "ДОСРОЧНОЕ ПОГОШЕНИЕ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "руб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown4;
        private Label label16;
        private NumericUpDown numericUpDown5;
        private Label label17;
        private Label label15;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private TextBox textBox2;
        private Label label14;
        private Label label1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private Label label2;
        private Label label3;
    }
}