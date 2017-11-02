namespace Test_winform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnSub = new System.Windows.Forms.RadioButton();
            this.rbtnMul = new System.Windows.Forms.RadioButton();
            this.rbtnDiv = new System.Windows.Forms.RadioButton();
            this.btnCacul = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lbExpression = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left Operand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right Operand";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(39, 73);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(100, 20);
            this.txtLeft.TabIndex = 2;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(405, 73);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(100, 20);
            this.txtRight.TabIndex = 3;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(237, 62);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(44, 17);
            this.rbtnAdd.TabIndex = 4;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnSub
            // 
            this.rbtnSub.AutoSize = true;
            this.rbtnSub.Location = new System.Drawing.Point(237, 85);
            this.rbtnSub.Name = "rbtnSub";
            this.rbtnSub.Size = new System.Drawing.Size(44, 17);
            this.rbtnSub.TabIndex = 5;
            this.rbtnSub.TabStop = true;
            this.rbtnSub.Text = "Sub";
            this.rbtnSub.UseVisualStyleBackColor = true;
            // 
            // rbtnMul
            // 
            this.rbtnMul.AutoSize = true;
            this.rbtnMul.Location = new System.Drawing.Point(236, 108);
            this.rbtnMul.Name = "rbtnMul";
            this.rbtnMul.Size = new System.Drawing.Size(42, 17);
            this.rbtnMul.TabIndex = 6;
            this.rbtnMul.TabStop = true;
            this.rbtnMul.Text = "Mul";
            this.rbtnMul.UseVisualStyleBackColor = true;
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.AutoSize = true;
            this.rbtnDiv.Location = new System.Drawing.Point(237, 131);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(41, 17);
            this.rbtnDiv.TabIndex = 7;
            this.rbtnDiv.TabStop = true;
            this.rbtnDiv.Text = "Div";
            this.rbtnDiv.UseVisualStyleBackColor = true;
            // 
            // btnCacul
            // 
            this.btnCacul.Location = new System.Drawing.Point(64, 171);
            this.btnCacul.Name = "btnCacul";
            this.btnCacul.Size = new System.Drawing.Size(75, 23);
            this.btnCacul.TabIndex = 8;
            this.btnCacul.Text = "Caculator";
            this.btnCacul.UseVisualStyleBackColor = true;
            this.btnCacul.Click += new System.EventHandler(this.btnCacul_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(430, 226);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // lbExpression
            // 
            this.lbExpression.AutoSize = true;
            this.lbExpression.Location = new System.Drawing.Point(216, 176);
            this.lbExpression.Name = "lbExpression";
            this.lbExpression.Size = new System.Drawing.Size(61, 13);
            this.lbExpression.TabIndex = 10;
            this.lbExpression.Text = "Expression:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(216, 208);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(40, 13);
            this.lbResult.TabIndex = 11;
            this.lbResult.Text = "Result:";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(36, 231);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbExpression);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCacul);
            this.Controls.Add(this.rbtnDiv);
            this.Controls.Add(this.rbtnMul);
            this.Controls.Add(this.rbtnSub);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnSub;
        private System.Windows.Forms.RadioButton rbtnMul;
        private System.Windows.Forms.RadioButton rbtnDiv;
        private System.Windows.Forms.Button btnCacul;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lbExpression;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbError;
    }
}

