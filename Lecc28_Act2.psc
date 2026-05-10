Algoritmo Lecc28_Act2
	Definir opc, cantBoletos, totalCobrado Como Entero
    cantBoletos = 0
    totalCobrado = 0
    
    Escribir "======= CONTROL DE ACCESO: RUEDA DE LA FORTUNA ======="
    Escribir "Instrucciones: 1=Niño ($10), 2=Adulto ($15), 0=Cerrar Caja"
    
    Repetir
        Escribir ""
        Escribir "Seleccione el tipo de boleto a vender:"
        Leer opc
        
        Segun opc Hacer
            1:
                cantBoletos = cantBoletos + 1
                totalCobrado = totalCobrado + 10
                Escribir ">> Boleto NIÑO registrado."
            2:
                cantBoletos = cantBoletos + 1
                totalCobrado = totalCobrado + 15
                Escribir ">> Boleto ADULTO registrado."
            0:
                Escribir "Generando reporte de cierre..."
            De Otro Modo:
                Escribir "Opción no válida, intente de nuevo."
        Fin Segun
        
        // Mostrar estado actual en cada repetición
        Escribir "-------------------------------------------"
        Escribir "Boletos vendidos hasta ahora: ", cantBoletos
        Escribir "Total cobrado actualmente: $", totalCobrado
        Escribir "-------------------------------------------"
        
    Hasta Que opc = 0
    
    Escribir ""
    Escribir "********** RESUMEN FINAL DEL TURNO **********"
    Escribir "Total de personas que subieron: ", cantBoletos
    Escribir "DINERO TOTAL EN CAJA: $", totalCobrado
    Escribir "*********************************************"
	
FinAlgoritmo
