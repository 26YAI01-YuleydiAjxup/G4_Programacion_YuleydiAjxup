Algoritmo Lecc23_Act4_Inc1
	Definir num, i, resultado Como Entero
    
    Escribir "======= GENERADOR DE TABLAS ======="
    Escribir "Ingrese el número que desea multiplicar:"
    Leer num
    
    Limpiar Pantalla
    Escribir "Tabla de multiplicar del ", num, ":"
    Escribir "-----------------------------------"
    
    // Usamos el ciclo Para porque conocemos el límite (del 1 al 10)
    Para i <- 1 Hasta 10 Hacer
        resultado <- num * i
        Escribir num, " x ", i, " = ", resultado
    Fin Para
    
    Escribir "-----------------------------------"
    Escribir "Fin del proceso. Presione una tecla para salir."
	
FinAlgoritmo
