using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegaChat.MVVM.Infrastructure.Commands;
using TelegaChat.Net;

namespace TelegaChat.MVVM.ViewModels
{
    internal class MainViewModel
    {
        public LambdaCommand ConnectToServerCommand { get; set; }

        private Server _server;
        public MainViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new LambdaCommand(o => _server.ConnectToServer());
        }
    }
}
