using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Terminal.Models.API.BillValidator
{
    public class InCommingSocket
    {
        public static ClientWebSocket BillValidatorSocket = new ClientWebSocket();

        public async void BillValidatorSocketRun()
        {
            
            BillValidatorSocket.Options.SetRequestHeader(nameof(Properties.Settings.Default.BillValidatorSecureKey),Properties.Settings.Default.BillValidatorSecureKey);
            try
            {
                await BillValidatorSocket.ConnectAsync(new Uri(Properties.Settings.Default.BillValidatorServerSocket), CancellationToken.None);
            }
            catch 
            {
            }
            while (!BillValidatorSocket.CloseStatus.HasValue)
            {
                byte[] buffer = new byte[1024 * 32];
                try
                {
                    WebSocketReceiveResult result = await BillValidatorSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (BillValidatorSocket != null)
                    {
                        Debug.WriteLine(Encoding.UTF8.GetString(buffer, 0, result.Count));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                    break;
                }
            }
            await Task.Delay(1000);
            BillValidatorSocketRun();
        }
    }
}
