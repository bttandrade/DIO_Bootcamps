salario = int(input()) 
if salario <= 600 :
    percentual = 0.17
elif salario > 600 and salario <= 900:
    percentual = 0.13
elif salario > 900 and salario <= 1500 :
    percentual = 0.12
elif salario > 1500 and salario <= 2000:
    percentual = 0.10
else: 
    percentual = 0.05

reajuste = salario*percentual 

texto = ('Novo salario: {:.2f}\nReajuste ganho: {:.2f}\nEm percentual: {:.0f} %'.format(salario+reajuste,reajuste,percentual*100))
print(texto)