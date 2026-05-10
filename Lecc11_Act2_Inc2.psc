Algoritmo Lecc11_Act2_Inc2
	Definir num Como Entero
    Definir respuesta Como Caracter
    
    Escribir "======= DETECTOR DE NÚMEROS IMPARES ======="
    
    Repetir
        Escribir "Ingrese un número para verificar:"
        Leer num
        
        Si num % 2 <> 0 Entonces
            Escribir "El número ", num, " es IMPAR."
        SiNo
            Escribir "El número ", num, " es PAR."
        Fin Si
        
        Escribir "¿Desea ingresar otro número? (s/n)"
        Leer respuesta
        
    Hasta Que respuesta = "n" O respuesta = "N"
    
    Escribir "Proceso terminado."
	
FinAlgoritmo
