﻿using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table2Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [ID Мастера ] " +
                    $"([Фамилия], [Имя], [Отчество], [Возраст], [Категория] ) " +
                    $"VALUES ('{args[1]}', '{args[2]}', '{args[3]}', {args[4]}, {args[5]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [ID Мастера]
                    SET [Фамилия] = {args[1]}, [Имя] = {args [2]}, [Отчество] = {args [3]}, [Возраст] = {args [4]}, [Категория] = {args [5]};
                    WHERE [ID Мастера] = {args[0]}";
            

            controller.ExecuteCommand(query);
            /*
             string query = $"UPDATE [Категории] SET [Категория товара] = '{type}', " +
                    $"[Скидка %] = {discount} " +
                    $"WHERE [ID] = {id}"; 
             */
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [ID Мастера] " +
                    $"WHERE [ID Мастера] = {args[0]}";
            controller.ExecuteCommand(query);
            /*
             string query = $"DELETE FROM [Категории] " +
                    $"WHERE [ID] = {id}";
             */
        }


    }
}
