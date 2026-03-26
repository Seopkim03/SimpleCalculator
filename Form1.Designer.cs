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
            btnMod = new Button();
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
            btnSquare = new Button();
            btnRoot = new Button();
            lstHistory = new ListBox();
            btnClrHis = new Button();
            SuspendLayout();
            // 
            // lblCal
            // 
            lblCal.AutoSize = true;
            lblCal.Font = new Font("한컴 말랑말랑 Regular", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 129);
            lblCal.ForeColor = SystemColors.MenuHighlight;
            lblCal.Location = new Point(12, 9);
            lblCal.Name = "lblCal";
            lblCal.Size = new Size(323, 47);
            lblCal.TabIndex = 0;
            lblCal.Text = "Simple Calculator";
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.GrayText;
            btnCE.Font = new Font("한컴산뜻돋움", 15.75F);
            btnCE.ForeColor = SystemColors.ButtonHighlight;
            btnCE.Location = new Point(12, 218);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(102, 39);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.UseWaitCursor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.GrayText;
            btnC.Font = new Font("한컴산뜻돋움", 15.75F);
            btnC.ForeColor = SystemColors.ButtonHighlight;
            btnC.Location = new Point(120, 218);
            btnC.Name = "btnC";
            btnC.Size = new Size(102, 39);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = SystemColors.GrayText;
            btnMod.Font = new Font("한컴산뜻돋움", 15.75F);
            btnMod.ForeColor = SystemColors.ButtonHighlight;
            btnMod.Location = new Point(228, 173);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(102, 39);
            btnMod.TabIndex = 5;
            btnMod.Text = "mod";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // btnOpDiv
            // 
            btnOpDiv.BackColor = SystemColors.GrayText;
            btnOpDiv.Font = new Font("한컴산뜻돋움", 15.75F);
            btnOpDiv.ForeColor = SystemColors.ButtonHighlight;
            btnOpDiv.Location = new Point(336, 218);
            btnOpDiv.Name = "btnOpDiv";
            btnOpDiv.Size = new Size(102, 39);
            btnOpDiv.TabIndex = 6;
            btnOpDiv.Text = "÷";
            btnOpDiv.UseVisualStyleBackColor = false;
            btnOpDiv.Click += btnOpDiv_Click;
            // 
            // btnOpTimes
            // 
            btnOpTimes.BackColor = SystemColors.GrayText;
            btnOpTimes.Font = new Font("한컴산뜻돋움", 15.75F);
            btnOpTimes.ForeColor = SystemColors.ButtonHighlight;
            btnOpTimes.Location = new Point(336, 263);
            btnOpTimes.Name = "btnOpTimes";
            btnOpTimes.Size = new Size(102, 39);
            btnOpTimes.TabIndex = 10;
            btnOpTimes.Text = "×";
            btnOpTimes.UseVisualStyleBackColor = false;
            btnOpTimes.Click += btnOpTimes_Click;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = SystemColors.GrayText;
            btnNum9.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum9.ForeColor = SystemColors.ButtonHighlight;
            btnNum9.Location = new Point(228, 263);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(102, 39);
            btnNum9.TabIndex = 9;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = SystemColors.GrayText;
            btnNum8.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum8.ForeColor = SystemColors.ButtonHighlight;
            btnNum8.Location = new Point(120, 263);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(102, 39);
            btnNum8.TabIndex = 8;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = SystemColors.GrayText;
            btnNum7.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum7.ForeColor = SystemColors.ButtonHighlight;
            btnNum7.Location = new Point(12, 263);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(102, 39);
            btnNum7.TabIndex = 7;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnOpMinus
            // 
            btnOpMinus.BackColor = SystemColors.GrayText;
            btnOpMinus.Font = new Font("한컴산뜻돋움", 15.75F);
            btnOpMinus.ForeColor = SystemColors.ButtonHighlight;
            btnOpMinus.Location = new Point(336, 308);
            btnOpMinus.Name = "btnOpMinus";
            btnOpMinus.Size = new Size(102, 39);
            btnOpMinus.TabIndex = 14;
            btnOpMinus.Text = "-";
            btnOpMinus.UseVisualStyleBackColor = false;
            btnOpMinus.Click += btnOpMinus_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = SystemColors.GrayText;
            btnNum6.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum6.ForeColor = SystemColors.ButtonHighlight;
            btnNum6.Location = new Point(228, 308);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(102, 39);
            btnNum6.TabIndex = 13;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = SystemColors.GrayText;
            btnNum5.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum5.ForeColor = SystemColors.ButtonHighlight;
            btnNum5.Location = new Point(120, 308);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(102, 39);
            btnNum5.TabIndex = 12;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = SystemColors.GrayText;
            btnNum4.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum4.ForeColor = SystemColors.ButtonHighlight;
            btnNum4.Location = new Point(12, 308);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(102, 39);
            btnNum4.TabIndex = 11;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnOpPlus
            // 
            btnOpPlus.BackColor = SystemColors.GrayText;
            btnOpPlus.Font = new Font("한컴산뜻돋움", 15.75F);
            btnOpPlus.ForeColor = SystemColors.ButtonHighlight;
            btnOpPlus.Location = new Point(336, 353);
            btnOpPlus.Name = "btnOpPlus";
            btnOpPlus.Size = new Size(102, 39);
            btnOpPlus.TabIndex = 18;
            btnOpPlus.Text = "+";
            btnOpPlus.UseVisualStyleBackColor = false;
            btnOpPlus.Click += btnOpPlus_Click;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = SystemColors.GrayText;
            btnNum3.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum3.ForeColor = SystemColors.ButtonHighlight;
            btnNum3.Location = new Point(228, 353);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(102, 39);
            btnNum3.TabIndex = 17;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = SystemColors.GrayText;
            btnNum2.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum2.ForeColor = SystemColors.ButtonHighlight;
            btnNum2.Location = new Point(120, 353);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(102, 39);
            btnNum2.TabIndex = 16;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = SystemColors.GrayText;
            btnNum1.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum1.ForeColor = SystemColors.ButtonHighlight;
            btnNum1.Location = new Point(12, 353);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(102, 39);
            btnNum1.TabIndex = 15;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnOpEq
            // 
            btnOpEq.BackColor = SystemColors.GrayText;
            btnOpEq.Font = new Font("한컴산뜻돋움", 15.75F);
            btnOpEq.ForeColor = SystemColors.ButtonHighlight;
            btnOpEq.Location = new Point(336, 398);
            btnOpEq.Name = "btnOpEq";
            btnOpEq.Size = new Size(102, 39);
            btnOpEq.TabIndex = 22;
            btnOpEq.Text = "=";
            btnOpEq.UseVisualStyleBackColor = false;
            btnOpEq.Click += btnOpEq_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.GrayText;
            btnDot.Font = new Font("한컴산뜻돋움", 15.75F);
            btnDot.ForeColor = SystemColors.ButtonHighlight;
            btnDot.Location = new Point(228, 398);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(102, 39);
            btnDot.TabIndex = 21;
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = SystemColors.GrayText;
            btnNum0.Font = new Font("한컴산뜻돋움", 15.75F);
            btnNum0.ForeColor = SystemColors.ButtonHighlight;
            btnNum0.Location = new Point(120, 398);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(102, 39);
            btnNum0.TabIndex = 20;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = SystemColors.GrayText;
            btnPlusMinus.Font = new Font("한컴산뜻돋움", 15.75F);
            btnPlusMinus.ForeColor = SystemColors.ButtonHighlight;
            btnPlusMinus.Location = new Point(12, 398);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(102, 39);
            btnPlusMinus.TabIndex = 19;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
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
            btnBack.BackColor = SystemColors.GrayText;
            btnBack.Font = new Font("한컴산뜻돋움", 15.75F);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(336, 173);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 39);
            btnBack.TabIndex = 32;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GrayText;
            button2.Font = new Font("한컴산뜻돋움", 15.75F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(228, 218);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 31;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = SystemColors.GrayText;
            btnSquare.Font = new Font("한컴산뜻돋움", 15.75F);
            btnSquare.ForeColor = SystemColors.ButtonHighlight;
            btnSquare.Location = new Point(120, 173);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(102, 39);
            btnSquare.TabIndex = 30;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = SystemColors.GrayText;
            btnRoot.Font = new Font("한컴산뜻돋움", 15.75F);
            btnRoot.ForeColor = SystemColors.ButtonHighlight;
            btnRoot.Location = new Point(12, 173);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(102, 39);
            btnRoot.TabIndex = 29;
            btnRoot.Text = "√";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnRoot_Click;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 15;
            lstHistory.Location = new Point(453, 21);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(262, 409);
            lstHistory.TabIndex = 33;
            lstHistory.SelectedIndexChanged += lstHistory_SelectedIndexChanged;
            // 
            // btnClrHis
            // 
            btnClrHis.BackColor = Color.IndianRed;
            btnClrHis.Font = new Font("한컴산뜻돋움", 15.75F);
            btnClrHis.ForeColor = SystemColors.ButtonHighlight;
            btnClrHis.Location = new Point(364, 21);
            btnClrHis.Name = "btnClrHis";
            btnClrHis.Size = new Size(74, 39);
            btnClrHis.TabIndex = 34;
            btnClrHis.Text = "CLR";
            btnClrHis.UseVisualStyleBackColor = false;
            btnClrHis.Click += btnClrHis_Click;
            // 
            // Calculator
            // 
            AcceptButton = btnOpEq;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(727, 453);
            Controls.Add(btnClrHis);
            Controls.Add(lstHistory);
            Controls.Add(btnBack);
            Controls.Add(button2);
            Controls.Add(btnSquare);
            Controls.Add(btnRoot);
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
            Controls.Add(btnMod);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(lblCal);
            KeyPreview = true;
            Name = "Calculator";
            Text = "Calculator v1.0";
            KeyDown += Calculator_KeyDown;
            KeyPress += Calculator_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCal;
        private Button btnCE;
        private Button btnC;
        private Button btnMod;
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
        private Button btnSquare;
        private Button btnRoot;
        private ListBox lstHistory;
        private Button btnClrHis;
    }
}
