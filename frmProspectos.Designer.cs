﻿
namespace ControlDomino
{
	partial class frmProspectos
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspectos));
			this.lstJugadores = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.imgList1 = new System.Windows.Forms.ImageList(this.components);
			this.imgOff = new System.Windows.Forms.PictureBox();
			this.cmbTorneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgOff)).BeginInit();
			this.SuspendLayout();
			// 
			// lstJugadores
			// 
			this.lstJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.lstJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstJugadores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstJugadores.FullRowSelect = true;
			this.lstJugadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstJugadores.Location = new System.Drawing.Point(12, 54);
			this.lstJugadores.MultiSelect = false;
			this.lstJugadores.Name = "lstJugadores";
			this.lstJugadores.ShowItemToolTips = true;
			this.lstJugadores.Size = new System.Drawing.Size(291, 227);
			this.lstJugadores.SmallImageList = this.imgList1;
			this.lstJugadores.TabIndex = 35;
			this.lstJugadores.UseCompatibleStateImageBehavior = false;
			this.lstJugadores.View = System.Windows.Forms.View.Details;
			this.lstJugadores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProspectosKeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Jugador";
			this.columnHeader1.Width = 208;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ELO";
			this.columnHeader2.Width = 62;
			// 
			// imgList1
			// 
			this.imgList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imgOff
			// 
			this.imgOff.Image = ((System.Drawing.Image)(resources.GetObject("imgOff.Image")));
			this.imgOff.Location = new System.Drawing.Point(319, 108);
			this.imgOff.Name = "imgOff";
			this.imgOff.Size = new System.Drawing.Size(100, 104);
			this.imgOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgOff.TabIndex = 34;
			this.imgOff.TabStop = false;
			// 
			// cmbTorneo
			// 
			this.cmbTorneo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbTorneo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbTorneo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTorneo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbTorneo.FormattingEnabled = true;
			this.cmbTorneo.Location = new System.Drawing.Point(70, 12);
			this.cmbTorneo.Name = "cmbTorneo";
			this.cmbTorneo.Size = new System.Drawing.Size(233, 24);
			this.cmbTorneo.TabIndex = 77;
			this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.CmbTorneoSelectedIndexChanged);
			this.cmbTorneo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProspectosKeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(11, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 78;
			this.label6.Text = "Torneo:";
			// 
			// frmProspectos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(431, 293);
			this.Controls.Add(this.cmbTorneo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lstJugadores);
			this.Controls.Add(this.imgOff);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProspectos";
			this.Text = "Prospectos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProspectosFormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProspectosKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.imgOff)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTorneo;
		private System.Windows.Forms.ImageList imgList1;
		private System.Windows.Forms.PictureBox imgOff;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstJugadores;
	}
}
