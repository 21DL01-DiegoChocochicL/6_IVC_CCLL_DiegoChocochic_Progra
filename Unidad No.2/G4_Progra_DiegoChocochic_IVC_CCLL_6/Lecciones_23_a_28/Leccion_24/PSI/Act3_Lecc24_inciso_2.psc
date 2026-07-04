Algoritmo Act3_Lecc24_inciso_2
	Definir n, i, acumulador Como Entero
	Escribir '=========================================='
	Escribir '        BIENVENIDO AL CALCULADOR          '
	Escribir '         DE CUENTAS REGRESIVAS            '
	Escribir '=========================================='
	Escribir ''
	Escribir '  > Por favor, ingresa un número entero positivo:'
	Leer n
	Si n<=0 Entonces
		Escribir '  [!] Error: El número debe ser mayor a 0.'
	SiNo
		Escribir ''
		Escribir '--- Iniciando secuencia ---'
		Escribir ''
		acumulador <- 0
		Para i<-n Hasta 1 Con Paso -1 Hacer
			Si i=1 Entonces
				Escribir i, '.'
			SiNo
				Escribir i, ', 'Sin Saltar
			FinSi
			acumulador <- acumulador+i
		FinPara
		Escribir ''
		Escribir '------------------------------------------'
		Escribir '  RESULTADO FINAL:'
		Escribir '  La suma total de la secuencia es: ', acumulador
		Escribir '------------------------------------------'
		Escribir '          ¡Gracias por usarme!            '
	FinSi
FinAlgoritmo
