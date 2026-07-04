Algoritmo Act1_Lecc15_inciso1
	Definir opcion, contBoletos, op Como Entero
	Definir acumDinero Como Real
	contBoletos <- 0
	acumDinero <- 0
	op <- 1
	Escribir '*******************************************'
	Escribir '   SISTEMA DE CONTROL: RUEDA DE LA FORTUNA '
	Escribir '*******************************************'
	Mientras op<>0 Hacer
		Escribir ''
		Escribir '--- Menú de Ventas ---'
		Escribir '1. Adulto ($15)'
		Escribir '2. Niño ($10)'
		Escribir '0. Cerrar caja y ver reporte'
		Escribir 'Seleccione una opción:'
		Leer op
		Según op Hacer
			1:
				acumDinero <- acumDinero+15
				contBoletos <- contBoletos+1
				Escribir '>> [ÉXITO]: Venta registrada (Adulto).'
			2:
				acumDinero <- acumDinero+10
				contBoletos <- contBoletos+1
				Escribir '>> [ÉXITO]: Venta registrada (Niño).'
			0:
				Escribir '>> [AVISO]: Cerrando sistema de ventas...'
			De Otro Modo:
				Escribir '>> [ERROR]: Opción no válida. Intente de nuevo.'
		FinSegún
	FinMientras
	Escribir '-------------------------------------------'
	Escribir '           REPORTE DE CIERRE               '
	Escribir '-------------------------------------------'
	Escribir 'Total de boletos vendidos: ', contBoletos
	Escribir 'Total de dinero recaudado: $', acumDinero
	Escribir '-------------------------------------------'
	Escribir 'Proceso finalizado.'
	Escribir '*******************************************'
FinAlgoritmo
