namespace MinhaPrimeiraCalculadora
{
    partial class FormCalculadora
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
            this.btnCe = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnInversaoDeSinal = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCe
            // 
            this.btnCe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCe.Location = new System.Drawing.Point(9, 139);
            this.btnCe.Margin = new System.Windows.Forms.Padding(2);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(74, 64);
            this.btnCe.TabIndex = 1;
            this.btnCe.TabStop = false;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = false;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(87, 139);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(74, 64);
            this.btnC.TabIndex = 1;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(165, 139);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(74, 64);
            this.btnBackSpace.TabIndex = 2;
            this.btnBackSpace.TabStop = false;
            this.btnBackSpace.Text = "Backspace";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.SystemColors.Control;
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.Location = new System.Drawing.Point(9, 208);
            this.btnUm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(74, 64);
            this.btnUm.TabIndex = 3;
            this.btnUm.TabStop = false;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.SystemColors.Control;
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.Location = new System.Drawing.Point(87, 208);
            this.btnDois.Margin = new System.Windows.Forms.Padding(2);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(74, 64);
            this.btnDois.TabIndex = 4;
            this.btnDois.TabStop = false;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.SystemColors.Control;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(165, 208);
            this.btnTres.Margin = new System.Windows.Forms.Padding(2);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(74, 64);
            this.btnTres.TabIndex = 5;
            this.btnTres.TabStop = false;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.Location = new System.Drawing.Point(9, 277);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(74, 64);
            this.btnQuatro.TabIndex = 6;
            this.btnQuatro.TabStop = false;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.Control;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(87, 277);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(2);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(74, 64);
            this.btnCinco.TabIndex = 7;
            this.btnCinco.TabStop = false;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.Control;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(165, 277);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(74, 64);
            this.btnSeis.TabIndex = 8;
            this.btnSeis.TabStop = false;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(243, 139);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(2);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(74, 64);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.TabStop = false;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btn_OperacaoClick);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(243, 208);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(74, 64);
            this.btnMultiplicar.TabIndex = 10;
            this.btnMultiplicar.TabStop = false;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btn_OperacaoClick);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(243, 277);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(74, 64);
            this.btnSubtrair.TabIndex = 11;
            this.btnSubtrair.TabStop = false;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btn_OperacaoClick);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.SystemColors.Control;
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.Location = new System.Drawing.Point(9, 346);
            this.btnSete.Margin = new System.Windows.Forms.Padding(2);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(74, 64);
            this.btnSete.TabIndex = 12;
            this.btnSete.TabStop = false;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.SystemColors.Control;
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.Location = new System.Drawing.Point(87, 346);
            this.btnOito.Margin = new System.Windows.Forms.Padding(2);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(74, 64);
            this.btnOito.TabIndex = 13;
            this.btnOito.TabStop = false;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.SystemColors.Control;
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.Location = new System.Drawing.Point(165, 346);
            this.btnNove.Margin = new System.Windows.Forms.Padding(2);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(74, 64);
            this.btnNove.TabIndex = 14;
            this.btnNove.TabStop = false;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(243, 346);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(74, 64);
            this.btnSomar.TabIndex = 15;
            this.btnSomar.TabStop = false;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btn_OperacaoClick);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.Control;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(87, 415);
            this.btnZero.Margin = new System.Windows.Forms.Padding(2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(74, 64);
            this.btnZero.TabIndex = 16;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btn_NumeroClick);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(243, 415);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(74, 64);
            this.btnTotal.TabIndex = 18;
            this.btnTotal.TabStop = false;
            this.btnTotal.Text = "=";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVirgula.Enabled = false;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(165, 415);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(74, 64);
            this.btnVirgula.TabIndex = 19;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            // 
            // btnInversaoDeSinal
            // 
            this.btnInversaoDeSinal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInversaoDeSinal.Enabled = false;
            this.btnInversaoDeSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversaoDeSinal.Location = new System.Drawing.Point(9, 415);
            this.btnInversaoDeSinal.Margin = new System.Windows.Forms.Padding(2);
            this.btnInversaoDeSinal.Name = "btnInversaoDeSinal";
            this.btnInversaoDeSinal.Size = new System.Drawing.Size(74, 64);
            this.btnInversaoDeSinal.TabIndex = 20;
            this.btnInversaoDeSinal.Text = "+/-";
            this.btnInversaoDeSinal.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbDisplay
            // 
            this.tbDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.tbDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDisplay.Location = new System.Drawing.Point(9, 10);
            this.tbDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(308, 114);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TabStop = false;
            this.tbDisplay.Text = "0";
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(327, 493);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btnInversaoDeSinal);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 532);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(343, 532);
            this.Name = "FormCalculadora";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Click += new System.EventHandler(this.btn_NumeroClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnInversaoDeSinal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}

