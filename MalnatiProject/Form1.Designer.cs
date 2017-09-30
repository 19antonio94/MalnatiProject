using System;

namespace MalnatiProject
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AvviaServerBtn = new System.Windows.Forms.Button();
            this.privatoRdBtn = new System.Windows.Forms.RadioButton();
            this.publicoRdBtn = new System.Windows.Forms.RadioButton();
            this.ContenitoreDestro = new System.Windows.Forms.TableLayoutPanel();
            this.FotoUtente = new System.Windows.Forms.PictureBox();
            this.ContenitoreSinistro = new System.Windows.Forms.TableLayoutPanel();
            this.CaricaFoto = new System.Windows.Forms.Button();
            this.IconaBarraAvvio = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContenitoreDestro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoUtente)).BeginInit();
            this.ContenitoreSinistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvviaServerBtn
            // 
            this.AvviaServerBtn.AutoSize = true;
            this.AvviaServerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AvviaServerBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AvviaServerBtn.Location = new System.Drawing.Point(3, 229);
            this.AvviaServerBtn.MaximumSize = new System.Drawing.Size(125, 25);
            this.AvviaServerBtn.MinimumSize = new System.Drawing.Size(125, 25);
            this.AvviaServerBtn.Name = "AvviaServerBtn";
            this.AvviaServerBtn.Size = new System.Drawing.Size(125, 25);
            this.AvviaServerBtn.TabIndex = 0;
            this.AvviaServerBtn.Text = "Avvia Server";
            this.AvviaServerBtn.UseVisualStyleBackColor = true;
            this.AvviaServerBtn.Click += new System.EventHandler(this.AvviaServerBtn_Click);
            // 
            // privatoRdBtn
            // 
            this.privatoRdBtn.AutoSize = true;
            this.privatoRdBtn.Location = new System.Drawing.Point(3, 3);
            this.privatoRdBtn.MaximumSize = new System.Drawing.Size(57, 17);
            this.privatoRdBtn.MinimumSize = new System.Drawing.Size(57, 17);
            this.privatoRdBtn.Name = "privatoRdBtn";
            this.privatoRdBtn.Size = new System.Drawing.Size(57, 17);
            this.privatoRdBtn.TabIndex = 1;
            this.privatoRdBtn.Text = "privato";
            this.privatoRdBtn.UseVisualStyleBackColor = true;
            this.privatoRdBtn.CheckedChanged += new System.EventHandler(this.privatoRdBtn_CheckedChanged);
            // 
            // publicoRdBtn
            // 
            this.publicoRdBtn.AutoSize = true;
            this.publicoRdBtn.Checked = true;
            this.publicoRdBtn.Location = new System.Drawing.Point(3, 32);
            this.publicoRdBtn.MaximumSize = new System.Drawing.Size(80, 25);
            this.publicoRdBtn.MinimumSize = new System.Drawing.Size(80, 25);
            this.publicoRdBtn.Name = "publicoRdBtn";
            this.publicoRdBtn.Size = new System.Drawing.Size(80, 25);
            this.publicoRdBtn.TabIndex = 2;
            this.publicoRdBtn.TabStop = true;
            this.publicoRdBtn.Text = "pubblico";
            this.publicoRdBtn.UseVisualStyleBackColor = true;
            this.publicoRdBtn.CheckedChanged += new System.EventHandler(this.publicoRdBtn_CheckedChanged);
            // 
            // ContenitoreDestro
            // 
            this.ContenitoreDestro.AutoScroll = true;
            this.ContenitoreDestro.AutoSize = true;
            this.ContenitoreDestro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContenitoreDestro.ColumnCount = 1;
            this.ContenitoreDestro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContenitoreDestro.Controls.Add(this.privatoRdBtn, 0, 0);
            this.ContenitoreDestro.Controls.Add(this.publicoRdBtn, 0, 1);
            this.ContenitoreDestro.Controls.Add(this.AvviaServerBtn, 0, 2);
            this.ContenitoreDestro.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContenitoreDestro.Location = new System.Drawing.Point(596, 20);
            this.ContenitoreDestro.Name = "ContenitoreDestro";
            this.ContenitoreDestro.RowCount = 3;
            this.ContenitoreDestro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.ContenitoreDestro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContenitoreDestro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContenitoreDestro.Size = new System.Drawing.Size(131, 256);
            this.ContenitoreDestro.TabIndex = 3;
            this.ContenitoreDestro.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // FotoUtente
            // 
            this.FotoUtente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FotoUtente.InitialImage = null;
            this.FotoUtente.Location = new System.Drawing.Point(3, 3);
            this.FotoUtente.MaximumSize = new System.Drawing.Size(124, 106);
            this.FotoUtente.MinimumSize = new System.Drawing.Size(124, 106);
            this.FotoUtente.Name = "FotoUtente";
            this.FotoUtente.Size = new System.Drawing.Size(124, 106);
            this.FotoUtente.TabIndex = 4;
            this.FotoUtente.TabStop = false;
            // 
            // ContenitoreSinistro
            // 
            this.ContenitoreSinistro.AutoSize = true;
            this.ContenitoreSinistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContenitoreSinistro.ColumnCount = 2;
            this.ContenitoreSinistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.04943F));
            this.ContenitoreSinistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.95057F));
            this.ContenitoreSinistro.Controls.Add(this.FotoUtente, 0, 0);
            this.ContenitoreSinistro.Controls.Add(this.CaricaFoto, 0, 1);
            this.ContenitoreSinistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContenitoreSinistro.Location = new System.Drawing.Point(20, 20);
            this.ContenitoreSinistro.Name = "ContenitoreSinistro";
            this.ContenitoreSinistro.RowCount = 2;
            this.ContenitoreSinistro.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContenitoreSinistro.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContenitoreSinistro.Size = new System.Drawing.Size(265, 256);
            this.ContenitoreSinistro.TabIndex = 6;
            // 
            // CaricaFoto
            // 
            this.CaricaFoto.Location = new System.Drawing.Point(30, 115);
            this.CaricaFoto.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.CaricaFoto.MaximumSize = new System.Drawing.Size(75, 23);
            this.CaricaFoto.MinimumSize = new System.Drawing.Size(75, 23);
            this.CaricaFoto.Name = "CaricaFoto";
            this.CaricaFoto.Size = new System.Drawing.Size(75, 23);
            this.CaricaFoto.TabIndex = 5;
            this.CaricaFoto.Text = "Carica Foto";
            this.CaricaFoto.UseVisualStyleBackColor = true;
            this.CaricaFoto.Click += new System.EventHandler(this.CaricaFoto_Click);
            // 
            // IconaBarraAvvio
            // 
            this.IconaBarraAvvio.Icon = ((System.Drawing.Icon)(resources.GetObject("IconaBarraAvvio.Icon")));
            this.IconaBarraAvvio.Text = "MalnatiProject";
            this.IconaBarraAvvio.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(747, 296);
            this.Controls.Add(this.ContenitoreSinistro);
            this.Controls.Add(this.ContenitoreDestro);
            this.MinimumSize = new System.Drawing.Size(455, 230);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "MalnatiProject";
            this.ContenitoreDestro.ResumeLayout(false);
            this.ContenitoreDestro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoUtente)).EndInit();
            this.ContenitoreSinistro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button AvviaServerBtn;
        private System.Windows.Forms.RadioButton privatoRdBtn;
        private System.Windows.Forms.RadioButton publicoRdBtn;
        private EventHandler publico_CheckedChanged;
        private EventHandler privato_CheckedChanged;

        private void privatoRdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void publicoRdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.TableLayoutPanel ContenitoreDestro;
        private System.Windows.Forms.PictureBox FotoUtente;
        private System.Windows.Forms.TableLayoutPanel ContenitoreSinistro;
        private System.Windows.Forms.NotifyIcon IconaBarraAvvio;
        private System.Windows.Forms.Button CaricaFoto;
    }
}

