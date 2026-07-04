Algoritmo Act1_Lecc9_inciso1
	Definir manza, peso,k Como Entero
	Definir end Como Logico
	
	Escribir "Una Manzana tiene 250g y un kilo tiene 1000g"
	Escribir "Cuantas manzanas tienes?"
	Leer manza
	
	peso=manza*250
	k=1000-peso
	end=Falso
	
	Mientras end=Falso Hacer
		Si peso=1000 Entonces
			Escribir "Perfecto tienes un Kilo de manzanas"
		SiNo
			Si peso < 1000 Entonces
				Escribir "Te faltan ,",k,"g para llegar al kilo"
			SiNo
				Escribir "Tienes más de un kilo"
			Fin Si
		FinSi
		end=Verdadero
	Fin Mientras
	
FinAlgoritmo
