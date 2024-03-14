namespace Calculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnTres = new Button();
            btnDos = new Button();
            btnUno = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnCambioDeSigno = new Button();
            btnQuitar = new Button();
            btnBorrarTodo = new Button();
            btnBorrar = new Button();
            btnDividir = new Button();
            label1 = new Label();
            btnResultado = new Button();
            btnMas = new Button();
            btnMenos = new Button();
            btnMultiplicar = new Button();
            btnElevarAlCuadrado = new Button();
            btnRaizCuadrada = new Button();
            txtNumeroAuxiliar = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(0, 118);
            txtResultado.MaxLength = 15;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(329, 41);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTres.Location = new Point(152, 425);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(70, 55);
            btnTres.TabIndex = 31;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += AgregarNumero;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDos.Location = new Point(76, 425);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(70, 55);
            btnDos.TabIndex = 30;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += AgregarNumero;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUno.Location = new Point(0, 425);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(70, 55);
            btnUno.TabIndex = 29;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += AgregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(152, 364);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(70, 55);
            btnSeis.TabIndex = 36;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += AgregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(76, 364);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(70, 55);
            btnCinco.TabIndex = 35;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += AgregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCuatro.Location = new Point(0, 364);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(70, 55);
            btnCuatro.TabIndex = 34;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += AgregarNumero;
            // 
            // btnNueve
            // 
            btnNueve.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNueve.Location = new Point(152, 303);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(70, 55);
            btnNueve.TabIndex = 39;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += AgregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOcho.Location = new Point(76, 303);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(70, 55);
            btnOcho.TabIndex = 38;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += AgregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiete.Location = new Point(0, 303);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(70, 55);
            btnSiete.TabIndex = 37;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += AgregarNumero;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(152, 486);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(70, 55);
            btnPunto.TabIndex = 42;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCero.Location = new Point(76, 486);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(70, 55);
            btnCero.TabIndex = 41;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += AgregarNumero;
            // 
            // btnCambioDeSigno
            // 
            btnCambioDeSigno.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambioDeSigno.Location = new Point(0, 486);
            btnCambioDeSigno.Name = "btnCambioDeSigno";
            btnCambioDeSigno.Size = new Size(70, 55);
            btnCambioDeSigno.TabIndex = 40;
            btnCambioDeSigno.Text = "+/-";
            btnCambioDeSigno.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitar.Location = new Point(259, 181);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(70, 55);
            btnQuitar.TabIndex = 45;
            btnQuitar.Text = "←";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrarTodo.Location = new Point(152, 181);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(70, 55);
            btnBorrarTodo.TabIndex = 44;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(76, 181);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(70, 55);
            btnBorrar.TabIndex = 43;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(259, 242);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(70, 55);
            btnDividir.TabIndex = 48;
            btnDividir.Tag = "∕";
            btnDividir.Text = "∕";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += ClickOperador;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 49;
            label1.Text = "Estándar";
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(228, 486);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(101, 55);
            btnResultado.TabIndex = 33;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnMas
            // 
            btnMas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMas.Location = new Point(259, 425);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(70, 55);
            btnMas.TabIndex = 32;
            btnMas.Tag = "+";
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += ClickOperador;
            // 
            // btnMenos
            // 
            btnMenos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenos.Location = new Point(259, 364);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(70, 55);
            btnMenos.TabIndex = 47;
            btnMenos.Tag = "−";
            btnMenos.Text = "−";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += ClickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(259, 303);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(70, 55);
            btnMultiplicar.TabIndex = 46;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += ClickOperador;
            // 
            // btnElevarAlCuadrado
            // 
            btnElevarAlCuadrado.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnElevarAlCuadrado.Location = new Point(76, 239);
            btnElevarAlCuadrado.Name = "btnElevarAlCuadrado";
            btnElevarAlCuadrado.Size = new Size(70, 55);
            btnElevarAlCuadrado.TabIndex = 51;
            btnElevarAlCuadrado.Tag = "²";
            btnElevarAlCuadrado.Text = "x²";
            btnElevarAlCuadrado.UseVisualStyleBackColor = true;
            btnElevarAlCuadrado.Click += ClickOperador;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaizCuadrada.Location = new Point(152, 239);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(70, 55);
            btnRaizCuadrada.TabIndex = 50;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += ClickOperador;
            // 
            // txtNumeroAuxiliar
            // 
            txtNumeroAuxiliar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroAuxiliar.Location = new Point(117, 85);
            txtNumeroAuxiliar.MaxLength = 15;
            txtNumeroAuxiliar.Multiline = true;
            txtNumeroAuxiliar.Name = "txtNumeroAuxiliar";
            txtNumeroAuxiliar.Size = new Size(212, 27);
            txtNumeroAuxiliar.TabIndex = 52;
            txtNumeroAuxiliar.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 561);
            Controls.Add(txtNumeroAuxiliar);
            Controls.Add(btnElevarAlCuadrado);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(label1);
            Controls.Add(btnDividir);
            Controls.Add(btnMenos);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnCambioDeSigno);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnResultado);
            Controls.Add(btnMas);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora by Horacio Barrios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnPunto;
        private Button btnCero;
        private Button btnCambioDeSigno;
        private Button btnQuitar;
        private Button btnBorrarTodo;
        private Button btnBorrar;
        private Button btnDividir;
        private Label label1;
        private Button btnResultado;
        private Button btnMas;
        private Button btnMenos;
        private Button btnMultiplicar;
        private Button btnElevarAlCuadrado;
        private Button btnRaizCuadrada;
        private TextBox txtNumeroAuxiliar;
    }
}
