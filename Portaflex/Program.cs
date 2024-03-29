﻿using System;
using System.Windows.Forms;

namespace Portaflex
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(args));
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var ex = (Exception) e.ExceptionObject;

                MessageBox.Show("Prosím kontaktujte vývojáře "
                                + "s následující informací:\n\n" + ex.Message + ex.StackTrace,
                    "Kritická chyba", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                Application.Exit();
            }
        }

        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            var result = DialogResult.Abort;
            try
            {
                result = MessageBox.Show("Prosím kontaktujte vývojáře "
                                         + "s následující informací:\n\n" + e.Exception.Message
                                         + e.Exception.StackTrace, "Chyba aplikace",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
            finally
            {
                if (result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }
    }
}