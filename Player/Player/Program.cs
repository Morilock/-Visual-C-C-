using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Threading;


namespace Player
{
    static class Program
    {
        /*显示已经运行程序的主界面*/
        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        static extern bool ShowWindow(IntPtr handle, int flags);    //显示窗口
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        static extern bool SetForegroundWindow(IntPtr handle);     //将窗口置最前

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isCreated; 								//互斥体名称须唯一
            using (Mutex newMutex = new Mutex(true, @"Local\Player", out isCreated))
            {
                if (isCreated)
                {
                    Application.EnableVisualStyles();			//为应用程序启用可视样式
                    /*获得应用程序数据的注册表项*/
                    using (RegistryKey subKey = Application.UserAppDataRegistry)
                    {
                        Form1 form1 = new Form1();
                        subKey.SetValue("MyHandle", form1.Handle);
                        Application.Run(form1);
                    }
                    newMutex.ReleaseMutex();    			//释放互斥体的所属权
                }
                else
                {
                    string text = string.Format("“{0}”应用程序已经运行。",
                    AppDomain.CurrentDomain.FriendlyName);
                    MessageBox.Show(text, "系统提示！", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    using (RegistryKey subKey = Application.UserAppDataRegistry)
                    {
                        /* IntPtr类型称为“平台特定的整数类型”，用于本机资源，这里为窗口句柄*/
                        IntPtr handle = new IntPtr(Convert.ToInt32(subKey.GetValue("MyHandle")));
                        ShowWindow(handle, 1);         	//显示窗口
                        SetForegroundWindow(handle);   	//将窗口置最前
                    }
                }
            }
        }
    }
}
