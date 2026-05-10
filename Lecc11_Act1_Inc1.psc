Algoritmo Lecc11_Act1_Inc1
	Definir cupoMaximo, ocupados, ingresados Como Entero
    cupoMaximo = 200
    ocupados = 0
    
    Escribir "======= CONTROL DE ESTACIONAMIENTO ======="
    
    Repetir
        Escribir "Cajones disponibles: ", (cupoMaximo - ocupados)
        Escribir "Ingrese la cantidad de autos que entran ahora:"
        Leer ingresados
        
        Si (ocupados + ingresados) <= cupoMaximo Entonces
            ocupados = ocupados + ingresados
            Escribir "Autos ingresados con éxito."
        SiNo
            Escribir "Error: No hay suficiente espacio para esa cantidad."
        Fin Si
        
        Escribir "-------------------------------------------"
        
    Hasta Que ocupados = cupoMaximo
    
    Escribir "¡ESTABLECIMIENTO LLENO! No hay cajones libres."
	
FinAlgoritmo
