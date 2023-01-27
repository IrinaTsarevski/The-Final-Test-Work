# Проверочная работа по итогу прохождения первого блока по программе "разработчик"
1. сначала было добавлено описание *string* метода  *NewArrayString*, позволяющего из имеющегося массива строк сормировать массив из строк, длина которых меньше, либо равна 3 символам.
* задали переменную *count* равную нулю, которая поможет нам узнать длинну конечного массива.
* прописали условие для цикла *for* *(i = 0; i < arrString.Length; i++)*, в котором проверяем каждый элемент массива по длине *arrString.Length < 4* (по условию задания нас интересуют элементы, состоящие из 3 или меньше символов)
* если элемент удовлетворяет условию, тогда в счетчик *count* записывается +1.
* задаем конечный массив *result*, с количеством элементов равным count *(string [] result = new string[count])*.
* прописали условие для цикла *for* *(i = 0; i < arrString.Length; i++)*, в котором будем искать элементы удовлетворяющих условию задания, тут же задали переменную *j* равную нулю, чтобы идти по порядку по элементам массива *newArrString*.
* далее, если элемент массива НЕ длиннее 4 символов, то записываем его в result, и переходим к следующему элементу *i* и *j* *(i++, j++)*.
* если длиннее, то пропускаем его и переходим к проверке следующего элемента *i*, а номер элемента *j* в массиве *result* остается без изменений.
* всё готово, возвращаем результат!
1. затем добавили описание *void* метода *PrintArray*, чтобы наши массивы выводились в терминале.
* прописали название метода, и то что он будет принимать на вход.
* прописали условия для существования цикла *for* *(i = 0; i < arrString.Length; i++)*.
* теперь консоль напишет нам все элементы массива по-порядку в одной строке.
* добавили пустые строки, чтобы легче читалась информация.
1. добавили пустую строку, чтобы легко читались данные выводящиеся в терминале.
2. задали первоночальный массив строк *arrString*.
3. вывели его содержимое в терминал, чтобы легко было проверить дальнейший результат.
4. создали новый массив *newArrString*, в который положили описанный ранее метод *NewArrayString*.
5. вывели получившийся массив на экран при помощи метода *PrintArray*.