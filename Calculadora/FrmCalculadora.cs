namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        //numero1 representa el numero que elijio el usuario antes de presionar el operador matematico (lo guardamos, para dejar escribir el siguiente numero)
        private double _numero1 = 0;// double soporta valores mas grandes que float, int ...
        private double _numero2 = 0;
        private string _numeroParaTxtAuxiliar;
        private char _operador;

        public FrmCalculadora()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Agrega el número correspondiente al botón presionado al campo de resultado.
        /// Si el resultado es actualmente "0", lo limpia antes de agregar el número.
        /// </summary>
        /// <param name="sender">El botón que ha sido presionado.</param>
        /// <param name="e">Argumentos del evento (no utilizado en este caso).</param>
        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = (Button)sender;

            // Verifica si el texto actual es una cadena vacía o "0"
            if (string.IsNullOrEmpty(txtResultado.Text) || txtResultado.Text == "0")
            {
                txtResultado.Text = ""; // Limpia el campo de resultado si es "0" o está vacío
            }

            // Agrega el texto del botón al campo de resultado
            txtResultado.Text += boton.Text;
        }

        private void ClickOperador(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            _numero1 = Convert.ToInt32(txtResultado.Text); //guarda l 1er numero para continuar con la operacion luego
            //_operador = Convert.ToChar(boton.Text); //guarda el operador presionado(vamos a tener el problema de que el operador cuadrado son dos chracters y char soporta uno, por esto vamos a usar tag) en las propiedades del diseñador agregamos los caracteres al tag. Nos fijatemos en el tag en lugar del Text
            _operador = Convert.ToChar(boton.Tag);


            //reseteamos a 0
            txtResultado.Text = "0";
        }


        private void btnResultado_Click(object sender, EventArgs e)
        {
            _numero2 = Convert.ToInt32(txtResultado.Text); //lo que este escrito ahora es el segundo numero
            switch (_operador)
            {
                case '+':
                    txtResultado.Text = (_numero1 + _numero2).ToString(); // lo mostramos en string
                    _numero1 = Convert.ToDouble(txtResultado.Text); //el resultado lo gurdamos en _numero1
                    //min 27:46                                                
                    break;
            }
        }
    }
}
