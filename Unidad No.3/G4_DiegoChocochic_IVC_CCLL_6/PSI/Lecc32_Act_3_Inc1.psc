Algoritmo Lecc32_Act_3_Inc1
	// Reciba las medidas de los tres lados de un triangulo e indique si se trata de un  triangulo equilatero, isoceles
	// o escaleno. No importa el orden en que se den las medidas
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Triangulos'
	Definir lado1, lado2, lado3 Como Real
	Escribir 'Ingrese el lado 1:'
	Leer lado1
	Escribir 'Ingrese el lado 2:'
	Leer lado2
	Escribir 'Ingrese el lado 3:'
	Leer lado3
	Si (lado1+lado2>lado3) Y (lado1+lado3>lado2) Y (lado2+lado3>lado1) Entonces
		Si lado1=lado2 Y lado2=lado3 Entonces
			Escribir 'El triángulo es Equilátero.'
		SiNo
			Si lado1=lado2 O lado1=lado3 O lado2=lado3 Entonces
				Escribir 'El triángulo es Isósceles.'
			SiNo
				Escribir 'El triángulo es Escaleno.'
			FinSi
		FinSi
	SiNo
		Escribir 'Las medidas ingresadas no forman un triángulo válido.'
	FinSi
FinAlgoritmo
