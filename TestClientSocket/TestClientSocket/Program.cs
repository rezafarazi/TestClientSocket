//libs
using System.Net;
using System.Net.Sockets;

//get start program
main();

//main function
void main() 
{

    Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
    socket.Connect(new IPEndPoint(IPAddress.Loopback,8082));

    socket.Send(System.Text.ASCIIEncoding.ASCII.GetBytes("Hello world"));

    socket.Close();


}