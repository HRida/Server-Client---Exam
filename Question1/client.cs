using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Question1
{
    public partial class client : Form
    {
        private NetworkStream output;
        private BinaryWriter writer;
        private BinaryReader reader;

        private string message = "";

        private Thread readThread;

        public client()
        {
            InitializeComponent();
            
        }
        int portNum = 0;
        bool found = false;

        public void RunClient()
        {
            TcpClient client;

            // instantiate TcpClient for sending data to server
            try
            {
                if (portNb.Text.Length != 0)
                    portNum = Convert.ToInt16(portNb.Text);
                else portNum = 0;

                // Step 1: create TcpClient and connect to server
                client = new TcpClient();
                client.Connect("localhost", portNum);

                // Step 2: get NetworkStream associated with TcpClient
                output = client.GetStream();

                // create objects for writing and reading across stream
                writer = new BinaryWriter(output);
                reader = new BinaryReader(output);

                MessageBox.Show("Plz enter a userName to check it");

                Action update;
                
                update = () => cnxPanel.Enabled = false;
                cnxPanel.Invoke(update);

                update = () => userPassPanel.Enabled = true;
                userPassPanel.Invoke(update);
               

                // loop until server signals termination
                do
                {

                    // Step 3: processing phase
                    try
                    {
                        // read message from server
                        message = reader.ReadString();

                        if (message.Equals("confirmedName"))
                        {
                            update = () => passwrd.Enabled = true;
                            passwrd.Invoke(update);

                            update = () => userName.Enabled = false;
                            userName.Invoke(update);

                            MessageBox.Show("Enter Password Plz..");
                        }

                        if (message.Equals("confirmedPass"))
                        {
                            MessageBox.Show("UserName and Pass confirmed");
                            found = true;
                            Thread.Sleep(9000);
                            break;
                        }
                    }

                       // handle exception if error in reading server data
                    catch (Exception)
                    {
                        //System.Environment.Exit(
                        //   System.Environment.ExitCode);
                    }
                } while (!found);


                // Step 4: close connection
                writer.Close();
                reader.Close();
                output.Close();
                client.Close();
                this.Close();
            }

               // handle exception if error in establishing connection
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void sendPort_Click(object sender, EventArgs e)
        {
            readThread = new Thread(new ThreadStart(RunClient));
            readThread.Start();
        }

        private void sendUser_Click(object sender, EventArgs e)
        {
            try
            {
                writer.Write("user" + userName.Text);
            }
            catch (Exception w)
            {
                MessageBox.Show("Plz enter a userName to be checked");
            }
        }

        private void sendPass_Click(object sender, EventArgs e)
        {
           
            try
            {
                writer.Write("pass" + passwrd.Text);
            }
            catch (Exception w)
            {
                MessageBox.Show("Plz enter a userName to be checked");
            }
        }

       
    }
}
