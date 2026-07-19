Algoritmo Lecc35_Act_1_Inc2
	// En una tienda, el cajero ingresa el precio de un producto y despues la denominacion del billete con que pago el cliente
	// El programa muestra cuantos billetes de 200,100,5.,20 y monedas se deben dar de cambio
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Calculadora de Cambio'
	Definir precio, pago, cambioTotal, monedas, totalMonedas Como Real
	Definir cambioEntero, b200, b100, b50, b20, residuo Como Entero
	Escribir '--- Calculadora de Cambio ---'
	Escribir 'Ingrese el precio del producto:'
	Leer precio
	Escribir 'Ingrese la denominación del billete con que pagó el cliente:'
	Leer pago
	Si pago<precio Entonces
		Escribir 'Error: El pago es insuficiente para cubrir el precio del producto.'
	SiNo
		cambioTotal <- pago-precio
		Escribir ''
		Escribir 'El cambio total a entregar es: $', cambioTotal
		cambioEntero <- Trunc(cambioTotal)
		monedas <- cambioTotal-cambioEntero
		b200 <- Trunc(cambioEntero/200)
		residuo <- cambioEntero MOD 200
		b100 <- Trunc(residuo/100)
		residuo <- residuo MOD 100
		b50 <- Trunc(residuo/50)
		residuo <- residuo MOD 50
		b20 <- Trunc(residuo/20)
		residuo <- residuo MOD 20
		Escribir ''
		Escribir 'Desglose de cambio:'
		Si b200>0 Entonces
			Escribir '- Billetes de $200: ', b200
		FinSi
		Si b100>0 Entonces
			Escribir '- Billetes de $100: ', b100
		FinSi
		Si b50>0 Entonces
			Escribir '- Billetes de $50: ', b50
		FinSi
		Si b20>0 Entonces
			Escribir '- Billetes de $20: ', b20
		FinSi
		totalMonedas <- residuo+monedas
		Si totalMonedas>0 Entonces
			Escribir '- En monedas: $', totalMonedas
		FinSi
	FinSi
FinAlgoritmo
