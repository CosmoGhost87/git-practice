# Запись текста в файл
text = "Привет, мир!\nPython — это просто!\nУчимся работать с текстом."

with open("example.txt", "w", encoding="utf-8") as file:
    file.write(text)

print("Файл записан!")

# Чтение текста из файла
with open("example.txt", "r", encoding="utf-8") as file:
    content = file.read()

print("\n--- Содержимое файла ---")
print(content)