namespace ComponentePersonalizado
{
	partial class ComponentePersonalizado
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
            this.controlUsuario = new ComponenteButton.UserControl1();
            this.SuspendLayout();
            // 
            // controlUsuario
            // 
            this.controlUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlUsuario.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlUsuario.ForeColor = System.Drawing.Color.White;
            this.controlUsuario.Location = new System.Drawing.Point(134, -44);
            this.controlUsuario.Name = "controlUsuario";
            this.controlUsuario.Size = new System.Drawing.Size(142, 172);
            this.controlUsuario.TabIndex = 0;
            this.controlUsuario.Load += new System.EventHandler(this.controlUsuario_Load);
            // 
            // ComponentePersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 78);
            this.Controls.Add(this.controlUsuario);
            this.Name = "ComponentePersonalizado";
            this.Text = "Componente personalizado by Antonio Carrasco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private ComponenteButton.UserControl1 controlUsuario;
	}
}

