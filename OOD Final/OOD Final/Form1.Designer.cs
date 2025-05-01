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
            this.lstLogger = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lstIncomes = new System.Windows.Forms.ListBox();
            this.lstExpenses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(26, 106);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(107, 34);
            this.btnAddIncome.TabIndex = 0;
            this.btnAddIncome.Text = "Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(26, 146);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(107, 34);
            this.btnAddExpense.TabIndex = 1;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnUpdateBudget
            // 
            this.btnUpdateBudget.Location = new System.Drawing.Point(26, 186);
            this.btnUpdateBudget.Name = "btnUpdateBudget";
            this.btnUpdateBudget.Size = new System.Drawing.Size(107, 34);
            this.btnUpdateBudget.TabIndex = 2;
            this.btnUpdateBudget.Text = "Update Budget";
            this.btnUpdateBudget.UseVisualStyleBackColor = true;
            this.btnUpdateBudget.Click += new System.EventHandler(this.btnUpdateBudget_Click);
            // 
            // btnViewBudget
            // 
            this.btnViewBudget.Location = new System.Drawing.Point(26, 226);
            this.btnViewBudget.Name = "btnViewBudget";
            this.btnViewBudget.Size = new System.Drawing.Size(107, 34);
            this.btnViewBudget.TabIndex = 3;
            this.btnViewBudget.Text = "View Budget";
            this.btnViewBudget.UseVisualStyleBackColor = true;
            this.btnViewBudget.Click += new System.EventHandler(this.btnViewBudget_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(105, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 38);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "🦅BUDGET🦅CALCULATOR🦅2000🦅";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstLogger
            // 
            this.lstLogger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLogger.FormattingEnabled = true;
            this.lstLogger.HorizontalScrollbar = true;
            this.lstLogger.Location = new System.Drawing.Point(363, 105);
            this.lstLogger.Name = "lstLogger";
            this.lstLogger.ScrollAlwaysVisible = true;
            this.lstLogger.Size = new System.Drawing.Size(222, 264);
            this.lstLogger.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "I would like to:";
            // 
            // lstIncomes
            // 
            this.lstIncomes.FormattingEnabled = true;
            this.lstIncomes.Location = new System.Drawing.Point(26, 275);
            this.lstIncomes.Name = "lstIncomes";
            this.lstIncomes.ScrollAlwaysVisible = true;
            this.lstIncomes.Size = new System.Drawing.Size(136, 147);
            this.lstIncomes.TabIndex = 7;
            // 
            // lstExpenses
            // 
            this.lstExpenses.FormattingEnabled = true;
            this.lstExpenses.Location = new System.Drawing.Point(181, 275);
            this.lstExpenses.Name = "lstExpenses";
            this.lstExpenses.ScrollAlwaysVisible = true;
            this.lstExpenses.Size = new System.Drawing.Size(137, 147);
            this.lstExpenses.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.lstExpenses);
            this.Controls.Add(this.lstIncomes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lstLogger);
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
        private System.Windows.Forms.ListBox lstLogger;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lstIncomes;
        private System.Windows.Forms.ListBox lstExpenses;
    }
}