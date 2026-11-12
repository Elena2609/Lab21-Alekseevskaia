//2. Список и массив
List<string> tasks = new List<string> { "Код", "Тест", "Код" };
Console.WriteLine(tasks.Count);

//3. Добавление и вставка
tasks.Add("Отчёт");
Console.WriteLine(tasks.Count);
tasks.Insert(1, "План");

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

//Найдите ошибку: добавление по индексу
// List<string> emptyTasks = new List<string>();
// emptyTasks.Add("Код");
// Console.WriteLine(emptyTasks.Count);
// Console.WriteLine(emptyTasks[0]);

//4. Индексы, изменение и вывод списка
void PrintTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }
    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]}");
    }
}
PrintTasks(tasks);

//5. Удаление элементов
List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };

bool removed = removedTasks.Remove("Код");
Console.WriteLine(removed);
PrintTasks(removedTasks);

Console.WriteLine(removedTasks.Remove("Экзамен"));
Console.WriteLine(removedTasks.Count);

//Удаление по индексу — RemoveAt()
removedTasks.RemoveAt(1);
PrintTasks(removedTasks);

bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }
    tasks.RemoveAt(index);
    return true;
}

//Найдите ошибку: значение или индекс
// List<int> scores = new List<int> { 10, 20, 30 };
// scores.RemoveAt(1);
// Console.WriteLine(scores.Count);
// foreach (int i in scores)
// {
//     Console.WriteLine(i);
// }


//6. Поиск элементов
List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" }; 

Console.WriteLine(searchableTasks.Contains("Код"));
Console.WriteLine(searchableTasks.Contains("План"));
Console.WriteLine(searchableTasks.IndexOf("Код"));
Console.WriteLine(searchableTasks.IndexOf("План"));

//Найдите ошибку: индекс ноль
int index = searchableTasks.IndexOf("План");
if (index >= 0)
{
 Console.WriteLine($"Первый индекс: {index}");
}
else
{
 Console.WriteLine("Задача не найдена");
}
