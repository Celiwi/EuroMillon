namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.textnum6 = new System.Windows.Forms.TextBox();
            this.textnum5 = new System.Windows.Forms.TextBox();
            this.textnum4 = new System.Windows.Forms.TextBox();
            this.textnum3 = new System.Windows.Forms.TextBox();
            this.textnum2 = new System.Windows.Forms.TextBox();
            this.textnum1 = new System.Windows.Forms.TextBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.n6 = new System.Windows.Forms.Label();
            this.n5 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.grupo3 = new System.Windows.Forms.GroupBox();
            this.a6 = new System.Windows.Forms.Label();
            this.a5 = new System.Windows.Forms.Label();
            this.a4 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Label();
            this.labelAciertos = new System.Windows.Forms.Label();
            this.labelTemporizador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAutomataico = new System.Windows.Forms.Button();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.grupo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.textnum6);
            this.grupo1.Controls.Add(this.textnum5);
            this.grupo1.Controls.Add(this.textnum4);
            this.grupo1.Controls.Add(this.textnum3);
            this.grupo1.Controls.Add(this.textnum2);
            this.grupo1.Controls.Add(this.textnum1);
            this.grupo1.Location = new System.Drawing.Point(60, 79);
            this.grupo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupo1.Name = "grupo1";
            this.grupo1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupo1.Size = new System.Drawing.Size(201, 236);
            this.grupo1.TabIndex = 0;
            this.grupo1.TabStop = false;
            this.grupo1.Text = "Mis números";
            // 
            // textnum6
            // 
            this.textnum6.Location = new System.Drawing.Point(25, 191);
            this.textnum6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textnum6.Name = "textnum6";
            this.textnum6.Size = new System.Drawing.Size(132, 22);
            this.textnum6.TabIndex = 5;
            this.textnum6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnum1_KeyPress);
            this.textnum6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textnum1_KeyUp);
            // 
            // textnum5
            // 
            this.textnum5.Location = new System.Drawing.Point(25, 158);
            this.textnum5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textnum5.Name = "textnum5";
            this.textnum5.Size = new System.Drawing.Size(132, 22);
            this.textnum5.TabIndex = 4;
            this.textnum5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnum1_KeyPress);
            this.textnum5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textnum1_KeyUp);
            // 
            // textnum4
            // 
            this.textnum4.Location = new System.Drawing.Point(25, 124);
            this.textnum4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textnum4.Name = "textnum4";
            this.textnum4.Size = new System.Drawing.Size(132, 22);
            this.textnum4.TabIndex = 3;
            this.textnum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnum1_KeyPress);
            this.textnum4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textnum1_KeyUp);
            // 
            // textnum3
            // 
            this.textnum3.Location = new System.Drawing.Point(25, 91);
            this.textnum3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textnum3.Name = "textnum3";
            this.textnum3.Size = new System.Drawing.Size(132, 22);
            this.textnum3.TabIndex = 2;
            this.textnum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnum1_KeyPress);
            this.textnum3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textnum1_KeyUp);
            // 
            // textnum2
            // 
            this.textnum2.Location = new System.Drawing.Point(25, 58);
            this.textnum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textnum2.Name = "textnum2";
            this.textnum2.Size = new System.Drawing.Size(132, 22);
            this.textnum2.TabIndex = 1;
            this.textnum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnum1_KeyPress);
            this.textnum2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textnum1_KeyUp);
            // 
            // textnum1
            // 
            this.textnum1.Location = new System.Drawing.Point(25, 25);
            this.textnum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textnum1.Name = "textnum1";
            this.textnum1.Size = new System.Drawing.Size(132, 22);
            this.textnum1.TabIndex = 0;
            this.textnum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnum1_KeyPress);
            this.textnum1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textnum1_KeyUp);
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.n6);
            this.grupo2.Controls.Add(this.n5);
            this.grupo2.Controls.Add(this.n4);
            this.grupo2.Controls.Add(this.n3);
            this.grupo2.Controls.Add(this.n2);
            this.grupo2.Controls.Add(this.n1);
            this.grupo2.Location = new System.Drawing.Point(328, 79);
            this.grupo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupo2.Name = "grupo2";
            this.grupo2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupo2.Size = new System.Drawing.Size(201, 236);
            this.grupo2.TabIndex = 1;
            this.grupo2.TabStop = false;
            this.grupo2.Text = "Ganadores";
            // 
            // n6
            // 
            this.n6.AutoSize = true;
            this.n6.Location = new System.Drawing.Point(79, 199);
            this.n6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(0, 17);
            this.n6.TabIndex = 5;
            // 
            // n5
            // 
            this.n5.AutoSize = true;
            this.n5.Location = new System.Drawing.Point(79, 166);
            this.n5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(0, 17);
            this.n5.TabIndex = 4;
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.Location = new System.Drawing.Point(79, 133);
            this.n4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(0, 17);
            this.n4.TabIndex = 3;
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Location = new System.Drawing.Point(79, 95);
            this.n3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(0, 17);
            this.n3.TabIndex = 2;
            this.n3.Click += new System.EventHandler(this.label2_Click);
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(79, 66);
            this.n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(0, 17);
            this.n2.TabIndex = 1;
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(79, 33);
            this.n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(0, 17);
            this.n1.TabIndex = 0;
            // 
            // grupo3
            // 
            this.grupo3.Controls.Add(this.a6);
            this.grupo3.Controls.Add(this.a5);
            this.grupo3.Controls.Add(this.a4);
            this.grupo3.Controls.Add(this.a3);
            this.grupo3.Controls.Add(this.a2);
            this.grupo3.Controls.Add(this.a1);
            this.grupo3.Location = new System.Drawing.Point(592, 79);
            this.grupo3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupo3.Name = "grupo3";
            this.grupo3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupo3.Size = new System.Drawing.Size(201, 236);
            this.grupo3.TabIndex = 2;
            this.grupo3.TabStop = false;
            this.grupo3.Text = "Aciertos";
            // 
            // a6
            // 
            this.a6.AutoSize = true;
            this.a6.Location = new System.Drawing.Point(79, 199);
            this.a6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(0, 17);
            this.a6.TabIndex = 5;
            // 
            // a5
            // 
            this.a5.AutoSize = true;
            this.a5.Location = new System.Drawing.Point(79, 166);
            this.a5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(0, 17);
            this.a5.TabIndex = 4;
            // 
            // a4
            // 
            this.a4.AutoSize = true;
            this.a4.Location = new System.Drawing.Point(79, 133);
            this.a4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(0, 17);
            this.a4.TabIndex = 3;
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Location = new System.Drawing.Point(79, 95);
            this.a3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(0, 17);
            this.a3.TabIndex = 2;
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Location = new System.Drawing.Point(79, 66);
            this.a2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(0, 17);
            this.a2.TabIndex = 1;
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Location = new System.Drawing.Point(79, 33);
            this.a1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(0, 17);
            this.a1.TabIndex = 0;
            // 
            // labelAciertos
            // 
            this.labelAciertos.AutoSize = true;
            this.labelAciertos.Location = new System.Drawing.Point(592, 353);
            this.labelAciertos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAciertos.Name = "labelAciertos";
            this.labelAciertos.Size = new System.Drawing.Size(0, 17);
            this.labelAciertos.TabIndex = 3;
            // 
            // labelTemporizador
            // 
            this.labelTemporizador.AutoSize = true;
            this.labelTemporizador.Location = new System.Drawing.Point(81, 367);
            this.labelTemporizador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemporizador.Name = "labelTemporizador";
            this.labelTemporizador.Size = new System.Drawing.Size(24, 17);
            this.labelTemporizador.TabIndex = 4;
            this.labelTemporizador.Text = "10";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAutomataico
            // 
            this.btnAutomataico.Location = new System.Drawing.Point(383, 29);
            this.btnAutomataico.Name = "btnAutomataico";
            this.btnAutomataico.Size = new System.Drawing.Size(96, 23);
            this.btnAutomataico.TabIndex = 5;
            this.btnAutomataico.Text = "Automatico";
            this.btnAutomataico.UseVisualStyleBackColor = true;
            this.btnAutomataico.Click += new System.EventHandler(this.btnAutomataico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(835, 412);
            this.Controls.Add(this.btnAutomataico);
            this.Controls.Add(this.labelTemporizador);
            this.Controls.Add(this.labelAciertos);
            this.Controls.Add(this.grupo3);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textnum1_KeyUp);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.grupo3.ResumeLayout(false);
            this.grupo3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.TextBox textnum6;
        private System.Windows.Forms.TextBox textnum5;
        private System.Windows.Forms.TextBox textnum4;
        private System.Windows.Forms.TextBox textnum3;
        private System.Windows.Forms.TextBox textnum2;
        private System.Windows.Forms.TextBox textnum1;
        private System.Windows.Forms.GroupBox grupo2;
        private System.Windows.Forms.Label n6;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.GroupBox grupo3;
        private System.Windows.Forms.Label a6;
        private System.Windows.Forms.Label a5;
        private System.Windows.Forms.Label a4;
        private System.Windows.Forms.Label a3;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label labelAciertos;
        private System.Windows.Forms.Label labelTemporizador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAutomataico;
    }
}

