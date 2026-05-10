Algoritmo Lecc15_Act3_Inc1
	Definir i, multip, sumaMultiplos, contadorPares Como Entero
    Definir iniciar Como Caracter
    
    Escribir "======= ANALIZADOR DE MÚLTIPLOS DE 7 ======="
    Escribir "¿Desea calcular los primeros 20 múltiplos? (s/n)"
    Leer iniciar
    
    Si iniciar = "s" O iniciar = "S" Entonces
        sumaMultiplos = 0
        contadorPares = 0
        
        Para i = 1 Hasta 20 Hacer
            multip = i * 7
            sumaMultiplos = sumaMultiplos + multip
            
            Escribir "Múltiplo ", i, ": ", multip
            
            Si multip % 2 = 0 Entonces
                Escribir "Este múltiplo es PAR"
                contadorPares = contadorPares + 1
            SiNo
                Escribir "Este múltiplo es IMPAR"
            Fin Si
        Fin Para
        
        Escribir "-------------------------------------------"
        Escribir "SUMA TOTAL: ", sumaMultiplos
        Escribir "CANTIDAD DE PARES: ", contadorPares
    SiNo
        Escribir "Operación cancelada por el usuario."
		Fin Si 
	
FinAlgoritmo
