Algoritmo Act1_Lecc11_inciso1
	Definir capacidad, autosActuales, opcion Como Entero
	capacidad <- 200
	autosActuales <- 0
	Escribir '*******************************************'
	Escribir '    SISTEMA DE GESTIÓN DE ESTACIONAMIENTO   '
	Escribir '*******************************************'
	Repetir
		Escribir '-------------------------------------------'
		Escribir 'Cajones disponibles: ', capacidad-autosActuales
		Escribir 'Ingrese 1 para estacionar un auto (o cualquier otro número para salir):'
		Leer opcion
		Si opcion=1 Entonces
			Si autosActuales<capacidad Entonces
				autosActuales <- autosActuales+1
				Escribir '>> [ÉXITO]: Auto estacionado con éxito.'
			SiNo
				Escribir '>> [ERROR]: ¡El estacionamiento está lleno!'
			FinSi
		SiNo
			Escribir '>> [AVISO]: Saliendo del sistema...'
		FinSi
	Hasta Que (opcion<>1) O (autosActuales=capacidad)
	Escribir '-------------------------------------------'
	Escribir 'Programa finalizado.'
	Escribir '*******************************************'
FinAlgoritmo
