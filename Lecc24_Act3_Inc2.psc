Algoritmo Lecc24_Act3_Inc2
	Definir numInicio, i, acumuladorSuma Como Entero
    Escribir "======= CUENTA REGRESIVA INTERACTIVA ======="
    Escribir "Ingrese el número para iniciar la cuenta:"
    Leer numInicio
    
    acumuladorSuma <- 0
    
    // Ciclo desde el número dado hasta 1
    Para i <- numInicio Hasta 1 Con Paso -1 Hacer
        Escribir i
        acumuladorSuma <- acumuladorSuma + i
    Fin Para
    
    Escribir "---------------------------------------------"
    Escribir "La suma total de la serie es: ", acumuladorSuma
	
FinAlgoritmo
