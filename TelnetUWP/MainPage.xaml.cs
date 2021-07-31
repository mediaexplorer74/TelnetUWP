using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MinimalisticTelnet;
using System.Threading.Tasks;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace TelnetUWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        TelnetConnection tc;

        // constructor
        public MainPage()
        {
            this.InitializeComponent();

        }

        // "Concole output emulation" =)
        void SuperWriteLine(string onestring)
        {

            ResponseBox.Items.Add(onestring);
        }

        // ******************** Preparation ***********************

        // Connect 
        private void Connect()
        {
            // clear "terminal" 
            ResponseBox.Items.Clear();


            // try to connect...
            string IP = TelnetIP.Text;
            int Port = Int32.Parse(TelnetPort.Text);

            //todo: create a new telnet connection to hostname "127.0.0.1" on port "23"

            //tc = new TelnetConnection("192.168.1.33", 23);
            tc = new TelnetConnection(IP, Port);

            // DELAY
            // REDO! Risk of contionous loop!
            long i = 0;

            while (tc.IsConnected == false && i < 1000000)
            {
                i++; // a little deal ;)

                ResponseBox.Items.Clear();
                //SuperWriteLine(".");
            }

            //Task.Delay(1000);


            // check connection
            if (tc.IsConnected)
            {
                tc.WriteLine("Connected!");
                SuperWriteLine("Connected!");
            }
            else
            {
                tc.WriteLine("No connection!");
                SuperWriteLine("No connection!");
                return;
            }
        }//Connect end




        // SendCommand 
        private void SendCommand()
        {
            if (tc == null) return;

            // Clear "terminal"
            ResponseBox.Items.Clear();



            

            // A. Send Telnet Command 
            if (tc.IsConnected)
            {

                //SuperWriteLine("xapinst \\data\\users\\public\\pictures\\bb.xap 0");
                //tc.WriteLine("xapinst \\data\\users\\public\\XAPs\\bb.xap 0\r\n");

                SuperWriteLine(TelnetCommand.Text);
                tc.WriteLine(TelnetCommand.Text + "\n");
            }
            else
            {
                tc.WriteLine("No connection!");
                SuperWriteLine("No connection!");
                return;
            }


            // DELAY
            
            long i = 0;
            while (i < 5000)
            {
                i++; // a little deal ;)

                ResponseBox.Items.Clear();
                //SuperWriteLine(".");
            }

            //Task.Delay(1000);

            


            // B. Get Telnet command
            string s = tc.Read();

            SuperWriteLine("Readed data: " + s.Substring(0, min(s.Length,10000)));
            
            //DIAG
            SuperWriteLine("***DISCONNECTED"); 

        }//SendCommand end

        private int min(int length, int v)
        {
            int minvalue;
            if (length > v)
            {
                minvalue = v;
            }
            else
            {
                minvalue = length;
            }

            return minvalue;
        }


        // ******************** Realization ***********************

        // Redo: StartConnect
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            Connect();

        }// OpenButton_Click end




        // Redo: Send cmd
        private void StartDeploy_Click(object sender, RoutedEventArgs e)
        {

            Connect();


            SendCommand();
            

            //int r = tc.CloseConnection();
            
        }//StartDeploy_Click end


       

        
    }// MainPage class end

}// TcpIp namespace end
