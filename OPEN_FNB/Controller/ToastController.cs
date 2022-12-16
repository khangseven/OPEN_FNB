using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace OPEN_FNB.Controller
{
    internal class ToastController
    {
        private static LinkedList<K7Controls.K7Toast> ToastList;

        private static int paddingX = 20, paddingY = 100, gap=10;

        private static bool isOn = true;

        public ToastController()
        {
            init();
        }

        static void init()
        {
            ToastList = new LinkedList<K7Controls.K7Toast>();
            Timer timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            update();
        }

        public static void addToast(int type, string mess)
        {
            if (!isOn) return;
            if(ToastList==null) init();
            if (ToastList.Count > 10)
            {
                ToastList.Last().forceToClose();
                ToastList.RemoveLast();
            }
            Point point = new Point(
                    (int)SystemParameters.PrimaryScreenWidth - 300 - paddingX,
                   (int)SystemParameters.PrimaryScreenHeight - 70 - paddingY
                );
            K7Controls.K7Toast toast = new K7Controls.K7Toast(type,mess,point);
            ToastList.AddFirst(toast);
            toast.Show();
        }

        public static void addSureToast(int type, string mess)
        {
            
            if (ToastList == null) init();
            if (ToastList.Count > 10)
            {
                ToastList.Last().forceToClose();
                ToastList.RemoveLast();
            }
            Point point = new Point(
                    (int)SystemParameters.PrimaryScreenWidth - 300 - paddingX,
                   (int)SystemParameters.PrimaryScreenHeight - 70 - paddingY
                );
            K7Controls.K7Toast toast = new K7Controls.K7Toast(type, mess, point);
            ToastList.AddFirst(toast);
            toast.Show();
        }

        public static void update()
        {
            int index = 1;
            
            for(int i = 0; i < ToastList.Count; i++)
            {
                if(!ToastList.ElementAt(i).Complete)
                {
                    ToastList.ElementAt(i).setDestinyHeight((int)System.Windows.SystemParameters.PrimaryScreenHeight - index * 70 - paddingY - gap * index);
                    index++;
                }
                else
                {
                    ToastList.Remove(ToastList.ElementAt(i));
                }
                    
            }
        }

        public static void On()
        {
            isOn = true;
        }

        public static void Off()
        {
            isOn=false;
        }
    }
}
