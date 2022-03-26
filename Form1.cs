using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace MouseMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Opacity = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MoveMouseLong(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
        }
       
        private bool CursorChange()//проверка на изменение курсора (рука)
        {
            return this.Cursor == Cursors.Hand;
            
        }
        private void SetAndClick(int x,int y)//постановка и нажатие курсором
        {
            SetCursorPos(x, y + 75);
            while (CursorChange() == false)
            {
                Thread.Sleep(100);
            }
            ClickMouse();
        }
        private void MoveUnderGround(int x,int y) //прохождение 1 боя
        {
            SetCursorPos(x, y + 75);
            Thread.Sleep(200);
            ClickMouse();

        } 

        private void MoveMouseLong(int screenWidth, int screenHeight)
        {
            POINT p = new POINT();            
            int c = 0;
            SetCursorPos(409, 1045);//MW
            Thread.Sleep(200);
            ClickMouse();
            while (true)
            {

                SetCursorPos(796, 482 + 75);//1
                Thread.Sleep(200);

                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();              
                Thread.Sleep(2400);

                SetCursorPos(968, 480 + 75);//2
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);


                SetCursorPos(780, 490 + 75);//3
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);


                SetCursorPos(991, 493 + 75);//4
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);


                SetCursorPos(796, 482 + 75);//5
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);


                SetCursorPos(1029, 479 + 75);//6
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);


                SetCursorPos(848, 483 + 75);//7
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);


                SetCursorPos(1016, 483 + 75);//8
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);


                SetCursorPos(839, 493 + 75);//9
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);


                SetCursorPos(1012, 471 + 75);//10
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);





                SetCursorPos(792, 498 + 75);//11
                Thread.Sleep(200);

                ClickMouse();
                SetCursorPos(989, 511 + 75);
                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(2400);

                SetCursorPos(1002, 493 + 75);//12
                Thread.Sleep(200);
                ClickMouse();
                SetCursorPos(989, 511 + 75);


                Thread.Sleep(600);
                SetCursorPos(986, 483 + 75);//back
                Thread.Sleep(400);
                ClickMouse();
                Thread.Sleep(4800);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                ClickMouse();
                Thread.Sleep(4200);

                SendKeys.SendWait("{ENTER}");

                Thread.Sleep(4200);
                SendKeys.SendWait("{ENTER}");
                SetCursorPos(968, 471 + 75);//new

                Thread.Sleep(1000);
                ClickMouse();
                SetCursorPos(958, 555 + 75);//new
                Thread.Sleep(1000);
                ClickMouse();




                c++;
                Thread.Sleep(4000);
                if (c == 10)
                {
                    break;
                }
            }


        }


        private void ClickMouse()
        {
            int c = 0;
            POINT p=new POINT();
            GetCursorPos(ref p);
            ClientToScreen(Handle, ref p);
            DoMouseLeftClick(p.x, p.y);
          
        }
        [DllImport("user32.dll")]
        public static extern long SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;   
            public int y;
        }
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dsflag, int dx, int dy, int cButtons, int dsExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        private void DoMouseLeftClick(int x,int y)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }
        private void DoMouseRightClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref POINT lpPoint);


    }
}
