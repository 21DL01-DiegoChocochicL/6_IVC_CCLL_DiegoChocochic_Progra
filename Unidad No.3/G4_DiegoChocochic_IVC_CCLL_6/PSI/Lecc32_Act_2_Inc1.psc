Algoritmo Lecc32_Act_2_Inc1
	// El ususario ingresa su fecha de nacimiento (mes y dia) y el programa le muestra su signo zodiacal y un horoscopo
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Horoscopo'
	Definir dia, mes Como Entero
	Definir signo, prediccion Como Cadena
	Escribir 'Ingrese su día de nacimiento :'
	Leer dia
	Escribir 'Ingrese su mes de nacimiento :'
	Leer mes
	signo <- ''
	prediccion <- ''
	Si (mes=3 Y dia>=21) O (mes=4 Y dia<=19) Entonces
		signo <- 'Aries'
		prediccion <- 'Hoy es un excelente día para empezar nuevos proyectos con energía.'
	SiNo
		Si (mes=4 Y dia>=20) O (mes=5 Y dia<=20) Entonces
			signo <- 'Tauro'
			prediccion <- 'La paciencia será tu mejor aliada hoy. Mantén la calma.'
		SiNo
			Si (mes=5 Y dia>=21) O (mes=6 Y dia<=20) Entonces
				signo <- 'Géminis'
				prediccion <- 'Tu curiosidad te llevará a descubrir algo muy interesante hoy.'
			SiNo
				Si (mes=6 Y dia>=21) O (mes=7 Y dia<=22) Entonces
					signo <- 'Cáncer'
					prediccion <- 'Dedica tiempo a tus seres queridos; te recargará de buena vibra.'
				SiNo
					Si (mes=7 Y dia>=23) O (mes=8 Y dia<=22) Entonces
						signo <- 'Leo'
						prediccion <- 'Brillarás en lo que hagas hoy, confía plenamente en tu talento.'
					SiNo
						Si (mes=8 Y dia>=23) O (mes=9 Y dia<=22) Entonces
							signo <- 'Virgo'
							prediccion <- 'Un poco de orden en tus pendientes te dará mucha tranquilidad.'
						SiNo
							Si (mes=9 Y dia>=23) O (mes=10 Y dia<=22) Entonces
								signo <- 'Libra'
								prediccion <- 'Busca el equilibrio en tus decisiones y todo saldrá excelente.'
							SiNo
								Si (mes=10 Y dia>=23) O (mes=11 Y dia<=21) Entonces
									signo <- 'Escorpio'
									prediccion <- 'Tu intuición está muy aguda hoy, hazle caso a tu corazonada.'
								SiNo
									Si (mes=11 Y dia>=22) O (mes=12 Y dia<=21) Entonces
										signo <- 'Sagitario'
										prediccion <- 'Una aventura o sorpresa agradable te espera a la vuelta de la esquina.'
									SiNo
										Si (mes=12 Y dia>=22) O (mes=1 Y dia<=19) Entonces
											signo <- 'Capricornio'
											prediccion <- 'Tu esfuerzo dará frutos pronto. No te rindas ahora.'
										SiNo
											Si (mes=1 Y dia>=20) O (mes=2 Y dia<=18) Entonces
												signo <- 'Acuario'
												prediccion <- 'Tu mente creativa está al máximo, es hora de plasmar tus ideas.'
											SiNo
												Si (mes=2 Y dia>=19) O (mes=3 Y dia<=20) Entonces
													signo <- 'Piscis'
													prediccion <- 'Conéctate con tu lado artístico; hoy fluirá mucho amor a tu alrededor.'
												SiNo
													Escribir 'Fecha no válida.'
												FinSi
											FinSi
										FinSi
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
	Si signo<>'' Entonces
		Escribir ''
		Escribir 'Tu signo zodiacal es: ', signo
		Escribir 'Horóscopo: ', prediccion
	FinSi
FinAlgoritmo
