using System;
using System.Collections.Generic; // Para usar List<T>
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Para usar .Last()
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App
{
    public partial class Form1 : Form
    {
        // -------------------------------------------------------------------
        // DECLARACI�N DE LISTAS (CAMPOS PRIVADOS)
        /// <summary>
        /// Lista para almacenar los tipos de materiales seleccionados (ej. "Cemento", "Cal").
        /// Se utiliza una <c>List&lt;string&gt;</c> porque no se sabe cuantas veces se ingresar�n materiales
        /// y puede crecer din�micamente seg�n la entrada del usuario. Almacena datos de tipo texto.
        /// </summary>
        private List<string> tiposMateriales = new List<string>();

        /// <summary>
        /// Lista para almacenar las cantidades de materiales ingresadas en kilogramos.
        /// Se utiliza una <c>List&lt;int&gt;</c> porque el n�mero de cantidades es variable
        /// y corresponde a cada entrada de material. Almacena datos de tipo n�mero entero.
        /// </summary>
        private List<int> cantidades = new List<int>();
        // -------------------------------------------------------------------


        // CONSTRUCTOR DEL FORMULARIO
        // El m�todo InitializeComponent() es llamado aqu�. Su contenido
        // est� definido en el archivo Form1.Designer.cs, no aqu�.
        public Form1()
        {
            InitializeComponent();
            // Esta l�nea asocia el m�todo Form1_Load con el evento Load del formulario.
            // Es buena pr�ctica tenerla aqu� para asegurar la inicializaci�n.
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        // -------------------------------------------------------------------
        // M�TODOS DE EVENTOS DEL FORMULARIO Y CONTROLES

        /// <summary>
        /// M�todo Form1_Load: Se ejecuta al iniciar el formulario.
        /// Su funci�n es inicializar los componentes de la interfaz de usuario,
        /// espec�ficamente cargar las opciones v�lidas en la ComboBox de Tipo de Material
        /// y configurar su comportamiento para que solo se pueda seleccionar de la lista.
        /// Tipo de ciclo utilizado: Ninguno (las operaciones son secuenciales de inicializaci�n).
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga los tipos de material predefinidos en la ComboBox.
            cmbTipoMaterial.Items.Add("Cemento");
            cmbTipoMaterial.Items.Add("Cal");
            cmbTipoMaterial.Items.Add("Yeso");
            cmbTipoMaterial.Items.Add("Fierro");
            cmbTipoMaterial.Items.Add("Arena");

            // Configura la ComboBox para que solo permita seleccionar elementos de su lista,
            // impidiendo que el usuario escriba texto no v�lido.
            cmbTipoMaterial.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establece el primer elemento de la lista como seleccionado por defecto,
            // mejorando la usabilidad inicial.
            if (cmbTipoMaterial.Items.Count > 0)
            {
                cmbTipoMaterial.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// M�todo btnCapturar_Click: Se ejecuta al hacer clic en el bot�n "Registrar material".
        /// Su funci�n es:
        /// 1. Validar la entrada del usuario para Tipo de Material y Cantidad.
        /// 2. Almacenar los datos v�lidos en las listas <c>tiposMateriales</c> y <c>cantidades</c>.
        /// 3. Informar al usuario sobre el registro exitoso.
        /// 4. Limpiar el campo de cantidad para permitir la entrada de nuevos datos.
        /// Tipos de datos b�sicos: <c>string</c> (para el tipo de material) e <c>int</c> (para la cantidad).
        /// Tipos de ciclos: Ninguno (la l�gica es secuencial; las listas crecen din�micamente).
        /// Equivalencia a Console.ReadLine/WriteLine: Se utilizan controles de UI para entrada (ComboBox, NumericUpDown)
        /// y <c>MessageBox.Show()</c> para mostrar mensajes al usuario, en lugar de la consola.
        /// estas funciones cambiar�n seg�n las actividades del equipo
        /// </summary>
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            // --- VALIDACI�N DE ENTRADA ---
            // Asegura que se haya seleccionado un tipo de material.
            if (cmbTipoMaterial.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un Tipo de Material.", "Error de Captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoMaterial.Focus(); // Coloca el foco en la ComboBox para que el usuario pueda corregir.
                return; // Detiene la ejecuci�n del m�todo si la validaci�n falla.
            }

            // Asegura que la cantidad ingresada sea un valor v�lido y mayor a cero.
            // El tipo de dato 'int' se utiliza para la cantidad, ya que son n�meros enteros de kilogramos.
            int cantidad = (int)nudCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0 kg.", "Error de Captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudCantidad.Focus(); // Coloca el foco en el NumericUpDown.
                return; // Detiene la ejecuci�n del m�todo si la validaci�n falla.
            }

            // --- ALMACENAMIENTO DE DATOS ---
            // Agrega el tipo de material seleccionado a la lista 'tiposMateriales'.
            // La List<T> act�a como un array din�mico que crece seg�n se a�aden elementos.
            tiposMateriales.Add(cmbTipoMaterial.SelectedItem.ToString());

            // Agrega la cantidad a la lista 'cantidades'.
            cantidades.Add(cantidad);

            // --- FEEDBACK AL USUARIO Y PREPARACI�N PARA NUEVA ENTRADA ---
            // Muestra un mensaje de confirmaci�n al usuario (equivalente a Console.WriteLine).
            // Se utiliza '.Last()' para mostrar el �ltimo elemento agregado, que es el actual.
            MessageBox.Show($"Material registrado:\nTipo: {tiposMateriales.Last()}\nCantidad: {cantidades.Last()} kg",
                            "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpia el campo de cantidad y coloca el foco para facilitar la siguiente entrada.
            nudCantidad.Value = 0;
            cmbTipoMaterial.Focus(); // Coloca el foco en la ComboBox para la siguiente selecci�n.
        }

        /// <summary>
        /// M�todo btnFinalizar_Click: Se ejecuta al hacer clic en el bot�n "Finalizar Captura...".
        /// Por ahora, solo muestra un mensaje informativo, ya que la l�gica completa de finalizaci�n
        /// y apertura del inventario es responsabilidad de otro miembro del equipo.
        /// </summary>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funci�n ser� implementada por el equipo pronto", "Funci�n en Desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}