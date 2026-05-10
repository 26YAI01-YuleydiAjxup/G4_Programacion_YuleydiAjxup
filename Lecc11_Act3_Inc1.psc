Algoritmo Lecc11_Act3_Inc1
	Definir n1, n2, menor, mayor, i, suma Como Entero
    Escribir "Ingrese primer número:"
    Leer n1
    Escribir "Ingrese segundo número:"
    Leer n2
    
    Si n1 < n2 Entonces
        menor = n1
        mayor = n2
    SiNo
        menor = n2
        mayor = n1
    Fin Si
    
    suma = 0
    i = menor
    
    Repetir
        suma = suma + i
        i = i + 1
    Hasta Que i > mayor
    
    Escribir "La suma total del rango es: ", suma
	
FinAlgoritmo
