# итоговая контрольная работа
1. напишем команду для ввода количества элементов массива из строк
2. вводим строки через цикл и тем самым заполняем массив 
3. считаем количество символов в каждой строке. для этого используем цикл. ставим счетчик для тех строк, что удовлетворяют условию задачи. значение счетчика покажет результат - сколько элементов будет в новом массиве и сколько выделять памяти для этого массива.
4. создаем новый цикл. выход из этого цикла будет условие "счетчик = результат" и выводится на экран новый массив. До этого момента проверяется условие: количество символов в строке <= 3. если "да", то записываем строку в новый массив, далее счетчик увеличиваем на 1.

какие есть минусы решения этой задачи
-


в моём случае, я использую два раза цикл, тем самым загружая процессор

можно же взять новый массив длиной первого массива и заполнить его теми строками, которые удовлетворяют условию, но в таком случае мы занимаем память. 
