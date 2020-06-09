# msgenc

msgenc/MessageEncryption/ содержит решение Visual Studio, back-end

msgenc/msgenc-frontend/ содержит Angular 9 приложение, front-end

### Back-end 

Реализован с помощью ASP.NET MVC 5, EF6 и MS SQL. Перед запуском необходимо заменить или проверить корректность строки подключения к базе данных MS SQL в *web.config*. Таблица "Replacement" заполняется автоматически при инициализации, согласно картинке в задании.

### Front-end 

Реализован на Angular 9. Для запуска необходимо установить node, npm и angular/cli.
Команда для запуска: *ng serve*.
