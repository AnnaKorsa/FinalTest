# Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
# Решение
1. Вводим количество элементов массива с клавиатуры и проверяем заданное число. Если введенное число меньше либо равно 0, программа выдает ошибку и просит ввести количество элементов больше 0.
2. Заданное число присваиваем длине первоночального массива. Данный массив вводим с клавиатуры, для этого используем метод **InputArray**.
3. Для того, чтобы знать размер нового массива, который будет удовлетворять условиям задачи (меньше или 3 символа) используем метод **FindShortSymbol**. Также задаем условие: если размер равен 0, на экране появится пояснение "В массиве нет элементов, длина которых меньше, либо равна 3".
4. Чтобы заполнить новый массив значениями, создаем отдельный метод **ArrayShortSymbol**, который будет проверять каждую строку первоначального массива. Если его длина равна 3 или меньше, то записываем его в новый массив.
5. Выводим полученный массив с помощью метода **PrintArray**.