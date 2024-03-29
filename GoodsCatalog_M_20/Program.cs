﻿/*
-----------------------------------------------------------
Ваше завдання - спробуйте додати до адмінки фільтри для 
виборки товарів за виробником та за ціною. Схему реализації
можете обрати або винайти самостійно. Креатив буде плюсом!
-----------------------------------------------------------
Успішного виконання!
*/

/*
-------------------------------------------------------------
Для действующей версии проекта "Goods Catalog" разработайте 
функционал системы регистрации пользователей. Результат нужно
опубликовать на GitHub.
-------------------------------------------------------------
Успешного решения!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsCatalog_M_20
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
