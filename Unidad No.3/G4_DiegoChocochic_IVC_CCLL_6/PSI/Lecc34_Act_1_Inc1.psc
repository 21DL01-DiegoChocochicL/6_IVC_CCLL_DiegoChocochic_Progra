Algoritmo Lecc34_Act_1_Inc1
	// Convierte un numero decimal a binario y viceversa
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Retos'
	Definir opcion Como Cadena
	Definir decimalNum, temp, residuo, decimalResultado, long, i, digito, exponente Como Entero
	Definir binario, binarioStr, caracter Como Cadena
	Definir binarioValido Como Lógico
	Escribir '========================================'
	Escribir '    Conversor Decimal <-> Binario       '
	Escribir '========================================'
	Escribir '1. Convertir de Decimal a Binario'
	Escribir '2. Convertir de Binario a Decimal'
	Escribir 'Seleccione una opción (1 o 2):'
	Leer opcion
	Si opcion='1' Entonces
		Escribir ''
		Escribir 'Ingrese un número entero decimal positivo:'
		Leer decimalNum
		Si decimalNum<0 Entonces
			Escribir 'Por favor, ingrese un número no negativo.'
		SiNo
			Si decimalNum=0 Entonces
				Escribir 'El número en binario es: 0'
			SiNo
				binario <- ''
				temp <- decimalNum
				Mientras temp>0 Hacer
					residuo <- temp MOD 2
					Si residuo=1 Entonces
						binario <- '1'+binario
					SiNo
						binario <- '0'+binario
					FinSi
					temp <- (temp/2)
				FinMientras
				Escribir 'El número ', decimalNum, ' en binario es: ', binario
			FinSi
		FinSi
	SiNo
		Si opcion='2' Entonces
			Escribir ''
			Escribir 'Ingrese un número binario:'
			Leer binarioStr
			long <- long[binarioStr]
			binarioValido <- Verdadero
			Para i<-1 Hasta long Con Paso 1 Hacer
				caracter <- Subcadena(binarioStr,i,i)
				Si caracter<>'0' Y caracter<>'1' Entonces
					binarioValido <- Falso
				FinSi
			FinPara
			Si binarioValido=Falso Entonces
				Escribir 'Error'
			SiNo
				decimalResultado <- 0
				exponente <- 0
				Para i<-longitud Hasta 1 Con Paso -1 Hacer
					caracter <- Subcadena(binarioStr,i,i)
					Si caracter='1' Entonces
						digito <- 1
					SiNo
						digito <- 0
					FinSi
					decimalResultado <- decimalResultado+(digito*(2^exponente))
					exponente <- exponente+1
				FinPara
				Escribir 'El binario ', binarioStr, ' en decimal es: ', decimalResultado
			FinSi
		SiNo
			Escribir 'Opción no válida.'
		FinSi
	FinSi
FinAlgoritmo
