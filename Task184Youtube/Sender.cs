using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task184Youtube
{
    public class Sender
    {
        ICommand _command;
      public void SetCommand(ICommand command)
      {
            _command = command;
      }
      public void RunDownload(string videoUrl)
      {
            _command.RunDownload(videoUrl);
      }
        public void Description(string videoUrl)
        {
            _command.Description(videoUrl);
        }
    }
}
