using System;
using System.Globalization; // Necesario para CultureInfo

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        private double _numero1 = 0;
        private double _numero2 = 0;
        private char _operador;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        // Agrega el numero 
        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = (Button)sender;

            if (string.IsNullOrEmpty(txtResultado.Text) || txtResultado.Text == "0")//si esta vacio o tiene valor 0, no agreges nada cuando s toca un valor numerico(es pra que no podamos poner 00001245)
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += boton.Text;
        }

        // Captura el evento del operador matemático seleccionado por el usuario
        private void ClickOperador(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            _numero1 = ParseDouble(txtResultado.Text);
            _operador = Convert.ToChar(boton.Tag);

            switch (_operador)
            {
                case '²':
                    _numero1 = Math.Pow(_numero1, 2);
                    txtResultado.Text = _numero1.ToString();
                    break;
                case '√':
                    _numero1 = Math.Sqrt(_numero1);
                    txtResultado.Text = _numero1.ToString();
                    break;
                default:
                    txtResultado.Text = "0";
                    break;
            }
        }


        // Metodo que Realiza la operación matemática cuando se presiona el botón de resultado
        private void btnResultado_Click(object sender, EventArgs e)
        {
            _numero2 = ParseDouble(txtResultado.Text);

            switch (_operador)
            {
                case '+':
                    txtResultado.Text = (_numero1 + _numero2).ToString();
                    _numero1 = ParseDouble(txtResultado.Text);
                    break;
                case '−':
                    txtResultado.Text = (_numero1 - _numero2).ToString();
                    _numero1 = ParseDouble(txtResultado.Text);
                    break;
                case 'X':
                    txtResultado.Text = (_numero1 * _numero2).ToString();
                    _numero1 = ParseDouble(txtResultado.Text);
                    break;
                case '∕':
                    if(txtResultado.Text != "0")
                    {
                        txtResultado.Text = (_numero1 / _numero2).ToString();
                        _numero1 = ParseDouble(txtResultado.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por 0");                                
                    }
                    break;                    
            }

        }

        // Metodo que Elimina el último dígito ingresado
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        // Metodo Borra todos los números ingresados y restablece los valores
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            _numero1 = 0;
            _numero2 = 0;
            _operador = '\0'; // Carácter nulo
            txtResultado.Text = "0";
            
        }



        // Borra lo que se está escribiendo
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }



        // Metodo que agrega el punto decimal si no tiene uno
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains('.'))
            {
                txtResultado.Text += '.';
            }
        }




        // Método para convertir la cadena de texto en un número double
        /*
        Cuando se utiliza CultureInfo.InvariantCulture como parámetro en operaciones de formato y análisis, 
        se garantiza que se utilice un conjunto específico de reglas que no cambian según la configuración 
        regional del sistema. Por ejemplo, al convertir una cadena en un número decimal, el uso de 
        CultureInfo.InvariantCulture asegura que el punto (".") sea siempre interpretado como el separador decimal, 
        independientemente de si la configuración regional del sistema utiliza la coma (",") como separador decimal.
         */
        private double ParseDouble(string text)
        {
            double result;
            // Verificamos si la cadena de texto se puede convertir a double
            if (double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                return result;
            }
            else
            {
                // En caso en el que el texto no se puede convertir a un número double
                return 0;
            }
        }

        private void btnCambioDeSigno_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "0")
            {
                _numero1 = ParseDouble(txtResultado.Text);
                //_numero1 = _numero1 * -1;

                _numero1 *= -1; // al numero le cambia el signo, si es posit lo pasa a negativo y viceversa.
                txtResultado.Text = _numero1.ToString();
            }

        }
    }
}
