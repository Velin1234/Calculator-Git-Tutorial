namespace Calculator_Git_Tutorial_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number1_box = new System.Windows.Forms.TextBox();
            this.number2_box = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result_box = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_minOrMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // number1_box
            // 
            resources.ApplyResources(this.number1_box, "number1_box");
            this.number1_box.Name = "number1_box";
            // 
            // number2_box
            // 
            resources.ApplyResources(this.number2_box, "number2_box");
            this.number2_box.Name = "number2_box";
            // 
            // btn_plus
            // 
            resources.ApplyResources(this.btn_plus, "btn_plus");
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_substract
            // 
            resources.ApplyResources(this.btn_substract, "btn_substract");
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // btn_multiply
            // 
            resources.ApplyResources(this.btn_multiply, "btn_multiply");
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_divide
            // 
            resources.ApplyResources(this.btn_divide, "btn_divide");
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // result_box
            // 
            this.result_box.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.result_box, "result_box");
            this.result_box.Name = "result_box";
            this.result_box.ReadOnly = true;
            // 
            // btn_clear
            // 
            resources.ApplyResources(this.btn_clear, "btn_clear");
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_minOrMax
            // 
            resources.ApplyResources(this.btn_minOrMax, "btn_minOrMax");
            this.btn_minOrMax.Name = "btn_minOrMax";
            this.btn_minOrMax.UseVisualStyleBackColor = true;
            this.btn_minOrMax.Click += new System.EventHandler(this.btn_minOrMax_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btn_minOrMax);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_substract);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.number2_box);
            this.Controls.Add(this.number1_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number1_box;
        private System.Windows.Forms.TextBox number2_box;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_minOrMax;
    }
}

