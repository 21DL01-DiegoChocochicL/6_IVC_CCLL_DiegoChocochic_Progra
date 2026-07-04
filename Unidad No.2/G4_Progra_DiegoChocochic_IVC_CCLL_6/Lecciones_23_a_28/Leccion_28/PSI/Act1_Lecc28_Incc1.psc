Algoritmo Act1_Lecc28_Incc1
	Definir strikers, dinero, total Como Entero
	strikers <- 0
	dinero <- 0
	total <- 0
	Escribir '=========================================='
	Escribir '      SISTEMA DE ACUMULACIÓN DE ORO       '
	Escribir '    (Si ingresas 0, recibes un Strike)    '
	Escribir '=========================================='
	Escribir ''
	Repetir
		Escribir '------------------------------------------'
		Escribir ' >> Tienes: ', strikers, ' strike(s)'
		Escribir ' >> Total acumulado: $', total
		Escribir ''
		Escribir ' Ingresa la cantidad de dinero ganada:'
		Leer dinero
		Si dinero==0 Entonces
			strikers <- strikers+1
			Escribir ' [!] ¡CUIDADO! Has fallado. Strike añadido.'
		SiNo
			total <- total+dinero
			Escribir ' [+] ¡Excelente! Sumaste $', dinero
		FinSi
		Escribir ''
	Hasta Que strikers>=3
	Escribir '=========================================='
	Escribir '               GAME OVER                  '
	Escribir '=========================================='
	Escribir '  Puntaje final total: $', total
	Escribir '  Motivo: Alcanzaste el límite de strikes.'
	Escribir '=========================================='
FinAlgoritmo
