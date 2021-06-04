using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duloveme.Calculator
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "처리되지 않은 예외 발생");
            }
        }
    }
}
