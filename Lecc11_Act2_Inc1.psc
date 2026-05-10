Algoritmo Lecc11_Act2_Inc1
	Definir n, i, factorial Como Entero
    Escribir "Ingrese un número para calcular su factorial:"
    Leer n
    factorial = 1
    i = n
    
    Si n < 0 Entonces
        Escribir "El factorial no está definido para números negativos."
    SiNo
        Repetir
            Si n > 0 Entonces
                factorial =factorial * i
                i = i - 1
            Fin Si
        Hasta Que i = 0
        Escribir "El factorial de ", n, " es: ", factorial
    Fin Si
	
FinAlgoritmo
