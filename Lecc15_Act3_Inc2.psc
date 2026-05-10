Algoritmo Lecc15_Act3_Inc2
	Definir num, i, divisores, contPrimos, sumaPares Como Entero
    Definir tec Como Caracter
    
    Escribir "Este programa analizará del 300 al 1."
    Escribir "Presione cualquier tecla para comenzar el conteo..."
    Leer tec
    
    contPrimos = 0
    sumaPares = 0
    
    Para num = 300 Hasta 1 Con Paso -1 Hacer
        // Lógica de Pares
        Si num % 2 = 0 Entonces
            sumaPares = sumaPares + num
        Fin Si
        
        // Lógica de Primos
        divisores = 0
        Para i = 1 Hasta num Hacer
            Si num % i = 0 Entonces
                divisores = divisores + 1
            Fin Si
        Fin Para
        
        Si divisores = 2 Entonces
            contPrimos = contPrimos + 1
        Fin Si
        
        // Feedback para el usuario (opcional para no saturar la pantalla)
        Si num % 50 = 0 Entonces
            Escribir "Procesando... número actual: ", num
        Fin Si
    Fin Para
    
    Escribir "======= REPORTE FINAL (300 a 1) ======="
    Escribir "Números primos encontrados: ", contPrimos
    Escribir "Suma de todos los pares: ", sumaPares
    Escribir "======================================="
	
FinAlgoritmo
