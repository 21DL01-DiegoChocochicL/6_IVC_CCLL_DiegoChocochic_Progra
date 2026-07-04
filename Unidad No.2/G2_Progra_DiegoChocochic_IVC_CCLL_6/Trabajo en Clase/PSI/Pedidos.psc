Algoritmo Pedidos
	// Muestra un menú: 1 = Hamburguesa, 2 = Pizza, 3 = Pollo frito, 4 = Ensalada - El usuario elige una
	// opción y el programa muestra el pedido.
	// Inicio
	Definir n1 Como Real
	Escribir '\t* Menu'
	Escribir '\t**********************************************'
	Escribir '\t* El menu de hoy es:                         *'
	Escribir '\t* 1- Hamburguesa                             *'
	Escribir '\t* 2- Pizza                                   *'
	Escribir '\t* 3- Pollo Frito                             *'
	Escribir '\t* 4- Ensalada                                *'
	Escribir '\t**********************************************'
	Escribir 'Que desea el dia de hoy?'
	Leer n1
	// Proceso, Salida y Sentencia de Seleccion
	Según n1 Hacer
		1:
			Escribir 'Entendido la comida esta en camino, una hamburgesa'
		2:
			Escribir 'Entendido la comida esta en camino, una piza'
		3:
			Escribir 'Entendido la comida esta en camino, un Pollo frito'
		4:
			Escribir 'Entendido la comida esta en camino, una ensalada'
		De Otro Modo:
			Escribir 'La Opcion no esta disponible'
	FinSegún
FinAlgoritmo
