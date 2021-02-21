using CSharpExtendedCommands;
using System;
using System.Windows.Forms;

namespace FormApp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var nums = Maths.MMC(361);

            foreach (var n in nums)
                Console.WriteLine(n);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}
