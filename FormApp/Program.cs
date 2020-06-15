using System;
using CSharpExtendedCommands.Data;
using CSharpExtendedCommands;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using FormApp.Dialogs;

namespace FormApp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Main());
        }
    }
}
