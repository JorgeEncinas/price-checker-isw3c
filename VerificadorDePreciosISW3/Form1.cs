using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VerificadorDePreciosISW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string currentState;
        private string productCode;
        private int waitSeconds;
        private int elapsedSeconds;
        //private Dictionary<string, Func<bool>> stateDict = new Dictionary<string, Func<bool>>();
        private Dictionary<string, Action> stateDict = new Dictionary<string, Action>();

        /*States:
            Start State or Waiting State
            Loading State
            SuccessfulRetrieval State
            ReadError State
            404Error State
        */

        private void setElementSettings()
        {
            ///<summary>Sets the initial element settings</summary>

            //MessageBox.Show("This Form" + Environment.NewLine +
            //    "Width: " + this.Width + Environment.NewLine +
            //    "Height: " + this.Height);

            centerElementAtY(pbLoading, 0.50);
            pbLogo.Size = new Size(
                Convert.ToInt32(this.Width * 0.30),
                Convert.ToInt32(this.Height * 0.10));
            pbLogo.Location = new Point(
                Convert.ToInt32((this.Width - pbLogo.Width - 20)),
                20);
            pbResult.Height = Convert.ToInt32(this.Height / 2.50);
            pbResult.Width = Convert.ToInt32(this.Width / 3.25);
            pbResult.Location = new Point(
                40,
                Convert.ToInt32((this.Height * 0.50) - (pbResult.Height / 2)));
            labelContent.Width = Convert.ToInt32(this.Width * 0.50);
            labelContent.Height = Convert.ToInt32(this.Height * 0.30);
            labelContent.Location = new Point(
                Convert.ToInt32(this.Width * 0.40),
                Convert.ToInt32(this.Height * 0.30));
            labelContent.MaximumSize = new Size(
                Convert.ToInt32(this.Width * 0.60),
                Convert.ToInt32(this.Height * 0.60));
            labelProductName.MaximumSize = new Size(
                Convert.ToInt32(this.Width * 0.80),
                Convert.ToInt32(this.Height * 0.10));
            labelProductName.Location = new Point(40,
                Convert.ToInt32(this.Height * 0.15));
            pbScanAtBottom.Location = new Point(
                20,
                Convert.ToInt32(this.Height - pbScanAtBottom.Height - 20));
            labelBottomInstruction.Font = new Font("Microsoft sans serif", 24, FontStyle.Regular);
            labelBottomInstruction.Location = new Point(
                Convert.ToInt32(20 + pbScanAtBottom.Width + 20),
                Convert.ToInt32((this.Height * 0.9) - (pbScanAtBottom.Height / 2)));
            pbServicio.Height = pbScan.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// Starts the variables, the state dictionary, and sets startState

            productCode = "";
            waitSeconds = 180;
            elapsedSeconds = 0;
            setElementSettings();
            stateDict.Add("start", startState); //Default state
            stateDict.Add("loading", loadingState);
            stateDict.Add("retrieved", retrievedState); //Success retrieving data
            stateDict.Add("readError", readErrorState); //Error while reading
            stateDict.Add("notFoundError", notFoundErrorState); //Product Not Found
            currentState = "start";
            setState(currentState);
        }

        private void setState(string state)
        {
            ///<summary>Receives a string <c>state</c>, to get the State's Function (an <c>Action</c>)
            ///from the dictionary.</summary>

            //receive input with Action<string>, then Invoke(string)
            clean();
            stateDict[state].Invoke();
        }

        private void clean()
        {
            /// <summary>Removes everything a state has displayed.</summary>
            /// 
            pbResult.Visible = false;
            pbScan.Visible = false;
            pbScanAtBottom.Visible = false;
            pbLoading.Visible = false;
            pbServicio.Visible = false;
            labelBottomInstruction.Visible = false;
            labelMainInstruction.Visible = false;
            labelSecondaryInstruction.Visible = false;
            labelContent.Visible = false;
            labelProductName.Visible = false;
            elapsedSeconds = 0;
            timerToStartState.Enabled = false;
        }

        private void centerElementAtY(Control formElement, double heightPercent)
        {
            /// <summary> method <c>centerElementAtY</c> Centers an element horizontally
            /// and sets it at the vertical percentage it receives.</summary>
            /// <param name="formElement">The Control Element from the form</param>
            /// <param name="heightPercent"> The y-coordinate expressed as a percentage.</param>
            /// <remarks>Pass the percentage as a decimal value</remarks>
            /// <example> For example:
            /// <code> centerElementAtY(label1, 0.60);</code>
            /// </example>
            formElement.Location = new Point(
                Convert.ToInt32((this.Width/2) - (formElement.Width/2)),
                Convert.ToInt32((this.Height * heightPercent) - (formElement.Height/2)));
        }

        private void startState()
        {
            ///<summary> Action <c>startState</c> Sets the starting disposition of elements</summary>
            labelMainInstruction.Text = "¿Desea obtener más información del producto?";
            labelSecondaryInstruction.Text = "Coloque el código de barras del producto frente al lector";
            centerElementAtY(labelMainInstruction, 0.30);
            centerElementAtY(labelSecondaryInstruction, 0.70);
            centerElementAtY(pbScan, 0.50);
            pbScan.Visible = true;
            labelMainInstruction.Visible = true;
            labelSecondaryInstruction.Visible = true;
        }
        private void loadingState()
        {
            labelMainInstruction.Text = "Cargando...";
            centerElementAtY(labelMainInstruction, 0.30);
            labelMainInstruction.Visible = true;
            pbLoading.Visible = true;
        }
        private void retrievedState()
        {
            labelProductName.Visible = true;
            pbResult.Visible = true;
            labelContent.Visible = true;
            labelBottomInstruction.Visible = true;
            pbScanAtBottom.Visible = true;
            //MessageBox.Show("pbResult" + Environment.NewLine +
            //                "Width: " + pbResult.Width + Environment.NewLine +
            //                "Height: " + pbResult.Height);

            waitSeconds = 20; //Test number
            elapsedSeconds = 0; //Necessary if another product is read.
            timerToStartState.Enabled = true;
        }
        private void readErrorState()
        {
            labelMainInstruction.Text = "¡Lo sentimos!" + Environment.NewLine +
                "Ha ocurrido un error al leer el código de barras.";
            labelSecondaryInstruction.Text = "Intente pasar el código de nuevo, o" + Environment.NewLine +
                "Pase a Servicio al Cliente," + Environment.NewLine +
                "¡Con gusto le atenderemos!";
            centerElementAtY(labelMainInstruction, 0.25);
            centerElementAtY(labelSecondaryInstruction, 0.75);
            pbServicio.Location = new Point(
                Convert.ToInt32((this.Width / 2) + 20),
                Convert.ToInt32((this.Height/2) - (pbServicio.Height/2)));
            pbScan.Location = new Point(
                Convert.ToInt32((this.Width / 2) - pbScan.Width - 10),
                Convert.ToInt32((this.Height / 2) - (pbScan.Height / 2)));
            labelMainInstruction.Visible = true;
            labelSecondaryInstruction.Visible = true;
            pbServicio.Visible = true;
            pbScan.Visible = true;

            waitSeconds = 10; //Test number
            elapsedSeconds = 0;
            timerToStartState.Enabled = true;
        }
        private void notFoundErrorState()
        {
            labelMainInstruction.Text = "¡Lo sentimos!" + Environment.NewLine +
                "No se ha encontrado el producto leído";
            labelSecondaryInstruction.Text = "Pase a Servicio al Cliente," + Environment.NewLine +
                "¡Con gusto le atenderemos!";
            centerElementAtY(labelMainInstruction, 0.30);
            centerElementAtY(labelSecondaryInstruction, 0.70);
            centerElementAtY(pbServicio, 0.50);
            labelMainInstruction.Visible = true;
            labelSecondaryInstruction.Visible = true;
            pbServicio.Visible = true;
            pbScanAtBottom.Visible = true;
            labelBottomInstruction.Visible = true;

            waitSeconds = 10; //Test number
            elapsedSeconds = 0;
            timerToStartState.Enabled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// <summary>Chains the user's key presses and searches the resulting
            /// key in the database, changing state accordingly. </summary>
            if(e.KeyChar == 13)
            {
                setState("loading");
                try
                {
                    MySqlConnection connObject;
                    connObject = new MySqlConnection(
                        "server=127.0.0.1; " +
                        "user=root; " +
                        "database=verpres3; " +
                        "SSL Mode=None;");
                    connObject.Open();
                    string query = "SELECT clave, nombre, existencias, precio, rutaimg " +
                                   " FROM productos " +
                                   " WHERE clave = " + productCode;
                    MySqlCommand command = new MySqlCommand(query, connObject);
                    MySqlDataReader result = command.ExecuteReader();
                    if (result.HasRows)
                    {
                        result.Read();
                        labelProductName.Text = result.GetString(1);
                        pbResult.Load(result.GetString(4));
                        labelContent.Text = "$" + result.GetString(3) + Environment.NewLine + Environment.NewLine +
                            result.GetString(2) + " restantes en sucursal" + Environment.NewLine + Environment.NewLine +
                            "De momento, los productos no tienen descripción. Gracias por su preferencia.";
                        setState("retrieved");
                    }
                    else
                    {
                        setState("notFoundError");
                    }
                }
                catch (Exception ex)
                {
                    setState("readError");
                }
                productCode = "";
            }
            else
            {
                productCode += e.KeyChar;
            }
        }

        private void timerToStartState_Tick(object sender, EventArgs e)
        {
            ///<summary>Counts up to a number of seconds set by a state, then
            /// sets the Start State</summary>
            elapsedSeconds++;
            if(elapsedSeconds == waitSeconds)
            {
                timerToStartState.Enabled = false;
                elapsedSeconds = 0;
                setState("start");
            }
        }
    }
}
