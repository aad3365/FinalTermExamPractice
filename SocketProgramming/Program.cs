using SocketProgramming;

static void RunSocketTest()
{
    Task.Run(() =>
    {
        Server.start();
    });

    Thread.Sleep(1000);

    Client.start();
}