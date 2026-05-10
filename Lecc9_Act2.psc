Algoritmo Lecc9_Act2
	Definir monedasTotales, nuevasMonedas Como Entero
    monedasTotales = 0
    
    Escribir "======= NIVEL 5: BLOQUEADO ======="
    Escribir "Requisito: 350 monedas."
    
    // El ciclo "Mientras" evalúa la condición antes de cada iteración 
    Mientras monedasTotales < 350 Hacer
        Escribir "Tienes ", monedasTotales, " monedas."
        Escribir "Ingresa la cantidad de monedas ganadas:"
        Leer nuevasMonedas
        
        monedasTotales = monedasTotales + nuevasMonedas
    Fin Mientras
    
    Escribir "¡Meta alcanzada! Total de monedas: ", monedasTotales
    Escribir "Accediendo al Nivel 5..."
FinAlgoritmo
