using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_Задание_4
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        private static void ShowLoginForm(ApplicationContext context)
        {
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, e) =>
            {
                // Если закрыта форма входа и нет других открытых форм - завершаем приложение
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
            };

            context.MainForm = loginForm;
            loginForm.Show();
        }
    }
}
