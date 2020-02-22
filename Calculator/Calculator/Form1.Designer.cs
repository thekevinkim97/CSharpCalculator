namespace Calculator
{
    partial class Form1
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNeg = new System.Windows.Forms.Button();
            this.btnFrac = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnSq = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSqRT = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnCbRT = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AllowDrop = true;
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 33);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(369, 51);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 57);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNeg
            // 
            this.btnNeg.Location = new System.Drawing.Point(87, 87);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Size = new System.Drawing.Size(69, 57);
            this.btnNeg.TabIndex = 2;
            this.btnNeg.Text = "+/-";
            this.btnNeg.UseVisualStyleBackColor = true;
            this.btnNeg.Click += new System.EventHandler(this.btnNeg_Click);
            // 
            // btnFrac
            // 
            this.btnFrac.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrac.Location = new System.Drawing.Point(162, 87);
            this.btnFrac.Name = "btnFrac";
            this.btnFrac.Size = new System.Drawing.Size(69, 57);
            this.btnFrac.TabIndex = 3;
            this.btnFrac.Text = "/100";
            this.btnFrac.UseVisualStyleBackColor = true;
            this.btnFrac.Click += new System.EventHandler(this.btnFrac_Click);
            // 
            // btnRem
            // 
            this.btnRem.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.Location = new System.Drawing.Point(237, 87);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(69, 57);
            this.btnRem.TabIndex = 4;
            this.btnRem.Text = "%";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnSq
            // 
            this.btnSq.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSq.Location = new System.Drawing.Point(312, 87);
            this.btnSq.Name = "btnSq";
            this.btnSq.Size = new System.Drawing.Size(69, 57);
            this.btnSq.TabIndex = 5;
            this.btnSq.Text = "^2";
            this.btnSq.UseVisualStyleBackColor = true;
            this.btnSq.Click += new System.EventHandler(this.btnSqRT_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 57);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(87, 150);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 57);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(162, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 57);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(237, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 57);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSqRT
            // 
            this.btnSqRT.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqRT.Location = new System.Drawing.Point(312, 150);
            this.btnSqRT.Name = "btnSqRT";
            this.btnSqRT.Size = new System.Drawing.Size(69, 57);
            this.btnSqRT.TabIndex = 10;
            this.btnSqRT.Text = "SqrRt";
            this.btnSqRT.UseVisualStyleBackColor = true;
            this.btnSqRT.Click += new System.EventHandler(this.btnSqRT_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 213);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 57);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(87, 213);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 57);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(162, 213);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 57);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(237, 213);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(69, 57);
            this.btnSub.TabIndex = 14;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnCube
            // 
            this.btnCube.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCube.Location = new System.Drawing.Point(312, 213);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(69, 57);
            this.btnCube.TabIndex = 15;
            this.btnCube.Text = "^3";
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 276);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 57);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(87, 276);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 57);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(162, 276);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 57);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(237, 276);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(69, 57);
            this.btnMult.TabIndex = 19;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnCbRT
            // 
            this.btnCbRT.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCbRT.Location = new System.Drawing.Point(312, 276);
            this.btnCbRT.Name = "btnCbRT";
            this.btnCbRT.Size = new System.Drawing.Size(69, 57);
            this.btnCbRT.TabIndex = 20;
            this.btnCbRT.Text = "CbRt";
            this.btnCbRT.UseVisualStyleBackColor = true;
            this.btnCbRT.Click += new System.EventHandler(this.btnCbRT_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 344);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(144, 57);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.Location = new System.Drawing.Point(162, 344);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(69, 57);
            this.btnDec.TabIndex = 22;
            this.btnDec.Text = ".";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(237, 344);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(69, 57);
            this.btnDiv.TabIndex = 23;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.Location = new System.Drawing.Point(312, 344);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(69, 57);
            this.btnAns.TabIndex = 24;
            this.btnAns.Text = "=";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 413);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnCbRT);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSqRT);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSq);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnFrac);
            this.Controls.Add(this.btnNeg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNeg;
        private System.Windows.Forms.Button btnFrac;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnSq;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSqRT;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnCbRT;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnAns;
    }
}

