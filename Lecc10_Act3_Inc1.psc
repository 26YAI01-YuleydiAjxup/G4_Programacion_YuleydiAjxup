Algoritmo Lecc10_Act3_Inc1
	Definir i, n, j, divisores, sumaTotal Como Entero
    sumaTotal = 0
    
    Escribir "Suma de números primos (Rango 1-22)"
    
    Para i = 1 Hasta 22 Hacer
        Escribir i, ". Ingrese un número:"
        Leer n
        
        divisores = 0
        Para j = 1 Hasta n Hacer
            Si n % j = 0 Entonces
                divisores <- divisores + 1
            Fin Si
        Fin Para
        
        Si divisores = 2 Entonces
            Escribir "Es primo. Sumando..."
            sumaTotal = sumaTotal + n
        SiNo
            Escribir "No es primo."
        Fin Si
    Fin Para
    
    Escribir "La suma total de los primos ingresados es: ", sumaTotal
	
FinAlgoritmo
