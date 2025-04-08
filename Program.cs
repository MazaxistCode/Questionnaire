using Microsoft.EntityFrameworkCore;
using Questionnaire;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using Questionnaire.Forms;

namespace Questionnaire
{
    /// <summary>
    /// Класс запуска программы
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  Метод запуска программы
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Task.Run(() => { Application.Run(new Test() { Location = new(-10, 700)});});
            Application.Run(new LogInForm());
        }
    }
}