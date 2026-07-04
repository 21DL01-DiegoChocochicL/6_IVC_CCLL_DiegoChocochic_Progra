Algoritmo Act2_Lecc11_inciso3
	Definir n1, n2, menor, mayor, i Como Entero
	Escribir '*******************************************'
	Escribir '    BUSCADOR DE MÚLTIPLOS DE 4 EN RANGO    '
	Escribir '*******************************************'
	Escribir 'Ingrese el primer número:'
	Leer n1
	Escribir 'Ingrese el segundo número:'
	Leer n2
	Si n1<n2 Entonces
		menor <- n1
		mayor <- n2
	SiNo
		menor <- n2
		mayor <- n1
	FinSi
	Escribir '-------------------------------------------'
	Escribir 'Múltiplos de 4 entre ', menor, ' y ', mayor, ':'
	i <- menor
	Repetir
		Si i MOD 4=0 Entonces
			Escribir i
		FinSi
		i <- i+1
	Hasta Que i>mayor
	Escribir '-------------------------------------------'
	Escribir 'Proceso finalizado.'
	Escribir '*******************************************'
FinAlgoritmo
