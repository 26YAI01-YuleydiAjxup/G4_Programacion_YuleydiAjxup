Algoritmo Lecc11_Act3_Inc2
	Definir num, suma Como Entero
    suma = 0
    
    Escribir "======= SUMA INTERACTIVA (Escribe 9 para salir) ======="
    
    Repetir
        Escribir "Ingrese un número:"
        Leer num
        
        Si num <> 9 Entonces
            suma = suma + num
            Escribir "Suma parcial: ", suma
        Fin Si
        
    Hasta Que num = 9
    
    Escribir "Suma total final: ", suma
    Escribir "Saliendo del programa..."
	
FinAlgoritmo
