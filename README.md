Я создал WPF проект, в котором создаю класс VigenereCipher, в котором реализую алгоритм по шифрованию методом Виженера
В классе созадю два метода Encipher, который шифрует информацию и Decipher, который расшифровывает
Реализовал их по логике для шифрования с = (m + k) mod n, где n - количество букв в алфавите, m - номер буквы открытого текста, k - буквы ключа, c - номер буквы после шифрования
с = (m + n - k) mod n для рассшифровки

Так же сделал пару проверок на ввходящие данные, чтобы были соблюдены условия задания 
Так же реализовал простой интерфейс для работы с пользователем

Сделал несколько Unit тестов для проверки работы программы в определенных условиях
1. проверка правильности шифрования 
2. проверка правильности дешифрования
3. проверка ключа на правильность ввода при шифровании и дешифровании 
4. проверка входящего текста дял шифрования и дешифрования
