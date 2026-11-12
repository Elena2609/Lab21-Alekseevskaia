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



//Удаление по индексу — RemoveAt()
bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }
    tasks.RemoveAt(index);
    return true;
}


//8. Основная часть — «Список дел»
Console.Write("Сколько задач добавить сначала: ");
int count = Convert.ToInt32(Console.ReadLine());

List<string> tasks = new List<string>();

for (int i = 0; i < count; i++)
{
    Console.Write($"Задача {i + 1}: ");
    string title = Console.ReadLine() ?? "";
    tasks.Add(title);
}
// 1. Исходный список
PrintTasks(tasks);

// 2. Добавление в конец
Console.Write("Новая задача для добавления в конец: ");
string addTitle = Console.ReadLine();
tasks.Add(addTitle);
Console.WriteLine("Задача добавлена");

// 3. Вставка по индексу
Console.Write("Задача для вставки: ");
string insertTitle = Console.ReadLine();
Console.Write("Индекс для вставки: ");
int insertIndex = Convert.ToInt32(Console.ReadLine());

if (InsertTaskSafe(tasks, insertIndex, insertTitle)){
    Console.WriteLine("Задача вставлена");
} else {
    Console.WriteLine("Недопустимый индекс вставки");
}

// 4. Удаление по значению
Console.Write("Название для удаления: ");
string removeTitle = Console.ReadLine();

if (tasks.Remove(removeTitle)){
    Console.WriteLine("Первое совпадение удалено");
} else {
    Console.WriteLine("Задача не найдена ");
}

// 5. Удаление по индексу
Console.Write("Индекс для удаления: ");
int removeIndex = int.Parse(Console.ReadLine());

if (RemoveTaskAtSafe(tasks, removeIndex))
{
    Console.WriteLine("Задача по индексу удалена");
}
else
{
    Console.WriteLine("Недопустимый индекс удаления");
}

// 6. Поиск
Console.Write("Название для поиска: ");
string searchTitle = Console.ReadLine();
int foundIndex = tasks.IndexOf(searchTitle);

if (foundIndex != -1)
{
    Console.WriteLine($"Первый индекс: {foundIndex}");
}
else
{
    Console.WriteLine("Задача не найдена");
}

// 7. Итог
Console.WriteLine();
Console.WriteLine(">>> Итоговый список дел <<<");
Console.WriteLine();
Console.WriteLine($"Количество задач: {tasks.Count}");
PrintTasks(tasks);

//13. Самостоятельное задание
//Вариант 1. Количество совпадений
int CountTask(List<string> tasks, string title)
{
    int count = 0;
    foreach (string i in tasks)
    {
        if (i == title)
        {
            count++;
        }
    }
    return count;
}
Console.Write("Название для подсчёта совпадений: ");
string countTitle = Console.ReadLine();

int match = CountTask(tasks, countTitle);
Console.WriteLine($"Совпадений для *{countTitle}* : {match}");