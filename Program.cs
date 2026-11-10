//2. Список и массив
List<string> tasks = new List<string> { "Код", "Тест", "Код" };
Console.WriteLine(tasks.Count);

//3. Добавление и вставка
tasks.Add("Отчёт");
Console.WriteLine(tasks.Count);

//Метод безопасной вставки
bool InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        return false;
    }
    tasks.Insert(index, title);
    return true;
}
