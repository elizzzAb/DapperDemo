namespace DapperDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvObtenerTodos = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxObtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerId = new System.Windows.Forms.Button();
            this.txbCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContactTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObtenerTodos
            // 
            this.dgvObtenerTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObtenerTodos.Location = new System.Drawing.Point(12, 12);
            this.dgvObtenerTodos.Name = "dgvObtenerTodos";
            this.dgvObtenerTodos.Size = new System.Drawing.Size(776, 220);
            this.dgvObtenerTodos.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(239, 238);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(277, 25);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Obtener Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Cliente";
            // 
            // tboxObtenerID
            // 
            this.tboxObtenerID.Location = new System.Drawing.Point(86, 300);
            this.tboxObtenerID.Name = "tboxObtenerID";
            this.tboxObtenerID.Size = new System.Drawing.Size(123, 20);
            this.tboxObtenerID.TabIndex = 3;
            // 
            // btnObtenerId
            // 
            this.btnObtenerId.Location = new System.Drawing.Point(101, 326);
            this.btnObtenerId.Name = "btnObtenerId";
            this.btnObtenerId.Size = new System.Drawing.Size(88, 23);
            this.btnObtenerId.TabIndex = 4;
            this.btnObtenerId.Text = "Buscar";
            this.btnObtenerId.UseVisualStyleBackColor = true;
            this.btnObtenerId.Click += new System.EventHandler(this.btnObtenerId_Click);
            // 
            // txbCustomerId
            // 
            this.txbCustomerId.Location = new System.Drawing.Point(618, 268);
            this.txbCustomerId.Name = "txbCustomerId";
            this.txbCustomerId.Size = new System.Drawing.Size(123, 20);
            this.txbCustomerId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CustomerID";
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(618, 296);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(123, 20);
            this.txbCompanyName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CompanyName";
            // 
            // txbContactName
            // 
            this.txbContactName.Location = new System.Drawing.Point(618, 322);
            this.txbContactName.Name = "txbContactName";
            this.txbContactName.Size = new System.Drawing.Size(123, 20);
            this.txbContactName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ContactName";
            // 
            // txbContactTitle
            // 
            this.txbContactTitle.Location = new System.Drawing.Point(618, 351);
            this.txbContactTitle.Name = "txbContactTitle";
            this.txbContactTitle.Size = new System.Drawing.Size(123, 20);
            this.txbContactTitle.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact Title";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(618, 377);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(123, 20);
            this.txbAddress.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(637, 403);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(88, 23);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar Cliente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbContactTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbContactName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCustomerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObtenerId);
            this.Controls.Add(this.tboxObtenerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvObtenerTodos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObtenerTodos;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxObtenerID;
        private System.Windows.Forms.Button btnObtenerId;
        private System.Windows.Forms.TextBox txbCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbContactName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContactTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertar;
    }
}

