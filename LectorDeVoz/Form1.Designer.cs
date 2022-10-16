namespace LectorDeVoz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.conversation = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pausa = new System.Windows.Forms.Button();
            this.bandeja_entrada = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.lbTxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.conversation);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.pausa);
            this.panel1.Controls.Add(this.bandeja_entrada);
            this.panel1.Controls.Add(this.play);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 76);
            this.panel1.TabIndex = 0;
            // 
            // conversation
            // 
            this.conversation.BackColor = System.Drawing.Color.Transparent;
            this.conversation.BackgroundImage = global::LectorDeVoz.Properties.Resources.conversacion;
            this.conversation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.conversation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conversation.ForeColor = System.Drawing.Color.RosyBrown;
            this.conversation.Location = new System.Drawing.Point(360, 8);
            this.conversation.Name = "conversation";
            this.conversation.Size = new System.Drawing.Size(59, 53);
            this.conversation.TabIndex = 1;
            this.conversation.UseVisualStyleBackColor = false;
            this.conversation.Click += new System.EventHandler(this.conversation_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.BackgroundImage = global::LectorDeVoz.Properties.Resources.boton_detener;
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.Color.RosyBrown;
            this.stop.Location = new System.Drawing.Point(278, 8);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(59, 53);
            this.stop.TabIndex = 2;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pausa
            // 
            this.pausa.BackColor = System.Drawing.Color.Transparent;
            this.pausa.BackgroundImage = global::LectorDeVoz.Properties.Resources.boton_de_pausa_de_video;
            this.pausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pausa.ForeColor = System.Drawing.Color.RosyBrown;
            this.pausa.Location = new System.Drawing.Point(197, 8);
            this.pausa.Name = "pausa";
            this.pausa.Size = new System.Drawing.Size(59, 53);
            this.pausa.TabIndex = 2;
            this.pausa.UseVisualStyleBackColor = false;
            this.pausa.Click += new System.EventHandler(this.pausa_Click);
            // 
            // bandeja_entrada
            // 
            this.bandeja_entrada.BackColor = System.Drawing.Color.Transparent;
            this.bandeja_entrada.BackgroundImage = global::LectorDeVoz.Properties.Resources.bandeja_de_entrada;
            this.bandeja_entrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bandeja_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bandeja_entrada.ForeColor = System.Drawing.Color.RosyBrown;
            this.bandeja_entrada.Location = new System.Drawing.Point(114, 8);
            this.bandeja_entrada.Name = "bandeja_entrada";
            this.bandeja_entrada.Size = new System.Drawing.Size(59, 53);
            this.bandeja_entrada.TabIndex = 1;
            this.bandeja_entrada.UseVisualStyleBackColor = false;
            this.bandeja_entrada.Click += new System.EventHandler(this.bandeja_entrada_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = global::LectorDeVoz.Properties.Resources.boton_de_play;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.ForeColor = System.Drawing.Color.RosyBrown;
            this.play.Location = new System.Drawing.Point(32, 8);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(59, 53);
            this.play.TabIndex = 0;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // lbTxt
            // 
            this.lbTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTxt.Location = new System.Drawing.Point(0, 68);
            this.lbTxt.Name = "lbTxt";
            this.lbTxt.Size = new System.Drawing.Size(458, 385);
            this.lbTxt.TabIndex = 1;
            this.lbTxt.Text = "Lector de Texto Avanzado";
            this.lbTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.lbTxt);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lector de voz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button bandeja_entrada;
        private System.Windows.Forms.Button pausa;
        private System.Windows.Forms.Button conversation;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label lbTxt;
    }
}

