Algoritmo Lecc9_Act3_Inc2
	Definir num, i, cont Como Entero
    cont = 0
    Escribir "Ingrese el número a evaluar:"
    Leer num
    
    Para i = 1 Hasta num Hacer
        Si num % i = 0 Entonces
            cont = cont + 1
        Fin Si
    Fin Para
    
    Si cont = 2 Entonces
        Escribir "El número ", num, " es PRIMO."
    SiNo
        Escribir "El número ", num, " NO es primo."
    Fin Si
	
FinAlgoritmo
