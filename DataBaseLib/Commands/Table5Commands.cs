using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table5Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Запись на посещение] " +
                    $"([Код], [ID клиента], [ID категории], [ID услуги], [ID мастера], [Дата записи], [Время записи] ) " +
                    $"VALUES ({args[0]},{args[1]}, {args[2]}, {args[3]}, {args[4]}, '{args[5]}', '{args[6]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Запись на посещение]
                    SET [ID клиента] = {args[1]}, [ID категории] = {args[2]}, [ID услуги] = {args[3]}, [ID мастера] = {args[4]}, [Дата записи] = {args[5]}, [Время записи] = {args[6]};
                    WHERE [Код] = {args[0]}";


            controller.ExecuteCommand(query);
            /*
             string query = $"UPDATE [Категории] SET [Категория товара] = '{type}', " +
                    $"[Скидка %] = {discount} " +
                    $"WHERE [ID] = {id}"; 
             */
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Запись на посещение] " +
                    $"WHERE [Код] = {args[0]}";
            controller.ExecuteCommand(query);
            /*
             string query = $"DELETE FROM [Категории] " +
                    $"WHERE [ID] = {id}";
             */
        }


    }
}

