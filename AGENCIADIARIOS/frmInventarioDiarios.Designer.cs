﻿namespace AGENCIADIARIOS
{
    partial class frmInventarioDiarios
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
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.txtPrecioDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDiarios = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDiarioInventario = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dtgInvDiarios = new System.Windows.Forms.DataGridView();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvDiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.txtPrecioDia);
            this.gbInventario.Controls.Add(this.label3);
            this.gbInventario.Controls.Add(this.txtStock);
            this.gbInventario.Controls.Add(this.label1);
            this.gbInventario.Controls.Add(this.cbDiarios);
            this.gbInventario.Controls.Add(this.btnCancelar);
            this.gbInventario.Controls.Add(this.btnEditar);
            this.gbInventario.Controls.Add(this.btnAgregar);
            this.gbInventario.Controls.Add(this.btnEliminar);
            this.gbInventario.Controls.Add(this.lblDiarioInventario);
            this.gbInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.Location = new System.Drawing.Point(12, 25);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(383, 350);
            this.gbInventario.TabIndex = 8;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "MAESTRO INVENTARIO DE DIARIOS";
            // 
            // txtPrecioDia
            // 
            this.txtPrecioDia.Location = new System.Drawing.Point(215, 161);
            this.txtPrecioDia.Name = "txtPrecioDia";
            this.txtPrecioDia.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioDia.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese precio día:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(215, 120);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(121, 20);
            this.txtStock.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese stock del día:";
            // 
            // cbDiarios
            // 
            this.cbDiarios.FormattingEnabled = true;
            this.cbDiarios.Location = new System.Drawing.Point(215, 69);
            this.cbDiarios.Name = "cbDiarios";
            this.cbDiarios.Size = new System.Drawing.Size(121, 21);
            this.cbDiarios.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(291, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "🔓 Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.ForeColor = System.Drawing.Color.Gray;
            this.btnEditar.Location = new System.Drawing.Point(197, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 37);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "✏ Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregar.Location = new System.Drawing.Point(8, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 37);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "✔ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnEliminar.Location = new System.Drawing.Point(105, 296);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "❌ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblDiarioInventario
            // 
            this.lblDiarioInventario.AutoSize = true;
            this.lblDiarioInventario.Location = new System.Drawing.Point(21, 72);
            this.lblDiarioInventario.Name = "lblDiarioInventario";
            this.lblDiarioInventario.Size = new System.Drawing.Size(123, 13);
            this.lblDiarioInventario.TabIndex = 1;
            this.lblDiarioInventario.Text = "Seleccione el diario:";
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.ForeColor = System.Drawing.Color.White;
            this.lblNombreUser.Location = new System.Drawing.Point(889, 406);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(41, 13);
            this.lblNombreUser.TabIndex = 11;
            this.lblNombreUser.Text = "label3";
            this.lblNombreUser.Click += new System.EventHandler(this.lblNombreUser_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Location = new System.Drawing.Point(0, 402);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(996, 22);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // dtgInvDiarios
            // 
            this.dtgInvDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInvDiarios.Location = new System.Drawing.Point(410, 25);
            this.dtgInvDiarios.Name = "dtgInvDiarios";
            this.dtgInvDiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInvDiarios.Size = new System.Drawing.Size(537, 350);
            this.dtgInvDiarios.TabIndex = 9;
            this.dtgInvDiarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInvDiarios_CellClick);
            // 
            // frmInventarioDiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 421);
            this.Controls.Add(this.gbInventario);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dtgInvDiarios);
            this.Name = "frmInventarioDiarios";
            this.Text = "MAESTRO INVENTRARIO DE DIARIOS";
            this.Load += new System.EventHandler(this.frmInventarioDiarios_Load);
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvDiarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.TextBox txtPrecioDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDiarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDiarioInventario;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dtgInvDiarios;
    }
}