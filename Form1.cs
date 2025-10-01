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
        // DECLARACIÓN DE LISTAS (CAMPOS PRIVADOS)
        /// <summary>
        /// Lista para almacenar los tipos de materiales seleccionados (ej. "Cemento", "Cal").
        /// Se utiliza una <c>List&lt;string&gt;</c> porque no se sabe cuantas veces se ingresarán materiales
        /// y puede crecer dinámicamente según la entrada del usuario. Almacena datos de tipo texto.
        /// </summary>
        private List<string> tiposMateriales = new List<string>();

        /// <summary>
        /// Lista para almacenar las cantidades de materiales ingresadas en kilogramos.
        /// Se utiliza una <c>List&lt;int&gt;</c> porque el número de cantidades es variable
        /// y corresponde a cada entrada de material. Almacena datos de tipo número entero.
        /// </summary>
        private List<int> cantidades = new List<int>();
        // -------------------------------------------------------------------


        // CONSTRUCTOR DEL FORMULARIO
        // El método InitializeComponent() es llamado aquí. Su contenido
        // está definido en el archivo Form1.Designer.cs, no aquí.
        public Form1()
        {
            InitializeComponent();
            // Esta línea asocia el método Form1_Load con el evento Load del formulario.
            // Es buena práctica tenerla aquí para asegurar la inicialización.
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        // -------------------------------------------------------------------
        // MÉTODOS DE EVENTOS DEL FORMULARIO Y CONTROLES

        /// <summary>
        /// Método Form1_Load: Se ejecuta al iniciar el formulario.
        /// Su función es inicializar los componentes de la interfaz de usuario,
        /// específicamente cargar las opciones válidas en la ComboBox de Tipo de Material
        /// y configurar su comportamiento para que solo se pueda seleccionar de la lista.
        /// Tipo de ciclo utilizado: Ninguno (las operaciones son secuenciales de inicialización).
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
            // impidiendo que el usuario escriba texto no válido.
            cmbTipoMaterial.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establece el primer elemento de la lista como seleccionado por defecto,
            // mejorando la usabilidad inicial.
            if (cmbTipoMaterial.Items.Count > 0)
            {
                cmbTipoMaterial.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Método btnCapturar_Click: Se ejecuta al hacer clic en el botón "Registrar material".
        /// Su función es:
        /// 1. Validar la entrada del usuario para Tipo de Material y Cantidad.
        /// 2. Almacenar los datos válidos en las listas <c>tiposMateriales</c> y <c>cantidades</c>.
        /// 3. Informar al usuario sobre el registro exitoso.
        /// 4. Limpiar el campo de cantidad para permitir la entrada de nuevos datos.
        /// Tipos de datos básicos: <c>string</c> (para el tipo de material) e <c>int</c> (para la cantidad).
        /// Tipos de ciclos: Ninguno (la lógica es secuencial; las listas crecen dinámicamente).
        /// Equivalencia a Console.ReadLine/WriteLine: Se utilizan controles de UI para entrada (ComboBox, NumericUpDown)
        /// y <c>MessageBox.Show()</c> para mostrar mensajes al usuario, en lugar de la consola.
        /// estas funciones cambiarán según las actividades del equipo
        /// </summary>
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            // --- VALIDACIÓN DE ENTRADA ---
            // Asegura que se haya seleccionado un tipo de material.
            if (cmbTipoMaterial.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un Tipo de Material.", "Error de Captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoMaterial.Focus(); // Coloca el foco en la ComboBox para que el usuario pueda corregir.
                return; // Detiene la ejecución del método si la validación falla.
            }

            // Asegura que la cantidad ingresada sea un valor válido y mayor a cero.
            // El tipo de dato 'int' se utiliza para la cantidad, ya que son números enteros de kilogramos.
            int cantidad = (int)nudCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0 kg.", "Error de Captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudCantidad.Focus(); // Coloca el foco en el NumericUpDown.
                return; // Detiene la ejecución del método si la validación falla.
            }

            // --- ALMACENAMIENTO DE DATOS ---
            // Agrega el tipo de material seleccionado a la lista 'tiposMateriales'.
            // La List<T> actúa como un array dinámico que crece según se añaden elementos.
            tiposMateriales.Add(cmbTipoMaterial.SelectedItem.ToString());

            // Agrega la cantidad a la lista 'cantidades'.
            cantidades.Add(cantidad);

            // --- FEEDBACK AL USUARIO Y PREPARACIÓN PARA NUEVA ENTRADA ---
            // Muestra un mensaje de confirmación al usuario (equivalente a Console.WriteLine).
            // Se utiliza '.Last()' para mostrar el último elemento agregado, que es el actual.
            MessageBox.Show($"Material registrado:\nTipo: {tiposMateriales.Last()}\nCantidad: {cantidades.Last()} kg",
                            "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpia el campo de cantidad y coloca el foco para facilitar la siguiente entrada.
            nudCantidad.Value = 0;
            cmbTipoMaterial.Focus(); // Coloca el foco en la ComboBox para la siguiente selección.
        }

        /// <summary>
        /// Método btnFinalizar_Click: Se ejecuta al hacer clic en el botón "Finalizar Captura...".
        /// Por ahora, solo muestra un mensaje informativo, ya que la lógica completa de finalización
        /// y apertura del inventario es responsabilidad de otro miembro del equipo.
        /// </summary>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta función será implementada por el equipo pronto", "Función en Desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}