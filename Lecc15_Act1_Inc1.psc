Algoritmo Lecc15_Act1_Inc1
	Definir totalDinero, cantAdultos, cantNinos, opci Como Entero
    totalDinero = 0
    cantAdultos = 0
    cantNinos = 0
    opci = 0
    
    Escribir "======= CONTROL DE RUEDA DE LA FORTUNA ======="
    
    Repetir
        Escribir "1. Venta boleto ADULTO ($15)"
        Escribir "2. Venta boleto NIÑO ($10)"
        Escribir "3. CERRAR CAJA Y SALIR"
        Leer opci
        
        Segun opci Hacer
            1:
                totalDinero = totalDinero + 15
                cantAdultos = cantAdultos + 1
                Escribir "Boleto de adulto vendido."
            2:
                totalDinero = totalDinero + 10
                cantNinos = cantNinos + 1
                Escribir "Boleto de niño vendido."
            3:
                Escribir "Procesando cierre..."
            De Otro Modo:
                Escribir "Opción no válida."
        Fin Segun
        Escribir "Dinero acumulado: $", totalDinero
        Escribir "---------------------------------------------"
    Hasta Que opci = 3
    
    Escribir "======= REPORTE FINAL DE VENTAS ======="
    Escribir "Boletos de Adulto vendidos: ", cantAdultos
    Escribir "Boletos de Niño vendidos: ", cantNinos
    Escribir "Total de boletos vendidos: ", (cantAdultos + cantNinos)
    Escribir "TOTAL RECAUDADO: $", totalDinero
	
FinAlgoritmo
