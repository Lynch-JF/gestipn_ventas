namespace Gestion_de_ventas
{
    partial class Facturacion
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbventas = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.tbcliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lblprecio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpagos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbproductos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtable = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formapagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.respuestoDataSet1 = new Gestion_de_ventas.RespuestoDataSet1();
            this.ventasTableAdapter = new Gestion_de_ventas.RespuestoDataSet1TableAdapters.VentasTableAdapter();
            this.panel1.SuspendLayout();
            this.gbventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 95);
            this.panel1.TabIndex = 0;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(999, 43);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(157, 34);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "00/00/0000";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.Info;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Modern No. 20", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(0, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(81, 48);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(968, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de registro de ventas";
            // 
            // gbventas
            // 
            this.gbventas.Controls.Add(this.button1);
            this.gbventas.Controls.Add(this.btnmodificar);
            this.gbventas.Controls.Add(this.tbcliente);
            this.gbventas.Controls.Add(this.label7);
            this.gbventas.Controls.Add(this.btnregistrar);
            this.gbventas.Controls.Add(this.lblprecio);
            this.gbventas.Controls.Add(this.label6);
            this.gbventas.Controls.Add(this.tbcantidad);
            this.gbventas.Controls.Add(this.label5);
            this.gbventas.Controls.Add(this.tbpagos);
            this.gbventas.Controls.Add(this.label4);
            this.gbventas.Controls.Add(this.tbproductos);
            this.gbventas.Controls.Add(this.label3);
            this.gbventas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbventas.Location = new System.Drawing.Point(137, 119);
            this.gbventas.Name = "gbventas";
            this.gbventas.Size = new System.Drawing.Size(871, 255);
            this.gbventas.TabIndex = 1;
            this.gbventas.TabStop = false;
            this.gbventas.Text = "Ventas";
            this.gbventas.Enter += new System.EventHandler(this.gbventas_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(521, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.SystemColors.Info;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(639, 175);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(213, 64);
            this.btnmodificar.TabIndex = 13;
            this.btnmodificar.Text = "Editar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // tbcliente
            // 
            this.tbcliente.Location = new System.Drawing.Point(352, 185);
            this.tbcliente.Name = "tbcliente";
            this.tbcliente.Size = new System.Drawing.Size(154, 42);
            this.tbcliente.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1014, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cliente:";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.SystemColors.Info;
            this.btnregistrar.FlatAppearance.BorderSize = 0;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(639, 103);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(213, 64);
            this.btnregistrar.TabIndex = 3;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(749, 28);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(90, 45);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "0.00";
            this.lblprecio.Click += new System.EventHandler(this.lblprecio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(559, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio Total:";
            // 
            // tbcantidad
            // 
            this.tbcantidad.Location = new System.Drawing.Point(352, 92);
            this.tbcantidad.Name = "tbcantidad";
            this.tbcantidad.Size = new System.Drawing.Size(154, 42);
            this.tbcantidad.TabIndex = 8;
            this.tbcantidad.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad:";
            // 
            // tbpagos
            // 
            this.tbpagos.FormattingEnabled = true;
            this.tbpagos.Location = new System.Drawing.Point(27, 185);
            this.tbpagos.Name = "tbpagos";
            this.tbpagos.Size = new System.Drawing.Size(262, 42);
            this.tbpagos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione tipo de pago:";
            // 
            // tbproductos
            // 
            this.tbproductos.FormattingEnabled = true;
            this.tbproductos.Location = new System.Drawing.Point(27, 92);
            this.tbproductos.Name = "tbproductos";
            this.tbproductos.Size = new System.Drawing.Size(262, 42);
            this.tbproductos.TabIndex = 4;
            this.tbproductos.SelectedIndexChanged += new System.EventHandler(this.tbproductos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione producto:";
            // 
            // dtable
            // 
            this.dtable.AllowUserToAddRows = false;
            this.dtable.AutoGenerateColumns = false;
            this.dtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.productosDataGridViewTextBoxColumn,
            this.preciototalDataGridViewTextBoxColumn,
            this.formapagoDataGridViewTextBoxColumn});
            this.dtable.DataSource = this.ventasBindingSource;
            this.dtable.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtable.Location = new System.Drawing.Point(137, 450);
            this.dtable.Name = "dtable";
            this.dtable.RowHeadersVisible = false;
            this.dtable.RowHeadersWidth = 82;
            this.dtable.RowTemplate.Height = 33;
            this.dtable.Size = new System.Drawing.Size(903, 281);
            this.dtable.TabIndex = 6;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // productosDataGridViewTextBoxColumn
            // 
            this.productosDataGridViewTextBoxColumn.DataPropertyName = "Productos";
            this.productosDataGridViewTextBoxColumn.HeaderText = "Productos";
            this.productosDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productosDataGridViewTextBoxColumn.Name = "productosDataGridViewTextBoxColumn";
            // 
            // preciototalDataGridViewTextBoxColumn
            // 
            this.preciototalDataGridViewTextBoxColumn.DataPropertyName = "Precio_total";
            this.preciototalDataGridViewTextBoxColumn.HeaderText = "Precio_total";
            this.preciototalDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.preciototalDataGridViewTextBoxColumn.Name = "preciototalDataGridViewTextBoxColumn";
            // 
            // formapagoDataGridViewTextBoxColumn
            // 
            this.formapagoDataGridViewTextBoxColumn.DataPropertyName = "Forma_pago";
            this.formapagoDataGridViewTextBoxColumn.HeaderText = "Forma_pago";
            this.formapagoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.formapagoDataGridViewTextBoxColumn.Name = "formapagoDataGridViewTextBoxColumn";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.respuestoDataSet1;
            // 
            // respuestoDataSet1
            // 
            this.respuestoDataSet1.DataSetName = "RespuestoDataSet1";
            this.respuestoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 803);
            this.Controls.Add(this.dtable);
            this.Controls.Add(this.gbventas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbventas.ResumeLayout(false);
            this.gbventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbventas;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbpagos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tbproductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox tbcliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtable;
        private RespuestoDataSet1 respuestoDataSet1;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private RespuestoDataSet1TableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formapagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}