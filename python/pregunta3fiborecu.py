# -*- coding: utf-8 -*-
def impresion(funcion, n):
    for i in range(n):
        print(funcion(i))


def fib_rec(n):
    if(n==0):
        return 0
    if(n==1):
        return 1
    if(n==2):
        return 1
    return (fib_rec(n-1)+fib_rec(n-2)+fib_rec(n-3))

numero = int(input("ingrese el numero de fibonaccis a imprimir : "))
print("los primeros "+str(numero) +" numeros fibonacci recursivo es: ")
impresion(fib_rec, numero)

