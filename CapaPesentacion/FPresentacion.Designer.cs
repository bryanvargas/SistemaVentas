namespace CapaPesentacion
{
    partial class FPresentacion
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
            this.mensaje_tt = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listado_data = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.total_lbl = new System.Windows.Forms.Label();
            this.eliminar_ckb = new System.Windows.Forms.CheckBox();
            this.imprimir_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.editar_btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.descripcion_txt = new System.Windows.Forms.TextBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.codigo_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listado_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // mensaje_tt
            // 
            this.mensaje_tt.IsBalloon = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo: ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listado_data);
            this.tabPage1.Controls.Add(this.total_lbl);
            this.tabPage1.Controls.Add(this.eliminar_ckb);
            this.tabPage1.Controls.Add(this.imprimir_btn);
            this.tabPage1.Controls.Add(this.eliminar_btn);
            this.tabPage1.Controls.Add(this.buscar_btn);
            this.tabPage1.Controls.Add(this.buscar_txt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listado_data
            // 
            this.listado_data.AllowUserToAddRows = false;
            this.listado_data.AllowUserToDeleteRows = false;
            this.listado_data.AllowUserToOrderColumns = true;
            this.listado_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.listado_data.Location = new System.Drawing.Point(18, 114);
            this.listado_data.MultiSelect = false;
            this.listado_data.Name = "listado_data";
            this.listado_data.ReadOnly = true;
            this.listado_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listado_data.Size = new System.Drawing.Size(545, 186);
            this.listado_data.TabIndex = 5;
            this.listado_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listado_data_CellContentClick);
            this.listado_data.DoubleClick += new System.EventHandler(this.listado_data_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(417, 81);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(35, 13);
            this.total_lbl.TabIndex = 4;
            this.total_lbl.Text = "label3";
            // 
            // eliminar_ckb
            // 
            this.eliminar_ckb.AutoSize = true;
            this.eliminar_ckb.Location = new System.Drawing.Point(18, 77);
            this.eliminar_ckb.Name = "eliminar_ckb";
            this.eliminar_ckb.Size = new System.Drawing.Size(62, 17);
            this.eliminar_ckb.TabIndex = 3;
            this.eliminar_ckb.Text = "Eliminar";
            this.eliminar_ckb.UseVisualStyleBackColor = true;
            this.eliminar_ckb.CheckedChanged += new System.EventHandler(this.eliminar_ckb_CheckedChanged);
            // 
            // imprimir_btn
            // 
            this.imprimir_btn.Location = new System.Drawing.Point(473, 24);
            this.imprimir_btn.Name = "imprimir_btn";
            this.imprimir_btn.Size = new System.Drawing.Size(90, 23);
            this.imprimir_btn.TabIndex = 2;
            this.imprimir_btn.Text = "&Imprimir";
            this.imprimir_btn.UseVisualStyleBackColor = true;
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Location = new System.Drawing.Point(362, 24);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(90, 23);
            this.eliminar_btn.TabIndex = 2;
            this.eliminar_btn.Text = "&Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = true;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // buscar_btn
            // 
            this.buscar_btn.Location = new System.Drawing.Point(253, 24);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(90, 23);
            this.buscar_btn.TabIndex = 2;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // buscar_txt
            // 
            this.buscar_txt.Location = new System.Drawing.Point(75, 24);
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(144, 20);
            this.buscar_txt.TabIndex = 1;
            this.buscar_txt.TextChanged += new System.EventHandler(this.buscar_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(408, 242);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 2;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // editar_btn
            // 
            this.editar_btn.Location = new System.Drawing.Point(286, 242);
            this.editar_btn.Name = "editar_btn";
            this.editar_btn.Size = new System.Drawing.Size(75, 23);
            this.editar_btn.TabIndex = 2;
            this.editar_btn.Text = "Editar";
            this.editar_btn.UseVisualStyleBackColor = true;
            this.editar_btn.Click += new System.EventHandler(this.editar_btn_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Location = new System.Drawing.Point(182, 242);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(75, 23);
            this.guardar_btn.TabIndex = 2;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // nuevo_btn
            // 
            this.nuevo_btn.Location = new System.Drawing.Point(77, 242);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(75, 23);
            this.nuevo_btn.TabIndex = 2;
            this.nuevo_btn.Text = "&Nuevo";
            this.nuevo_btn.UseVisualStyleBackColor = true;
            this.nuevo_btn.Click += new System.EventHandler(this.nuevo_btn_Click);
            // 
            // descripcion_txt
            // 
            this.descripcion_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.descripcion_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcion_txt.Location = new System.Drawing.Point(102, 126);
            this.descripcion_txt.Multiline = true;
            this.descripcion_txt.Name = "descripcion_txt";
            this.descripcion_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcion_txt.Size = new System.Drawing.Size(272, 83);
            this.descripcion_txt.TabIndex = 1;
            // 
            // nombre_txt
            // 
            this.nombre_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nombre_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre_txt.Location = new System.Drawing.Point(102, 79);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(272, 20);
            this.nombre_txt.TabIndex = 1;
            // 
            // codigo_txt
            // 
            this.codigo_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.codigo_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigo_txt.Location = new System.Drawing.Point(102, 31);
            this.codigo_txt.Name = "codigo_txt";
            this.codigo_txt.Size = new System.Drawing.Size(100, 20);
            this.codigo_txt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelar_btn);
            this.groupBox1.Controls.Add(this.editar_btn);
            this.groupBox1.Controls.Add(this.guardar_btn);
            this.groupBox1.Controls.Add(this.nuevo_btn);
            this.groupBox1.Controls.Add(this.descripcion_txt);
            this.groupBox1.Controls.Add(this.nombre_txt);
            this.groupBox1.Controls.Add(this.codigo_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presentaciones";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 332);
            this.tabControl1.TabIndex = 3;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presentacion";
            // 
            // FPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 419);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FPresentacion";
            this.Text = "FPresentacion";
            this.Load += new System.EventHandler(this.FPresentacion_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listado_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip mensaje_tt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView listado_data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.CheckBox eliminar_ckb;
        private System.Windows.Forms.Button imprimir_btn;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button editar_btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Button nuevo_btn;
        private System.Windows.Forms.TextBox descripcion_txt;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.TextBox codigo_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label1;

    }
}