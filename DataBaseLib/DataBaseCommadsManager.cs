using DataBaseLib.Access;
using DataBaseLib.Commands;
using System.Data;

namespace DataBaseLib;

/// <summary>
/// Выполнение команд пользователя
/// </summary>
public class DataBaseCommadsManager
{


    public DataTable GetDataTable(string tableName)
    {
        BaseCommands command = new BaseCommands();
        return command.GetDataTable(tableName);
    }

    public void Insert(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "ID Категории":
                command = new Table1Commands();
                break;
            case "ID Мастера":
                command = new Table2Commands();
                break;
            case "ID Услуги":
                command = new Table3Commands();
                break;
            case "ID Клиента":
                command = new Table4Commands();
                break;
            case "Запись на посещение":
                command = new Table5Commands();
                break;

            default:
                command = new Table1Commands();
                break;
        }
        command.Insert(args);
    }
    public void Delete(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "ID Категории":
                command = new Table1Commands();
                break;
            case "ID Мастера":
                command = new Table2Commands();
                break;
            case "ID Услуги":
                command = new Table3Commands();
                break;
            case "ID Клиента":
                command = new Table4Commands();
                break;
            case "Запись на посещение":
                command = new Table5Commands();
                break;

            default:
                command = new Table1Commands();
                break;
        }
        command.Delete(args);

    }
    public void Update(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "ID Категории":
                command = new Table1Commands();
                break;
            case "ID Мастера":
                command = new Table2Commands();
                break;
            case "ID Услуги":
                command = new Table3Commands();
                break;
            case "ID Клиента":
                command = new Table4Commands();
                break;
            case "Запись на посещение":
                command = new Table5Commands();
                break;
            default:
                command = new Table1Commands();
                break;
        }
        command.Update(args);

        // Домашнее задание
        // 1. Дописать логику методов Update, Delete
        // 2. Продумать структуру БД по вариантам
        // 3. Использовать Access или SQLite

    }
}
