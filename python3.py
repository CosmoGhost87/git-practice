num = int(input("Введите целое число: "))
result = {0: "чётное", 1: "нечётное"}
print(f"{num} — {result[num % 2]} число")