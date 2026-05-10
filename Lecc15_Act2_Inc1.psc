Algoritmo Lecc15_Act2_Inc1
	Definir num, i, divisores, contadorPrimos, sumaPrimos Como Entero
    Definir respuesta Como Caracter
    contadorPrimos = 0
    sumaPrimos = 0
    
    Escribir "======= ANALIZADOR DE NÚMEROS PRIMOS ======="
    
    Repetir
        Escribir "Ingrese un número para verificar:"
        Leer num
        
        divisores = 0
        Para i = 1 Hasta num Hacer
            Si num % i = 0 Entonces
                divisores = divisores + 1
            Fin Si
        Fin Para
        
        Si divisores = 2 Entonces
            Escribir " Es PRIMO"
            contadorPrimos = contadorPrimos + 1
            sumaPrimos = sumaPrimos + num
        SiNo
            Escribir " NO es primo"
        Fin Si
        
        Escribir "¿Desea ingresar otro número? (s/n):"
        Leer respuesta
    Hasta Que respuesta = "n" O respuesta = "N"
    
    Escribir "**********************************************"
    Escribir "Cantidad de números primos: ", contadorPrimos
    Escribir "Suma total de los primos: ", sumaPrimos
    Escribir "**********************************************"
	
FinAlgoritmo
