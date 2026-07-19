Algoritmo Lecc34_Act_1_Inc2
	// Calcula el indice de masa corporal de una persona utilizando la siguiente formula:
	// IMC=peso(en kg)/altura (en m)^2
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Peso Corporal'
	Definir peso, altura, imc Como Real
	Escribir '--- Calculadora de Índice de Masa Corporal (IMC) ---'
	Escribir 'Ingrese su peso en kilogramos (kg):'
	Leer peso
	Escribir 'Ingrese su altura en metros (m):'
	Leer altura
	Si altura>0 Y peso>0 Entonces
		imc <- peso/(altura*altura)
		Escribir ''
		Escribir 'Su Índice de Masa Corporal (IMC) es: ', imc
		Si imc<18.5 Entonces
			Escribir 'Clasificación: Bajo peso'
		SiNo
			Si imc>=18.5 Y imc<25 Entonces
				Escribir 'Clasificación: Peso normal'
			SiNo
				Si imc>=25 Y imc<30 Entonces
					Escribir 'Clasificación: Sobrepeso'
				SiNo
					Escribir 'Clasificación: Obesidad'
				FinSi
			FinSi
		FinSi
	SiNo
		Escribir 'Error'
	FinSi
FinAlgoritmo
