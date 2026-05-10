Algoritmo Lecc9_Act4_Inc1
	Definir tabla, i, resultado Como Entero
    
    Escribir "======= TABLAS DE MULTIPLICAR ======="
    Escribir "Ingrese el número de la tabla que desea ver:"
    Leer tabla
    
    Escribir "Tabla del ", tabla, ":"
    
    // Ciclo definido del 1 al 10
    Para i <- 1 Hasta 10 Con Paso 1 Hacer
        resultado <- tabla * i
        Escribir tabla, " x ", i, " = ", resultado
    Fin Para
	
FinAlgoritmo
