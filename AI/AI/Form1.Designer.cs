namespace AI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRoad = new System.Windows.Forms.CheckBox();
            this.checkBoxPeople = new System.Windows.Forms.CheckBox();
            this.rGreen = new System.Windows.Forms.RadioButton();
            this.rYellow = new System.Windows.Forms.RadioButton();
            this.rRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRoad = new System.Windows.Forms.TextBox();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.wGreen = new System.Windows.Forms.TextBox();
            this.wYellow = new System.Windows.Forms.TextBox();
            this.wRed = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnCalcSum = new System.Windows.Forms.Button();
            this.btnEduRed = new System.Windows.Forms.Button();
            this.btnEduAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxFest = new System.Windows.Forms.CheckBox();
            this.textBoxFest = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFest);
            this.groupBox1.Controls.Add(this.checkBoxRoad);
            this.groupBox1.Controls.Add(this.checkBoxPeople);
            this.groupBox1.Controls.Add(this.rGreen);
            this.groupBox1.Controls.Add(this.rYellow);
            this.groupBox1.Controls.Add(this.rRed);
            this.groupBox1.Location = new System.Drawing.Point(34, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвет сфетофора";
            // 
            // checkBoxRoad
            // 
            this.checkBoxRoad.AutoSize = true;
            this.checkBoxRoad.Location = new System.Drawing.Point(17, 189);
            this.checkBoxRoad.Name = "checkBoxRoad";
            this.checkBoxRoad.Size = new System.Drawing.Size(163, 24);
            this.checkBoxRoad.TabIndex = 10;
            this.checkBoxRoad.Text = "Дорожные работы";
            this.checkBoxRoad.UseVisualStyleBackColor = true;
            this.checkBoxRoad.CheckedChanged += new System.EventHandler(this.checkBoxRoad_CheckedChanged);
            // 
            // checkBoxPeople
            // 
            this.checkBoxPeople.AutoSize = true;
            this.checkBoxPeople.Location = new System.Drawing.Point(17, 159);
            this.checkBoxPeople.Name = "checkBoxPeople";
            this.checkBoxPeople.Size = new System.Drawing.Size(76, 24);
            this.checkBoxPeople.TabIndex = 9;
            this.checkBoxPeople.Text = "People";
            this.checkBoxPeople.UseVisualStyleBackColor = true;
            this.checkBoxPeople.CheckedChanged += new System.EventHandler(this.checkBoxPeople_CheckedChanged);
            // 
            // rGreen
            // 
            this.rGreen.AutoSize = true;
            this.rGreen.Location = new System.Drawing.Point(17, 108);
            this.rGreen.Name = "rGreen";
            this.rGreen.Size = new System.Drawing.Size(91, 24);
            this.rGreen.TabIndex = 8;
            this.rGreen.TabStop = true;
            this.rGreen.Text = "Зеленый";
            this.rGreen.UseVisualStyleBackColor = true;
            this.rGreen.CheckedChanged += new System.EventHandler(this.changeLed);
            // 
            // rYellow
            // 
            this.rYellow.AutoSize = true;
            this.rYellow.Location = new System.Drawing.Point(17, 75);
            this.rYellow.Name = "rYellow";
            this.rYellow.Size = new System.Drawing.Size(85, 24);
            this.rYellow.TabIndex = 7;
            this.rYellow.TabStop = true;
            this.rYellow.Text = "Желтый";
            this.rYellow.UseVisualStyleBackColor = true;
            this.rYellow.CheckedChanged += new System.EventHandler(this.changeLed);
            // 
            // rRed
            // 
            this.rRed.AutoSize = true;
            this.rRed.Location = new System.Drawing.Point(17, 42);
            this.rRed.Name = "rRed";
            this.rRed.Size = new System.Drawing.Size(92, 24);
            this.rRed.TabIndex = 6;
            this.rRed.TabStop = true;
            this.rRed.Text = "Красный";
            this.rRed.UseVisualStyleBackColor = true;
            this.rRed.CheckedChanged += new System.EventHandler(this.changeLed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFest);
            this.groupBox2.Controls.Add(this.textBoxRoad);
            this.groupBox2.Controls.Add(this.textBoxPeople);
            this.groupBox2.Controls.Add(this.wGreen);
            this.groupBox2.Controls.Add(this.wYellow);
            this.groupBox2.Controls.Add(this.wRed);
            this.groupBox2.Location = new System.Drawing.Point(273, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Веса";
            // 
            // textBoxRoad
            // 
            this.textBoxRoad.Location = new System.Drawing.Point(19, 189);
            this.textBoxRoad.Name = "textBoxRoad";
            this.textBoxRoad.Size = new System.Drawing.Size(111, 27);
            this.textBoxRoad.TabIndex = 6;
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Location = new System.Drawing.Point(19, 156);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.Size = new System.Drawing.Size(111, 27);
            this.textBoxPeople.TabIndex = 5;
            // 
            // wGreen
            // 
            this.wGreen.Location = new System.Drawing.Point(19, 105);
            this.wGreen.Name = "wGreen";
            this.wGreen.Size = new System.Drawing.Size(111, 27);
            this.wGreen.TabIndex = 4;
            // 
            // wYellow
            // 
            this.wYellow.Location = new System.Drawing.Point(19, 72);
            this.wYellow.Name = "wYellow";
            this.wYellow.Size = new System.Drawing.Size(111, 27);
            this.wYellow.TabIndex = 3;
            // 
            // wRed
            // 
            this.wRed.Location = new System.Drawing.Point(19, 39);
            this.wRed.Name = "wRed";
            this.wRed.Size = new System.Drawing.Size(111, 27);
            this.wRed.TabIndex = 2;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(510, 80);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(111, 27);
            this.textResult.TabIndex = 5;
            // 
            // btnCalcSum
            // 
            this.btnCalcSum.Location = new System.Drawing.Point(510, 141);
            this.btnCalcSum.Name = "btnCalcSum";
            this.btnCalcSum.Size = new System.Drawing.Size(111, 29);
            this.btnCalcSum.TabIndex = 6;
            this.btnCalcSum.Text = "Calc Sum";
            this.btnCalcSum.UseVisualStyleBackColor = true;
            this.btnCalcSum.Click += new System.EventHandler(this.btnCalcSum_Click);
            // 
            // btnEduRed
            // 
            this.btnEduRed.Location = new System.Drawing.Point(51, 322);
            this.btnEduRed.Name = "btnEduRed";
            this.btnEduRed.Size = new System.Drawing.Size(111, 29);
            this.btnEduRed.TabIndex = 7;
            this.btnEduRed.Text = "EduRed";
            this.btnEduRed.UseVisualStyleBackColor = true;
            this.btnEduRed.Click += new System.EventHandler(this.btnEduRed_Click);
            // 
            // btnEduAll
            // 
            this.btnEduAll.Location = new System.Drawing.Point(273, 322);
            this.btnEduAll.Name = "btnEduAll";
            this.btnEduAll.Size = new System.Drawing.Size(111, 29);
            this.btnEduAll.TabIndex = 8;
            this.btnEduAll.Text = "EduAll";
            this.btnEduAll.UseVisualStyleBackColor = true;
            this.btnEduAll.Click += new System.EventHandler(this.btnEduAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "100 Times";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxFest
            // 
            this.checkBoxFest.AutoSize = true;
            this.checkBoxFest.Location = new System.Drawing.Point(17, 219);
            this.checkBoxFest.Name = "checkBoxFest";
            this.checkBoxFest.Size = new System.Drawing.Size(99, 24);
            this.checkBoxFest.TabIndex = 11;
            this.checkBoxFest.Text = "Праздник";
            this.checkBoxFest.UseVisualStyleBackColor = true;
            this.checkBoxFest.CheckedChanged += new System.EventHandler(this.checkBoxFest_CheckedChanged);
            // 
            // textBoxFest
            // 
            this.textBoxFest.Location = new System.Drawing.Point(19, 222);
            this.textBoxFest.Name = "textBoxFest";
            this.textBoxFest.Size = new System.Drawing.Size(111, 27);
            this.textBoxFest.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEduAll);
            this.Controls.Add(this.btnEduRed);
            this.Controls.Add(this.btnCalcSum);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rGreen;
        private RadioButton rYellow;
        private RadioButton rRed;
        private GroupBox groupBox2;
        public TextBox wGreen;
        public TextBox wYellow;
        public TextBox wRed;
        private Button btnCalcSum;
        public TextBox textResult;
        private Button btnEduRed;
        private Button btnEduAll;
        private CheckBox checkBoxPeople;
        public TextBox textBoxPeople;
        private Button button1;
        private CheckBox checkBoxRoad;
        public TextBox textBoxRoad;
        private CheckBox checkBoxFest;
        public TextBox textBoxFest;
    }
}