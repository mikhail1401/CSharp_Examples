// Игра в детские пирамидки
// Где нужно кольца пирамиды с одного шпиля,
// расположенные от большего снизу к меншему сверу,
// Переместить на другой шпиль

// string from - шпиль, с которого мы начинаем
// string to - шпиль, на которой мы должны расставить кольца
// string middle - промежуточной шпиль
// int count - количество блинов, которое у нас есть
void Towers(string from = "1", string to = "3", string middle = "2", int count = 3)
{
    if (count > 1) Towers(from, middle, to, count - 1);
    Console.WriteLine($"{from} >> {to}");
    if (count>1) Towers(middle, to, from, count-1);
}

Towers();