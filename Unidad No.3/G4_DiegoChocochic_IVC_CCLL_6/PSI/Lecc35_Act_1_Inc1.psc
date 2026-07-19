Algoritmo Lecc35_Act_1_Inc1
	// Se ingresa una cantidad en la moneda local y el programa muestra el equivalente en la moneda de cinco distintos
	// paises de tu eleccion.Al teminar, el programa debe preguntar si desea convertir otra cantidad.
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Convertidos de moneda'
	Definir monedaLocal Como Real
	Definir tasaUSD, tasaEUR, tasaGTQ, tasaJPY, tasaGBP Como Real
	Definir respuesta Como Cadena
	Definir calcularOtraVez Como Lógico
	Escribir '========================================'
	Escribir '      Conversor de Moneda Múltiple      '
	Escribir '========================================'
	calcularOtraVez <- Verdadero
	tasaUSD <- 0.050
	tasaEUR <- 0.046
	tasaGTQ <- 0.39
	tasaJPY <- 7.55
	tasaGBP <- 0.039
	Mientras calcularOtraVez Hacer
		Escribir ''
		Escribir 'Ingrese la cantidad en moneda local (MXN):'
		Leer monedaLocal
		Si monedaLocal<0 Entonces
			Escribir 'Por favor, ingrese una cantidad válida mayor o igual a cero.'
		SiNo
			Escribir ''
			Escribir '--- Equivalencias ---'
			Escribir '- Estados Unidos (USD): $', (monedaLocal*tasaUSD)
			Escribir '- Unión Europea (EUR): EUR ', (monedaLocal*tasaEUR)
			Escribir '- Guatemala (GTQ): Q ', (monedaLocal*tasaGTQ)
			Escribir '- Japón (JPY): YEN ', (monedaLocal*tasaJPY)
			Escribir '- Reino Unido (GBP): GBP ', (monedaLocal*tasaGBP)
			Escribir ''
			Escribir '¿Desea convertir otra cantidad? (s/n):'
			Leer respuesta
			Si respuesta<>'s' Y respuesta<>'S' Entonces
				calcularOtraVez <- Falso
			FinSi
		FinSi
	FinMientras
	Escribir ''
	Escribir 'Cerrando Programa'
FinAlgoritmo
