using System.Net;
using System.Net.Sockets;
namespace ChatSimple
{
    public partial class Form1 : Form
    {
        private TcpClient cliente;
        private StreamReader reader;
        private StreamWriter writer;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta aplicación es el servidor'", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (respuesta == DialogResult.Yes)
                {
                    int port = int.Parse(txtPuerto.Text);
                    TcpListener server = new TcpListener(IPAddress.Any, port);
                    server.Start();
                    // Esperar a que un cliente se conecte de manera asincrona
                    cliente = await server.AcceptTcpClientAsync();
                    rtbHistorial.AppendText("Cliente conectado!\n");
                    // funcion que obtenga los datos entrantes 

                }
            }
            catch (Exception ex)
            {


            }
        }

        private void ConfigurarStream()
        {
            NetworkStream stream = cliente.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream) { AutoFlush = true }; // Para que se envíen los mensajes inmediatamente
        }

        private async Task RecibirMensajes()
        {
            try
            {
                while (cliente != null && cliente.Connected)
                {
                    string mensajeRecibido = await reader.ReadLineAsync();
                    if (mensajeRecibido != null)
                    {
                        rtbHistorial.Invoke((MethodInvoker)delegate// manda la info al otro hilo, mantiene la comunicacion entre ambos hilos
                        {
                            rtbHistorial.AppendText("Extraño: " + mensajeRecibido + "\n");


                        });
                    }
                }
            }
            catch(Exception ex)
            {
                rtbHistorial.Invoke((MethodInvoker)delegate
                {
                    rtbHistorial.AppendText("Cliente Desconectado: \n " );


                });

            }


        }

    }

}
