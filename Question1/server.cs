using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;   



namespace Question1
{
    public partial class server : Form
    {
        private NetworkStream socketStream;
        private BinaryWriter writer;
        private BinaryReader reader;
        private Socket connection;
        private Thread readThread;
        public server()
        {
            InitializeComponent();
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();
        }

        string [] passwrd = { "jG43tYqL" ,  " 9fB6RK87" , "Vuj75Po9" , "2SWn9C7v", "Jc6Nf3me", "r7h9CX6q", "p8Bnc5Gt"};
        string[] userName = { "alice", "beverly", "caroline", "duncan", "esther", "frank", "george" };

        int index = 0;
        int portNb;
       

        public void RunServer()
        {
            TcpListener listener;
            int counter = 1;

            // wait for a client connection and display the text
            // that the client sends
            try
            {
                // Step 1: create TcpListener

                if (portNum.Text.Length != 0)
                    portNb = Convert.ToInt16(portNum.Text);
                else portNb = 0;


                listener = new TcpListener(portNb);

                // Step 2: TcpListener waits for connection request
                listener.Start();

                // Step 3: establish connection upon client request
                while (true)
                {
                    // accept an incoming connection
                    connection = listener.AcceptSocket();

                    // create NetworkStream object associated with socket
                    socketStream = new NetworkStream(connection);

                    // create objects for transferring data across stream
                    writer = new BinaryWriter(socketStream);
                    reader = new BinaryReader(socketStream);


                    string msg = "";

                    // Step 4: read String data sent from client
                    do
                    {
                        try
                        {
                            // read the string sent to the server
                            msg = reader.ReadString();

                            //read userName and check it
                            if (msg.Substring(0, 4).Equals("user"))
                            {
                                index = 0;
                                MessageBox.Show("UserName Received");
                                foreach (string name in userName)
                                {
                                    index++;
                                    if (msg.Substring(4).Equals(name))
                                    {
                                        MessageBox.Show("UserName found..Plz send in password");
                                        writer.Write("confirmedName");
                                        break;
                                    }
                                }

                            }

                            if (msg.Substring(0, 4).Equals("pass"))
                            {
                                if (msg.Substring(4).Equals(passwrd[index - 1]))
                                {
                                    writer.Write("confirmedPass");
                                   
                                }
                                else writer.Write("Password Wrong");
                            }

                           
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    

                    } while (connection.Connected);



                    // Step 5: close connection
                    writer.Close();
                    reader.Close();
                    socketStream.Close();
                    connection.Close();
                    Application.Exit();

                }
            } // end try

            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void sendPortNb_Click(object sender, EventArgs e)
        {
            client c = new client();
            c.Show();
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();
        }
    }
}
