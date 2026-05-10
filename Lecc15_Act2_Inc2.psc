Algoritmo Lecc15_Act2_Inc2
	Definir billete, contador100, sumaTotal, totalProcesados Como Entero
    contador100 = 0
    sumaTotal = 0
    totalProcesados = 0
    
    Escribir "--- Sistema de Caja ---"
    Escribir "(Ingrese 0 para finalizar el conteo)"
    
    Repetir
        totalProcesados = totalProcesados + 1
        Escribir "Billete #", totalProcesados, ". Ingrese denominacion:"
        Leer billete
        
        Si billete = 100 Entonces
            contador100 = contador100 + 1
            sumaTotal = sumaTotal + 100
            Escribir ">> Registrado: $100"
        Fin Si
        
    Hasta Que billete = 0 O totalProcesados = 1000
    
    Escribir ""
    Escribir "********** CIERRE DE CAJA **********"
    Escribir "Billetes de $100 encontrados: ", contador100
    Escribir "Total de dinero en $100: $", sumaTotal
    Escribir "Total de billetes revisados: ", totalProcesados - 1
    Escribir "************************************"
	
FinAlgoritmo
