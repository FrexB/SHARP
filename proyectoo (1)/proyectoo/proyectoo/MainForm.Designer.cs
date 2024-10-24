/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 22/10/2024
 * Time: 07:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyectoo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblnombre = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.lblapellido1 = new System.Windows.Forms.Label();
			this.txtApellido1 = new System.Windows.Forms.TextBox();
			this.lblApellido2 = new System.Windows.Forms.Label();
			this.txtApellido2 = new System.Windows.Forms.TextBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.cbSemestre = new System.Windows.Forms.ComboBox();
			this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
			this.lblSemestre = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblRFC = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblnombre
			// 
			this.lblnombre.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblnombre.Location = new System.Drawing.Point(12, 25);
			this.lblnombre.Name = "lblnombre";
			this.lblnombre.Size = new System.Drawing.Size(100, 23);
			this.lblnombre.TabIndex = 0;
			this.lblnombre.Text = "Nombre:";
			// 
			// txtnombre
			// 
			this.txtnombre.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.Location = new System.Drawing.Point(12, 51);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(100, 20);
			this.txtnombre.TabIndex = 1;
			// 
			// lblapellido1
			// 
			this.lblapellido1.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblapellido1.Location = new System.Drawing.Point(137, 25);
			this.lblapellido1.Name = "lblapellido1";
			this.lblapellido1.Size = new System.Drawing.Size(121, 23);
			this.lblapellido1.TabIndex = 2;
			this.lblapellido1.Text = "Apellido Paterno";
			// 
			// txtApellido1
			// 
			this.txtApellido1.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido1.Location = new System.Drawing.Point(137, 52);
			this.txtApellido1.Name = "txtApellido1";
			this.txtApellido1.Size = new System.Drawing.Size(121, 20);
			this.txtApellido1.TabIndex = 3;
			// 
			// lblApellido2
			// 
			this.lblApellido2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApellido2.Location = new System.Drawing.Point(287, 25);
			this.lblApellido2.Name = "lblApellido2";
			this.lblApellido2.Size = new System.Drawing.Size(121, 23);
			this.lblApellido2.TabIndex = 4;
			this.lblApellido2.Text = "Apellido Materno";
			// 
			// txtApellido2
			// 
			this.txtApellido2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido2.Location = new System.Drawing.Point(287, 51);
			this.txtApellido2.Name = "txtApellido2";
			this.txtApellido2.Size = new System.Drawing.Size(165, 20);
			this.txtApellido2.TabIndex = 5;
			// 
			// lblTelefono
			// 
			this.lblTelefono.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefono.Location = new System.Drawing.Point(287, 92);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(100, 23);
			this.lblTelefono.TabIndex = 6;
			this.lblTelefono.Text = "Telefono";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(287, 120);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(165, 20);
			this.txtTelefono.TabIndex = 7;
			// 
			// lblDireccion
			// 
			this.lblDireccion.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDireccion.Location = new System.Drawing.Point(12, 92);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(100, 23);
			this.lblDireccion.TabIndex = 8;
			this.lblDireccion.Text = "Direccion";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(12, 120);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(100, 20);
			this.txtDireccion.TabIndex = 9;
			// 
			// cbSemestre
			// 
			this.cbSemestre.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSemestre.FormattingEnabled = true;
			this.cbSemestre.Items.AddRange(new object[] {
									"1er semestre",
									"2do semestre",
									"3er semestre",
									"4to semestre",
									"5to semestre",
									"6to semestre"});
			this.cbSemestre.Location = new System.Drawing.Point(137, 119);
			this.cbSemestre.Name = "cbSemestre";
			this.cbSemestre.Size = new System.Drawing.Size(121, 21);
			this.cbSemestre.TabIndex = 10;
			// 
			// dtpFechaDeNacimiento
			// 
			this.dtpFechaDeNacimiento.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(149, 163);
			this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
			this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(202, 20);
			this.dtpFechaDeNacimiento.TabIndex = 11;
			// 
			// lblSemestre
			// 
			this.lblSemestre.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSemestre.Location = new System.Drawing.Point(137, 92);
			this.lblSemestre.Name = "lblSemestre";
			this.lblSemestre.Size = new System.Drawing.Size(100, 23);
			this.lblSemestre.TabIndex = 12;
			this.lblSemestre.Text = "Semestre";
			// 
			// lblFecha
			// 
			this.lblFecha.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(12, 157);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(117, 26);
			this.lblFecha.TabIndex = 13;
			this.lblFecha.Text = "Fecha de Nacimiento";
			// 
			// lblRFC
			// 
			this.lblRFC.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRFC.Location = new System.Drawing.Point(193, 236);
			this.lblRFC.Name = "lblRFC";
			this.lblRFC.Size = new System.Drawing.Size(100, 23);
			this.lblRFC.TabIndex = 14;
			this.lblRFC.Text = "TU RFC ES:";
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(193, 261);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 15;
			this.lblResultado.Text = "/////";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(191, 287);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(102, 32);
			this.btnCalcular.TabIndex = 16;
			this.btnCalcular.Text = "Calcular RFC";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(475, 346);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblRFC);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblSemestre);
			this.Controls.Add(this.dtpFechaDeNacimiento);
			this.Controls.Add(this.cbSemestre);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.lblDireccion);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.txtApellido2);
			this.Controls.Add(this.lblApellido2);
			this.Controls.Add(this.txtApellido1);
			this.Controls.Add(this.lblapellido1);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.lblnombre);
			this.Name = "MainForm";
			this.Text = "proyectoo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblRFC;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblSemestre;
		private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
		private System.Windows.Forms.ComboBox cbSemestre;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.TextBox txtApellido2;
		private System.Windows.Forms.Label lblApellido2;
		private System.Windows.Forms.TextBox txtApellido1;
		private System.Windows.Forms.Label lblapellido1;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label lblnombre;
	}
}
