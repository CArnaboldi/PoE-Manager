using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoE_Manager
{
    public interface IStatus
    {
        void startApp();
        void stopApp();
        void destroy();
    }
}
