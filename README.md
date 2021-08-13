---
###                  Тестовое задание EF ###
#### 1.	Создать проект «Консольное приложение».
#### 2.	Описать классы, со структурой, указанной в задании по SQL.
#### 3.	Сделать класс-контекст (DbContext) и поместить в него свойства с этими классами.
#### 4.	Настроить проект и строку соединения для подключения к MySql.
#### 5.	Создать и настроить миграцию в проекте.
#### 6.	Обновить структуру данных в БД.
#### 7.	Написать метод генерирующий вставку данных в таблицы «Страны» и «Города».
#### 8.	Написать метод генерирующий вставку в таблицу «Клиенты».
#### 9.	Написать метод вносящий изменения в таблицу «Клиенты».
#### 10.	Написать метод удаляющий запись из таблицы «Клиенты».
#### 11.	Написать метод, который будет выводить данные из всех таблиц на консоль.
#### 12.	Написать метод, который будет вносить изменения в счета при выполнении операций Пополнение/Списание/Перевод.
#### 13.	Написать метод, который будет выводить на консоль статистику по количеству денег на счетах по странам и городам.
---
###                     Задание № 2. SQL ###
#### > 1.	Написать скрипт на создание таблиц «Страны» и «Города»
#### >> a.	Ключевое поле
#### >> b.	Код (строка 30)
#### >> c.	Наименование (строка 400)
#### > 2.	Написать скрипт на создание таблицы «Клиенты банка»
##### >> a.	Ключевое поле (ID)
##### >> b.	ФИО (строка 400)
##### >> c.	Ссылка на страну
##### >> d.	Ссылка на город
##### >> e.	Адрес проживания (строка 400)
##### >> f.	ИИН (строка 12)
##### >> g.	Дата рождения
#### > 3.	Сделать для всех таблицы первичные ключи
#### > 4.	Сделать для таблицы «Клиенты банка» вторичные ключи для полей «Ссылка на страну» и «Ссылка на город»
#### > 5.	Сделать скрипт для таблицы уникальный индекс на поле «ИИН»
#### > 6.	Написать скрипт на вставку данных в таблицы (10-20 записей)
#### > 7.	Написать скрипт на изменение строки в таблице «Страны»
#### > 8.	Написать скрипт на удаление строки в таблице «Клиенты банка»
#### > 9.	Написать скрипт показывающий разбивку количества клиентов по странам и городам, отсортированные по странам и городам.
#### > 10.	Создать таблицу «Операции по счетам»
##### >> a.	Ключевое поле
##### >> b.	Тип операции (Снятие/Пополнение/Перевод)
##### >> c.	Ссылка на клиента отправителя
##### >> d.	Ссылка на счет отправителя
##### >> e.	Ссылка на клиента получателя
##### >> f.	Ссылка на счет получателя
##### >> g.	Сумма (плавающее 18,3)
#### > 11.	Создать таблицу «Счета»
##### >> a.	Ключевое поле
##### >> b.	Ссылка на клиента
##### >> c.	Номер счета (строка 15)
##### >> d.	Остаток на счете (плавающее 18,3)
#### > 12.	Сделать для таблицы «Счета» вторичный ключ для поля «Ссылка на клиентов»
#### > 13.	Сделать триггер на таблице «Операции по счетам», который срабатывает при выполнении вставки, списывает нужно количество денег со счета в таблице «Счета» отправителя и записывает нужное количество денег на счет получателя.
#### > 14.	Сделать скрипт на проведение нескольких операций по каждому счету – Снятие, пополнение, перевод
#### > 15.	Сделать скрипт по отображению сумм по операциям в разрезе городов и стран.
---
###                Задание № 4. ASP.NET MVC ### 
#### 1.	Создать проект ASP.NET MVC.
#### 2.	Настройте в проекте классы и Entity Framework на работу с БД из Задания 3.
#### 3.	Создайте страницу для отображение данных из таблицы «Страны».
#### 4.	Создайте страницу для отображение данных из таблицы «Города».
#### 5.	Создайте страницу для отображение данных из таблицы «Клиенты».
#### 6.	Сделайте на странице отображения данных из таблицы «Клиенты» кнопки по просмотру, редактированию (ссылка на страницу для редактирования) и удалению записей.
#### 7.	Создайте страницу для отображения и редактирования одной записи из таблицы «Клиенты».
#### 8.	Создайте страницу для просмотра результата запроса количества клиентов с группировкой по странам и городам.
#### 9.	Создайте на странице редактирования клиента возможность просмотра счетов клиента.
---
