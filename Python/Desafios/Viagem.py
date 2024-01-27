valores = input().split()

horas = int(valores[0]) 
velo = int(valores[1])

total = (horas*velo)/12

print('{:.3f}'.format(total))