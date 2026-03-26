namespace SimpleCalculator
{
    partial class Calculator
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
            lblCal = new Label();
            btnCE = new Button();
            btnC = new Button();
            btnDel = new Button();
            btnOpDiv = new Button();
            btnOpTimes = new Button();
            btnNum9 = new Button();
            btnNum8 = new Button();
            btnNum7 = new Button();
            btnOpMinus = new Button();
            btnNum6 = new Button();
            btnNum5 = new Button();
            btnNum4 = new Button();
            btnOpPlus = new Button();
            btnNum3 = new Button();
            btnNum2 = new Button();
            btnNum1 = new Button();
            btnOpEq = new Button();
            btnDot = new Button();
            btnNum0 = new Button();
            btnPlusMinus = new Button();
            txtDisplay = new TextBox();
            txtResult = new TextBox();
            btnBack = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // lblCal
            // 
            lblCal.AutoSize = true;
            lblCal.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCal.Location = new Point(12, 9);
            lblCal.Name = "lblCal";
            lblCal.Size = new Size(298, 47);
            lblCal.TabIndex = 0;
            lblCal.Text = "Simple Calculator";
            // 
            // btnCE
            // 
            btnCE.Location = new Point(12, 218);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(102, 39);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.UseWaitCursor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(120, 218);
            btnC.Name = "btnC";
            btnC.Size = new Size(102, 39);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(228, 218);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(102, 39);
            btnDel.TabIndex = 5;
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnOpDiv
            // 
            btnOpDiv.Font = new Font("맑은 고딕", 14.25F);
            btnOpDiv.Location = new Point(336, 218);
            btnOpDiv.Name = "btnOpDiv";
            btnOpDiv.Size = new Size(102, 39);
            btnOpDiv.TabIndex = 6;
            btnOpDiv.Text = "÷";
            btnOpDiv.UseVisualStyleBackColor = true;
            btnOpDiv.Click += btnOpDiv_Click;
            // 
            // btnOpTimes
            // 
            btnOpTimes.Font = new Font("맑은 고딕", 14.25F);
            btnOpTimes.Location = new Point(336, 263);
            btnOpTimes.Name = "btnOpTimes";
            btnOpTimes.Size = new Size(102, 39);
            btnOpTimes.TabIndex = 10;
            btnOpTimes.Text = "×";
            btnOpTimes.UseVisualStyleBackColor = true;
            btnOpTimes.Click += btnOpTimes_Click;
            // 
            // btnNum9
            // 
            btnNum9.Location = new Point(228, 263);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(102, 39);
            btnNum9.TabIndex = 9;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum8
            // 
            btnNum8.Location = new Point(120, 263);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(102, 39);
            btnNum8.TabIndex = 8;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum7
            // 
            btnNum7.Location = new Point(12, 263);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(102, 39);
            btnNum7.TabIndex = 7;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnOpMinus
            // 
            btnOpMinus.Font = new Font("맑은 고딕", 14.25F);
            btnOpMinus.Location = new Point(336, 308);
            btnOpMinus.Name = "btnOpMinus";
            btnOpMinus.Size = new Size(102, 39);
            btnOpMinus.TabIndex = 14;
            btnOpMinus.Text = "-";
            btnOpMinus.UseVisualStyleBackColor = true;
            btnOpMinus.Click += btnOpMinus_Click;
            // 
            // btnNum6
            // 
            btnNum6.Location = new Point(228, 308);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(102, 39);
            btnNum6.TabIndex = 13;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum5
            // 
            btnNum5.Location = new Point(120, 308);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(102, 39);
            btnNum5.TabIndex = 12;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum4
            // 
            btnNum4.Location = new Point(12, 308);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(102, 39);
            btnNum4.TabIndex = 11;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnOpPlus
            // 
            btnOpPlus.Font = new Font("맑은 고딕", 14.25F);
            btnOpPlus.Location = new Point(336, 353);
            btnOpPlus.Name = "btnOpPlus";
            btnOpPlus.Size = new Size(102, 39);
            btnOpPlus.TabIndex = 18;
            btnOpPlus.Text = "+";
            btnOpPlus.UseVisualStyleBackColor = true;
            btnOpPlus.Click += btnOpPlus_Click;
            // 
            // btnNum3
            // 
            btnNum3.Location = new Point(228, 353);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(102, 39);
            btnNum3.TabIndex = 17;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum2
            // 
            btnNum2.Location = new Point(120, 353);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(102, 39);
            btnNum2.TabIndex = 16;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum1
            // 
            btnNum1.Location = new Point(12, 353);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(102, 39);
            btnNum1.TabIndex = 15;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnOpEq
            // 
            btnOpEq.Font = new Font("맑은 고딕", 14.25F);
            btnOpEq.Location = new Point(336, 398);
            btnOpEq.Name = "btnOpEq";
            btnOpEq.Size = new Size(102, 39);
            btnOpEq.TabIndex = 22;
            btnOpEq.Text = "=";
            btnOpEq.UseVisualStyleBackColor = true;
            btnOpEq.Click += btnOpEq_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(228, 398);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(102, 39);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnNum0
            // 
            btnNum0.Location = new Point(120, 398);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(102, 39);
            btnNum0.TabIndex = 20;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Location = new Point(12, 398);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(102, 39);
            btnPlusMinus.TabIndex = 19;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = true;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtDisplay.Location = new Point(14, 78);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(424, 35);
            txtDisplay.TabIndex = 27;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtResult.Location = new Point(14, 119);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(424, 35);
            txtResult.TabIndex = 28;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("맑은 고딕", 14.25F);
            btnBack.Location = new Point(336, 173);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 39);
            btnBack.TabIndex = 32;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 14.25F);
            button2.Location = new Point(228, 173);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 31;
            button2.Text = ".";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(120, 173);
            button3.Name = "button3";
            button3.Size = new Size(102, 39);
            button3.TabIndex = 30;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("맑은 고딕", 14.25F);
            button6.Location = new Point(12, 173);
            button6.Name = "button6";
            button6.Size = new Size(102, 39);
            button6.TabIndex = 29;
            button6.Text = "+/-";
            button6.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 612);
            Controls.Add(btnBack);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(txtResult);
            Controls.Add(txtDisplay);
            Controls.Add(btnOpEq);
            Controls.Add(btnDot);
            Controls.Add(btnNum0);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnOpPlus);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnOpMinus);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnOpTimes);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnOpDiv);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(lblCal);
            KeyPreview = true;
            Name = "Calculator";
            Text = "Calculator v1.0";
            KeyPress += Calculator_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCal;
        private Button btnCE;
        private Button btnC;
        private Button btnDel;
        private Button btnOpDiv;
        private Button btnOpTimes;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum7;
        private Button btnOpMinus;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum4;
        private Button btnOpPlus;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnOpEq;
        private Button btnDot;
        private Button btnNum0;
        private Button btnPlusMinus;
        private TextBox txtDisplay;
        private TextBox txtResult;
        private Button btnBack;
        private Button button2;
        private Button button3;
        private Button button6;
    }
}
