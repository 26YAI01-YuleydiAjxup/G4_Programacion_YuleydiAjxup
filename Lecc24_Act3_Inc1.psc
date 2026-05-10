Algoritmo Lecc24_Act3_Inc1
	Definir num, i, divisores, acumuladorSuma Como Entero
    acumuladorSuma <- 0
    
    Escribir "Calculando la suma de números primos entre 1 y 50..."
    
    Para num <- 1 Hasta 50 Hacer
        divisores <- 0
        Para i <- 1 Hasta num Hacer
            Si num % i = 0 Entonces
                divisores <- divisores + 1
            Fin Si
        Fin Para
        
        Si divisores = 2 Entonces
            Escribir "Primo encontrado: ", num
            acumuladorSuma <- acumuladorSuma + num
        Fin Si
    Fin Para
    
    Escribir "---------------------------------------------"
    Escribir "La suma total de los primos es: ", acumuladorSuma
	
FinAlgoritmo
