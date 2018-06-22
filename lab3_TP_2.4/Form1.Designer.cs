namespace lab3_TP_2._4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.arrSize = new System.Windows.Forms.TextBox();
            this.lowerBorder = new System.Windows.Forms.TextBox();
            this.upperBorder = new System.Windows.Forms.TextBox();
            this.getArr = new System.Windows.Forms.Button();
            this.numC = new System.Windows.Forms.TextBox();
            this.firstOp = new System.Windows.Forms.Button();
            this.secondOp = new System.Windows.Forms.Button();
            this.thirdOp = new System.Windows.Forms.Button();
            this.foursOp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrSize
            // 
            this.arrSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrSize.Location = new System.Drawing.Point(3, 27);
            this.arrSize.Name = "arrSize";
            this.arrSize.Size = new System.Drawing.Size(73, 34);
            this.arrSize.TabIndex = 0;
            // 
            // lowerBorder
            // 
            this.lowerBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowerBorder.Location = new System.Drawing.Point(98, 27);
            this.lowerBorder.Name = "lowerBorder";
            this.lowerBorder.Size = new System.Drawing.Size(73, 34);
            this.lowerBorder.TabIndex = 1;
            // 
            // upperBorder
            // 
            this.upperBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upperBorder.Location = new System.Drawing.Point(192, 27);
            this.upperBorder.Name = "upperBorder";
            this.upperBorder.Size = new System.Drawing.Size(73, 34);
            this.upperBorder.TabIndex = 2;
            // 
            // getArr
            // 
            this.getArr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getArr.Location = new System.Drawing.Point(284, 27);
            this.getArr.Name = "getArr";
            this.getArr.Size = new System.Drawing.Size(80, 34);
            this.getArr.TabIndex = 3;
            this.getArr.Text = "Get array";
            this.getArr.UseVisualStyleBackColor = true;
            this.getArr.Click += new System.EventHandler(this.getArr_Click);
            // 
            // numC
            // 
            this.numC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numC.Location = new System.Drawing.Point(18, 17);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(73, 34);
            this.numC.TabIndex = 4;
            // 
            // firstOp
            // 
            this.firstOp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstOp.Location = new System.Drawing.Point(106, 17);
            this.firstOp.Name = "firstOp";
            this.firstOp.Size = new System.Drawing.Size(118, 34);
            this.firstOp.TabIndex = 5;
            this.firstOp.Text = "First operation";
            this.firstOp.UseVisualStyleBackColor = true;
            this.firstOp.Click += new System.EventHandler(this.firstOp_Click);
            // 
            // secondOp
            // 
            this.secondOp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondOp.Location = new System.Drawing.Point(106, 57);
            this.secondOp.Name = "secondOp";
            this.secondOp.Size = new System.Drawing.Size(118, 42);
            this.secondOp.TabIndex = 6;
            this.secondOp.Text = "Second operation";
            this.secondOp.UseVisualStyleBackColor = true;
            this.secondOp.Click += new System.EventHandler(this.secondOp_Click);
            // 
            // thirdOp
            // 
            this.thirdOp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.thirdOp.Location = new System.Drawing.Point(106, 105);
            this.thirdOp.Name = "thirdOp";
            this.thirdOp.Size = new System.Drawing.Size(118, 34);
            this.thirdOp.TabIndex = 7;
            this.thirdOp.Text = "Third operation";
            this.thirdOp.UseVisualStyleBackColor = true;
            this.thirdOp.Click += new System.EventHandler(this.thirdOp_Click);
            // 
            // foursOp
            // 
            this.foursOp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.foursOp.Location = new System.Drawing.Point(106, 145);
            this.foursOp.Name = "foursOp";
            this.foursOp.Size = new System.Drawing.Size(118, 34);
            this.foursOp.TabIndex = 8;
            this.foursOp.Text = "Fours operation";
            this.foursOp.UseVisualStyleBackColor = true;
            this.foursOp.Click += new System.EventHandler(this.foursOp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.num});
            this.dataGridView1.Location = new System.Drawing.Point(27, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 364);
            this.dataGridView1.TabIndex = 9;
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // num
            // 
            this.num.HeaderText = "num";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(28, 76);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(372, 22);
            this.output.TabIndex = 10;
            // 
            // Open
            // 
            this.Open.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Open.Location = new System.Drawing.Point(400, 224);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(130, 45);
            this.Open.TabIndex = 11;
            this.Open.Text = "Open file";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.save.Location = new System.Drawing.Point(400, 275);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(130, 45);
            this.save.TabIndex = 12;
            this.save.Text = "Save file";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getArr);
            this.groupBox1.Controls.Add(this.upperBorder);
            this.groupBox1.Controls.Add(this.lowerBorder);
            this.groupBox1.Controls.Add(this.arrSize);
            this.groupBox1.Location = new System.Drawing.Point(24, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 66);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get array buttons";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.foursOp);
            this.groupBox2.Controls.Add(this.thirdOp);
            this.groupBox2.Controls.Add(this.secondOp);
            this.groupBox2.Controls.Add(this.firstOp);
            this.groupBox2.Controls.Add(this.numC);
            this.groupBox2.Location = new System.Drawing.Point(427, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 204);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.output);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Обработчик массивов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrSize;
        private System.Windows.Forms.TextBox lowerBorder;
        private System.Windows.Forms.TextBox upperBorder;
        private System.Windows.Forms.Button getArr;
        private System.Windows.Forms.TextBox numC;
        private System.Windows.Forms.Button firstOp;
        private System.Windows.Forms.Button secondOp;
        private System.Windows.Forms.Button thirdOp;
        private System.Windows.Forms.Button foursOp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

