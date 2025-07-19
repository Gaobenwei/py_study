using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_test
{
    class InputThread
    {
        private static InputThread instance = new InputThread();
        public static InputThread Instance
        {
            get 
            {
                return instance;
            }
        }

        //线程监听输入
        Thread inputThread;
        private InputThread()
        {
            inputThread = new Thread(InputCheck);
            inputThread.IsBackground = true;
            inputThread.Start();
        }

        private void InputCheck() 
        {
            while(true)
            {
                inputEvent?.Invoke();
            }
        }

        public event Action inputEvent;
    }
}
