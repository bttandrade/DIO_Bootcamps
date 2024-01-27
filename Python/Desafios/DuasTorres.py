entrada = input().split(' ')

distancia = int(entrada[0])
diametro1 = int(entrada[1])
diametro2 = int(entrada[2])

icm = round(distancia/(diametro1+diametro2), 2)

print('{:.2f}'.format(icm))