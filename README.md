# Final-Working

## В программе три функция:
1. **FillingInArray** - принимает размер массива "size". 
    * Создает массив строк, размера "size".
    * Ввод элементов массива.
    * Возвращает массив строк.

2. **SelectLessCharacters** - принимает массив строк "arr".
    * Создает новый массив размера "arr.Length".
    * Создает переменную "step", для заполнения нового массива по индексу.
    * В цикле отбирает элементы массива размера меньше или равно 3.
    * Изменяет размер нового массива, через "Array.Resize".
    * Возвращает новый массив.

3.  **PrintArray** - принимает массив строк "arr".
    * Вывод массива через "string.Join".


### Основная программа 
  * Ввод размера массива и присвоение в переменную "size".

 * Создание массива **stringArray** и присвоение к ниму результата функции **FillingInArray(size)**.

 * Вывод массива **stringArray** через функцию **PrintArray**.

* Создание массива **processedArray** и присвоение к ниму результата функции **SelectLessCharacters(stringArray)**. 

* Вывод массива **processedArray** через функцию **PrintArray**.

 