using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace cliente___final_de_progra3
{
    class Cliente
    {
        static Cliente instancia;
        private Cliente()
        {
        }

        public static Cliente getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Cliente();
            }
            return instancia;
        }
        public double Lista(String nombre, string apellido, int edad)
        {
            string cadena = nombre.ToString() + "," + apellido.ToString() + "," + edad.ToString();  

            byte[] bytes = new byte[1024];
            
            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];

                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);

                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
  
                try
                {
                    sender.Connect(remoteEP);

                    sender.RemoteEndPoint.ToString();

                    byte[] msg = Encoding.ASCII.GetBytes(cadena);

                    int bytesSent = sender.Send(msg);
  
                    int bytesRec = sender.Receive(bytes);
                    string respuesta = (Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                    return double.Parse(respuesta);
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return 0;
        }

        internal string Lista(string nombre, string apellido, Sexo sexoo, int edad)
        {
            throw new NotImplementedException();
        }
    }
}
