﻿## OwnDictionary
 * Реализуйте класс OtusDictionary, который позволяет оперировать int-овыми значениями в качестве ключей и строками в качестве значений.
 * Для добавления используйте метод void Add(int key, string value), а для получения элементов - string Get(int key).
 * Внутреннее хранилище реализуйте через массив.
 * При нахождении коллизий, создавайте новый массив в два раза больше и не забывайте пересчитать хеши для всех уже вставленных элементов.
 * Метод GetHashCode использовать не нужно и массив/список объектов по одному адресу создавать тоже не нужно (только один объект по одному индексу).
 * Словарь не должен давать сохранить null в качестве строки, соответственно, проверять заполнен элемент или нет можно сравнивая строку с null.
