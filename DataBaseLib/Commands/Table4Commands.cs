using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table4Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [ID Клиента ] " +
                    $"([Фамилия], [Имя], [Отчество], [Телефон]) " +
                    $"VALUES ('{args[1]}', '{args[2]}', '{args[3]}', {args[4]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [ID Клиента]
                    SET [Фамилия] = {args[1]}, [Имя] = {args[2]}, [Отчество] = {args[3]}, [Телефон] = {args[4]};
                    WHERE [ID Клиента] = {args[0]}";


            controller.ExecuteCommand(query);
            /*
             string query = $"UPDATE [Категории] SET [Категория товара] = '{type}', " +
                    $"[Скидка %] = {discount} " +
                    $"WHERE [ID] = {id}"; 
             */
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [ID Клиента] " +
                    $"WHERE [ID Клиента] = {args[0]}";
            controller.ExecuteCommand(query);
            /*
             string query = $"DELETE FROM [Категории] " +
                    $"WHERE [ID] = {id}";
             */
        }


    }
}

