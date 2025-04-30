namespace OOD_Final
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
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnUpdateBudget = new System.Windows.Forms.Button();
            this.btnViewBudget = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(86, 267);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(168, 65);
            this.btnAddIncome.TabIndex = 0;
            this.btnAddIncome.Text = "Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(441, 267);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(168, 65);
            this.btnAddExpense.TabIndex = 1;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnUpdateBudget
            // 
            this.btnUpdateBudget.Location = new System.Drawing.Point(86, 338);
            this.btnUpdateBudget.Name = "btnUpdateBudget";
            this.btnUpdateBudget.Size = new System.Drawing.Size(168, 65);
            this.btnUpdateBudget.TabIndex = 2;
            this.btnUpdateBudget.Text = "Update Budget";
            this.btnUpdateBudget.UseVisualStyleBackColor = true;
            this.btnUpdateBudget.Click += new System.EventHandler(this.btnUpdateBudget_Click);
            // 
            // btnViewBudget
            // 
            this.btnViewBudget.Location = new System.Drawing.Point(441, 338);
            this.btnViewBudget.Name = "btnViewBudget";
            this.btnViewBudget.Size = new System.Drawing.Size(168, 65);
            this.btnViewBudget.TabIndex = 3;
            this.btnViewBudget.Text = "View Budget";
            this.btnViewBudget.UseVisualStyleBackColor = true;
            this.btnViewBudget.Click += new System.EventHandler(this.btnViewBudget_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(157, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 38);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "🦅BUDGET🦅CALCULATOR🦅2000🦅";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnViewBudget);
            this.Controls.Add(this.btnUpdateBudget);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnAddIncome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnUpdateBudget;
        private System.Windows.Forms.Button btnViewBudget;
        private System.Windows.Forms.TextBox textBox1;
    }
}