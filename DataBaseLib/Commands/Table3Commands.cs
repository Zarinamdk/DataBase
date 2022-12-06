using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table3Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [ID Услуги ] " +
                    $"([Услуга], [Категория], [Цена]) " +
                    $"VALUES ('{args[1]}', {args[2]}, {args[3]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [ID Услуги]
                    SET [Услуга] = {args[1]}, [Категория] = {args[2]}, [Цена] = {args[3]};
                    WHERE [ID Услуги] = {args[0]}";


            controller.ExecuteCommand(query);
            /*
             string query = $"UPDATE [Категории] SET [Категория товара] = '{type}', " +
                    $"[Скидка %] = {discount} " +
                    $"WHERE [ID] = {id}"; 
             */
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [ID Услуги] " +
                    $"WHERE [ID Услуги] = {args[0]}";
            controller.ExecuteCommand(query);
            /*
             string query = $"DELETE FROM [Категории] " +
                    $"WHERE [ID] = {id}";
             */
        }


    }
}

