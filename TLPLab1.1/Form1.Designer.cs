namespace TLPLab1._1
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
            this.btnTest = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.minLenField = new System.Windows.Forms.NumericUpDown();
            this.maxLenField = new System.Windows.Forms.NumericUpDown();
            this.startSymbolField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minLenField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLenField)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(110, 33);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Подставить тест";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 112);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(360, 153);
            this.textBox.TabIndex = 1;
            // 
            // minLenField
            // 
            this.minLenField.Location = new System.Drawing.Point(82, 84);
            this.minLenField.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.minLenField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minLenField.Name = "minLenField";
            this.minLenField.Size = new System.Drawing.Size(34, 20);
            this.minLenField.TabIndex = 2;
            this.minLenField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxLenField
            // 
            this.maxLenField.Location = new System.Drawing.Point(194, 84);
            this.maxLenField.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maxLenField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxLenField.Name = "maxLenField";
            this.maxLenField.Size = new System.Drawing.Size(34, 20);
            this.maxLenField.TabIndex = 3;
            this.maxLenField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startSymbolField
            // 
            this.startSymbolField.Location = new System.Drawing.Point(122, 63);
            this.startSymbolField.MaxLength = 1;
            this.startSymbolField.Name = "startSymbolField";
            this.startSymbolField.Size = new System.Drawing.Size(20, 20);
            this.startSymbolField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Стартовый символ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min Длина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Длина:";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 271);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(112, 31);
            this.btnGen.TabIndex = 8;
            this.btnGen.Text = "Сгенерировать";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 308);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(360, 291);
            this.textBoxResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 611);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startSymbolField);
            this.Controls.Add(this.maxLenField);
            this.Controls.Add(this.minLenField);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minLenField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLenField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.NumericUpDown minLenField;
        private System.Windows.Forms.NumericUpDown maxLenField;
        private System.Windows.Forms.TextBox startSymbolField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

