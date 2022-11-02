using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task184Youtube
{
    public interface ICommand
    {
        public void RunDownload(string videoUrl);
        public void Description(string videoUrl);
    }
}
