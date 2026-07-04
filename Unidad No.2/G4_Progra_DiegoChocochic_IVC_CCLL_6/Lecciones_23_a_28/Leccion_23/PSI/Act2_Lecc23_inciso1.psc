Algoritmo Act2_Lecc9_inciso1
	Definir monedas Como Entero
	monedas <- 0
	Escribir '*******************************************'
	Escribir '       ¡BIENVENIDO AL DESAFÍO NIVEL 5!      '
	Escribir '*******************************************'
	Escribir 'Para entrar al Nivel 5 necesitas 350 monedas.'
	Mientras monedas<350 Hacer
		Escribir '-------------------------------------------'
		Escribir 'Estado: Nivel 5 Bloqueado.'
		Escribir 'Ingresa cuántas monedas tienes para subir de nivel:'
		Leer monedas
	FinMientras
	Escribir '*******************************************'
	Escribir '¡Felicidades! Has alcanzado las ', monedas, ' monedas.'
	Escribir 'Nivel 5 Desbloqueado.'
	Escribir '*******************************************'
FinAlgoritmo
