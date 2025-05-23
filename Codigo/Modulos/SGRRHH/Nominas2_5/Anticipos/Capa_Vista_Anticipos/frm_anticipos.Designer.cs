﻿
namespace Capa_Vista_Anticipos
{
    partial class frm_anticipos
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
            this.cmb_meses_anticipos = new System.Windows.Forms.ComboBox();
            this.Btn_anticipo_nominas = new System.Windows.Forms.Button();
            this.Lbl_mes_anticipo = new System.Windows.Forms.Label();
            this.Lbl_fomulario_anticipos = new System.Windows.Forms.Label();
            this.Btn_reporte_anticipo = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_meses_anticipos
            // 
            this.cmb_meses_anticipos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_meses_anticipos.FormattingEnabled = true;
            this.cmb_meses_anticipos.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cmb_meses_anticipos.Location = new System.Drawing.Point(797, 146);
            this.cmb_meses_anticipos.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_meses_anticipos.Name = "cmb_meses_anticipos";
            this.cmb_meses_anticipos.Size = new System.Drawing.Size(195, 24);
            this.cmb_meses_anticipos.TabIndex = 0;
            // 
            // Btn_anticipo_nominas
            // 
            this.Btn_anticipo_nominas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_anticipo_nominas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anticipo_nominas.Location = new System.Drawing.Point(797, 192);
            this.Btn_anticipo_nominas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_anticipo_nominas.Name = "Btn_anticipo_nominas";
            this.Btn_anticipo_nominas.Size = new System.Drawing.Size(196, 48);
            this.Btn_anticipo_nominas.TabIndex = 1;
            this.Btn_anticipo_nominas.Text = "Calcular Anticipo";
            this.Btn_anticipo_nominas.UseVisualStyleBackColor = true;
            this.Btn_anticipo_nominas.Click += new System.EventHandler(this.Btn_anticipo_nominas_Click);
            // 
            // Lbl_mes_anticipo
            // 
            this.Lbl_mes_anticipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_mes_anticipo.AutoSize = true;
            this.Lbl_mes_anticipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes_anticipo.Location = new System.Drawing.Point(379, 146);
            this.Lbl_mes_anticipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_mes_anticipo.Name = "Lbl_mes_anticipo";
            this.Lbl_mes_anticipo.Size = new System.Drawing.Size(386, 22);
            this.Lbl_mes_anticipo.TabIndex = 2;
            this.Lbl_mes_anticipo.Text = "MES PARA GENERAR TOTAL DE ATICIPOS";
            // 
            // Lbl_fomulario_anticipos
            // 
            this.Lbl_fomulario_anticipos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_fomulario_anticipos.AutoSize = true;
            this.Lbl_fomulario_anticipos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fomulario_anticipos.Location = new System.Drawing.Point(304, 15);
            this.Lbl_fomulario_anticipos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fomulario_anticipos.Name = "Lbl_fomulario_anticipos";
            this.Lbl_fomulario_anticipos.Size = new System.Drawing.Size(898, 26);
            this.Lbl_fomulario_anticipos.TabIndex = 3;
            this.Lbl_fomulario_anticipos.Text = "FORMULARIO PARA CALCULAR ANTICIPOS POR MES DE CADA EMPLEADO";
            this.Lbl_fomulario_anticipos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_reporte_anticipo
            // 
            this.Btn_reporte_anticipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_reporte_anticipo.BackgroundImage = global::Capa_Vista_Anticipos.Properties.Resources.reporte2;
            this.Btn_reporte_anticipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_reporte_anticipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_reporte_anticipo.Location = new System.Drawing.Point(1357, 15);
            this.Btn_reporte_anticipo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_reporte_anticipo.Name = "Btn_reporte_anticipo";
            this.Btn_reporte_anticipo.Size = new System.Drawing.Size(95, 88);
            this.Btn_reporte_anticipo.TabIndex = 5;
            this.Btn_reporte_anticipo.UseVisualStyleBackColor = true;
            this.Btn_reporte_anticipo.Click += new System.EventHandler(this.Btn_reporte_anticipo_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ayuda.BackgroundImage = global::Capa_Vista_Anticipos.Properties.Resources.preguntas2;
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ayuda.Location = new System.Drawing.Point(1460, 15);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(95, 88);
            this.Btn_ayuda.TabIndex = 4;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_anticipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1571, 404);
            this.Controls.Add(this.Btn_reporte_anticipo);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Lbl_fomulario_anticipos);
            this.Controls.Add(this.Lbl_mes_anticipo);
            this.Controls.Add(this.Btn_anticipo_nominas);
            this.Controls.Add(this.cmb_meses_anticipos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_anticipos";
            this.Text = "frm_anticipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_meses_anticipos;
        private System.Windows.Forms.Button Btn_anticipo_nominas;
        private System.Windows.Forms.Label Lbl_mes_anticipo;
        private System.Windows.Forms.Label Lbl_fomulario_anticipos;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_reporte_anticipo;
    }
}