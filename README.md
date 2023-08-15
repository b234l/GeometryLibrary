# Задание 2. GeometryLibrary

**Задание: Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.**

*Проект выполнен на базе Библиотеки классов для .NET, выполнение задания можно посмотреть в файле GeomtryCalculator.cs:*
1. Инициализируется интерфейс фигуры `IShape` с методом `CalculateArea()` для нахождения площади фигуры.
2. Создаются классы-наследники `Circle` и `Triangle` и переопределяется метод `CalculateArea()`, 
а также добавляются свойства `Radius` для круга и `Side1, Side2, Side3` для треугольника.  
*ПРИМЕЧАНИЕ*: В классе `Triangle` площадь вычисляется по формуле Герона через дополнительное свойство `semiPerimeter` (полупериметр)
3. В классе `Triangle` метод `IsRightTriangle()` используется для проверки треугольника на прямоугольность по теореме Пифагора.
4. В папке *Test* находится файл `Test1.cs` модульного тестирования.
5. Вычислять площадь фигуры можно без знания фигуры.

# Задание 3. MS SQL Server Query

**В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.**

*Для решения данной задачи можно использовать оператор LEFT JOIN, чтобы выбрать все продукты и их категории, а также продукты без категорий.*
*В результате выполнения запроса получаем все пары "Имя продукта - Имя категории", включая продукты, у которых нет категорий.*

*Запрос находится в директории `Вопрос №3. MS SQL Serv\task3_query.sql`*