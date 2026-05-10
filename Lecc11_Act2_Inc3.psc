Algoritmo Lecc11_Act2_Inc3
	Definir n1, n2, mayor, menor, i Como Entero
    Escribir "Ingrese el primer número:"
    Leer n1
    Escribir "Ingrese el segundo número:"
    Leer n2
    
    Si n1 < n2 Entonces
        menor = n1
        mayor = n2
    SiNo
        menor = n2
        mayor = n1
    Fin Si
    
    i = menor
    Escribir "Múltiplos de 4 entre ", menor, " y ", mayor, ":"
    
    Repetir
        Si i % 4 = 0 Entonces
            Escribir i
        Fin Si
        i = i + 1
    Hasta Que i > mayor
	
FinAlgoritmo
