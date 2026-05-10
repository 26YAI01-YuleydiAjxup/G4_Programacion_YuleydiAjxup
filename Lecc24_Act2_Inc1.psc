Algoritmo Lecc24_Act2_Inc1
	Definir num, i, resultado Como Entero
    
    Escribir "======= GENERADOR DE 20 MÚLTIPLOS ======="
    Escribir "Ingrese el número base:"
    Leer num
    
    Escribir "Los primeros 20 múltiplos de ", num, " son:"
    Escribir "---------------------------------------"
    
    // Ciclo definido para cumplir con los 20 múltiplos solicitados
    Para i <- 1 Hasta 20 Hacer
        resultado <- num * i
        Escribir "Múltiplo ", i, ": ", resultado
    Fin Para
    
    Escribir "---------------------------------------"
    Escribir "Proceso completado con éxito."
	
FinAlgoritmo
