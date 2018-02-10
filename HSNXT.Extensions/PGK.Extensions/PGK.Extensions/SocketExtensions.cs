using System.Net.Sockets;

namespace HSNXT
{
    public static partial class Extensions
    {
        public static bool IsConnected(this Socket socket)
        {
            var part1 = socket.Poll(1000, SelectMode.SelectRead);
            var part2 = (socket.Available == 0);

            return part1 & part2;
        }
    }
}