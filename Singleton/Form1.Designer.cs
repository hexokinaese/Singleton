
namespace Singleton
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_tactor = new System.Windows.Forms.Button();
            this.l_tables = new System.Windows.Forms.Label();
            this.l_chosentable = new System.Windows.Forms.Label();
            this.b_tcity = new System.Windows.Forms.Button();
            this.b_tcategory = new System.Windows.Forms.Button();
            this.b_tfilm = new System.Windows.Forms.Button();
            this.b_tpayment = new System.Windows.Forms.Button();
            this.b_tstore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 616);
            this.dataGridView1.TabIndex = 0;
            // 
            // b_tactor
            // 
            this.b_tactor.Location = new System.Drawing.Point(676, 95);
            this.b_tactor.Name = "b_tactor";
            this.b_tactor.Size = new System.Drawing.Size(88, 23);
            this.b_tactor.TabIndex = 1;
            this.b_tactor.Text = "Actor";
            this.b_tactor.UseVisualStyleBackColor = true;
            this.b_tactor.Click += new System.EventHandler(this.b_tactor_Click);
            // 
            // l_tables
            // 
            this.l_tables.AutoSize = true;
            this.l_tables.Location = new System.Drawing.Point(673, 27);
            this.l_tables.Name = "l_tables";
            this.l_tables.Size = new System.Drawing.Size(91, 17);
            this.l_tables.TabIndex = 2;
            this.l_tables.Text = "Choose table";
            // 
            // l_chosentable
            // 
            this.l_chosentable.AutoSize = true;
            this.l_chosentable.Location = new System.Drawing.Point(688, 59);
            this.l_chosentable.Name = "l_chosentable";
            this.l_chosentable.Size = new System.Drawing.Size(100, 17);
            this.l_chosentable.TabIndex = 3;
            this.l_chosentable.Text = "Chosen table -";
            // 
            // b_tcity
            // 
            this.b_tcity.Location = new System.Drawing.Point(676, 143);
            this.b_tcity.Name = "b_tcity";
            this.b_tcity.Size = new System.Drawing.Size(88, 23);
            this.b_tcity.TabIndex = 4;
            this.b_tcity.Text = "City";
            this.b_tcity.UseVisualStyleBackColor = true;
            this.b_tcity.Click += new System.EventHandler(this.b_tcity_Click);
            // 
            // b_tcategory
            // 
            this.b_tcategory.Location = new System.Drawing.Point(676, 193);
            this.b_tcategory.Name = "b_tcategory";
            this.b_tcategory.Size = new System.Drawing.Size(88, 23);
            this.b_tcategory.TabIndex = 5;
            this.b_tcategory.Text = "Category";
            this.b_tcategory.UseVisualStyleBackColor = true;
            this.b_tcategory.Click += new System.EventHandler(this.b_tcategory_Click);
            // 
            // b_tfilm
            // 
            this.b_tfilm.Location = new System.Drawing.Point(806, 95);
            this.b_tfilm.Name = "b_tfilm";
            this.b_tfilm.Size = new System.Drawing.Size(81, 23);
            this.b_tfilm.TabIndex = 6;
            this.b_tfilm.Text = "Film";
            this.b_tfilm.UseVisualStyleBackColor = true;
            this.b_tfilm.Click += new System.EventHandler(this.b_tfilm_Click);
            // 
            // b_tpayment
            // 
            this.b_tpayment.Location = new System.Drawing.Point(806, 143);
            this.b_tpayment.Name = "b_tpayment";
            this.b_tpayment.Size = new System.Drawing.Size(81, 23);
            this.b_tpayment.TabIndex = 7;
            this.b_tpayment.Text = "Payment";
            this.b_tpayment.UseVisualStyleBackColor = true;
            this.b_tpayment.Click += new System.EventHandler(this.b_tpayment_Click);
            // 
            // b_tstore
            // 
            this.b_tstore.Location = new System.Drawing.Point(806, 193);
            this.b_tstore.Name = "b_tstore";
            this.b_tstore.Size = new System.Drawing.Size(81, 23);
            this.b_tstore.TabIndex = 8;
            this.b_tstore.Text = "Store";
            this.b_tstore.UseVisualStyleBackColor = true;
            this.b_tstore.Click += new System.EventHandler(this.b_tstore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 639);
            this.Controls.Add(this.b_tstore);
            this.Controls.Add(this.b_tpayment);
            this.Controls.Add(this.b_tfilm);
            this.Controls.Add(this.b_tcategory);
            this.Controls.Add(this.b_tcity);
            this.Controls.Add(this.l_chosentable);
            this.Controls.Add(this.l_tables);
            this.Controls.Add(this.b_tactor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "SingletonMethod";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_tactor;
        private System.Windows.Forms.Label l_tables;
        private System.Windows.Forms.Label l_chosentable;
        private System.Windows.Forms.Button b_tcity;
        private System.Windows.Forms.Button b_tcategory;
        private System.Windows.Forms.Button b_tfilm;
        private System.Windows.Forms.Button b_tpayment;
        private System.Windows.Forms.Button b_tstore;
    }
}

