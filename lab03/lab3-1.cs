using System;
using System.Collections.Generic;

var lines = new[] { "Запуск програми", "Читання конфігу", "Підключення до БД", "Обробка запиту", "Завершення" };

var log = new List<string>();
foreach (var line in lines)
    log.Add(line);

log.Reverse();
foreach (var line in log)
    Console.WriteLine(line);