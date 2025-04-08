using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.Forms
{
    /// <summary>
    /// Класс формы для ввода кода с почты
    /// </summary>
    public partial class EnterCodeForm : Form
    {
        /// <summary>
        /// Конструктор формы для ввода кода с почты
        /// </summary>
        public EnterCodeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка ввода кода с почты
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void codeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка ввода не нужной почты
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
